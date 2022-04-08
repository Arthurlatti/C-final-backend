using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;

namespace FinalProJectMVC.Models {
    public class AppUser : IdentityUser {

        public IEnumerable<Post> Posts {get; set;}
    }
}