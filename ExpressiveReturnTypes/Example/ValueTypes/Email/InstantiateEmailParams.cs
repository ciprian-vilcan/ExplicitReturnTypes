namespace ExpressiveReturnTypes.Example.ValueTypes.Email
{
    public class InstantiateIEmailParams
    {
        public InstantiateIEmailParams(string email)
        {
            this.Email = email;
        }

        public string Email { get; }

        public static implicit operator InstantiateIEmailParams(string email) => new InstantiateIEmailParams(email);
    }
}