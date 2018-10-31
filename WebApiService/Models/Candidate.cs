using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApiService.Models
{
    public class Candidate
    {
        public int id;
        public string Username { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Password { get; set; }
        public string Userrole { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreateDate { get; set; }
    }
}