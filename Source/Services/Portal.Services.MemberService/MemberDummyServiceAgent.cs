using System;
using System.Collections.Generic;
using System.Linq;
using Portal.Services.MemberService.Models;

namespace Portal.Services.MemberService
{
    public class MemberDummyServiceAgent : IMemberServiceAgent
    {
        private List<Member> _members = new List<Member>(){
                new Member(){Id = Guid.NewGuid(), FirstName = "Firstname 1", LastName = "Lastname 1" },
                new Member(){Id = Guid.NewGuid(), FirstName = "Firstname 2", LastName = "Lastname 2" },
                new Member(){Id = Guid.NewGuid(), FirstName = "Firstname 3", LastName = "Lastname 3" },
                new Member(){Id = Guid.NewGuid(), FirstName = "Firstname 4", LastName = "Lastname 4" },
                new Member(){Id = Guid.NewGuid(), FirstName = "Firstname 5", LastName = "Lastname 5" }
            };

        public IEnumerable<Member> Get()
        {
            return _members;
        }

        public Member Get(Guid id)
        {
            return _members.FirstOrDefault(m => m.Id == id);
        }

        public void Save(Member member)
        {
            if (!_members.Any(m => m.Id == member.Id))
            {
                _members.Add(member);
            }
            else
            {
                _members.Add(member);
            }
        }

        public void Delete(Guid id)
        {
            _members.Remove(_members.FirstOrDefault(m => m.Id == id));
        }
    }
}
