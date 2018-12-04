namespace ExpressiveReturnTypes
{
    /// <summary>
    /// A class representing nothing (unit in functional programming).
    /// </summary>
    public class Nothing
    {
        /// <summary>
        /// Prevents a default instance of the <see cref="Nothing"/> class from being created.
        /// </summary>
        private Nothing()
        {
        }

        /// <summary>
        /// Gets the only instance of <see cref="Nothing"/> in existence.
        /// </summary>
        public static Nothing Instance { get; } = new Nothing();
    }
}