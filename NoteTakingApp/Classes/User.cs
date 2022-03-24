using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;

namespace NoteTakingApp.Classes
{
    [Table("users")]
    public class User
    {
        [PrimaryKey, AutoIncrement]
        public int id { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public string name { get; set; } 
        public string role { get; set; }
    }
}
