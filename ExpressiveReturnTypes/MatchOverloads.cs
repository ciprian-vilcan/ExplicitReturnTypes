namespace ExpressiveReturnTypes
{
    using System;

    public static class MatchOverloads
    {
        public static TResult MatchWithDefault<T1, T2, T3, TResult>(
            this IEither<T1, T2, T3> either,
            Func<T1, TResult> aFunc,
            TResult otherDefaultValue)
            => either.Match(
                aFunc,
                t2 => otherDefaultValue,
                t3 => otherDefaultValue);

        public static TResult MatchWithDefault<T1, T2, T3, TCommon, TResult>(
            this IEither<T1, T2, T3> either,
            Func<T1, TResult> aFunc,
            Func<TCommon, TResult> otherDefaultFunc) 
            where T2 : TCommon 
            where T3 : TCommon
        {
            return either.Match(
                aFunc,
                t2 => otherDefaultFunc(t2),
                t3 => otherDefaultFunc(t3));
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
    }
}
