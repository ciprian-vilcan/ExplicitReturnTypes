namespace ExpressiveReturnTypes.Example.ValueTypes.Email.ThatIsNotInUse
{
    public class EmailThatIsNotInUse : IEmailThatIsNotInUse
    {
        private EmailThatIsNotInUse(string value)
        {
            this.Value = value;
        }

        /// <inheritdoc />
        public string Value { get; }

        public class Factory : IMethod<string, IEither<IEmailThatIsNotInUse, InvalidEmailThatIsNotInUse>>
        {
            private readonly IMethod<
                string, 
                IEither<IEmail, InvalidEmailFormat, UntrustedProvider>> emailFactoryImplementation;

            private readonly IMethod<IEmail, bool> emailIsInUse;

            public Factory(
                IMethod<
                    string, 
                    IEither<IEmail, InvalidEmailFormat, UntrustedProvider>> emailFactoryImplementation,
                IMethod<IEmail, bool> emailIsInUse)
            {
                this.emailFactoryImplementation = emailFactoryImplementation;
                this.emailIsInUse = emailIsInUse;
            }

            /// <inheritdoc />
            public IEither<IEmailThatIsNotInUse, InvalidEmailThatIsNotInUse> Execute(string parameters)
            {
                var result = this.emailFactoryImplementation
                    .Execute(parameters)
                    .Match(
                        validEmail =>
                            {
                                Either<IEmailThatIsNotInUse, InvalidEmailThatIsNotInUse> r;
                                if (this.emailIsInUse.Execute(validEmail))
                                {
                                    r = new InvalidEmailThatIsNotInUse(new EmailAlreadyInUse());
                                }
                                else
                                {
                                    r = new EmailThatIsNotInUse(validEmail.Value);
                                }

                                return r;
                            },
                        invalidFormat => new InvalidEmailThatIsNotInUse(invalidFormat),
                        untrustedProvider => new InvalidEmailThatIsNotInUse(untrustedProvider));

                return result;
            }
        }
    }
}