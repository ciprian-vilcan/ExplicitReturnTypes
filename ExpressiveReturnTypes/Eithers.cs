namespace ExpressiveReturnTypes
{
    using System;
    
    public class Either<T1> : IEither<T1>
    {
        private readonly object underlyingValue;
        
        public Either(T1 value)
        {
            this.underlyingValue = value;
        }
        
        public static implicit operator Either<T1>(T1 value) => new Either<T1>(value);
        
        public TResult Match<TResult>(Func<T1, TResult> func1)
        {
            return func1((T1)this.underlyingValue);
        }
    }
    
    public class Either<T1, T2> : IEither<T1, T2>
    {
        private readonly object underlyingValue;
        
        public Either(T1 value)
        {
            this.underlyingValue = value;
        }
        
        public Either(T2 value)
        {
            this.underlyingValue = value;
        }
        
        public static implicit operator Either<T1, T2>(T1 value) => new Either<T1, T2>(value);
        
        public static implicit operator Either<T1, T2>(T2 value) => new Either<T1, T2>(value);
        
        public TResult Match<TResult>(Func<T1, TResult> func1, Func<T2, TResult> func2)
        {
            return this.underlyingValue is T1 ? func1((T1)this.underlyingValue) : func2((T2)this.underlyingValue);
        }
    }
    
    public class Either<T1, T2, T3> : IEither<T1, T2, T3>
    {
        private readonly object underlyingValue;
        
        public Either(T1 value)
        {
            this.underlyingValue = value;
        }
        
        public Either(T2 value)
        {
            this.underlyingValue = value;
        }
        
        public Either(T3 value)
        {
            this.underlyingValue = value;
        }
        
        public static implicit operator Either<T1, T2, T3>(T1 value) => new Either<T1, T2, T3>(value);
        
        public static implicit operator Either<T1, T2, T3>(T2 value) => new Either<T1, T2, T3>(value);
        
        public static implicit operator Either<T1, T2, T3>(T3 value) => new Either<T1, T2, T3>(value);
        
        public TResult Match<TResult>(Func<T1, TResult> func1, Func<T2, TResult> func2, Func<T3, TResult> func3)
        {
            return this.underlyingValue is T1 ? func1((T1)this.underlyingValue) : this.underlyingValue is T2 ? func2((T2)this.underlyingValue) : func3((T3)this.underlyingValue);
        }
    }
    
    public class Either<T1, T2, T3, T4> : IEither<T1, T2, T3, T4>
    {
        private readonly object underlyingValue;
        
        public Either(T1 value)
        {
            this.underlyingValue = value;
        }
        
        public Either(T2 value)
        {
            this.underlyingValue = value;
        }
        
        public Either(T3 value)
        {
            this.underlyingValue = value;
        }
        
        public Either(T4 value)
        {
            this.underlyingValue = value;
        }
        
        public static implicit operator Either<T1, T2, T3, T4>(T1 value) => new Either<T1, T2, T3, T4>(value);
        
        public static implicit operator Either<T1, T2, T3, T4>(T2 value) => new Either<T1, T2, T3, T4>(value);
        
        public static implicit operator Either<T1, T2, T3, T4>(T3 value) => new Either<T1, T2, T3, T4>(value);
        
        public static implicit operator Either<T1, T2, T3, T4>(T4 value) => new Either<T1, T2, T3, T4>(value);
        
        public TResult Match<TResult>(Func<T1, TResult> func1, Func<T2, TResult> func2, Func<T3, TResult> func3, Func<T4, TResult> func4)
        {
            return this.underlyingValue is T1 ? func1((T1)this.underlyingValue) : this.underlyingValue is T2 ? func2((T2)this.underlyingValue) : this.underlyingValue is T3 ? func3((T3)this.underlyingValue) : func4((T4)this.underlyingValue);
        }
    }
    
    public class Either<T1, T2, T3, T4, T5> : IEither<T1, T2, T3, T4, T5>
    {
        private readonly object underlyingValue;
        
        public Either(T1 value)
        {
            this.underlyingValue = value;
        }
        
        public Either(T2 value)
        {
            this.underlyingValue = value;
        }
        
        public Either(T3 value)
        {
            this.underlyingValue = value;
        }
        
        public Either(T4 value)
        {
            this.underlyingValue = value;
        }
        
        public Either(T5 value)
        {
            this.underlyingValue = value;
        }
        
        public static implicit operator Either<T1, T2, T3, T4, T5>(T1 value) => new Either<T1, T2, T3, T4, T5>(value);
        
        public static implicit operator Either<T1, T2, T3, T4, T5>(T2 value) => new Either<T1, T2, T3, T4, T5>(value);
        
        public static implicit operator Either<T1, T2, T3, T4, T5>(T3 value) => new Either<T1, T2, T3, T4, T5>(value);
        
        public static implicit operator Either<T1, T2, T3, T4, T5>(T4 value) => new Either<T1, T2, T3, T4, T5>(value);
        
        public static implicit operator Either<T1, T2, T3, T4, T5>(T5 value) => new Either<T1, T2, T3, T4, T5>(value);
        
        public TResult Match<TResult>(Func<T1, TResult> func1, Func<T2, TResult> func2, Func<T3, TResult> func3, Func<T4, TResult> func4, Func<T5, TResult> func5)
        {
            return this.underlyingValue is T1 ? func1((T1)this.underlyingValue) : this.underlyingValue is T2 ? func2((T2)this.underlyingValue) : this.underlyingValue is T3 ? func3((T3)this.underlyingValue) : this.underlyingValue is T4 ? func4((T4)this.underlyingValue) : func5((T5)this.underlyingValue);
        }
    }
    
    public class Either<T1, T2, T3, T4, T5, T6> : IEither<T1, T2, T3, T4, T5, T6>
    {
        private readonly object underlyingValue;
        
        public Either(T1 value)
        {
            this.underlyingValue = value;
        }
        
        public Either(T2 value)
        {
            this.underlyingValue = value;
        }
        
        public Either(T3 value)
        {
            this.underlyingValue = value;
        }
        
        public Either(T4 value)
        {
            this.underlyingValue = value;
        }
        
        public Either(T5 value)
        {
            this.underlyingValue = value;
        }
        
        public Either(T6 value)
        {
            this.underlyingValue = value;
        }
        
        public static implicit operator Either<T1, T2, T3, T4, T5, T6>(T1 value) => new Either<T1, T2, T3, T4, T5, T6>(value);
        
        public static implicit operator Either<T1, T2, T3, T4, T5, T6>(T2 value) => new Either<T1, T2, T3, T4, T5, T6>(value);
        
        public static implicit operator Either<T1, T2, T3, T4, T5, T6>(T3 value) => new Either<T1, T2, T3, T4, T5, T6>(value);
        
        public static implicit operator Either<T1, T2, T3, T4, T5, T6>(T4 value) => new Either<T1, T2, T3, T4, T5, T6>(value);
        
        public static implicit operator Either<T1, T2, T3, T4, T5, T6>(T5 value) => new Either<T1, T2, T3, T4, T5, T6>(value);
        
        public static implicit operator Either<T1, T2, T3, T4, T5, T6>(T6 value) => new Either<T1, T2, T3, T4, T5, T6>(value);
        
        public TResult Match<TResult>(Func<T1, TResult> func1, Func<T2, TResult> func2, Func<T3, TResult> func3, Func<T4, TResult> func4, Func<T5, TResult> func5, Func<T6, TResult> func6)
        {
            return this.underlyingValue is T1 ? func1((T1)this.underlyingValue) : this.underlyingValue is T2 ? func2((T2)this.underlyingValue) : this.underlyingValue is T3 ? func3((T3)this.underlyingValue) : this.underlyingValue is T4 ? func4((T4)this.underlyingValue) : this.underlyingValue is T5 ? func5((T5)this.underlyingValue) : func6((T6)this.underlyingValue);
        }
    }
    
    public class Either<T1, T2, T3, T4, T5, T6, T7> : IEither<T1, T2, T3, T4, T5, T6, T7>
    {
        private readonly object underlyingValue;
        
        public Either(T1 value)
        {
            this.underlyingValue = value;
        }
        
        public Either(T2 value)
        {
            this.underlyingValue = value;
        }
        
        public Either(T3 value)
        {
            this.underlyingValue = value;
        }
        
        public Either(T4 value)
        {
            this.underlyingValue = value;
        }
        
        public Either(T5 value)
        {
            this.underlyingValue = value;
        }
        
        public Either(T6 value)
        {
            this.underlyingValue = value;
        }
        
        public Either(T7 value)
        {
            this.underlyingValue = value;
        }
        
        public static implicit operator Either<T1, T2, T3, T4, T5, T6, T7>(T1 value) => new Either<T1, T2, T3, T4, T5, T6, T7>(value);
        
        public static implicit operator Either<T1, T2, T3, T4, T5, T6, T7>(T2 value) => new Either<T1, T2, T3, T4, T5, T6, T7>(value);
        
        public static implicit operator Either<T1, T2, T3, T4, T5, T6, T7>(T3 value) => new Either<T1, T2, T3, T4, T5, T6, T7>(value);
        
        public static implicit operator Either<T1, T2, T3, T4, T5, T6, T7>(T4 value) => new Either<T1, T2, T3, T4, T5, T6, T7>(value);
        
        public static implicit operator Either<T1, T2, T3, T4, T5, T6, T7>(T5 value) => new Either<T1, T2, T3, T4, T5, T6, T7>(value);
        
        public static implicit operator Either<T1, T2, T3, T4, T5, T6, T7>(T6 value) => new Either<T1, T2, T3, T4, T5, T6, T7>(value);
        
        public static implicit operator Either<T1, T2, T3, T4, T5, T6, T7>(T7 value) => new Either<T1, T2, T3, T4, T5, T6, T7>(value);
        
        public TResult Match<TResult>(Func<T1, TResult> func1, Func<T2, TResult> func2, Func<T3, TResult> func3, Func<T4, TResult> func4, Func<T5, TResult> func5, Func<T6, TResult> func6, Func<T7, TResult> func7)
        {
            return this.underlyingValue is T1 ? func1((T1)this.underlyingValue) : this.underlyingValue is T2 ? func2((T2)this.underlyingValue) : this.underlyingValue is T3 ? func3((T3)this.underlyingValue) : this.underlyingValue is T4 ? func4((T4)this.underlyingValue) : this.underlyingValue is T5 ? func5((T5)this.underlyingValue) : this.underlyingValue is T6 ? func6((T6)this.underlyingValue) : func7((T7)this.underlyingValue);
        }
    }
    
    public class Either<T1, T2, T3, T4, T5, T6, T7, T8> : IEither<T1, T2, T3, T4, T5, T6, T7, T8>
    {
        private readonly object underlyingValue;
        
        public Either(T1 value)
        {
            this.underlyingValue = value;
        }
        
        public Either(T2 value)
        {
            this.underlyingValue = value;
        }
        
        public Either(T3 value)
        {
            this.underlyingValue = value;
        }
        
        public Either(T4 value)
        {
            this.underlyingValue = value;
        }
        
        public Either(T5 value)
        {
            this.underlyingValue = value;
        }
        
        public Either(T6 value)
        {
            this.underlyingValue = value;
        }
        
        public Either(T7 value)
        {
            this.underlyingValue = value;
        }
        
        public Either(T8 value)
        {
            this.underlyingValue = value;
        }
        
        public static implicit operator Either<T1, T2, T3, T4, T5, T6, T7, T8>(T1 value) => new Either<T1, T2, T3, T4, T5, T6, T7, T8>(value);
        
        public static implicit operator Either<T1, T2, T3, T4, T5, T6, T7, T8>(T2 value) => new Either<T1, T2, T3, T4, T5, T6, T7, T8>(value);
        
        public static implicit operator Either<T1, T2, T3, T4, T5, T6, T7, T8>(T3 value) => new Either<T1, T2, T3, T4, T5, T6, T7, T8>(value);
        
        public static implicit operator Either<T1, T2, T3, T4, T5, T6, T7, T8>(T4 value) => new Either<T1, T2, T3, T4, T5, T6, T7, T8>(value);
        
        public static implicit operator Either<T1, T2, T3, T4, T5, T6, T7, T8>(T5 value) => new Either<T1, T2, T3, T4, T5, T6, T7, T8>(value);
        
        public static implicit operator Either<T1, T2, T3, T4, T5, T6, T7, T8>(T6 value) => new Either<T1, T2, T3, T4, T5, T6, T7, T8>(value);
        
        public static implicit operator Either<T1, T2, T3, T4, T5, T6, T7, T8>(T7 value) => new Either<T1, T2, T3, T4, T5, T6, T7, T8>(value);
        
        public static implicit operator Either<T1, T2, T3, T4, T5, T6, T7, T8>(T8 value) => new Either<T1, T2, T3, T4, T5, T6, T7, T8>(value);
        
        public TResult Match<TResult>(Func<T1, TResult> func1, Func<T2, TResult> func2, Func<T3, TResult> func3, Func<T4, TResult> func4, Func<T5, TResult> func5, Func<T6, TResult> func6, Func<T7, TResult> func7, Func<T8, TResult> func8)
        {
            return this.underlyingValue is T1 ? func1((T1)this.underlyingValue) : this.underlyingValue is T2 ? func2((T2)this.underlyingValue) : this.underlyingValue is T3 ? func3((T3)this.underlyingValue) : this.underlyingValue is T4 ? func4((T4)this.underlyingValue) : this.underlyingValue is T5 ? func5((T5)this.underlyingValue) : this.underlyingValue is T6 ? func6((T6)this.underlyingValue) : this.underlyingValue is T7 ? func7((T7)this.underlyingValue) : func8((T8)this.underlyingValue);
        }
    }
    
    public class Either<T1, T2, T3, T4, T5, T6, T7, T8, T9> : IEither<T1, T2, T3, T4, T5, T6, T7, T8, T9>
    {
        private readonly object underlyingValue;
        
        public Either(T1 value)
        {
            this.underlyingValue = value;
        }
        
        public Either(T2 value)
        {
            this.underlyingValue = value;
        }
        
        public Either(T3 value)
        {
            this.underlyingValue = value;
        }
        
        public Either(T4 value)
        {
            this.underlyingValue = value;
        }
        
        public Either(T5 value)
        {
            this.underlyingValue = value;
        }
        
        public Either(T6 value)
        {
            this.underlyingValue = value;
        }
        
        public Either(T7 value)
        {
            this.underlyingValue = value;
        }
        
        public Either(T8 value)
        {
            this.underlyingValue = value;
        }
        
        public Either(T9 value)
        {
            this.underlyingValue = value;
        }
        
        public static implicit operator Either<T1, T2, T3, T4, T5, T6, T7, T8, T9>(T1 value) => new Either<T1, T2, T3, T4, T5, T6, T7, T8, T9>(value);
        
        public static implicit operator Either<T1, T2, T3, T4, T5, T6, T7, T8, T9>(T2 value) => new Either<T1, T2, T3, T4, T5, T6, T7, T8, T9>(value);
        
        public static implicit operator Either<T1, T2, T3, T4, T5, T6, T7, T8, T9>(T3 value) => new Either<T1, T2, T3, T4, T5, T6, T7, T8, T9>(value);
        
        public static implicit operator Either<T1, T2, T3, T4, T5, T6, T7, T8, T9>(T4 value) => new Either<T1, T2, T3, T4, T5, T6, T7, T8, T9>(value);
        
        public static implicit operator Either<T1, T2, T3, T4, T5, T6, T7, T8, T9>(T5 value) => new Either<T1, T2, T3, T4, T5, T6, T7, T8, T9>(value);
        
        public static implicit operator Either<T1, T2, T3, T4, T5, T6, T7, T8, T9>(T6 value) => new Either<T1, T2, T3, T4, T5, T6, T7, T8, T9>(value);
        
        public static implicit operator Either<T1, T2, T3, T4, T5, T6, T7, T8, T9>(T7 value) => new Either<T1, T2, T3, T4, T5, T6, T7, T8, T9>(value);
        
        public static implicit operator Either<T1, T2, T3, T4, T5, T6, T7, T8, T9>(T8 value) => new Either<T1, T2, T3, T4, T5, T6, T7, T8, T9>(value);
        
        public static implicit operator Either<T1, T2, T3, T4, T5, T6, T7, T8, T9>(T9 value) => new Either<T1, T2, T3, T4, T5, T6, T7, T8, T9>(value);
        
        public TResult Match<TResult>(Func<T1, TResult> func1, Func<T2, TResult> func2, Func<T3, TResult> func3, Func<T4, TResult> func4, Func<T5, TResult> func5, Func<T6, TResult> func6, Func<T7, TResult> func7, Func<T8, TResult> func8, Func<T9, TResult> func9)
        {
            return this.underlyingValue is T1 ? func1((T1)this.underlyingValue) : this.underlyingValue is T2 ? func2((T2)this.underlyingValue) : this.underlyingValue is T3 ? func3((T3)this.underlyingValue) : this.underlyingValue is T4 ? func4((T4)this.underlyingValue) : this.underlyingValue is T5 ? func5((T5)this.underlyingValue) : this.underlyingValue is T6 ? func6((T6)this.underlyingValue) : this.underlyingValue is T7 ? func7((T7)this.underlyingValue) : this.underlyingValue is T8 ? func8((T8)this.underlyingValue) : func9((T9)this.underlyingValue);
        }
    }
    
    public class Either<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> : IEither<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>
    {
        private readonly object underlyingValue;
        
        public Either(T1 value)
        {
            this.underlyingValue = value;
        }
        
        public Either(T2 value)
        {
            this.underlyingValue = value;
        }
        
        public Either(T3 value)
        {
            this.underlyingValue = value;
        }
        
        public Either(T4 value)
        {
            this.underlyingValue = value;
        }
        
        public Either(T5 value)
        {
            this.underlyingValue = value;
        }
        
        public Either(T6 value)
        {
            this.underlyingValue = value;
        }
        
        public Either(T7 value)
        {
            this.underlyingValue = value;
        }
        
        public Either(T8 value)
        {
            this.underlyingValue = value;
        }
        
        public Either(T9 value)
        {
            this.underlyingValue = value;
        }
        
        public Either(T10 value)
        {
            this.underlyingValue = value;
        }
        
        public static implicit operator Either<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(T1 value) => new Either<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(value);
        
        public static implicit operator Either<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(T2 value) => new Either<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(value);
        
        public static implicit operator Either<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(T3 value) => new Either<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(value);
        
        public static implicit operator Either<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(T4 value) => new Either<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(value);
        
        public static implicit operator Either<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(T5 value) => new Either<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(value);
        
        public static implicit operator Either<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(T6 value) => new Either<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(value);
        
        public static implicit operator Either<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(T7 value) => new Either<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(value);
        
        public static implicit operator Either<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(T8 value) => new Either<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(value);
        
        public static implicit operator Either<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(T9 value) => new Either<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(value);
        
        public static implicit operator Either<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(T10 value) => new Either<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(value);
        
        public TResult Match<TResult>(Func<T1, TResult> func1, Func<T2, TResult> func2, Func<T3, TResult> func3, Func<T4, TResult> func4, Func<T5, TResult> func5, Func<T6, TResult> func6, Func<T7, TResult> func7, Func<T8, TResult> func8, Func<T9, TResult> func9, Func<T10, TResult> func10)
        {
            return this.underlyingValue is T1 ? func1((T1)this.underlyingValue) : this.underlyingValue is T2 ? func2((T2)this.underlyingValue) : this.underlyingValue is T3 ? func3((T3)this.underlyingValue) : this.underlyingValue is T4 ? func4((T4)this.underlyingValue) : this.underlyingValue is T5 ? func5((T5)this.underlyingValue) : this.underlyingValue is T6 ? func6((T6)this.underlyingValue) : this.underlyingValue is T7 ? func7((T7)this.underlyingValue) : this.underlyingValue is T8 ? func8((T8)this.underlyingValue) : this.underlyingValue is T9 ? func9((T9)this.underlyingValue) : func10((T10)this.underlyingValue);
        }
    }
    
    public class Either<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> : IEither<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>
    {
        private readonly object underlyingValue;
        
        public Either(T1 value)
        {
            this.underlyingValue = value;
        }
        
        public Either(T2 value)
        {
            this.underlyingValue = value;
        }
        
        public Either(T3 value)
        {
            this.underlyingValue = value;
        }
        
        public Either(T4 value)
        {
            this.underlyingValue = value;
        }
        
        public Either(T5 value)
        {
            this.underlyingValue = value;
        }
        
        public Either(T6 value)
        {
            this.underlyingValue = value;
        }
        
        public Either(T7 value)
        {
            this.underlyingValue = value;
        }
        
        public Either(T8 value)
        {
            this.underlyingValue = value;
        }
        
        public Either(T9 value)
        {
            this.underlyingValue = value;
        }
        
        public Either(T10 value)
        {
            this.underlyingValue = value;
        }
        
        public Either(T11 value)
        {
            this.underlyingValue = value;
        }
        
        public static implicit operator Either<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(T1 value) => new Either<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(value);
        
        public static implicit operator Either<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(T2 value) => new Either<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(value);
        
        public static implicit operator Either<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(T3 value) => new Either<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(value);
        
        public static implicit operator Either<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(T4 value) => new Either<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(value);
        
        public static implicit operator Either<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(T5 value) => new Either<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(value);
        
        public static implicit operator Either<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(T6 value) => new Either<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(value);
        
        public static implicit operator Either<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(T7 value) => new Either<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(value);
        
        public static implicit operator Either<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(T8 value) => new Either<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(value);
        
        public static implicit operator Either<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(T9 value) => new Either<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(value);
        
        public static implicit operator Either<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(T10 value) => new Either<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(value);
        
        public static implicit operator Either<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(T11 value) => new Either<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(value);
        
        public TResult Match<TResult>(Func<T1, TResult> func1, Func<T2, TResult> func2, Func<T3, TResult> func3, Func<T4, TResult> func4, Func<T5, TResult> func5, Func<T6, TResult> func6, Func<T7, TResult> func7, Func<T8, TResult> func8, Func<T9, TResult> func9, Func<T10, TResult> func10, Func<T11, TResult> func11)
        {
            return this.underlyingValue is T1 ? func1((T1)this.underlyingValue) : this.underlyingValue is T2 ? func2((T2)this.underlyingValue) : this.underlyingValue is T3 ? func3((T3)this.underlyingValue) : this.underlyingValue is T4 ? func4((T4)this.underlyingValue) : this.underlyingValue is T5 ? func5((T5)this.underlyingValue) : this.underlyingValue is T6 ? func6((T6)this.underlyingValue) : this.underlyingValue is T7 ? func7((T7)this.underlyingValue) : this.underlyingValue is T8 ? func8((T8)this.underlyingValue) : this.underlyingValue is T9 ? func9((T9)this.underlyingValue) : this.underlyingValue is T10 ? func10((T10)this.underlyingValue) : func11((T11)this.underlyingValue);
        }
    }
    
    public class Either<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> : IEither<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>
    {
        private readonly object underlyingValue;
        
        public Either(T1 value)
        {
            this.underlyingValue = value;
        }
        
        public Either(T2 value)
        {
            this.underlyingValue = value;
        }
        
        public Either(T3 value)
        {
            this.underlyingValue = value;
        }
        
        public Either(T4 value)
        {
            this.underlyingValue = value;
        }
        
        public Either(T5 value)
        {
            this.underlyingValue = value;
        }
        
        public Either(T6 value)
        {
            this.underlyingValue = value;
        }
        
        public Either(T7 value)
        {
            this.underlyingValue = value;
        }
        
        public Either(T8 value)
        {
            this.underlyingValue = value;
        }
        
        public Either(T9 value)
        {
            this.underlyingValue = value;
        }
        
        public Either(T10 value)
        {
            this.underlyingValue = value;
        }
        
        public Either(T11 value)
        {
            this.underlyingValue = value;
        }
        
        public Either(T12 value)
        {
            this.underlyingValue = value;
        }
        
        public static implicit operator Either<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(T1 value) => new Either<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(value);
        
        public static implicit operator Either<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(T2 value) => new Either<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(value);
        
        public static implicit operator Either<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(T3 value) => new Either<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(value);
        
        public static implicit operator Either<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(T4 value) => new Either<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(value);
        
        public static implicit operator Either<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(T5 value) => new Either<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(value);
        
        public static implicit operator Either<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(T6 value) => new Either<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(value);
        
        public static implicit operator Either<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(T7 value) => new Either<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(value);
        
        public static implicit operator Either<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(T8 value) => new Either<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(value);
        
        public static implicit operator Either<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(T9 value) => new Either<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(value);
        
        public static implicit operator Either<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(T10 value) => new Either<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(value);
        
        public static implicit operator Either<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(T11 value) => new Either<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(value);
        
        public static implicit operator Either<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(T12 value) => new Either<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(value);
        
        public TResult Match<TResult>(Func<T1, TResult> func1, Func<T2, TResult> func2, Func<T3, TResult> func3, Func<T4, TResult> func4, Func<T5, TResult> func5, Func<T6, TResult> func6, Func<T7, TResult> func7, Func<T8, TResult> func8, Func<T9, TResult> func9, Func<T10, TResult> func10, Func<T11, TResult> func11, Func<T12, TResult> func12)
        {
            return this.underlyingValue is T1 ? func1((T1)this.underlyingValue) : this.underlyingValue is T2 ? func2((T2)this.underlyingValue) : this.underlyingValue is T3 ? func3((T3)this.underlyingValue) : this.underlyingValue is T4 ? func4((T4)this.underlyingValue) : this.underlyingValue is T5 ? func5((T5)this.underlyingValue) : this.underlyingValue is T6 ? func6((T6)this.underlyingValue) : this.underlyingValue is T7 ? func7((T7)this.underlyingValue) : this.underlyingValue is T8 ? func8((T8)this.underlyingValue) : this.underlyingValue is T9 ? func9((T9)this.underlyingValue) : this.underlyingValue is T10 ? func10((T10)this.underlyingValue) : this.underlyingValue is T11 ? func11((T11)this.underlyingValue) : func12((T12)this.underlyingValue);
        }
    }
    
    public class Either<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> : IEither<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>
    {
        private readonly object underlyingValue;
        
        public Either(T1 value)
        {
            this.underlyingValue = value;
        }
        
        public Either(T2 value)
        {
            this.underlyingValue = value;
        }
        
        public Either(T3 value)
        {
            this.underlyingValue = value;
        }
        
        public Either(T4 value)
        {
            this.underlyingValue = value;
        }
        
        public Either(T5 value)
        {
            this.underlyingValue = value;
        }
        
        public Either(T6 value)
        {
            this.underlyingValue = value;
        }
        
        public Either(T7 value)
        {
            this.underlyingValue = value;
        }
        
        public Either(T8 value)
        {
            this.underlyingValue = value;
        }
        
        public Either(T9 value)
        {
            this.underlyingValue = value;
        }
        
        public Either(T10 value)
        {
            this.underlyingValue = value;
        }
        
        public Either(T11 value)
        {
            this.underlyingValue = value;
        }
        
        public Either(T12 value)
        {
            this.underlyingValue = value;
        }
        
        public Either(T13 value)
        {
            this.underlyingValue = value;
        }
        
        public static implicit operator Either<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(T1 value) => new Either<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(value);
        
        public static implicit operator Either<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(T2 value) => new Either<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(value);
        
        public static implicit operator Either<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(T3 value) => new Either<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(value);
        
        public static implicit operator Either<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(T4 value) => new Either<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(value);
        
        public static implicit operator Either<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(T5 value) => new Either<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(value);
        
        public static implicit operator Either<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(T6 value) => new Either<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(value);
        
        public static implicit operator Either<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(T7 value) => new Either<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(value);
        
        public static implicit operator Either<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(T8 value) => new Either<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(value);
        
        public static implicit operator Either<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(T9 value) => new Either<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(value);
        
        public static implicit operator Either<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(T10 value) => new Either<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(value);
        
        public static implicit operator Either<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(T11 value) => new Either<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(value);
        
        public static implicit operator Either<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(T12 value) => new Either<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(value);
        
        public static implicit operator Either<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(T13 value) => new Either<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(value);
        
        public TResult Match<TResult>(Func<T1, TResult> func1, Func<T2, TResult> func2, Func<T3, TResult> func3, Func<T4, TResult> func4, Func<T5, TResult> func5, Func<T6, TResult> func6, Func<T7, TResult> func7, Func<T8, TResult> func8, Func<T9, TResult> func9, Func<T10, TResult> func10, Func<T11, TResult> func11, Func<T12, TResult> func12, Func<T13, TResult> func13)
        {
            return this.underlyingValue is T1 ? func1((T1)this.underlyingValue) : this.underlyingValue is T2 ? func2((T2)this.underlyingValue) : this.underlyingValue is T3 ? func3((T3)this.underlyingValue) : this.underlyingValue is T4 ? func4((T4)this.underlyingValue) : this.underlyingValue is T5 ? func5((T5)this.underlyingValue) : this.underlyingValue is T6 ? func6((T6)this.underlyingValue) : this.underlyingValue is T7 ? func7((T7)this.underlyingValue) : this.underlyingValue is T8 ? func8((T8)this.underlyingValue) : this.underlyingValue is T9 ? func9((T9)this.underlyingValue) : this.underlyingValue is T10 ? func10((T10)this.underlyingValue) : this.underlyingValue is T11 ? func11((T11)this.underlyingValue) : this.underlyingValue is T12 ? func12((T12)this.underlyingValue) : func13((T13)this.underlyingValue);
        }
    }
    
    public class Either<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> : IEither<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>
    {
        private readonly object underlyingValue;
        
        public Either(T1 value)
        {
            this.underlyingValue = value;
        }
        
        public Either(T2 value)
        {
            this.underlyingValue = value;
        }
        
        public Either(T3 value)
        {
            this.underlyingValue = value;
        }
        
        public Either(T4 value)
        {
            this.underlyingValue = value;
        }
        
        public Either(T5 value)
        {
            this.underlyingValue = value;
        }
        
        public Either(T6 value)
        {
            this.underlyingValue = value;
        }
        
        public Either(T7 value)
        {
            this.underlyingValue = value;
        }
        
        public Either(T8 value)
        {
            this.underlyingValue = value;
        }
        
        public Either(T9 value)
        {
            this.underlyingValue = value;
        }
        
        public Either(T10 value)
        {
            this.underlyingValue = value;
        }
        
        public Either(T11 value)
        {
            this.underlyingValue = value;
        }
        
        public Either(T12 value)
        {
            this.underlyingValue = value;
        }
        
        public Either(T13 value)
        {
            this.underlyingValue = value;
        }
        
        public Either(T14 value)
        {
            this.underlyingValue = value;
        }
        
        public static implicit operator Either<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(T1 value) => new Either<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(value);
        
        public static implicit operator Either<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(T2 value) => new Either<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(value);
        
        public static implicit operator Either<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(T3 value) => new Either<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(value);
        
        public static implicit operator Either<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(T4 value) => new Either<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(value);
        
        public static implicit operator Either<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(T5 value) => new Either<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(value);
        
        public static implicit operator Either<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(T6 value) => new Either<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(value);
        
        public static implicit operator Either<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(T7 value) => new Either<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(value);
        
        public static implicit operator Either<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(T8 value) => new Either<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(value);
        
        public static implicit operator Either<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(T9 value) => new Either<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(value);
        
        public static implicit operator Either<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(T10 value) => new Either<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(value);
        
        public static implicit operator Either<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(T11 value) => new Either<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(value);
        
        public static implicit operator Either<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(T12 value) => new Either<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(value);
        
        public static implicit operator Either<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(T13 value) => new Either<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(value);
        
        public static implicit operator Either<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(T14 value) => new Either<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(value);
        
        public TResult Match<TResult>(Func<T1, TResult> func1, Func<T2, TResult> func2, Func<T3, TResult> func3, Func<T4, TResult> func4, Func<T5, TResult> func5, Func<T6, TResult> func6, Func<T7, TResult> func7, Func<T8, TResult> func8, Func<T9, TResult> func9, Func<T10, TResult> func10, Func<T11, TResult> func11, Func<T12, TResult> func12, Func<T13, TResult> func13, Func<T14, TResult> func14)
        {
            return this.underlyingValue is T1 ? func1((T1)this.underlyingValue) : this.underlyingValue is T2 ? func2((T2)this.underlyingValue) : this.underlyingValue is T3 ? func3((T3)this.underlyingValue) : this.underlyingValue is T4 ? func4((T4)this.underlyingValue) : this.underlyingValue is T5 ? func5((T5)this.underlyingValue) : this.underlyingValue is T6 ? func6((T6)this.underlyingValue) : this.underlyingValue is T7 ? func7((T7)this.underlyingValue) : this.underlyingValue is T8 ? func8((T8)this.underlyingValue) : this.underlyingValue is T9 ? func9((T9)this.underlyingValue) : this.underlyingValue is T10 ? func10((T10)this.underlyingValue) : this.underlyingValue is T11 ? func11((T11)this.underlyingValue) : this.underlyingValue is T12 ? func12((T12)this.underlyingValue) : this.underlyingValue is T13 ? func13((T13)this.underlyingValue) : func14((T14)this.underlyingValue);
        }
    }
    
    public class Either<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> : IEither<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>
    {
        private readonly object underlyingValue;
        
        public Either(T1 value)
        {
            this.underlyingValue = value;
        }
        
        public Either(T2 value)
        {
            this.underlyingValue = value;
        }
        
        public Either(T3 value)
        {
            this.underlyingValue = value;
        }
        
        public Either(T4 value)
        {
            this.underlyingValue = value;
        }
        
        public Either(T5 value)
        {
            this.underlyingValue = value;
        }
        
        public Either(T6 value)
        {
            this.underlyingValue = value;
        }
        
        public Either(T7 value)
        {
            this.underlyingValue = value;
        }
        
        public Either(T8 value)
        {
            this.underlyingValue = value;
        }
        
        public Either(T9 value)
        {
            this.underlyingValue = value;
        }
        
        public Either(T10 value)
        {
            this.underlyingValue = value;
        }
        
        public Either(T11 value)
        {
            this.underlyingValue = value;
        }
        
        public Either(T12 value)
        {
            this.underlyingValue = value;
        }
        
        public Either(T13 value)
        {
            this.underlyingValue = value;
        }
        
        public Either(T14 value)
        {
            this.underlyingValue = value;
        }
        
        public Either(T15 value)
        {
            this.underlyingValue = value;
        }
        
        public static implicit operator Either<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(T1 value) => new Either<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(value);
        
        public static implicit operator Either<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(T2 value) => new Either<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(value);
        
        public static implicit operator Either<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(T3 value) => new Either<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(value);
        
        public static implicit operator Either<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(T4 value) => new Either<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(value);
        
        public static implicit operator Either<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(T5 value) => new Either<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(value);
        
        public static implicit operator Either<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(T6 value) => new Either<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(value);
        
        public static implicit operator Either<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(T7 value) => new Either<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(value);
        
        public static implicit operator Either<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(T8 value) => new Either<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(value);
        
        public static implicit operator Either<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(T9 value) => new Either<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(value);
        
        public static implicit operator Either<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(T10 value) => new Either<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(value);
        
        public static implicit operator Either<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(T11 value) => new Either<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(value);
        
        public static implicit operator Either<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(T12 value) => new Either<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(value);
        
        public static implicit operator Either<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(T13 value) => new Either<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(value);
        
        public static implicit operator Either<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(T14 value) => new Either<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(value);
        
        public static implicit operator Either<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(T15 value) => new Either<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(value);
        
        public TResult Match<TResult>(Func<T1, TResult> func1, Func<T2, TResult> func2, Func<T3, TResult> func3, Func<T4, TResult> func4, Func<T5, TResult> func5, Func<T6, TResult> func6, Func<T7, TResult> func7, Func<T8, TResult> func8, Func<T9, TResult> func9, Func<T10, TResult> func10, Func<T11, TResult> func11, Func<T12, TResult> func12, Func<T13, TResult> func13, Func<T14, TResult> func14, Func<T15, TResult> func15)
        {
            return this.underlyingValue is T1 ? func1((T1)this.underlyingValue) : this.underlyingValue is T2 ? func2((T2)this.underlyingValue) : this.underlyingValue is T3 ? func3((T3)this.underlyingValue) : this.underlyingValue is T4 ? func4((T4)this.underlyingValue) : this.underlyingValue is T5 ? func5((T5)this.underlyingValue) : this.underlyingValue is T6 ? func6((T6)this.underlyingValue) : this.underlyingValue is T7 ? func7((T7)this.underlyingValue) : this.underlyingValue is T8 ? func8((T8)this.underlyingValue) : this.underlyingValue is T9 ? func9((T9)this.underlyingValue) : this.underlyingValue is T10 ? func10((T10)this.underlyingValue) : this.underlyingValue is T11 ? func11((T11)this.underlyingValue) : this.underlyingValue is T12 ? func12((T12)this.underlyingValue) : this.underlyingValue is T13 ? func13((T13)this.underlyingValue) : this.underlyingValue is T14 ? func14((T14)this.underlyingValue) : func15((T15)this.underlyingValue);
        }
    }
    
    public class Either<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> : IEither<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>
    {
        private readonly object underlyingValue;
        
        public Either(T1 value)
        {
            this.underlyingValue = value;
        }
        
        public Either(T2 value)
        {
            this.underlyingValue = value;
        }
        
        public Either(T3 value)
        {
            this.underlyingValue = value;
        }
        
        public Either(T4 value)
        {
            this.underlyingValue = value;
        }
        
        public Either(T5 value)
        {
            this.underlyingValue = value;
        }
        
        public Either(T6 value)
        {
            this.underlyingValue = value;
        }
        
        public Either(T7 value)
        {
            this.underlyingValue = value;
        }
        
        public Either(T8 value)
        {
            this.underlyingValue = value;
        }
        
        public Either(T9 value)
        {
            this.underlyingValue = value;
        }
        
        public Either(T10 value)
        {
            this.underlyingValue = value;
        }
        
        public Either(T11 value)
        {
            this.underlyingValue = value;
        }
        
        public Either(T12 value)
        {
            this.underlyingValue = value;
        }
        
        public Either(T13 value)
        {
            this.underlyingValue = value;
        }
        
        public Either(T14 value)
        {
            this.underlyingValue = value;
        }
        
        public Either(T15 value)
        {
            this.underlyingValue = value;
        }
        
        public Either(T16 value)
        {
            this.underlyingValue = value;
        }
        
        public static implicit operator Either<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(T1 value) => new Either<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(value);
        
        public static implicit operator Either<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(T2 value) => new Either<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(value);
        
        public static implicit operator Either<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(T3 value) => new Either<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(value);
        
        public static implicit operator Either<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(T4 value) => new Either<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(value);
        
        public static implicit operator Either<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(T5 value) => new Either<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(value);
        
        public static implicit operator Either<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(T6 value) => new Either<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(value);
        
        public static implicit operator Either<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(T7 value) => new Either<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(value);
        
        public static implicit operator Either<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(T8 value) => new Either<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(value);
        
        public static implicit operator Either<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(T9 value) => new Either<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(value);
        
        public static implicit operator Either<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(T10 value) => new Either<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(value);
        
        public static implicit operator Either<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(T11 value) => new Either<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(value);
        
        public static implicit operator Either<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(T12 value) => new Either<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(value);
        
        public static implicit operator Either<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(T13 value) => new Either<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(value);
        
        public static implicit operator Either<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(T14 value) => new Either<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(value);
        
        public static implicit operator Either<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(T15 value) => new Either<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(value);
        
        public static implicit operator Either<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(T16 value) => new Either<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(value);
        
        public TResult Match<TResult>(Func<T1, TResult> func1, Func<T2, TResult> func2, Func<T3, TResult> func3, Func<T4, TResult> func4, Func<T5, TResult> func5, Func<T6, TResult> func6, Func<T7, TResult> func7, Func<T8, TResult> func8, Func<T9, TResult> func9, Func<T10, TResult> func10, Func<T11, TResult> func11, Func<T12, TResult> func12, Func<T13, TResult> func13, Func<T14, TResult> func14, Func<T15, TResult> func15, Func<T16, TResult> func16)
        {
            return this.underlyingValue is T1 ? func1((T1)this.underlyingValue) : this.underlyingValue is T2 ? func2((T2)this.underlyingValue) : this.underlyingValue is T3 ? func3((T3)this.underlyingValue) : this.underlyingValue is T4 ? func4((T4)this.underlyingValue) : this.underlyingValue is T5 ? func5((T5)this.underlyingValue) : this.underlyingValue is T6 ? func6((T6)this.underlyingValue) : this.underlyingValue is T7 ? func7((T7)this.underlyingValue) : this.underlyingValue is T8 ? func8((T8)this.underlyingValue) : this.underlyingValue is T9 ? func9((T9)this.underlyingValue) : this.underlyingValue is T10 ? func10((T10)this.underlyingValue) : this.underlyingValue is T11 ? func11((T11)this.underlyingValue) : this.underlyingValue is T12 ? func12((T12)this.underlyingValue) : this.underlyingValue is T13 ? func13((T13)this.underlyingValue) : this.underlyingValue is T14 ? func14((T14)this.underlyingValue) : this.underlyingValue is T15 ? func15((T15)this.underlyingValue) : func16((T16)this.underlyingValue);
        }
    }
}

