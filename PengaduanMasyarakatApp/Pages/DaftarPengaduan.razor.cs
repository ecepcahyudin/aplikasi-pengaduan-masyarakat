using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Identity;
using PengaduanMasyarakatApp.DataAccessLibrary.Contracts;
using PengaduanMasyarakatApp.Pages.Dialogs;
using PengaduanMasyarakatApp.Shared.Models;
using Radzen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PengaduanMasyarakatApp.Pages
{
    public partial class DaftarPengaduan
    {
        [Inject] AppState AppState { get; set; }
        [Inject] IPengaduanData PengaduanData { get; set; }
        [Inject] IGlobalData GlobalData { get; set; }
        [Inject] DialogService dialogService { get; set; }
        
        [Inject] NotificationService NotificationService { get; set; }

        [Inject] NavigationManager navigationManager { get; set; }

        [CascadingParameter]
        private Task<AuthenticationState> authenticationStateTask { get; set; }
        System.Security.Claims.ClaimsPrincipal CurrentUser;

        [Inject] UserManager<ApplicationUser> _UserManager { get; set; }


        PengaduanViewModel data = new PengaduanViewModel();
        PengaduanViewModel dataSelected = new PengaduanViewModel();
        List<PengaduanViewModel> datas = new List<PengaduanViewModel>();
        List<StatusModel> statuss = new List<StatusModel>();

        FilterModel filter = new FilterModel();

        bool isDialogVerifikasi;


        protected override async Task OnInitializedAsync()
        {
            AppState.SetComponentTitle("Daftar Pengaduan");
            filter.Top = "25";
            dialogService.OnClose += DialogClosed;

            CurrentUser = (await authenticationStateTask).User;

            var user = await _UserManager.FindByIdAsync(_UserManager.GetUserId(CurrentUser));
            var UserResult =
                    await _UserManager
                    .IsInRoleAsync(user, "Administrators");

            if(UserResult)
                filter.PetugasId = _UserManager.GetUserId(CurrentUser);

            await GetStatus();
            await Get();
            
        }

        public async Task Save()
        {
            try
            {
                
                await PengaduanData.InsertAsync(data);

                data.UserId = _UserManager.GetUserId(CurrentUser);
                await PengaduanData.InsertTanggapanAsync(data);
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
            datas = await PengaduanData.GetAsync(filter);
        }

        public async Task GetStatus()
        {
            statuss = await GlobalData.GetStatussAsync();
        }

        public async Task Delete(PengaduanViewModel data)
        {
            try
            {
                if (data.StatusId == "1" || data.StatusId == "3")
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

        void VerifikasiValidasi(PengaduanViewModel data)
        {
            isDialogVerifikasi = true;
            dataSelected = data;
            dialogService.Open<VerifikasiValidasiDialog>
                (

                    "Verifikasi dan Validasi",

                    new Dictionary<string, object>()
                    {
                        { "Data", data}
                    },
                    new DialogOptions { Width = "700px", Height = "700px" }

                );
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

        void TindakLanjut(PengaduanViewModel data)
        {
            isDialogVerifikasi = false;
            dataSelected = data;
            dialogService.Open<TindakLanjutDialog>
                (

                    "Tindak Lanjut",

                    new Dictionary<string, object>()
                    {
                        { "Data", data}
                    },
                    new DialogOptions { Width = "700px", Height = "700px" }

                );
        }

        async Task ShowNotification(NotificationMessage message)
        {
            NotificationService.Notify(message);

            await InvokeAsync(() => { StateHasChanged(); });
        }

        async void DialogClosed(dynamic result)
        {
            if (result == null)
                result = false;

            if (result)
            {
                try
                {
                    if (isDialogVerifikasi)
                    {
                        if (dataSelected.IsLolosVerifikasiValidasi)
                        {
                            dataSelected.StatusId = "2";
                        }
                        else
                        {
                            dataSelected.StatusId = "3";
                        }
                    }
                    
                    
                    await PengaduanData.InsertAsync(dataSelected);
                    await PengaduanData.InsertTanggapanAsync(dataSelected);
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
                            Severity = NotificationSeverity.Success,
                            Summary = "Gagal disimpan",
                            Detail = e.Message,
                            Duration = 4000
                        }
                    );
                }

            }

        }

        void Cetak(PengaduanViewModel data)
        {
            DataReport.dataReportPengaduan = data;
            navigationManager.NavigateTo("/DownloadPdf?pageName=pengaduanReport", true);
        }

        void CetakRekap()
        {
            DataReport.dataReportRekapPengaduan = datas;
            navigationManager.NavigateTo("/DownloadPdf?pageName=rekapPengaduanReport", true);
        }
    }
}
