namespace ExpressiveReturnTypes
{
    using System;

    public interface IMethod<in TParams, out TResult>
    {
        TResult Execute(TParams parameters);
    }

    public interface IMethodV2<in TParams, out TResult, out TError> where TError : Exception
    {
        IEither<TResult, TError> Execute(TParams parameters);
    }
}