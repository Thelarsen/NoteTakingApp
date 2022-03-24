using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;

namespace NoteTakingApp.Classes
{
    public class Database
    {
        public SQLiteConnection con;

        public Database()
        {
            SQLiteConnectionString str = new SQLiteConnectionString("Data Source=notes.db;Password=therese");
            con = new SQLiteConnection("notes.db");
            con.BeginTransaction();
            con.CreateTable<User>();
            con.CreateTable<Role>();
            con.CreateTable<Case>();
            con.CreateTable<Exhibit>();
            con.CreateTable<Note>();
            con.CreateTable<Auditlog>();

            if (con.Table<User>().Where(u => u.username == "admin").FirstOrDefault() == null)
            {
                User user = new User();
                Console.WriteLine("creating user");
                user.username = "admin";
                user.password = Crypt.hashPassword("admin");
                user.role = "admin";
                user.name = "Admin";
                con.Insert(user);

                user.username = "therese";
                user.password = Crypt.hashPassword("123");
                user.role = "user";
                user.name = "Therese";
                con.Insert(user);
            }

            con.Commit();
        }
    }
}
