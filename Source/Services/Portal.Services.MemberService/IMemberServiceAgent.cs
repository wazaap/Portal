using System;
using System.Collections.Generic;
using Portal.Services.MemberService.Models;

namespace Portal.Services.MemberService{
    public interface IMemberServiceAgent{
        IEnumerable<Member> Get();
         Member Get(Guid id);
        void Save(Member member);
        void Delete(Guid id);
    }
}