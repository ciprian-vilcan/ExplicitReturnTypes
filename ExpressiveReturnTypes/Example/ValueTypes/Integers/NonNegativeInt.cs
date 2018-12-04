namespace ExpressiveReturnTypes.Example.ValueTypes.Integers
{
    /// <summary>
    /// An instance of a non negative int.
    /// </summary>
    public struct NonNegativeInt
    {
        /// <summary>
        /// The value.
        /// </summary>
        private readonly int value;

        /// <summary>
        /// Initializes a new instance of the <see cref="NonNegativeInt"/> struct.
        /// </summary>
        /// <param name="value"> The value. </param>
        internal NonNegativeInt(int value) => this.value = value;

        /// <summary>
        /// Implicit int conversion.
        /// </summary>
        /// <param name="instance"> The instance. </param>
        public static implicit operator int(NonNegativeInt instance) => instance.value;

        /// <inheritdoc />
        public override bool Equals(object obj) => this.value.Equals(obj);

        /// <inheritdoc />
        public override int GetHashCode() => this.value.GetHashCode();
    }
}