

namespace librarymanegement
{
    internal class libraryManagement:LibraryManegementCore
    {
        public void RegisteeUser(string firstName, string lastName)
        {

        }
        public void RegisteeUser(string firstName, string lastName,string userName)
        {
            var foundUser = false;
            foreach (var user in Store.Users) 
            {
                if(user.UserName == userName)
                {
                    foundUser = true;
                    break;
                }
            }
            if (foundUser)
                return;
            Store.Users.Add(new User(firstName, lastName,userName));
        }

    }
}
