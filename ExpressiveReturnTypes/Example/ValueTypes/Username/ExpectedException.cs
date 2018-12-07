namespace ExpressiveReturnTypes.Example.ValueTypes.Username
{
    using System;

    using Humanizer;

    public class ExpectedException : Exception
    {
        protected ExpectedException(string message = null)
        {
            this.Message = message ?? this.GetType().Name.Humanize();
        }

        /// <inheritdoc />
        public override string Message { get; }
    }
}