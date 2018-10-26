﻿namespace StudentSystem.Data.Models
{
    public class User
    {
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Password { get; set; }

        public string Email { get; set; }

        public int StudentNumber { get; set; }

        public Role Role { get; set; }
    }
}