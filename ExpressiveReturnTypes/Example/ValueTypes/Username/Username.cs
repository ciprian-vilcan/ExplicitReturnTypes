namespace ExpressiveReturnTypes.Example.ValueTypes.Username
{
    using System;

    using ExpressiveReturnTypes.Example.Flows.CreateUser;

    public class Username : IUsername
    {
        private Username(string username)
        {
            this.Value = username;
        }

        public string Value { get; }

        public static implicit operator string(Username instance) => instance.Value;

        public class Factory : IMethod<InstantiateIUsernameParams, IEither<IUsername, InvalidUsername>>
        {
            private readonly Func<string, bool> usernameExists;

            public Factory(Func<string, bool> usernameExists)
            {
                this.usernameExists = usernameExists;
            }

            public IEither<IUsername, InvalidUsername> Execute(InstantiateIUsernameParams username)
            {
                Either<Username, InvalidUsername> result;

                if (username.Value.Length < 2)
                {
                    result = new InvalidUsername(new UsernameTooShort());
                }
                else if (this.usernameExists(username.Value))
                {
                    result = new InvalidUsername(new UsernameTaken());
                }
                else
                {
                    result = new Username(username.Value);
                }

                return result;
            }
        }
    }
}
