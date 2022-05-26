using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;

namespace NoteTakingApp.Classes
{
    // Database is created with a connection to the program.
    public class Database
    {
        // Connection to the database.
        public SQLiteConnection con;

        // Tables are created in the database.
        public Database()
        {
            SQLiteConnectionString str = new SQLiteConnectionString("Data Source=notes.db;");
            con = new SQLiteConnection("notes.db");
            con.BeginTransaction();
            // con.CreateTable: create a new table if not exist.
            con.CreateTable<User>();
            con.CreateTable<Case>();
            con.CreateTable<Note>();
            con.CreateTable<Auditlog>();

            // Default users are created if not exist.
            if (con.Table<User>().Where(u => u.username == "admin").FirstOrDefault() == null)
            {
                // Create a user with admin permissions.
                User user = new User();
                Console.WriteLine("creating user");
                user.username = "admin";
                user.password = Crypt.hashPassword("admin"); // Passed from Crypt, encrypts password before storing it in database.
                user.role = "admin";
                user.name = "Admin";
                con.Insert(user);

                // Create a user with regular permissions.
                //user.username = "therese";
                //user.password = Crypt.hashPassword("123"); // Passed from Crypt, encrypts password before storing it in database.
                //user.role = "user";
                //user.name = "Therese";
                //con.Insert(user);
            }

            // Write to database.
            con.Commit();
        }
    }
}
