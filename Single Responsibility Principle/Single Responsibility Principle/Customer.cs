namespace Single_Responsibility_Principle
{
    public class Customer
    {
        private readonly string firstName;
        private readonly string lastName;
        private readonly string email;
        private readonly string phone;

        public Customer(string firstName, string lastName, string email, string phone)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.email = email;
            this.phone = phone;
        }

        public string GetFullName()
        {
            return $"{this.firstName} {this.lastName}";
        }

        public string GetPhoneNumber()
        {
            return this.phone;
        }

        public string GetEmailAddress()
        {
            return this.email;
        }
    }
}
