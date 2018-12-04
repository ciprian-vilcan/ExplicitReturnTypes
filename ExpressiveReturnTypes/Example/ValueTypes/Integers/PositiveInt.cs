namespace ExpressiveReturnTypes.Example.ValueTypes.Integers
{
    /// <summary>
    /// An instance of an int that is greater than zero.
    /// </summary>
    public struct PositiveInt
    {
        /// <summary>
        /// The value.
        /// </summary>
        private readonly int value;

        /// <summary>
        /// Initializes a new instance of the <see cref="PositiveInt"/> struct.
        /// </summary>
        /// <param name="value"> The value. </param>
        internal PositiveInt(int value) => this.value = value;

        /// <summary>
        /// Implicit int converter.
        /// </summary>
        /// <param name="instance"> The instance. </param>
        public static implicit operator int(PositiveInt instance) => instance.value;

        /// <inheritdoc />
        public override bool Equals(object obj) => this.value.Equals(obj);

        /// <inheritdoc />
        public override int GetHashCode() => this.value.GetHashCode();
    }
}