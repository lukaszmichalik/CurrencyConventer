//using CurrencyConverter.Helper;
//using CurrencyConverter.Views;
//using System.ComponentModel;
//using System.Runtime.CompilerServices;
//using System.Threading.Tasks;
//using Xamarin.Forms.Extended;


//namespace CurrencyConverter.ViewModel
//{
//    class MainViewModel : INotifyPropertyChanged
//    {
//        private bool _isBusy;
//        private const int PageSize = 10;
//        readonly MainPage _dataService = new MainPage();

//        public InfiniteScrollCollection<string> Items { get; }

//        public bool IsBusy
//        {
//            get => _isBusy;
//            set
//            {
//                _isBusy = value;
//                OnPropertyChanged();
//            }
//        }

//        public MainViewModel()
//        {
//            Items = new InfiniteScrollCollection<string>
//            {
//                OnLoadMore = async () =>
//                {
//                    IsBusy = true;

//                    // load the next page
//                    var page = Items.Count / PageSize;

//                    var items = await _dataService.GetItemsAsync(page, PageSize);

//                    IsBusy = false;

//                    // return the items that need to be added
//                    return items;
//                },
//                OnCanLoadMore = () =>
//                {
//                    return Items.Count < 17;
//                }
//            };

//            _ = DownloadDataAsync();
//        }

//        private async Task DownloadDataAsync()
//        {
//            var items = await _dataService.GetItemsAsync(pageIndex: 0, pageSize: PageSize);

//            Items.AddRange(items);
//        }

//        public event PropertyChangedEventHandler PropertyChanged;

//        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
//        {
//            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
//        }
//    }
//}
