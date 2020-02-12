namespace LojaZero.UserDomain.Entity
{
    public class Phone
    {
        public string AppUserId { get; set; }
        public AppUser AppUser { get; set; }
        public string CountryCode { get; set; }
        public string AreaCode { get; set; }
        public string Number { get; set; }
    }
}
