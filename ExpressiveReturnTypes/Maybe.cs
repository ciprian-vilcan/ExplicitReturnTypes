namespace ExpressiveReturnTypes
{
    using System;

    public class Maybe<T> : IMaybe<T>
    {
        private readonly Either<T, Nothing> innerEither;

        public Maybe()
        {
            this.innerEither = new Either<T, Nothing>(Nothing.Instance);
        }

        public Maybe(T value)
        {
            this.innerEither = new Either<T, Nothing>(value);
        }

        public TResult Match<TResult>(Func<T, TResult> aFunc, Func<Nothing, TResult> bFunc) 
            => this.innerEither.Match(aFunc, bFunc);

        public static implicit operator Maybe<T>(Nothing nothing) => new Maybe<T>();

        public static implicit operator Maybe<T>(T instance) => new Maybe<T>(instance);

        /// <inheritdoc />
        public TResult Match<TResult>(Func<T, TResult> someFunc, Func<TResult> noneFunc) 
            => this.Match(
                someFunc, 
                nothing => noneFunc());

        /// <inheritdoc />
        public override string ToString() => this.innerEither.Match(some => some.ToString(), none => none.ToString());
    }
}