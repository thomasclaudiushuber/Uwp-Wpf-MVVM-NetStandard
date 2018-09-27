using FriendStorage.Common;
using System.Collections.Generic;

namespace FriendStorage.DataAccess.InMemory
{
  public class InMemoryFriendDataProvider : IFriendDataProvider
  {
    public IEnumerable<Friend> LoadFriends()
    {
      return new List<Friend>
      {
        new Friend{FirstName="Silvester",LastName="Stallone"},
        new Friend{FirstName="Arnold",LastName="Schwarzenegger"},
        new Friend{FirstName="Bruce",LastName="Willis"},
        new Friend{FirstName="Dolph",LastName="Lundgren"},
      };
    }
  }
}
