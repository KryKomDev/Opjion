//
// Opjion (c) by KryKom 2025
//

namespace Opjion;

public readonly struct Opjion<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> : IOpjion<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>, IEquatable<Opjion<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>> {
    private readonly object _obj;
    private readonly byte _type;
    
    public object Value => _obj;
    public byte Index => _type;
    
    public Opjion(T0 value0) {
        _obj = value0;
        _type = 0;
    }
    public Opjion(T1 value1) {
        _obj = value1;
        _type = 1;
    }
    public Opjion(T2 value2) {
        _obj = value2;
        _type = 2;
    }
    public Opjion(T3 value3) {
        _obj = value3;
        _type = 3;
    }
    public Opjion(T4 value4) {
        _obj = value4;
        _type = 4;
    }
    public Opjion(T5 value5) {
        _obj = value5;
        _type = 5;
    }
    public Opjion(T6 value6) {
        _obj = value6;
        _type = 6;
    }
    public Opjion(T7 value7) {
        _obj = value7;
        _type = 7;
    }
    public Opjion(T8 value8) {
        _obj = value8;
        _type = 8;
    }
    public Opjion(T9 value9) {
        _obj = value9;
        _type = 9;
    }
    
    public bool IsT0 => _type is 0;
    public bool IsT1 => _type is 1;
    public bool IsT2 => _type is 2;
    public bool IsT3 => _type is 3;
    public bool IsT4 => _type is 4;
    public bool IsT5 => _type is 5;
    public bool IsT6 => _type is 6;
    public bool IsT7 => _type is 7;
    public bool IsT8 => _type is 8;
    public bool IsT9 => _type is 9;
    
    public T0 AsT0 => _type is 0 ? (T0)_obj : throw new InvalidOperationException($"Cannot cast T0 to T{_type}.");
    public T1 AsT1 => _type is 1 ? (T1)_obj : throw new InvalidOperationException($"Cannot cast T1 to T{_type}.");
    public T2 AsT2 => _type is 2 ? (T2)_obj : throw new InvalidOperationException($"Cannot cast T2 to T{_type}.");
    public T3 AsT3 => _type is 3 ? (T3)_obj : throw new InvalidOperationException($"Cannot cast T3 to T{_type}.");
    public T4 AsT4 => _type is 4 ? (T4)_obj : throw new InvalidOperationException($"Cannot cast T4 to T{_type}.");
    public T5 AsT5 => _type is 5 ? (T5)_obj : throw new InvalidOperationException($"Cannot cast T5 to T{_type}.");
    public T6 AsT6 => _type is 6 ? (T6)_obj : throw new InvalidOperationException($"Cannot cast T6 to T{_type}.");
    public T7 AsT7 => _type is 7 ? (T7)_obj : throw new InvalidOperationException($"Cannot cast T7 to T{_type}.");
    public T8 AsT8 => _type is 8 ? (T8)_obj : throw new InvalidOperationException($"Cannot cast T8 to T{_type}.");
    public T9 AsT9 => _type is 9 ? (T9)_obj : throw new InvalidOperationException($"Cannot cast T9 to T{_type}.");
    
    public void Switch(Action<T0> f0, Action<T1> f1, Action<T2> f2, Action<T3> f3, Action<T4> f4, Action<T5> f5, Action<T6> f6, Action<T7> f7, Action<T8> f8, Action<T9> f9) {
        switch (_type) {
            case 0: f0(AsT0); break;
            case 1: f1(AsT1); break;
            case 2: f2(AsT2); break;
            case 3: f3(AsT3); break;
            case 4: f4(AsT4); break;
            case 5: f5(AsT5); break;
            case 6: f6(AsT6); break;
            case 7: f7(AsT7); break;
            case 8: f8(AsT8); break;
            case 9: f9(AsT9); break;
            default: throw new ArgumentOutOfRangeException();
        }
    } 
    
    public TResult Match<TResult>(Func<T0, TResult> f0, Func<T1, TResult> f1, Func<T2, TResult> f2, Func<T3, TResult> f3, Func<T4, TResult> f4, Func<T5, TResult> f5, Func<T6, TResult> f6, Func<T7, TResult> f7, Func<T8, TResult> f8, Func<T9, TResult> f9) {
        return _type switch {
            0 => f0(AsT0),
            1 => f1(AsT1),
            2 => f2(AsT2),
            3 => f3(AsT3),
            4 => f4(AsT4),
            5 => f5(AsT5),
            6 => f6(AsT6),
            7 => f7(AsT7),
            8 => f8(AsT8),
            9 => f9(AsT9),
            _ => throw new ArgumentOutOfRangeException()
        };
    }
    
    public override string ToString() => _type switch {
        0 => AsT0.ToString(),
        1 => AsT1.ToString(),
        2 => AsT2.ToString(),
        3 => AsT3.ToString(),
        4 => AsT4.ToString(),
        5 => AsT5.ToString(),
        6 => AsT6.ToString(),
        7 => AsT7.ToString(),
        8 => AsT8.ToString(),
        9 => AsT9.ToString(),
        _ => throw new ArgumentOutOfRangeException()
    };

    public override int GetHashCode() => _type switch {
        0 => AsT0.GetHashCode(),
        1 => AsT1.GetHashCode(),
        2 => AsT2.GetHashCode(),
        3 => AsT3.GetHashCode(),
        4 => AsT4.GetHashCode(),
        5 => AsT5.GetHashCode(),
        6 => AsT6.GetHashCode(),
        7 => AsT7.GetHashCode(),
        8 => AsT8.GetHashCode(),
        9 => AsT9.GetHashCode(),
        _ => throw new ArgumentOutOfRangeException()
    };

    public override bool Equals(object obj) => 
        obj is Opjion<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> o && 
        _type == o._type && 
        Equals(_obj, o._obj);

    public bool Equals(Opjion<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> other) => _type == other._type && Equals(_obj, other._obj);

    public static bool operator ==(Opjion<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> left, Opjion<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> right) => left.Equals(right);
    public static bool operator !=(Opjion<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> left, Opjion<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> right) => !left.Equals(right);

    public static Opjion<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> FromT0(T0 v) => new(v);
    public static Opjion<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> FromT1(T1 v) => new(v);
    public static Opjion<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> FromT2(T2 v) => new(v);
    public static Opjion<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> FromT3(T3 v) => new(v);
    public static Opjion<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> FromT4(T4 v) => new(v);
    public static Opjion<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> FromT5(T5 v) => new(v);
    public static Opjion<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> FromT6(T6 v) => new(v);
    public static Opjion<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> FromT7(T7 v) => new(v);
    public static Opjion<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> FromT8(T8 v) => new(v);
    public static Opjion<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> FromT9(T9 v) => new(v);
    
    public static implicit operator Opjion<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(T0 v) => new(v);
    public static implicit operator Opjion<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(T1 v) => new(v);
    public static implicit operator Opjion<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(T2 v) => new(v);
    public static implicit operator Opjion<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(T3 v) => new(v);
    public static implicit operator Opjion<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(T4 v) => new(v);
    public static implicit operator Opjion<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(T5 v) => new(v);
    public static implicit operator Opjion<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(T6 v) => new(v);
    public static implicit operator Opjion<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(T7 v) => new(v);
    public static implicit operator Opjion<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(T8 v) => new(v);
    public static implicit operator Opjion<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(T9 v) => new(v);
}