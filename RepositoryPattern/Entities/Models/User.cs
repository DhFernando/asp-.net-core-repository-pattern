using System;
using System.Collections.Generic;

namespace RepositoryPattern.Models
{
    public partial class User
    {
        public string UserId { get; set; }
        public string UserName { get; set; }
        public string UserBday { get; set; }
        public string UserRole { get; set; }
        public string UserDep { get; set; }
    }
}
