

namespace librarymanegement
{
    public abstract class LibraryManegementCore
    {
        public librarystore Store { get; set; }
        public LibraryManegementCore()
        {
            Store = new librarystore();
        } 
        public LibraryManegementCore(List<Book> books,List<User> users)
        {
            Store = new librarystore(books,users);
        }
        public void DisplayAllUsers()
        {
            foreach(var user in Store.Users)
                Console.WriteLine(user.ToString());
        }
        public void DisplayAllBooks()
        {
            foreach(var book in Store.Books)
                Console.WriteLine(book.ToString());
        }



    }
}
