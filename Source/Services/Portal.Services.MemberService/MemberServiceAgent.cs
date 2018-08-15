using System;
using System.Collections.Generic;
using Portal.Services.Models;

namespace Portal.Services.MemberService
{
    public class MemberServiceAgent
    {
        
        public IEnumerable<Member> Get(){
            return new List<Member>(){
                new Member(){Id = Guid.NewGuid(), FirstName = "Firstname 1", LastName = "Lastname 1" },
                new Member(){Id = Guid.NewGuid(), FirstName = "Firstname 2", LastName = "Lastname 2" },
                new Member(){Id = Guid.NewGuid(), FirstName = "Firstname 3", LastName = "Lastname 3" },
                new Member(){Id = Guid.NewGuid(), FirstName = "Firstname 4", LastName = "Lastname 4" },
                new Member(){Id = Guid.NewGuid(), FirstName = "Firstname 5", LastName = "Lastname 5" }
            };
        }
    }
}
