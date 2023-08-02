using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinForm.NotDefteri
{
    public class DataStore
    {
        public static AppUser AppUser = new AppUser { Id=1,Username="Admin",Password="1"};
        public static List<Note> notes=new List<Note>()
        { 
            new Note{Id=1,Description="Note 1"},
            new Note{Id=2,Description="Note 2"}
        
        
        };
    }



    public class Note
    {
        public int Id { get; set; }
        public string Description { get; set; }
    }

    public class AppUser
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public int Id { get; set; }
    }
}
