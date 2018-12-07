namespace ExpressiveReturnTypes.Example.ValueTypes.Email.ThatIsNotInUse
{
    using System;

    using ExpressiveReturnTypes.Example.ValueTypes.Username;

    public class InvalidEmailThatIsNotInUse : CompositeExpectedException, IEither<InvalidEmailFormat, UntrustedProvider, EmailAlreadyInUse>
    {
        private readonly Either<InvalidEmailFormat, UntrustedProvider, EmailAlreadyInUse> innerEither;

        public InvalidEmailThatIsNotInUse(InvalidEmailFormat case1) : base(case1)
        {
            this.innerEither = case1;
        }

        public InvalidEmailThatIsNotInUse(UntrustedProvider case2) : base(case2)
        {
            this.innerEither = case2;
        }

        public InvalidEmailThatIsNotInUse(EmailAlreadyInUse case3) : base(case3)
        {
            this.innerEither = case3;
        }

        public TResult Match<TResult>(Func<InvalidEmailFormat, TResult> aFunc, Func<UntrustedProvider, TResult> bFunc, Func<EmailAlreadyInUse, TResult> cFunc)
            => this.innerEither.Match(aFunc, bFunc, cFunc);

        public static implicit operator InvalidEmailThatIsNotInUse(InvalidEmailFormat instance) => new InvalidEmailThatIsNotInUse(instance);

        public static implicit operator InvalidEmailThatIsNotInUse(UntrustedProvider instance) => new InvalidEmailThatIsNotInUse(instance);

        public static implicit operator InvalidEmailThatIsNotInUse(EmailAlreadyInUse instance) => new InvalidEmailThatIsNotInUse(instance);
    }
}