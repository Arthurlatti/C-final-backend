using System;

namespace FinalProJectMVC.Models
{
    public class Post {

        public int Id { get; set; }
        public string Title { get; set; }
        public string content { get; set; }
        public DateTime Timestamp { get; set;}

         public AppUser User {get; set;}
    }
}