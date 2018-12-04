namespace ExpressiveReturnTypes
{
    using System;
    
    public interface IAny<out T1>
    {
        /// <summary>
        /// Aggregates (binds) the contents of the data type by providing a func treating all possible cases.
        /// </summary>
        /// <param name="func"> A func to aggregate the possible states. </param>
        /// <typeparam name="TResult"> The type of result. </typeparam>
        /// <returns> The <see cref="TResult"/>. </returns>
        TResult Aggregate<TResult>(Func<IMaybe<T1>, TResult> func);
    }
    
    public interface IAny<out T1, out T2>
    {
        /// <summary>
        /// Aggregates (binds) the contents of the data type by providing a func treating all possible cases.
        /// </summary>
        /// <param name="func"> A func to aggregate the possible states. </param>
        /// <typeparam name="TResult"> The type of result. </typeparam>
        /// <returns> The <see cref="TResult"/>. </returns>
        TResult Aggregate<TResult>(Func<IMaybe<T1>, IMaybe<T2>, TResult> func);
    }
    
    public interface IAny<out T1, out T2, out T3>
    {
        /// <summary>
        /// Aggregates (binds) the contents of the data type by providing a func treating all possible cases.
        /// </summary>
        /// <param name="func"> A func to aggregate the possible states. </param>
        /// <typeparam name="TResult"> The type of result. </typeparam>
        /// <returns> The <see cref="TResult"/>. </returns>
        TResult Aggregate<TResult>(Func<IMaybe<T1>, IMaybe<T2>, IMaybe<T3>, TResult> func);
    }
    
    public interface IAny<out T1, out T2, out T3, out T4>
    {
        /// <summary>
        /// Aggregates (binds) the contents of the data type by providing a func treating all possible cases.
        /// </summary>
        /// <param name="func"> A func to aggregate the possible states. </param>
        /// <typeparam name="TResult"> The type of result. </typeparam>
        /// <returns> The <see cref="TResult"/>. </returns>
        TResult Aggregate<TResult>(Func<IMaybe<T1>, IMaybe<T2>, IMaybe<T3>, IMaybe<T4>, TResult> func);
    }
    
    public interface IAny<out T1, out T2, out T3, out T4, out T5>
    {
        /// <summary>
        /// Aggregates (binds) the contents of the data type by providing a func treating all possible cases.
        /// </summary>
        /// <param name="func"> A func to aggregate the possible states. </param>
        /// <typeparam name="TResult"> The type of result. </typeparam>
        /// <returns> The <see cref="TResult"/>. </returns>
        TResult Aggregate<TResult>(Func<IMaybe<T1>, IMaybe<T2>, IMaybe<T3>, IMaybe<T4>, IMaybe<T5>, TResult> func);
    }
    
    public interface IAny<out T1, out T2, out T3, out T4, out T5, out T6>
    {
        /// <summary>
        /// Aggregates (binds) the contents of the data type by providing a func treating all possible cases.
        /// </summary>
        /// <param name="func"> A func to aggregate the possible states. </param>
        /// <typeparam name="TResult"> The type of result. </typeparam>
        /// <returns> The <see cref="TResult"/>. </returns>
        TResult Aggregate<TResult>(Func<IMaybe<T1>, IMaybe<T2>, IMaybe<T3>, IMaybe<T4>, IMaybe<T5>, IMaybe<T6>, TResult> func);
    }
    
    public interface IAny<out T1, out T2, out T3, out T4, out T5, out T6, out T7>
    {
        /// <summary>
        /// Aggregates (binds) the contents of the data type by providing a func treating all possible cases.
        /// </summary>
        /// <param name="func"> A func to aggregate the possible states. </param>
        /// <typeparam name="TResult"> The type of result. </typeparam>
        /// <returns> The <see cref="TResult"/>. </returns>
        TResult Aggregate<TResult>(Func<IMaybe<T1>, IMaybe<T2>, IMaybe<T3>, IMaybe<T4>, IMaybe<T5>, IMaybe<T6>, IMaybe<T7>, TResult> func);
    }
    
    public interface IAny<out T1, out T2, out T3, out T4, out T5, out T6, out T7, out T8>
    {
        /// <summary>
        /// Aggregates (binds) the contents of the data type by providing a func treating all possible cases.
        /// </summary>
        /// <param name="func"> A func to aggregate the possible states. </param>
        /// <typeparam name="TResult"> The type of result. </typeparam>
        /// <returns> The <see cref="TResult"/>. </returns>
        TResult Aggregate<TResult>(Func<IMaybe<T1>, IMaybe<T2>, IMaybe<T3>, IMaybe<T4>, IMaybe<T5>, IMaybe<T6>, IMaybe<T7>, IMaybe<T8>, TResult> func);
    }
    
    public interface IAny<out T1, out T2, out T3, out T4, out T5, out T6, out T7, out T8, out T9>
    {
        /// <summary>
        /// Aggregates (binds) the contents of the data type by providing a func treating all possible cases.
        /// </summary>
        /// <param name="func"> A func to aggregate the possible states. </param>
        /// <typeparam name="TResult"> The type of result. </typeparam>
        /// <returns> The <see cref="TResult"/>. </returns>
        TResult Aggregate<TResult>(Func<IMaybe<T1>, IMaybe<T2>, IMaybe<T3>, IMaybe<T4>, IMaybe<T5>, IMaybe<T6>, IMaybe<T7>, IMaybe<T8>, IMaybe<T9>, TResult> func);
    }
    
    public interface IAny<out T1, out T2, out T3, out T4, out T5, out T6, out T7, out T8, out T9, out T10>
    {
        /// <summary>
        /// Aggregates (binds) the contents of the data type by providing a func treating all possible cases.
        /// </summary>
        /// <param name="func"> A func to aggregate the possible states. </param>
        /// <typeparam name="TResult"> The type of result. </typeparam>
        /// <returns> The <see cref="TResult"/>. </returns>
        TResult Aggregate<TResult>(Func<IMaybe<T1>, IMaybe<T2>, IMaybe<T3>, IMaybe<T4>, IMaybe<T5>, IMaybe<T6>, IMaybe<T7>, IMaybe<T8>, IMaybe<T9>, IMaybe<T10>, TResult> func);
    }
    
    public interface IAny<out T1, out T2, out T3, out T4, out T5, out T6, out T7, out T8, out T9, out T10, out T11>
    {
        /// <summary>
        /// Aggregates (binds) the contents of the data type by providing a func treating all possible cases.
        /// </summary>
        /// <param name="func"> A func to aggregate the possible states. </param>
        /// <typeparam name="TResult"> The type of result. </typeparam>
        /// <returns> The <see cref="TResult"/>. </returns>
        TResult Aggregate<TResult>(Func<IMaybe<T1>, IMaybe<T2>, IMaybe<T3>, IMaybe<T4>, IMaybe<T5>, IMaybe<T6>, IMaybe<T7>, IMaybe<T8>, IMaybe<T9>, IMaybe<T10>, IMaybe<T11>, TResult> func);
    }
    
    public interface IAny<out T1, out T2, out T3, out T4, out T5, out T6, out T7, out T8, out T9, out T10, out T11, out T12>
    {
        /// <summary>
        /// Aggregates (binds) the contents of the data type by providing a func treating all possible cases.
        /// </summary>
        /// <param name="func"> A func to aggregate the possible states. </param>
        /// <typeparam name="TResult"> The type of result. </typeparam>
        /// <returns> The <see cref="TResult"/>. </returns>
        TResult Aggregate<TResult>(Func<IMaybe<T1>, IMaybe<T2>, IMaybe<T3>, IMaybe<T4>, IMaybe<T5>, IMaybe<T6>, IMaybe<T7>, IMaybe<T8>, IMaybe<T9>, IMaybe<T10>, IMaybe<T11>, IMaybe<T12>, TResult> func);
    }
    
    public interface IAny<out T1, out T2, out T3, out T4, out T5, out T6, out T7, out T8, out T9, out T10, out T11, out T12, out T13>
    {
        /// <summary>
        /// Aggregates (binds) the contents of the data type by providing a func treating all possible cases.
        /// </summary>
        /// <param name="func"> A func to aggregate the possible states. </param>
        /// <typeparam name="TResult"> The type of result. </typeparam>
        /// <returns> The <see cref="TResult"/>. </returns>
        TResult Aggregate<TResult>(Func<IMaybe<T1>, IMaybe<T2>, IMaybe<T3>, IMaybe<T4>, IMaybe<T5>, IMaybe<T6>, IMaybe<T7>, IMaybe<T8>, IMaybe<T9>, IMaybe<T10>, IMaybe<T11>, IMaybe<T12>, IMaybe<T13>, TResult> func);
    }
    
    public interface IAny<out T1, out T2, out T3, out T4, out T5, out T6, out T7, out T8, out T9, out T10, out T11, out T12, out T13, out T14>
    {
        /// <summary>
        /// Aggregates (binds) the contents of the data type by providing a func treating all possible cases.
        /// </summary>
        /// <param name="func"> A func to aggregate the possible states. </param>
        /// <typeparam name="TResult"> The type of result. </typeparam>
        /// <returns> The <see cref="TResult"/>. </returns>
        TResult Aggregate<TResult>(Func<IMaybe<T1>, IMaybe<T2>, IMaybe<T3>, IMaybe<T4>, IMaybe<T5>, IMaybe<T6>, IMaybe<T7>, IMaybe<T8>, IMaybe<T9>, IMaybe<T10>, IMaybe<T11>, IMaybe<T12>, IMaybe<T13>, IMaybe<T14>, TResult> func);
    }
    
    public interface IAny<out T1, out T2, out T3, out T4, out T5, out T6, out T7, out T8, out T9, out T10, out T11, out T12, out T13, out T14, out T15>
    {
        /// <summary>
        /// Aggregates (binds) the contents of the data type by providing a func treating all possible cases.
        /// </summary>
        /// <param name="func"> A func to aggregate the possible states. </param>
        /// <typeparam name="TResult"> The type of result. </typeparam>
        /// <returns> The <see cref="TResult"/>. </returns>
        TResult Aggregate<TResult>(Func<IMaybe<T1>, IMaybe<T2>, IMaybe<T3>, IMaybe<T4>, IMaybe<T5>, IMaybe<T6>, IMaybe<T7>, IMaybe<T8>, IMaybe<T9>, IMaybe<T10>, IMaybe<T11>, IMaybe<T12>, IMaybe<T13>, IMaybe<T14>, IMaybe<T15>, TResult> func);
    }
    
    public interface IAny<out T1, out T2, out T3, out T4, out T5, out T6, out T7, out T8, out T9, out T10, out T11, out T12, out T13, out T14, out T15, out T16>
    {
        /// <summary>
        /// Aggregates (binds) the contents of the data type by providing a func treating all possible cases.
        /// </summary>
        /// <param name="func"> A func to aggregate the possible states. </param>
        /// <typeparam name="TResult"> The type of result. </typeparam>
        /// <returns> The <see cref="TResult"/>. </returns>
        TResult Aggregate<TResult>(Func<IMaybe<T1>, IMaybe<T2>, IMaybe<T3>, IMaybe<T4>, IMaybe<T5>, IMaybe<T6>, IMaybe<T7>, IMaybe<T8>, IMaybe<T9>, IMaybe<T10>, IMaybe<T11>, IMaybe<T12>, IMaybe<T13>, IMaybe<T14>, IMaybe<T15>, IMaybe<T16>, TResult> func);
    }
}


