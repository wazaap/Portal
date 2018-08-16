using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Portal.Services.MemberService;
using Portal.Web.Models.Member;

namespace Portal.Web.Controllers{
    public class MemberController: Controller{
        private readonly IMemberServiceAgent memberServiceAgent;

        public MemberController(IMemberServiceAgent memberServiceAgent)
        {
            this.memberServiceAgent = memberServiceAgent;
        }
        public IEnumerable<MemberListModel> Index(){
            return Enumerable.Empty<MemberListModel>();
        }
    }
}