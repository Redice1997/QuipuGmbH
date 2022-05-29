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
        #region Заголовок окна
        private string title = "Тестовое задание";

        /// <summary>Заголовок окна</summary>
        public string Title
        {
            get => title;
            set => Set(ref title, value);
        }
        #endregion

        #region Status : string - Статус программы
        private string status = "Готово!";

        /// <summary>Статус программы</summary>
        public string Status
        {
            get => status;
            set => Set(ref status, value);
        }
        #endregion
    }
}
