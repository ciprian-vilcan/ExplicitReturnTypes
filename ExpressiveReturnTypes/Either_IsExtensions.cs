namespace ExpressiveReturnTypes
{
    public static class Either_IsExtensions
    {
        public static IMaybe<A> IsCase1<A, B>(this IEither<A, B> either)
        {
            var isCase1 = either.Match(
                a => a.ToMaybe(),
                b => Nothing.Instance.ToMaybe<A>());

            return isCase1;
        }

        public static IMaybe<B> IsCase2<A, B>(this IEither<A, B> either)
        {
            var isCase2 = either.Match(
                a => Nothing.Instance.ToMaybe<B>(),
                b => b.ToMaybe());

            return isCase2;
        }

        public static bool IsCase1<A, B>(this IEither<A, B> either, out A ifIsCase1)
        {
            (bool isCase1, A result) resultPair = either.Match(
                a => (true, a),
                b => (false, default(A)));

            ifIsCase1 = resultPair.result;

            return resultPair.isCase1;
        }

        public static bool IsCase2<A, B>(this IEither<A, B> either, out B ifIsCase2)
        {
            (bool isCase2, B result) resultPair = either.Match(
                a => (false, default(B)),
                b => (true, b));

            ifIsCase2 = resultPair.result;

            return resultPair.isCase2;
        }
    }
}
