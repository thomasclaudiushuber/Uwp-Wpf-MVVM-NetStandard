using System.Collections.Generic;

namespace FriendStorage.Common
{
  public interface IFriendDataProvider
  {
    IEnumerable<Friend> LoadFriends();
  }
}