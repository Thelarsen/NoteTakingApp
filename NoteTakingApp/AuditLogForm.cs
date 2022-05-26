using NoteTakingApp.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NoteTakingApp
{
    public partial class AuditLogForm : Form
    {
        Database db;
        Note note;
        public AuditLogForm(Note _note)
        {
            InitializeComponent();
            db = new Database(); // New database connection.
            note = _note; // Passed from CaseForm.
            loadAuditList();
        }

        // Loading a list of audits from the chosen note and grabs the data from the database.
        public void loadAuditList()
        {
            List<Auditlog> auditLog = db.con.Table<Auditlog>().Where(a => a.note_id == note.id).OrderByDescending(a => a.created).ToList();
            auditList.Items.Clear();
            // Loop through each audit for a given note and add to list.
            foreach (Auditlog audit in auditLog)
            {
                ListViewItem item = new ListViewItem();
                item.Text = audit.created.ToString("dd.MM.yyyy HH:mm");
                item.Tag = audit;
                auditList.Items.Add(item);
            }
        }

        // Selecting an audit will show the audit and original content on the side, if none are selected it will remain empty.
        private void auditList_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Check if note has been selected.
            if (auditList.SelectedItems.Count > 0)
            {
                Auditlog audit = auditList.SelectedItems[0].Tag as Auditlog;
                originalNote.Text = audit.original_content;
                editedNote.Text = audit.edited_content;
            }
            else
            {
                originalNote.Text = "";
                editedNote.Text = "";
            }
        }
    }
}
