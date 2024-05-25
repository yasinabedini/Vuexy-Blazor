namespace ViewModels
{
    public class User
    {
        public string Id { get; set; }
        public string UserName { get; set; }
        public string PhoneNumber { get; set; }

        public User(string id, string userName, string phoneNumber)
        {
            Id = id;
            UserName = userName;
            PhoneNumber = phoneNumber;
        }
    }
}
