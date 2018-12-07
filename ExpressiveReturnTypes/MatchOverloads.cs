namespace ExpressiveReturnTypes
{
    using System;

    public static class MatchOverloads
    {
        public static TResult Match<T, TResult>(this IMaybe<T> maybe, Func<T, TResult> someFunc, Func<TResult> noneFunc)
        {
            return maybe.Match(
                someFunc,
                none => noneFunc());
        }

        public static TResult Match<T, TResult>(this IMaybe<T> maybe, Func<T, TResult> someFunc, TResult noneDefault = default(TResult))
        {
            return maybe.Match(
                someFunc,
                none => noneDefault);
        }

        public static TResult Match<TA1, TB1, TA2, TB2, TResult>(
            this IEither<TA1, TB1> either1,
            IEither<TA2, TB2> either2,
            Func<TA1, TA2, TResult> bothAreA,
            TResult anyIsB)
        {
            var result = either1.Match(
                a1 => either2.Match(
                    a2 => bothAreA(a1, a2),
                    b2 => anyIsB),
                b1 => anyIsB);

            return result;
        }

        public static IEither<TWanted, IAny<TBad1, TBad2, TBad3>> MatchOnlyCase1<TGood1, TBad1, TGood2, TBad2, TGood3, TBad3, TWanted>(
            this IEither<TGood1, TBad1> either1,
            IEither<TGood2, TBad2> either2,
            IEither<TGood3, TBad3> either3,
            Func<TGood1, TGood2, TGood3, TWanted> allAreLeft)
        {
            var result = either1.Match(
                good1 => either2.Match(
                    good2 => either3.Match<Either<TWanted, IAny<TBad1, TBad2, TBad3>>>(
                        good3 => allAreLeft(good1, good2, good3),
                        bad3 => new Any<TBad1, TBad2, TBad3>(bad3)),
                    bad2 => either3.Match(
                        good3 => new Any<TBad1, TBad2, TBad3>(bad2),
                        bad3 => new Any<TBad1, TBad2, TBad3>(bad2, bad3))),
                bad1 => either2.Match(
                    good2 => either3.Match(
                        good3 => new Any<TBad1, TBad2, TBad3>(bad1),
                        bad3 => new Any<TBad1, TBad2, TBad3>(bad1, t3: bad3)),
                    bad2 => either3.Match(
                        good3 => new Any<TBad1, TBad2, TBad3>(bad1, bad2),
                        bad3 => new Any<TBad1, TBad2, TBad3>(bad1, bad2, bad3))));

            return result;
        }

        public static IEither<TGood, TBad> Match<A1, A2, B1, B2, C1, C2, TGood, TBad>(
            this IEither<A1, A2> a,
            IEither<B1, B2> b,
            IEither<C1, C2> c,
            Func<A1, B1, C1, TGood> goodFunc,
            Func<IMaybe<A2>, IMaybe<B2>, IMaybe<C2>, TBad> badFunc)
        {
            var result = a.Match(
                a1 => b.Match(
                    b1 => c.Match<Either<TGood, TBad>>(
                        c1 => goodFunc(a1, b1, c1),
                        c2 => badFunc(Nothing.Instance.ToMaybe<A2>(), Nothing.Instance.ToMaybe<B2>(), c2.ToMaybe())),
                    b2 => c.Match(
                        c1 => badFunc(Nothing.Instance.ToMaybe<A2>(), b2.ToMaybe(), Nothing.Instance.ToMaybe<C2>()),
                        c2 => badFunc(Nothing.Instance.ToMaybe<A2>(), b2.ToMaybe(), c2.ToMaybe()))),
                a2 => b.Match(
                    b1 => c.Match<Either<TGood, TBad>>(
                        c1 => badFunc(a2.ToMaybe(), Nothing.Instance.ToMaybe<B2>(), Nothing.Instance.ToMaybe<C2>()),
                        c2 => badFunc(a2.ToMaybe(), Nothing.Instance.ToMaybe<B2>(), c2.ToMaybe())),
                    b2 => c.Match(
                        c1 => badFunc(a2.ToMaybe(), Nothing.Instance.ToMaybe<B2>(), Nothing.Instance.ToMaybe<C2>()),
                        c2 => badFunc(a2.ToMaybe(), b2.ToMaybe(), c2.ToMaybe()))));

            return result;
        }
    }
}
