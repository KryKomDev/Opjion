//
// Opjion (c) by KryKom 2025
//

namespace Opjion;

public readonly struct Opjion<T0, T1, T2, T3, T4> : IOpjion<T0, T1, T2, T3, T4>, IEquatable<Opjion<T0, T1, T2, T3, T4>> {
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
    
    public bool IsT0 => _type is 0;
    public bool IsT1 => _type is 1;
    public bool IsT2 => _type is 2;
    public bool IsT3 => _type is 3;
    public bool IsT4 => _type is 4;
    
    public T0 AsT0 => _type is 0 ? (T0)_obj : throw new InvalidOperationException($"Cannot cast T0 to T{_type}.");
    public T1 AsT1 => _type is 1 ? (T1)_obj : throw new InvalidOperationException($"Cannot cast T1 to T{_type}.");
    public T2 AsT2 => _type is 2 ? (T2)_obj : throw new InvalidOperationException($"Cannot cast T2 to T{_type}.");
    public T3 AsT3 => _type is 3 ? (T3)_obj : throw new InvalidOperationException($"Cannot cast T3 to T{_type}.");
    public T4 AsT4 => _type is 4 ? (T4)_obj : throw new InvalidOperationException($"Cannot cast T4 to T{_type}.");
    
    public void Switch(Action<T0> f0, Action<T1> f1, Action<T2> f2, Action<T3> f3, Action<T4> f4) {
        switch (_type) {
            case 0: f0(AsT0); break;
            case 1: f1(AsT1); break;
            case 2: f2(AsT2); break;
            case 3: f3(AsT3); break;
            case 4: f4(AsT4); break;
            default: throw new ArgumentOutOfRangeException();
        }
    } 
    
    public TResult Match<TResult>(Func<T0, TResult> f0, Func<T1, TResult> f1, Func<T2, TResult> f2, Func<T3, TResult> f3, Func<T4, TResult> f4) {
        return _type switch {
            0 => f0(AsT0),
            1 => f1(AsT1),
            2 => f2(AsT2),
            3 => f3(AsT3),
            4 => f4(AsT4),
            _ => throw new ArgumentOutOfRangeException()
        };
    }
    
    public override string ToString() => _type switch {
        0 => AsT0.ToString(),
        1 => AsT1.ToString(),
        2 => AsT2.ToString(),
        3 => AsT3.ToString(),
        4 => AsT4.ToString(),
        _ => throw new ArgumentOutOfRangeException()
    };

    public override int GetHashCode() => _type switch {
        0 => AsT0.GetHashCode(),
        1 => AsT1.GetHashCode(),
        2 => AsT2.GetHashCode(),
        3 => AsT3.GetHashCode(),
        4 => AsT4.GetHashCode(),
        _ => throw new ArgumentOutOfRangeException()
    };

    public override bool Equals(object obj) => 
        obj is Opjion<T0, T1, T2, T3, T4> o && 
        _type == o._type && 
        Equals(_obj, o._obj);

    public bool Equals(Opjion<T0, T1, T2, T3, T4> other) => _type == other._type && Equals(_obj, other._obj);

    public static bool operator ==(Opjion<T0, T1, T2, T3, T4> left, Opjion<T0, T1, T2, T3, T4> right) => left.Equals(right);
    public static bool operator !=(Opjion<T0, T1, T2, T3, T4> left, Opjion<T0, T1, T2, T3, T4> right) => !left.Equals(right);

    public static Opjion<T0, T1, T2, T3, T4> FromT0(T0 v) => new(v);
    public static Opjion<T0, T1, T2, T3, T4> FromT1(T1 v) => new(v);
    public static Opjion<T0, T1, T2, T3, T4> FromT2(T2 v) => new(v);
    public static Opjion<T0, T1, T2, T3, T4> FromT3(T3 v) => new(v);
    public static Opjion<T0, T1, T2, T3, T4> FromT4(T4 v) => new(v);
    
    public static implicit operator Opjion<T0, T1, T2, T3, T4>(T0 v) => new(v);
    public static implicit operator Opjion<T0, T1, T2, T3, T4>(T1 v) => new(v);
    public static implicit operator Opjion<T0, T1, T2, T3, T4>(T2 v) => new(v);
    public static implicit operator Opjion<T0, T1, T2, T3, T4>(T3 v) => new(v);
    public static implicit operator Opjion<T0, T1, T2, T3, T4>(T4 v) => new(v);
}