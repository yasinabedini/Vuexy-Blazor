namespace Features.User;

public class UserViewModel
{
    public string Id { get; set; }
    public string UserName { get; set; }
    public string PhoneNumber { get; set; }

    public UserViewModel(string id, string userName, string phoneNumber)
    {
        Id = id;
        UserName = userName;
        PhoneNumber = phoneNumber;
    }
}
