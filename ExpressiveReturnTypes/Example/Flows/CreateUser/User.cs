namespace ExpressiveReturnTypes.Example.Flows.CreateUser
{
    using ExpressiveReturnTypes.Example.ValueTypes.Email;
    using ExpressiveReturnTypes.Example.ValueTypes.Password;
    using ExpressiveReturnTypes.Example.ValueTypes.Username;

    public class User : IUser
    {
        public User(IUsername username, IPassword password, IEmail email)
        {
            this.Username = username;
            this.Password = password;
            this.Email = email;
        }

        public IUsername Username { get; }

        public IPassword Password { get; }

        public IEmail Email { get; }
    }
}
