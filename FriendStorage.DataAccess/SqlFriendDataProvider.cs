using FriendStorage.Common;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace FriendStorage.DataAccess
{
  public class SqlFriendDataProvider : IFriendDataProvider
  {
    public IEnumerable<Friend> LoadFriends()
    {
      // Amazing what's available with .NET Standard 2.0,
      // you can even use the DataTable!
      var table = new DataTable();
      using (var conn = new SqlConnection("Data Source=.;Initial Catalog=FriendStorage;Integrated Security=True"))
      {
        using (var cmd = new SqlCommand("Select * from Friend", conn))
        {
          conn.Open();
          table.Load(cmd.ExecuteReader());
        }
      }

      return table.Rows.Cast<DataRow>().Select(row =>
       new Friend
       {
         FirstName = (string)row["FirstName"],
         LastName = (string)row["LastName"]
       }).ToList();
    }
  }
}
