namespace MvcModelBindingDemo.Models
{
    public class User
    {
        // Simple Types
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }

        // Complex Type
        public Address Address { get; set; }
    }
}