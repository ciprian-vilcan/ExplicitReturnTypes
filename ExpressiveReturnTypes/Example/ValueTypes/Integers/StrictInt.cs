namespace ExpressiveReturnTypes.Example.ValueTypes.Integers
{
    using System;

    /// <summary>
    /// An instance of an int that can be either negative, zero, or positive.
    /// </summary>
    public struct StrictInt : IEither<NegativeInt, Zero, PositiveInt>
    {
        /// <summary>
        /// The either implementation.
        /// </summary>
        private readonly IEither<NegativeInt, Zero, PositiveInt> eitherImplementation;

        /// <summary>
        /// Initializes a new instance of the <see cref="StrictInt"/> struct.
        /// </summary>
        /// <param name="value"> The value. </param>
        public StrictInt(int value)
        {
            Either<NegativeInt, Zero, PositiveInt> either;

            if (value < 0)
            {
                either = new NegativeInt(value);
            }
            else if (value == 0)
            {
                either = new Zero();
            }
            else
            {
                either = new PositiveInt(value);
            }

            this.eitherImplementation = either;
        }

        /// <inheritdoc />
        public TResult Match<TResult>(Func<NegativeInt, TResult> aFunc, Func<Zero, TResult> bFunc, Func<PositiveInt, TResult> cFunc) 
            => this.eitherImplementation.Match(aFunc, bFunc, cFunc);

        /// <inheritdoc />
        public override bool Equals(object obj) => 
            this.eitherImplementation.Match(
                negativeInt => negativeInt.Equals(obj), 
                zero => zero.Equals(obj),
                positiveInt => positiveInt.Equals(obj));

        /// <inheritdoc />
        public override int GetHashCode() =>
            this.eitherImplementation.Match(
                negativeInt => negativeInt.GetHashCode(),
                zero => zero.GetHashCode(),
                positiveInt => positiveInt.GetHashCode());
    }
}
