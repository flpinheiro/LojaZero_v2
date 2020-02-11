namespace LojaZero.UserDomain.Entity
{
    public class Phone
    {
        public string PersonId { get; set; }
        public Person Person { get; set; }
        public string CountryCode { get; set; }
        public string AreaCode { get; set; }
        public string Number { get; set; }
    }
}
