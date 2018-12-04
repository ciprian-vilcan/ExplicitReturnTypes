namespace ExpressiveReturnTypes.Example.ValueTypes.Username
{
    public class InstantiateIUsernameParams
    {
        public InstantiateIUsernameParams(string username)
        {
            this.Value = username;
        }

        public string Value { get; }

        public static implicit operator InstantiateIUsernameParams(string username) => new InstantiateIUsernameParams(username);
    }
}