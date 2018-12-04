namespace ExpressiveReturnTypes.Example.ValueTypes.Email
{
    using System;

    using ExpressiveReturnTypes.Example.ValueTypes.Email.ThatIsNotInUse;

    public class InvalidEmail : IEither<InvalidEmailFormat, UntrustedProvider, AlreadyInUse>
    {
        private readonly Either<InvalidEmailFormat, UntrustedProvider, AlreadyInUse> innerEither;

        public InvalidEmail(InvalidEmailFormat case1)
        {
            this.innerEither = case1;
        }

        public InvalidEmail(UntrustedProvider case1)
        {
            this.innerEither = case1;
        }

        public InvalidEmail(AlreadyInUse case1)
        {
            this.innerEither = case1;
        }

        public TResult Match<TResult>(Func<InvalidEmailFormat, TResult> aFunc, Func<UntrustedProvider, TResult> bFunc, Func<AlreadyInUse, TResult> cFunc) 
            => this.innerEither.Match(aFunc, bFunc, cFunc);

        /// <inheritdoc />
        public override string ToString() => this.innerEither.ToString();
    }
}