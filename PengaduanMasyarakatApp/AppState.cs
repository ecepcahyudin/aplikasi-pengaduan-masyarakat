using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PengaduanMasyarakatApp
{
    public class AppState
    {
        public string ComponentTitle { get; set; }
        
        public event Action OnChangeComponentTitle;
        
        public void SetComponentTitle(string title,string petunjuk="")
        {
            ComponentTitle = title;
            
            NotifyStateChanged();
        }

       
        private void NotifyStateChanged()
        {
            OnChangeComponentTitle?.Invoke();
            
        }
        


    }
}
