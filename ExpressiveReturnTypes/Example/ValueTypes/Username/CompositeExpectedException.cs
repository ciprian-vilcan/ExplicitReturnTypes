namespace ExpressiveReturnTypes.Example.ValueTypes.Username
{
    using System;
    using System.Linq;

    using Humanizer;

    public class CompositeExpectedException : ExpectedException
    {
        protected CompositeExpectedException(ExpectedException firstException, string message = null, params ExpectedException[] otherExceptions)
        {
            var errorList = new[]{ firstException }.Concat(otherExceptions).Select(e => $"-{e.Message}");
            this.Message = $@"{message ?? $"{this.GetType().Name.Humanize()}"}:{Environment.NewLine}{string.Join(Environment.NewLine + "    ", errorList)}";
        }

        /// <inheritdoc />
        public override string Message { get; }
    }
}