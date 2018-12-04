namespace ExpressiveReturnTypes
{
    using System;

    /// <summary>
    /// A data type that indicates that the result of an operation may contain the desired result (some) or it may not (none).
    /// </summary>
    public interface IMaybe<out T> : IEither<T, Nothing>
    {
        /// <summary>
        /// Pattern matches 
        /// </summary>
        /// <param name="some">
        /// The none func.
        /// </param>
        /// <param name="none">
        /// The none.
        /// </param>
        /// <typeparam name="TResult">
        /// </typeparam>
        /// <returns>
        /// The <see cref="TResult"/>.
        /// </returns>
        TResult Match<TResult>(Func<T, TResult> some, Func<TResult> none);
    }

    public interface IMaybe : IEither<Nothing, Nothing>
    {
        TResult Match<TResult>(Func<TResult> some, Func<TResult> none);
    }
}
