using System;

namespace Portal.Services.Models{
    public class Member{
        public Guid Id { get; set; } 
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
    }
}