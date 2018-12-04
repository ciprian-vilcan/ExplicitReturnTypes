namespace ExpressiveReturnTypes.Example.ValueTypes.Integers
{
    using System;

    /// <summary>
    /// A data type that may contain a <see cref="NonPositiveInt"/> or a <see cref="PositiveInt"/>.
    /// </summary>
    public struct NegativityLenientInt : IEither<NonPositiveInt, PositiveInt>
    {
        /// <summary>
        /// The either implementation.
        /// </summary>
        private readonly IEither<NonPositiveInt, PositiveInt> eitherImplementation;

        /// <summary>
        /// Initializes a new instance of the <see cref="NegativityLenientInt"/> struct.
        /// </summary>
        /// <param name="value"> The value. </param>
        public NegativityLenientInt(int value)
        {
            Either<NonPositiveInt, PositiveInt> either;

            if (value <= 0)
            {
                either = new NonPositiveInt(value);
            }
            else
            {
                either = new PositiveInt(value);
            }

            this.eitherImplementation = either;
        }

        /// <inheritdoc />
        public TResult Match<TResult>(Func<NonPositiveInt, TResult> aFunc, Func<PositiveInt, TResult> bFunc)
            => this.eitherImplementation.Match(aFunc, bFunc);

        /// <inheritdoc />
        public override bool Equals(object obj) =>
            this.eitherImplementation.Match(
                nonPositiveInt => nonPositiveInt.Equals(obj),
                positiveInt => positiveInt.Equals(obj));

        /// <inheritdoc />
        public override int GetHashCode() =>
            this.eitherImplementation.Match(
                nonPositiveInt => nonPositiveInt.GetHashCode(),
                positiveInt => positiveInt.GetHashCode());
    }
}