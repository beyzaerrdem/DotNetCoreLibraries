namespace FluentValidationLib.DTOs
{
    public class CustomerDto
    {
        public int Id { get; set; }

        public string Isim { get; set; }

        public string Eposta { get; set; }

        public int Yas { get; set; }

        public string FullName { get; set; }

        public int CreditCardNumber { get; set; }

        public DateTime CreditCardValidDate { get; set; }
    }
}
