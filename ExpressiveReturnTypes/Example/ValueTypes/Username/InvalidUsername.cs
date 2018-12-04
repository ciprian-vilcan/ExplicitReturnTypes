namespace ExpressiveReturnTypes.Example.ValueTypes.Username
{
    using System;

    public class InvalidUsername : IEither<UsernameTooShort, UsernameTaken>
    {
        private readonly Either<UsernameTooShort, UsernameTaken> innerEither;

        public InvalidUsername(UsernameTooShort case1)
        {
            this.innerEither = case1;
        }

        public InvalidUsername(UsernameTaken case2)
        {
            this.innerEither = case2;
        }

        public TResult Match<TResult>(Func<UsernameTooShort, TResult> aFunc, Func<UsernameTaken, TResult> bFunc)
            => this.innerEither.Match(aFunc, bFunc);

        /// <inheritdoc />
        public override string ToString() => this.innerEither.ToString();
    }
}