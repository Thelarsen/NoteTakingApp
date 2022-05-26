using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;

namespace NoteTakingApp.Classes
{
    [Table("notes")]
    public class Note
    {
        [PrimaryKey, AutoIncrement]
        public int id { get; set; }
        public string content { get; set; }        
        [Indexed]
        public DateTime created { get; set; }
        [Indexed]
        public int case_id { get; set; }
        [Indexed]
        public int user_id { get; set; }
        public bool is_edited { get; set; } = false;
    }
}
