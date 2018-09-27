using FriendStorage.DataAccess;
using FriendStorage.DataAccess.InMemory;
using FriendStorage.ViewModel;
using System.Windows;

namespace FriendStorage.Wpf
{
  public partial class MainWindow : Window
  {
    MainViewModel _viewModel;
    public MainWindow()
    {
      InitializeComponent();
      //_viewModel = new MainViewModel(new SqlFriendDataProvider());
      _viewModel = new MainViewModel(new InMemoryFriendDataProvider());
      DataContext = _viewModel;
      this.Loaded += MainWindow_Loaded;
    }

    private void MainWindow_Loaded(object sender, RoutedEventArgs e)
    {
      _viewModel.Load();
    }
  }
}
