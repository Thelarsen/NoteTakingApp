using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;

namespace NoteTakingApp.Classes
{
    [Table("roles")]
    public class Role
    {
        [PrimaryKey]
        public string role { get; set; } = "user";
        public int permission { get; set; }
    }
}
