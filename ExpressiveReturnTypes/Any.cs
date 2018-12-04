namespace ExpressiveReturnTypes
{
    using System;
    using System.Collections.Generic;

    public class Any<T1, T2, T3> : IAny<T1, T2, T3>
    {
        private readonly IMaybe<T1> t1;
        private readonly IMaybe<T2> t2;
        private readonly IMaybe<T3> t3;

        public Any(T1 t1, T2 t2 = default(T2), T3 t3 = default(T3)) : this(true, t1, t2, t3)
        {
        }

        public Any(T2 t2, T3 t3 = default(T3)) : this(true, default(T1), t2, t3)
        {
        }

        public Any(T3 t3) : this(true, default(T1), default(T2), t3)
        {
        }

        public Any(IAny<T1, T2> any2, T3 t3 = default(T3))
            : this(
                true,
                any2.Aggregate((t1, t2) => t1).Match(some => some, none => default(T1)),
                any2.Aggregate((t1, t2) => t2).Match(some => some, none => default(T2)),
                t3)
        {
        }

        private Any(bool _, T1 t1, T2 t2, T3 t3)
        {
            this.t1 = EqualityComparer<T1>.Default.Equals(t1, default(T1))
                          ? Nothing.Instance.ToMaybe<T1>()
                          : t1.ToMaybe();
            this.t2 = EqualityComparer<T2>.Default.Equals(t2, default(T2))
                          ? Nothing.Instance.ToMaybe<T2>()
                          : t2.ToMaybe();
            this.t3 = EqualityComparer<T3>.Default.Equals(t3, default(T3))
                          ? Nothing.Instance.ToMaybe<T3>()
                          : t3.ToMaybe(); ;
        }

        /// <inheritdoc />
        public TResult Aggregate<TResult>(Func<IMaybe<T1>, IMaybe<T2>, IMaybe<T3>, TResult> func)
        {
            var result = func(this.t1, this.t2, this.t3);

            return result;
        }
    }

    public class Any<T1, T2> : IAny<T1, T2>
    {
        private readonly IMaybe<T1> t1;
        private readonly IMaybe<T2> t2;

        public Any(T1 t1) : this(t1, default(T2))
        {
        }

        public Any(T2 t2) : this(default(T1), t2)
        {
        }

        public Any(T1 t1, T2 t2)
        {
            this.t1 = EqualityComparer<T1>.Default.Equals(t1, default(T1))
                          ? Nothing.Instance.ToMaybe<T1>()
                          : t1.ToMaybe();
            this.t2 = EqualityComparer<T2>.Default.Equals(t2, default(T2))
                          ? Nothing.Instance.ToMaybe<T2>()
                          : t2.ToMaybe();
        }

        /// <inheritdoc />
        public TResult Aggregate<TResult>(Func<IMaybe<T1>, IMaybe<T2>, TResult> func)
        {
            var result = func(this.t1, this.t2);

            return result;
        }
    }

    public class Any<T1> : IAny<T1>
    {
        private readonly IMaybe<T1> t1;

        public Any(T1 t1)
        {
            this.t1 = t1.ToMaybe();
        }

        /// <inheritdoc />
        public TResult Aggregate<TResult>(Func<IMaybe<T1>, TResult> func)
        {
            var result = func(this.t1);

            return result;
        }
    }
}