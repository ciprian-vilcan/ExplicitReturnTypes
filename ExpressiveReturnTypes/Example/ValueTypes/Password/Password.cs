namespace ExpressiveReturnTypes.Example.ValueTypes.Password
{
    using ExpressiveReturnTypes.Example.Flows.CreateUser;

    public class Password : IPassword
    {
        private Password(string value)
        {
            this.Value = value;
        }

        public string Value { get; }

        public static implicit operator string(Password instance) => instance.Value;

        public class Factory : IMethod<InstantiateIPasswordParams, IEither<IPassword, InvalidPassword>>
        {
            public IEither<IPassword, InvalidPassword> Execute(InstantiateIPasswordParams parameters)
            {
                Either<Password, InvalidPassword> result;

                if (parameters.Value.Length < 12)
                {
                    result = new PasswordTooShort().ToInvalidPassword();
                }
                else
                {
                    result = new Password(parameters.Value);
                }

                return result;
            }
        }
    }
}
