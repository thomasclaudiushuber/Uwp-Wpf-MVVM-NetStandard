using FriendStorage.Common;
using System.Collections.ObjectModel;

namespace FriendStorage.ViewModel
{
  public class MainViewModel : ViewModelBase
  {
    private Friend _selectedFriend;
    private readonly IFriendDataProvider _friendDataProvider;

    public MainViewModel(IFriendDataProvider friendDataProvider)
    {
      Friends = new ObservableCollection<Friend>();
      _friendDataProvider = friendDataProvider;
    }

    public void Load()
    {
      foreach (var friend in _friendDataProvider.LoadFriends())
      {
        Friends.Add(friend);
      }
    }

    public ObservableCollection<Friend> Friends { get; }


    public Friend SelectedFriend
    {
      get { return _selectedFriend; }
      set
      {
        if (_selectedFriend != value)
        {
          _selectedFriend = value;
          OnPropertyChanged();
          OnPropertyChanged(nameof(IsFriendSelected));
        }
      }
    }

    public bool IsFriendSelected => SelectedFriend != null;
  }
}
