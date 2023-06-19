using J_Explore.Utils;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace J_Explore.Models
{
    public class AkunUser
    {
        public int Id;
        public string Username;

        public AkunUser(int id, string username)
        {
            Id = id;
            Username = username;
        }

        public static AkunUser FromDataRow(DataRow row) => new AkunUser
        (
            (int)row[Global.ColumnAkunUserId],
            (string)row[Global.ColumnAkunUserUsername]
        );

        public Dictionary<string, dynamic> ToDictionary() => new Dictionary<string, dynamic>
        {
            {Global.ColumnAkunUserId, Id},
            {Global.ColumnAkunUserUsername, Username},
        };
    }
}
