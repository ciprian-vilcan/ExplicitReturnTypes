namespace ExpressiveReturnTypes.Example.Flows.CreateUser
{
    using ExpressiveReturnTypes.Example.ValueTypes.Email;
    using ExpressiveReturnTypes.Example.ValueTypes.Password;
    using ExpressiveReturnTypes.Example.ValueTypes.Username;

    public class InstantiateUserParams
    {
        public InstantiateUserParams(InstantiateIUsernameParams username, InstantiateIPasswordParams password, InstantiateIEmailParams email)
        {
            this.Username = username;
            this.Password = password;
            this.Email = email;
        }

        public InstantiateIUsernameParams Username { get; }

        public InstantiateIPasswordParams Password { get; }

        public InstantiateIEmailParams Email { get; }
    }
}