namespace SARC.WForm.Domain.Models
{
    public class Cliente
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public string Celphone { get; set; }


        public string FullName { get { return Name + " " + LastName; } }
    }
}