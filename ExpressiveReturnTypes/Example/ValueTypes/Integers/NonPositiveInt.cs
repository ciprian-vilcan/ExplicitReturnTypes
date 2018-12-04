namespace ExpressiveReturnTypes.Example.ValueTypes.Integers
{
    /// <summary>
    /// An instance of an int that is greater or equal to zero.
    /// </summary>
    public struct NonPositiveInt
    {
        /// <summary>
        /// The value.
        /// </summary>
        private readonly int value;

        /// <summary>
        /// Initializes a new instance of the <see cref="NonPositiveInt"/> struct.
        /// </summary>
        /// <param name="value"> The value. </param>
        internal NonPositiveInt(int value) => this.value = value;

        /// <summary>
        /// Implicit int converter.
        /// </summary>
        /// <param name="instance"> The instance. </param>
        public static implicit operator int(NonPositiveInt instance) => instance.value;

        /// <inheritdoc />
        public override bool Equals(object obj) => this.value.Equals(obj);

        /// <inheritdoc />
        public override int GetHashCode() => this.value.GetHashCode();
    }
}