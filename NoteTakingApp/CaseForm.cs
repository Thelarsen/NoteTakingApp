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
            
            InitializeComponent(); // Windows form function.
            db = new Database(); // New database connection.
            caseobject = _case; // Passed from MainWindow on case click.
            LoadNotes();
            Text = "Notes for: " + caseobject.name; // Form.Text: labels window for note.
            if (!caseobject.is_closed) noteText.ReadOnly = false; 
            if (caseobject.is_closed) clearBtn.Enabled = false;
            if (caseobject.is_closed) saveBtn.Enabled = false;
        }

        // Clears text box and changes isEditing tag.
        private void clearBtn_Click(object sender, EventArgs e)
        {
            noteText.Clear();
            isEditing = false;
            noteList.SelectedItems.Clear();
        }

        // Saves note in text box, updates audit log and note list.
        private void saveBtn_Click(object sender, EventArgs e)
        {
            if (noteText.Text.Trim() == "")
            {
                MessageBox.Show("Please write your notes before saving.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Creates new note.
            Note note = new Note();
            note.content = noteText.Text;
            note.case_id = caseobject.id;
            note.user_id = caseobject.user_id;
            note.created = DateTime.Now;
            
            // Triggered on clicking a note in the list.
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
                audit.case_id = note.case_id;
                // Saves original content to audit log and updates the most recent note.
                db.con.Insert(audit);
                db.con.InsertOrReplace(note);
                isEditing = false;
            }
            // The default behavior is saving data in text box as new note.
            else
            {
                db.con.Insert(note);
            }

            // Refresh UI.
            noteText.Clear();
            LoadNotes();
        }

        // Loading a list of notes from the chosen case and grabs the data from the database.
        public void LoadNotes()
        {
            List<Note> notes = db.con.Table<Note>().Where(n => n.case_id == caseobject.id).OrderByDescending(n => n.created).ToList();
            noteList.Items.Clear();
            // Loop through each note and add data to the list.
            foreach (Note note in notes) 
            {
                ListViewItem item = new ListViewItem();
                item.Text = note.created.ToString("dd.MM.yyyy HH:mm");
                // If a note is edited it is marked with "*" in the list.
                if (note.is_edited)
                {
                    item.Text += " *";
                }
                item.SubItems.Add(note.content);
                item.Tag = note;
                noteList.Items.Add(item);
            }
        }
        // When selecting a new note load the most recent data, check for case_closed, and change isEditing tag.
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

        // Opens a window with the audit log for a given note on button click.
        private void autditLogBtn_Click(object sender, EventArgs e)
        {
            if (noteList.SelectedItems.Count > 0)
            {
                Note selectedNote = noteList.SelectedItems[0].Tag as Note;
                AuditLogForm auditLogForm = new AuditLogForm(selectedNote);
                auditLogForm.ShowDialog(this);
            }
            // The default behavior is giving an error if a note has not been chosen.
            else
            {
                MessageBox.Show("Please select a note.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
