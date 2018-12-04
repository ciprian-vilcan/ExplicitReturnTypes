namespace ExpressiveReturnTypes
{
    public static class IMaybeIEitherExtensions
    {
        public static IMaybe<IEither<T1, T2, T3>> ToMaybe<T1, T2, T3>(this IEither<T1, T2, T3> either)
            => new Maybe<IEither<T1,T2,T3>>(either);


    }
}
