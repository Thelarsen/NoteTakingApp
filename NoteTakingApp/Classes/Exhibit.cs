using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoteTakingApp.Classes
{
    [Table("exhibit")]
    public class Exhibit
    {
        [PrimaryKey, AutoIncrement]
        public int id { get; set; }
        public string name { get; set; }
        public string comment { get; set; }
        [Indexed]
        public int case_id { get; set; }
        [Indexed]
        public int user_id { get; set; }
    }
}
