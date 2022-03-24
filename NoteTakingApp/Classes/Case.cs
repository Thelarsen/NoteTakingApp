using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;

namespace NoteTakingApp.Classes
{
    [Table("cases")]
    public class Case
    {
        [PrimaryKey, AutoIncrement]
        public int id { get; set; }
        public string name { get; set; }
        public DateTime created { get; set; }
        public DateTime closed { get; set; }
        public string description { get; set; }
        public bool is_closed { get; set; } = false;
        [Indexed]
        public int user_id { get; set; }

    }
}
