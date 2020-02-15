namespace LojaZero.UserDomain.Entity
{
    public class Phone
    {
        public string UserId { get; set; }
        public AppIdentityUser User { get; set; }
        public string CountryCode { get; set; }
        public string AreaCode { get; set; }
        public string Number { get; set; }
    }
}
