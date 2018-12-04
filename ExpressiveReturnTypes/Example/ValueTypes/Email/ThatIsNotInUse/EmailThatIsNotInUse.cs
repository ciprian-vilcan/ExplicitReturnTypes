namespace ExpressiveReturnTypes.Example.ValueTypes.Email.ThatIsNotInUse
{
    using System;

    using ExpressiveReturnTypes.Example.Flows.CreateUser;

    public class EmailThatIsNotInUse : IEmailThatIsNotInUse
    {
        public EmailThatIsNotInUse(string value)
        {
            this.Value = value;
        }

        /// <inheritdoc />
        public string Value { get; }

        public class Factory : IMethod<InstantiateIEmailParams, IEither<IEmailThatIsNotInUse, InvalidEmailThatIsNotInUse>>
        {
            private readonly IMethod<
                InstantiateIEmailParams, 
                IEither<IEmail, InvalidEmailFormat, UntrustedProvider>> emailFactoryImplementation;

            private readonly IMethod<IEmail, IMaybe> emailIsInUse;

            public Factory(
                IMethod<
                    InstantiateIEmailParams, 
                    IEither<IEmail, InvalidEmailFormat, UntrustedProvider>> emailFactoryImplementation,
                IMethod<IEmail, IMaybe> emailIsInUse)
            {
                this.emailFactoryImplementation = emailFactoryImplementation;
                this.emailIsInUse = emailIsInUse;
            }

            /// <inheritdoc />
            public IEither<IEmailThatIsNotInUse, InvalidEmailThatIsNotInUse> Execute(InstantiateIEmailParams parameters)
            {
                Either<IEmailThatIsNotInUse, InvalidEmailThatIsNotInUse> result = this.emailFactoryImplementation
                    .Execute(parameters)
                    .Match(
                        validEmail => this.emailIsInUse
                            .Execute(validEmail)
                            .Match<Either<IEmailThatIsNotInUse, InvalidEmailThatIsNotInUse>>(
                                exists => new EmailAlreadyInUse().ToInstantiationFailure(),
                                doesNotExist => new EmailThatIsNotInUse(validEmail.Value)),
                        invalidFormat => invalidFormat.ToInstantiationFailure(),
                        untrustedProvider => untrustedProvider.ToInstantiationFailure());

                return result;
            }
        }
    }

    public class InvalidEmailThatIsNotInUse : IEither<InvalidEmailFormat, UntrustedProvider, EmailAlreadyInUse>
    {
        private readonly Either<InvalidEmailFormat, UntrustedProvider, EmailAlreadyInUse> innerEither;

        public InvalidEmailThatIsNotInUse(InvalidEmailFormat case1)
        {
            this.innerEither = case1;
        }

        public InvalidEmailThatIsNotInUse(UntrustedProvider case2)
        {
            this.innerEither = case2;
        }

        public InvalidEmailThatIsNotInUse(EmailAlreadyInUse case3)
        {
            this.innerEither = case3;
        }

        public TResult Match<TResult>(Func<InvalidEmailFormat, TResult> aFunc, Func<UntrustedProvider, TResult> bFunc, Func<EmailAlreadyInUse, TResult> cFunc)
            => this.innerEither.Match(aFunc, bFunc, cFunc);

        public static implicit operator InvalidEmailThatIsNotInUse(InvalidEmailFormat instance) => new InvalidEmailThatIsNotInUse(instance);

        public static implicit operator InvalidEmailThatIsNotInUse(UntrustedProvider instance) => new InvalidEmailThatIsNotInUse(instance);

        public static implicit operator InvalidEmailThatIsNotInUse(EmailAlreadyInUse instance) => new InvalidEmailThatIsNotInUse(instance);
    }

    internal static class EmailThatIsNotInUse_Extensions
    {
        public static InvalidEmailThatIsNotInUse ToInstantiationFailure(this InvalidEmailFormat instance)
            => new InvalidEmailThatIsNotInUse(instance);

        public static InvalidEmailThatIsNotInUse ToInstantiationFailure(this UntrustedProvider instance)
            => new InvalidEmailThatIsNotInUse(instance);

        public static InvalidEmailThatIsNotInUse ToInstantiationFailure(this EmailAlreadyInUse instance)
            => new InvalidEmailThatIsNotInUse(instance);
    }
}