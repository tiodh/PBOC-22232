using J_Explore.Utils;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace J_Explore.Models
{
    public class AkunAdmin
    {
        public int Id;
        public string Username;
        public string Password;
        public string Email;
        public string NoHp;

        public AkunAdmin(int id, string username, string password, string email, string noHp)
        {
            Id = id;
            Username = username;
            Password = password;
            Email = email;
            NoHp = noHp;
        }

        public static AkunAdmin FromDataRow(DataRow row) => new AkunAdmin(
            (int)row[Global.ColumnAkunAdminId],
            (string)row[Global.ColumnAkunAdminUsername],
            (string)row[Global.ColumnAkunAdminPassword],
            (string)row[Global.ColumnAkunAdminEmail],
            (string)row[Global.ColumnAkunAdminNoHp]
        );

        public Dictionary<string, dynamic> ToDictionary() => new Dictionary<string, dynamic>
        {
            {Global.ColumnAkunAdminUsername, Username},
            {Global.ColumnAkunAdminPassword, Password},
            {Global.ColumnAkunAdminEmail, Email},
            {Global.ColumnAkunAdminNoHp, NoHp},
        };
    }
}
