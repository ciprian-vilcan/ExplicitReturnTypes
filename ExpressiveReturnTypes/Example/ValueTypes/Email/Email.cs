namespace ExpressiveReturnTypes.Example.ValueTypes.Email
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Text.RegularExpressions;

    using ExpressiveReturnTypes.Example.Flows.CreateUser;

    public class Email : IEmail
    {
        private Email(string value)
        {
            this.Value = value;
        }

        /// <inheritdoc />
        public string Value { get; }

        public class Factory : IMethod<InstantiateIEmailParams, IEither<IEmail, InvalidEmailFormat, UntrustedProvider>>
        {
            private readonly IEnumerable<string> trustedProviders;

            public Factory(IEnumerable<string> trustedProviders)
            {
                this.trustedProviders = trustedProviders;
            }

            public IEither<IEmail, InvalidEmailFormat, UntrustedProvider> Execute(InstantiateIEmailParams parameters)
            {
                Either<IEmail, InvalidEmailFormat, UntrustedProvider> result;

                if (!Regex.IsMatch(parameters.Email, @"[a-zA-Z]@[a-zA-Z]\.(com|net)"))
                {
                    result = new InvalidEmailFormat();
                }
                else if (this.trustedProviders.All(p => p != parameters.Email.Split('@').Last()))
                {
                    result = new UntrustedProvider();
                }
                else
                {
                    result = new Email(parameters.Email);
                }

                return result;
            }
        }
    }
}