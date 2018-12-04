namespace ExpressiveReturnTypes.Example.ValueTypes.Password
{
    using System;

    public class InvalidPassword : IEither<PasswordTooShort>
    {
        private readonly IEither<PasswordTooShort> innerEither;

        public InvalidPassword(IEither<PasswordTooShort> innerEither)
        {
            this.innerEither = innerEither;
        }

        /// <inheritdoc />
        public TResult Match<TResult>(Func<PasswordTooShort, TResult> aFunc)
        {
            return this.innerEither.Match(aFunc);
        }
    }

    public static class InvalidPassword_Extensions
    {
        public static InvalidPassword ToInvalidPassword(this PasswordTooShort instance)
            => new InvalidPassword(new Either<PasswordTooShort>(instance));
    }
}