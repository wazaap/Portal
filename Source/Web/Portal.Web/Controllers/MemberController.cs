using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Portal.Web.Models.Member;

namespace Portal.Web.Controllers{
    public class MemberController: Controller{
        public IEnumerable<MemberListModel> Index(){
            return Enumerable.Empty<MemberListModel>();
        }
    }
}