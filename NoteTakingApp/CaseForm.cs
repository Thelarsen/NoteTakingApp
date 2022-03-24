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
    public partial class CaseForm : Form
    {
        Database db;
        Case caseobject;
        bool isEditing;
        Note originalNote;
        public CaseForm(Case _case)
        {
            InitializeComponent();
            db = new Database();
            caseobject = _case;
            LoadNotes();
            Text = "Notes for: " + caseobject.name;
            if (!caseobject.is_closed) noteText.ReadOnly = false;
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            noteText.Clear();
            isEditing = false;
            noteList.SelectedItems.Clear();
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            if (noteText.Text.Trim() == "")
            {
                MessageBox.Show("Please write your notes before saving.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Note note = new Note();
            note.content = noteText.Text;
            note.case_id = caseobject.id;
            note.user_id = caseobject.user_id;
            note.tool = "";
            note.created = DateTime.Now;

            if (isEditing)
            {
                note.is_edited = true;
                note.id = originalNote.id;
                note.created = originalNote.created;
                Auditlog audit = new Auditlog();
                audit.original_content = originalNote.content;
                audit.created = DateTime.Now;
                audit.edited_content = note.content;
                audit.note_id = note.id;
                audit.user_id = note.user_id;
                db.con.Insert(audit);
                db.con.InsertOrReplace(note);
                isEditing = false;
            }
            else
            {
                db.con.Insert(note);
            }

            noteText.Clear();
            LoadNotes();
        }

        public void LoadNotes()
        {
            List<Note> notes = db.con.Table<Note>().Where(n => n.case_id == caseobject.id).OrderByDescending(n => n.created).ToList();
            noteList.Items.Clear();
            foreach (Note note in notes)
            {
                ListViewItem item = new ListViewItem();
                item.Text = note.created.ToString("dd.MM.yyyy HH:mm");
                if (note.is_edited)
                {
                    item.Text += " *";
                }
                item.SubItems.Add(note.content);
                item.Tag = note;
                noteList.Items.Add(item);
            }
        }

        private void noteList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (noteList.SelectedItems.Count > 0)
            {
                ListViewItem noteitem = noteList.SelectedItems[0];
                Note note = noteitem.Tag as Note;
                if (note != null)
                {
                    originalNote = new Note();
                    originalNote.created = note.created;
                    originalNote.content = note.content;
                    originalNote.id = note.id;
                    originalNote.case_id = note.case_id;
                    originalNote.user_id = note.user_id;
                    originalNote.tool = note.tool;

                    isEditing = true;

                    if (caseobject.is_closed)
                    {
                        noteText.ReadOnly = true;
                        saveBtn.Enabled = false;
                        clearBtn.Enabled = false;
                    }
                    else
                    {
                        noteText.ReadOnly = false;
                        saveBtn.Enabled = true;
                        clearBtn.Enabled = true;
                    }

                    noteText.Text = note.content;
                }
                else
                {
                    isEditing = false;
                    noteText.Clear();
                }
            }
        }

        private void autditLogBtn_Click(object sender, EventArgs e)
        {
            if (noteList.SelectedItems.Count > 0)
            {
                Note selectedNote = noteList.SelectedItems[0].Tag as Note;
                AuditLogForm auditLogForm = new AuditLogForm(selectedNote);
                auditLogForm.ShowDialog(this);
            }
            else
            {
                //TODO display messagebox
                MessageBox.Show("Please select a note.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
