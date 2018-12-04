namespace ExpressiveReturnTypes
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public static class IMaybeExtensions
    {
        public static IMaybe<T> ToMaybe<T>(this T value) => new Maybe<T>(value);

        public static IMaybe<T> ToMaybe<T>(this Nothing instance) => new Maybe<T>();

        public static TResult AggregateWithBase<T1, T2, T3, TBase, TCommon, TResult>(
            this IMaybe<T1> maybe1,
            IMaybe<T2> maybe2,
            IMaybe<T3> maybe3,
            Func<TBase, TCommon> someTransformer,
            Func<IEnumerable<TCommon>, TResult> aggregationFunc)
            where T1 : TBase where T2 : TBase where T3 : TBase
        {
            var match1 = maybe1.Match(some => someTransformer(some), none => default(TCommon));
            var match2 = maybe2.Match(some => someTransformer(some), none => default(TCommon));
            var match3 = maybe3.Match(some => someTransformer(some), none => default(TCommon));

            var result = aggregationFunc(
                new[] 
                    { 
                        match1,
                        match2,
                        match3
                    }
                    .Where(common => !EqualityComparer<TCommon>.Default.Equals(common, default(TCommon))));

            return result;
        }

        public static IMaybe<TOther> Map<T, TOther>(this IMaybe<T> self, Func<T, TOther> map)
        {
            var result = self.Match(some => map(some).ToMaybe(), none => Nothing.Instance.ToMaybe<TOther>());

            return result;
        }

        public static IMaybe<TOther> Apply<T, TOther>(this IMaybe<T> self, IMaybe<Func<T, TOther>> apply)
        {
            var result = self.Match(
                some => apply.Match(
                    someApply => someApply(some).ToMaybe(),
                    noneApply => Nothing.Instance.ToMaybe<TOther>()),
                none => apply.Match(
                    someApply => Nothing.Instance.ToMaybe<TOther>(),
                    noneApply => Nothing.Instance.ToMaybe<TOther>()));

            return result;
        }

        public static IMaybe<TOther> Bind<T, TOther>(this IMaybe<T> self, Func<T, IMaybe<TOther>> someFunc)
        {
            var result = self.Match(someFunc, none => new Maybe<TOther>());

            return result;
        }

        public static IMaybe<TResult> SelectMany<T, TOther, TResult>(
            this IMaybe<T> self,
            Func<T, IMaybe<TOther>> someFunc, 
            Func<T, TOther, TResult> bothSome)
        {
            var result = self.Match(
                some => self.Match(
                    someFunc(some),
                    (t, tOther) => bothSome(t, tOther).ToMaybe(),
                    new Maybe<TResult>()),
                none => new Maybe<TResult>());

            return result;
        }

        public static IEither<TR1, IAny<T2, TO2>> SelectMany<T1, T2, TO1, TO2, TR1>(
            this IEither<T1, T2> self,
            Func<T1, IEither<TO1, TO2>> func1,
            Func<T1, TO1, IEither<TR1, IAny<T2, TO2>>> func2)
        {
            var result = self.Match(
                t1 => func1(t1).Match(
                    to1 => func2(t1, to1),
                    to2 => new Either<TR1, IAny<T2, TO2>>(new Any<T2, TO2>(to2))), 
                t2 => new Either<TR1, IAny<T2, TO2>>(new Any<T2, TO2>(t2)));

            return result;
        }

        public static IEither<TR1, IAny<T2, TO2, TO3>> SelectMany<T1, T2, TO1, TO2, TO3, TR1>(
            this IEither<T1, IAny<T2, TO2>> self,
            Func<T1, IEither<TO1, TO2, TO3>> func1,
            Func<T1, TO1, IEither<TR1, IAny<T2, TO2, TO3>>> func2)
        {
            var result = self.Match(
                t1 => func1(t1).Match(
                    to1 => func2(t1, to1),
                    to2 => new Either<TR1, IAny<T2, TO2, TO3>>(new Any<T2, TO2, TO3>(to2)),
                    to3 => new Either<TR1, IAny<T2, TO2, TO3>>(new Any<T2, TO2, TO3>(to3))),
                t2 => new Either<TR1, IAny<T2, TO2, TO3>>(new Any<T2, TO2, TO3>(t2)));

            return result;
        }
    }
}
