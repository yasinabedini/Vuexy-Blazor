namespace ApiTest.Models
{
    public class User
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string PhoneNumber { get; set; }

        public User(int id, string userName, string phoneNumber)
        {
            Id = id;
            UserName = userName;
            PhoneNumber = phoneNumber;
        }
    }
}
