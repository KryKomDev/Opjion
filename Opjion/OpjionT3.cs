namespace Opjion;

public readonly struct Opjion<T0, T1, T2> : IOpjion<T0, T1, T2>, IEquatable<Opjion<T0, T1, T2>> {
    private readonly object _obj;
    private readonly byte _type;

    public Opjion(T0 value0) {
        _obj = value0;
        _type = 0;
    }
    
    public Opjion(T1 value1) {
        _obj = value1;
        _type = 1;
    }
    
    public Opjion(T2 value1) {
        _obj = value1;
        _type = 2;
    }
    
    public object Value => _obj;
    public byte Index => _type;

    public bool IsT0 => _type == 0;
    public bool IsT1 => _type == 1;
    public bool IsT2 => _type == 2;
    
    public T0 AsT0 => _type is 0 ? (T0)_obj! : throw new InvalidOperationException($"Cannot cast T{_type} to T0");
    public T1 AsT1 => _type is 1 ? (T1)_obj! : throw new InvalidOperationException($"Cannot cast T{_type} to T1");
    public T2 AsT2 => _type is 2 ? (T2)_obj! : throw new InvalidOperationException($"Cannot cast T{_type} to T2");
    
    public static implicit operator Opjion<T0, T1, T2>(T0 value0) => new(value0);
    public static implicit operator Opjion<T0, T1, T2>(T1 value1) => new(value1);
    public static implicit operator Opjion<T0, T1, T2>(T2 value2) => new(value2);

    public TResult Match<TResult>(
        Func<T0, TResult> f0, 
        Func<T1, TResult> f1, 
        Func<T2, TResult> f2) => 
    _type switch {
        0 => f0(AsT0),
        1 => f1(AsT1),
        2 => f2(AsT2),
        _ => throw new ArgumentOutOfRangeException()
    };

    public void Switch(Action<T0> f0, Action<T1> f1, Action<T2> f2) {
        switch (_type) {
            case 0: f0(AsT0); break;
            case 1: f1(AsT1); break;
            case 2: f2(AsT2); break;
            default: throw new ArgumentOutOfRangeException();
        }
    } 
    
    public static Opjion<T0, T1, T2> FromT0(T0 value0) => new(value0);
    public static Opjion<T0, T1, T2> FromT1(T1 value1) => new(value1);
    public static Opjion<T0, T1, T2> FromT2(T2 value2) => new(value2);
    
    public override string ToString() => _type switch {
        0 => AsT0.ToString(),
        1 => AsT1.ToString(),
        2 => AsT2.ToString(),
        _ => throw new ArgumentOutOfRangeException()
    };

    public override int GetHashCode() => _type switch {
        0 => AsT0.GetHashCode(),
        1 => AsT1.GetHashCode(),
        2 => AsT2.GetHashCode(),
        _ => throw new ArgumentOutOfRangeException()
    };

    public override bool Equals(object obj) => 
        obj is Opjion<T0, T1, T2> o && 
        _type == o._type && 
        Equals(_obj, o._obj);

    public static bool operator ==(Opjion<T0, T1, T2> left, Opjion<T0, T1, T2> right) => left.Equals(right);
    public static bool operator !=(Opjion<T0, T1, T2> left, Opjion<T0, T1, T2> right) => !left.Equals(right);

    public bool Equals(Opjion<T0, T1, T2> other) => _type == other._type && Equals(_obj, other._obj);
}