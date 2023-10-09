namespace FluentValidationLib.Models
{
    public class Customer
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Email { get; set; }

        public int Age { get; set; }

        public DateTime? BirthdayTime { get; set; }

        public Gender Gender { get; set; } //enum

        public IList<Address> Addresses { get; set; }

        public string FullName2()  //otomatik mapping için GetFullName olarak isimlendirilmeli
        {
            return $"{Name} {Email} {Age}";
        }

        public CreditCard CreditCard {  get; set; }
    }
}
