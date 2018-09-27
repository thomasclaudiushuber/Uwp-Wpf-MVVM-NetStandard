using FriendStorage.DataAccess;
using FriendStorage.DataAccess.InMemory;
using FriendStorage.ViewModel;
using Windows.UI.Xaml.Controls;

namespace FriendStorage.Uwp
{
  public sealed partial class MainPage : Page
  {
    public MainViewModel ViewModel { get; }

    public MainPage()
    {
      this.InitializeComponent();
      //ViewModel = new MainViewModel(new SqlFriendDataProvider());      
      ViewModel = new MainViewModel(new InMemoryFriendDataProvider());
      DataContext = ViewModel;
      this.Loaded += MainPage_Loaded;
    }

    private void MainPage_Loaded(object sender, Windows.UI.Xaml.RoutedEventArgs e)
    {
      ViewModel.Load();
    }
  }
}
