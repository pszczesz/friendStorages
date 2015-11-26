using System;
using System.Collections.Generic;

namespace FriendStories.Model {
    public class Friend {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Address Address { get; set; }
        public DateTime Birthday { get; set; }
        public bool IsDeveloper { get; set; }
        public List<FriendEmail> Emails { get; set; }
        public int Id { get; set; }
        public int FriendGroupId { get; set; }
    }
}