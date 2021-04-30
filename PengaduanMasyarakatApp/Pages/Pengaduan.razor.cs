using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.JSInterop;
using PengaduanMasyarakatApp.DataAccessLibrary.Contracts;
using PengaduanMasyarakatApp.Pages.Dialogs;
using PengaduanMasyarakatApp.Shared.Models;
using Radzen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace PengaduanMasyarakatApp.Pages
{
    public partial class Pengaduan
    {
        [Inject] AppState AppState { get; set; }
        [Inject] IPengaduanData PengaduanData {get;set;}
        [Inject] DialogService dialogService { get; set; }
        [Inject] NotificationService NotificationService { get; set; }
        [Inject] IGlobalData GlobalData { get; set; }
        [Inject] NavigationManager navigationManager { get; set; }

        [CascadingParameter]
        private Task<AuthenticationState> authenticationStateTask { get; set; }
        System.Security.Claims.ClaimsPrincipal CurrentUser;

        [Inject] UserManager<ApplicationUser> _UserManager { get; set; }

        PengaduanViewModel data = new PengaduanViewModel();
        
        List<PengaduanViewModel> datas = new List<PengaduanViewModel>();
        FilterModel filter = new FilterModel();
        List<StatusModel> statuss = new List<StatusModel>();

        protected override async Task OnInitializedAsync()
        {
            AppState.SetComponentTitle("Pengaduan");
            
            filter.Top = "25";
            
            CurrentUser = (await authenticationStateTask).User;
            filter.UserId = _UserManager.GetUserId(CurrentUser);

            await GetStatus();

            await Get();
        }

        public async Task Save()
        {
            try
            {
                data.StatusId = "1";
                data.UserId = _UserManager.GetUserId(CurrentUser);

                await PengaduanData.InsertAsync(data);
                Cancel();
                await Get();

                await ShowNotification(
                        new NotificationMessage()
                        {
                            Severity = NotificationSeverity.Success,
                            Summary = "Berhasil disimpan",
                            Detail = "",
                            Duration = 4000
                        }
                    );
            }
            catch (Exception e)
            {
                await ShowNotification(
                        new NotificationMessage()
                        {
                            Severity = NotificationSeverity.Error,
                            Summary = "Gagal disimpan",
                            Detail = e.Message,
                            Duration = 4000
                        }
                    );
            }
            
        }

        public async Task Get()
        {
            datas= await PengaduanData.GetAsync(filter);
        }

        public async Task Delete(PengaduanViewModel data)
        {
            try
            {
                if(data.StatusId=="1" || data.StatusId == "3")
                {
                    await PengaduanData.DeleteAsync(data.Id);
                    await Get();
                    await ShowNotification(
                            new NotificationMessage()
                            {
                                Severity = NotificationSeverity.Error,
                                Summary = "Berhasil dihapus",
                                Detail = "",
                                Duration = 4000
                            }
                        );
                }
                else
                {
                    await ShowNotification(
                            new NotificationMessage()
                            {
                                Severity = NotificationSeverity.Warning,
                                Summary = "Data yang sudah lolos verifikasi dan validasi tidak bisa dihapus",
                                Detail = "",
                                Duration = 4000
                            }
                        );
                }
                
            }
            catch (Exception e)
            {
                await ShowNotification(
                        new NotificationMessage()
                        {
                            Severity = NotificationSeverity.Success,
                            Summary = "Gagal dihapus",
                            Detail = e.Message,
                            Duration = 4000
                        }
                    );
            }
            
        }

        public void Cancel()
        {
            data.NIK = "";
            data.JudulLaporan = "";
            data.Laporan = "";
            data.Foto = "";
            
        }

        public async void Edit(PengaduanViewModel dataFromGrid)
        {
            if(data.StatusId == "1" || data.StatusId == "3")
            {
                data = dataFromGrid;
            }
            else
            {
                await ShowNotification(
                            new NotificationMessage()
                            {
                                Severity = NotificationSeverity.Warning,
                                Summary = "Data yang sudah lolos verifikasi dan validasi tidak bisa dihapus",
                                Detail = "",
                                Duration = 4000
                            }
                        );
            }
            
        }

        void LihatTanggapan(PengaduanViewModel data)
        {

            dialogService.Open<TanggapanDialog>
                (

                    "Tanggapan",

                    new Dictionary<string, object>()
                    {
                        { "Data", data}
                    },
                    new DialogOptions { Width = "400px", Height = "400px" }

                );
        }

        async Task ShowNotification(NotificationMessage message)
        {
            NotificationService.Notify(message);

            await InvokeAsync(() => { StateHasChanged(); });
        }

        public async Task GetStatus()
        {
            statuss = await GlobalData.GetStatussAsync();
        }

        void Cetak(PengaduanViewModel data)
        {
            DataReport.dataReportPengaduan = data;
            navigationManager.NavigateTo("/DownloadPdf?pageName=pengaduanReport", true);
        }


        
        

    }
}
