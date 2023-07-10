namespace CleanArch.Domain.Entities;
public partial class AuthUser
{
    public AuthUser Create(string firstName, string lastName, string username, string password, string email, string mobile)
    {

        this.FirstName = firstName;
        this.LastName = lastName;
        this.Username = username;
        this.Password = password;
        this.Email = email;
        this.Mobile = mobile;
        return this;
    }
    public long Id { get; private set; }
    public string FirstName { get; private set; } = string.Empty;
    public string LastName { get; private set; } = string.Empty;
    public string Username { get; private set; } = string.Empty;
    public string Password { get; private set; } = string.Empty;
    public string Email { get; private set; } = string.Empty;
    public string Mobile { get; private set; } = string.Empty;

}