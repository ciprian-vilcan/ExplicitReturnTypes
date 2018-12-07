namespace ExpressiveReturnTypes.Example.Flows.CreateUser
{
    using ExpressiveReturnTypes.Example.ValueTypes.Email;
    using ExpressiveReturnTypes.Example.ValueTypes.Password;
    using ExpressiveReturnTypes.Example.ValueTypes.Username;

    public interface IUser
    {
        IUsername Username { get; }

        IPassword Password { get; }

        IEmail Email { get; }
    }
}