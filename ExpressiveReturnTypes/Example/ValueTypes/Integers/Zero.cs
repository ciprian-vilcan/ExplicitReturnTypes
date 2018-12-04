namespace ExpressiveReturnTypes.Example.ValueTypes.Integers
{
    /// <summary>
    /// Zero. Used for statically defining Eithers.
    /// </summary>
    public struct Zero
    {
        /// <summary>
        /// Implicit conversion to int.
        /// </summary>
        /// <param name="instance"> The instance. </param>
        public static implicit operator int(Zero instance) => 0;

        /// <inheritdoc />
        public override bool Equals(object obj) => 0.Equals(obj);

        /// <inheritdoc />
        public override int GetHashCode() => 0.GetHashCode();
    }
}