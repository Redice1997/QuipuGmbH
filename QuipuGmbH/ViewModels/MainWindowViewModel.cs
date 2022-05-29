using QuipuGmbH.ViewModels.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuipuGmbH.ViewModels
{
    class MainWindowViewModel : ViewModel
    {
        #region Status : string - Статус программы
        /// <summary>Статус программы</summary>
        private string status = "Готов!";

        /// <summary>Статус программы</summary>
        public string Status
        {
            get { return status; }
            set { Set(ref status, value); }
        }
        #endregion
    }
}
