using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;

namespace NoteTakingApp.Classes
{
    [Table("auditlog")]
    internal class Auditlog
    {
        [PrimaryKey, AutoIncrement]
        public int id { get; set; }
        public string original_content { get; set; }
        public string edited_content { get; set; }
        public DateTime created { get; set; }
        [Indexed]
        public int note_id { get; set; }
        [Indexed]
        public int case_id { get; set; }
        [Indexed]
        public int user_id { get; set; }

    }
}
