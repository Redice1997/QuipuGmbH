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
