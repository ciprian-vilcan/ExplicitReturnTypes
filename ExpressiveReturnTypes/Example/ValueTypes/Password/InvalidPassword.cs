namespace ExpressiveReturnTypes.Example.ValueTypes.Password
{
    using System;

    using ExpressiveReturnTypes.Example.ValueTypes.Username;

    public class InvalidPassword : CompositeExpectedException, IEither<PasswordTooShort>
    {
        private readonly Either<PasswordTooShort> innerEither;

        public InvalidPassword(PasswordTooShort passwordTooShort) : base(passwordTooShort)
        {
            this.innerEither = passwordTooShort;
        }

        /// <inheritdoc />
        public TResult Match<TResult>(Func<PasswordTooShort, TResult> aFunc)
        {
            return this.innerEither.Match(aFunc);
        }
    }
}