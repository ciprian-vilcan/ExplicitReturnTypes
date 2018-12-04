namespace ExpressiveReturnTypes.Example.ValueTypes.Integers
{
    /// <summary>
    /// An instance of a negative int.
    /// </summary>
    public struct NegativeInt
    {
        /// <summary>
        /// The underlying value.
        /// </summary>
        private readonly int value;

        /// <summary>
        /// Initializes a new instance of the <see cref="NegativeInt"/> struct.
        /// </summary>
        /// <param name="value">
        /// The value.
        /// </param>
        internal NegativeInt(int value) => this.value = value;

        /// <summary>
        /// Implicit int converter.
        /// </summary>
        /// <param name="instance"> The instance. </param>
        public static implicit operator int(NegativeInt instance) => instance.value;

        /// <inheritdoc />
        public override bool Equals(object obj) => this.value.Equals(obj);

        /// <inheritdoc />
        public override int GetHashCode() => this.value.GetHashCode();
    }
}