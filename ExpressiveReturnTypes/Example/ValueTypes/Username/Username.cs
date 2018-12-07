namespace ExpressiveReturnTypes.Example.ValueTypes.Username
{
    using System;

    public class Username : IUsername
    {
        private Username(string username)
        {
            this.Value = username;
        }

        public string Value { get; }

        public static implicit operator string(Username instance) => instance.Value;

        public class Factory : IMethod<string, IEither<IUsername, InvalidUsername>>
        {
            private readonly Func<string, bool> usernameExists;

            public Factory(Func<string, bool> usernameExists)
            {
                this.usernameExists = usernameExists;
            }

            public IEither<IUsername, InvalidUsername> Execute(string username)
            {
                Either<Username, InvalidUsername> result;

                if (username.Length < 2)
                {
                    result = new InvalidUsername(new UsernameTooShort());
                }
                else if (this.usernameExists(username))
                {
                    result = new InvalidUsername(new UsernameTaken());
                }
                else
                {
                    result = new Username(username);
                }

                return result;
            }
        }
    }
}
