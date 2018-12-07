namespace ExpressiveReturnTypes.Example.ValueTypes.Password
{
    public class Password : IPassword
    {
        private Password(string value)
        {
            this.Value = value;
        }

        public string Value { get; }

        public static implicit operator string(Password instance) => instance.Value;

        public class Factory : IMethod<string, IEither<IPassword, InvalidPassword>>
        {
            public IEither<IPassword, InvalidPassword> Execute(string password)
            {
                Either<Password, InvalidPassword> result;

                if (password.Length < 12)
                {
                    result = new InvalidPassword(new PasswordTooShort());
                }
                else
                {
                    result = new Password(password);
                }

                return result;
            }
        }
    }
}
