using QuipuGmbH.Models;
using QuipuGmbH.ViewModels.Base;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuipuGmbH.ViewModels
{
    class MainWindowViewModel : ViewModel
    {
        #region Title : string - Заголовок окна
        private string _Title = "Тестовое задание";

        /// <summary>Заголовок окна</summary>
        public string Title
        {
            get => _Title;
            set => Set(ref _Title, value);
        }
        #endregion

        #region Status : string - Статус программы
        private string _Status = "Готово!";

        /// <summary>Статус программы</summary>
        public string Status
        {
            get => _Status;
            set => Set(ref _Status, value);
        }
        #endregion

        #region UrlCounters : ObservableCollection<UrlCounter> - Список URL с количеством тегов в каждом

        /// <summary>Список URL с количеством тегов в каждом</summary>
        private ObservableCollection<UrlCounter> _UrlCounters;

        /// <summary>Список URL с количеством тегов в каждом</summary>
        public ObservableCollection<UrlCounter> UrlCounters { get => _UrlCounters; set => Set(ref _UrlCounters, value); }

        #endregion
       

        public MainWindowViewModel()
        {
            var urlCounters = Enumerable.Range(1, 20).Select(i => new UrlCounter
            {
                Url = $"https://url{i}",
                TagCount = new Random().Next(500)
            }).OrderByDescending(url => url.TagCount);

            UrlCounters = new ObservableCollection<UrlCounter>(urlCounters);
        }
    }
}
