﻿namespace LojaZero.UserDomain.Entity
{
    public class Address
    {
        public string UserId { get; set; }
        public AppIdentityUser User { get; set; }
        public string ZipCode { get; set; }
        public int Number { get; set; }
        public string Street { get; set; }
        public string Complement { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
    }
}
