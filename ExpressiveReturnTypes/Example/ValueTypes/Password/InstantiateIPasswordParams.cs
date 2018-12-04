namespace ExpressiveReturnTypes.Example.ValueTypes.Password
{
    public class InstantiateIPasswordParams
    {
        public InstantiateIPasswordParams(string value)
        {
            this.Value = value;
        }

        public string Value { get; }

        public static implicit operator InstantiateIPasswordParams(string password) => new InstantiateIPasswordParams(password);
    }
}