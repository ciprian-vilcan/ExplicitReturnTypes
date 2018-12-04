namespace ExpressiveReturnTypes.Example.ValueTypes.Integers
{
    using System;

    /// <summary>
    /// An instance of an int that is either non negative or negative.
    /// </summary>
    public struct PositivityLenientInt : IEither<NonNegativeInt, NegativeInt>
    {
        /// <summary>
        /// The either implementation.
        /// </summary>
        private readonly IEither<NonNegativeInt, NegativeInt> eitherImplementation;

        /// <summary>
        /// Initializes a new instance of the <see cref="PositivityLenientInt"/> struct.
        /// </summary>
        /// <param name="value"> The value. </param>
        public PositivityLenientInt(int value)
        {
            Either<NonNegativeInt, NegativeInt> either;

            if (value >= 0)
            {
                either = new NonNegativeInt(value);
            }
            else
            {
                either = new NegativeInt(value);
            }

            this.eitherImplementation = either;
        }

        /// <inheritdoc />
        public TResult Match<TResult>(Func<NonNegativeInt, TResult> aFunc, Func<NegativeInt, TResult> bFunc)
            => this.eitherImplementation.Match(aFunc, bFunc);

        /// <inheritdoc />
        public override bool Equals(object obj) =>
            this.eitherImplementation.Match(
                nonNegativeInt => nonNegativeInt.Equals(obj),
                negativeInt => negativeInt.Equals(obj));

        /// <inheritdoc />
        public override int GetHashCode() =>
            this.eitherImplementation.Match(
                nonNegativeInt => nonNegativeInt.GetHashCode(),
                negativeInt => negativeInt.GetHashCode());
    }
}