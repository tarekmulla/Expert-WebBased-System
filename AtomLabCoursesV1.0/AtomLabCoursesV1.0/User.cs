//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AtomLabCoursesV1._0
{
    using System;
    using System.Collections.Generic;
    
    public partial class User
    {
        public User()
        {
            this.Rates = new HashSet<Rate>();
            this.UserFriends = new HashSet<UserFriend>();
            this.UsersExperts = new HashSet<UsersExpert>();
        }
    
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string Job { get; set; }
        public string FieldInterest { get; set; }
    
        public virtual ICollection<Rate> Rates { get; set; }
        public virtual ICollection<UserFriend> UserFriends { get; set; }
        public virtual ICollection<UsersExpert> UsersExperts { get; set; }
    }
}