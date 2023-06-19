﻿

namespace librarymanegement
{
    public class User
    {
        public Guid Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string UserName { get;set; }


        public User(string firstName, string lastName)
        {
            Id = Guid.NewGuid();
            FirstName = firstName;
            LastName = lastName;
        }
        public User(string firstName,string lastName, string userName):this (firstName,lastName)
        {
            UserName = userName;
        }
        public override string ToString()
        {
            return $"Kitob" +
            $"\n id : {Id}, " +
                $"\n FirstName : {FirstName}, " +
                $"\n LastName : {LastName}" +
                $"\n UserName : {UserName}";
        }
    }
}
