namespace ExpressiveReturnTypes.Example.ValueTypes.Email
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Text.RegularExpressions;

    public class Email : IEmail
    {
        private Email(string value)
        {
            this.Value = value;
        }

        /// <inheritdoc />
        public string Value { get; }

        public class Factory : IMethod<string, IEither<IEmail, InvalidEmailFormat, UntrustedProvider>>
        {
            private readonly IEnumerable<string> trustedProviders;

            public Factory(IEnumerable<string> trustedProviders)
            {
                this.trustedProviders = trustedProviders;
            }

            public IEither<IEmail, InvalidEmailFormat, UntrustedProvider> Execute(string email)
            {
                Either<IEmail, InvalidEmailFormat, UntrustedProvider> result;

                if (!Regex.IsMatch(email, @"[a-zA-Z]@[a-zA-Z]\.(com|net)"))
                {
                    result = new InvalidEmailFormat();
                }
                else if (this.trustedProviders.All(p => p != email.Split('@').Last()))
                {
                    result = new UntrustedProvider();
                }
                else
                {
                    result = new Email(email);
                }

                return result;
            }
        }
    }
}