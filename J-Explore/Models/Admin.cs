using J_Explore.Utils;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace J_Explore.Models
{
    public class Admin
    {
        public string Username;
        public string Password;

        public Admin(string username, string password)
        {
            Username = username;
            Password = password;
        }

        public static Admin FromDataRow(DataRow row) => new Admin(
            (string)row[Global.ColumnAkunAdminUsername],
            (string)row[Global.ColumnAkunAdminPassword]
        );

        public Dictionary<string, dynamic> ToDictionary() => new Dictionary<string, dynamic>
        {
            {Global.ColumnAkunAdminPassword, Password},
        };
    }
}
