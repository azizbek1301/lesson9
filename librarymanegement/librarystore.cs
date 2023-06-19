using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace librarymanegement
{
    public class librarystore
    {
        public List<Book>Books { get; set; }
        public List<User>Users { get; set; }
        public librarystore()
        {
            Books = new List<Book>();
            Users = new List<User>();
            
        }
        public librarystore(List<Book> books, List<User> users)
        {
            Books = books;
            Users = users;
        }
    }


}
