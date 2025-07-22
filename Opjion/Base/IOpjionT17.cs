//
// Opjion (c) by KryKom 2025
//

namespace Opjion;

public interface IOpjion<out T0, out T1, out T2, out T3, out T4, out T5, out T6, out T7, out T8, out T9, out T10, out T11, out T12, out T13, out T14, out T15, out T16> : IOpjion { 
    public bool IsT0 { get; }
    public bool IsT1 { get; }
    public bool IsT2 { get; }
    public bool IsT3 { get; }
    public bool IsT4 { get; }
    public bool IsT5 { get; }
    public bool IsT6 { get; }
    public bool IsT7 { get; }
    public bool IsT8 { get; }
    public bool IsT9 { get; }
    public bool IsT10 { get; }
    public bool IsT11 { get; }
    public bool IsT12 { get; }
    public bool IsT13 { get; }
    public bool IsT14 { get; }
    public bool IsT15 { get; }
    public bool IsT16 { get; }
    
    public T0 AsT0 { get; }
    public T1 AsT1 { get; }
    public T2 AsT2 { get; }
    public T3 AsT3 { get; }
    public T4 AsT4 { get; }
    public T5 AsT5 { get; }
    public T6 AsT6 { get; }
    public T7 AsT7 { get; }
    public T8 AsT8 { get; }
    public T9 AsT9 { get; }
    public T10 AsT10 { get; }
    public T11 AsT11 { get; }
    public T12 AsT12 { get; }
    public T13 AsT13 { get; }
    public T14 AsT14 { get; }
    public T15 AsT15 { get; }
    public T16 AsT16 { get; }
    
    public void Switch(Action<T0> f0, Action<T1> f1, Action<T2> f2, Action<T3> f3, Action<T4> f4, Action<T5> f5, Action<T6> f6, Action<T7> f7, Action<T8> f8, Action<T9> f9, Action<T10> f10, Action<T11> f11, Action<T12> f12, Action<T13> f13, Action<T14> f14, Action<T15> f15, Action<T16> f16);
    public TResult Match<TResult>(Func<T0, TResult> f0, Func<T1, TResult> f1, Func<T2, TResult> f2, Func<T3, TResult> f3, Func<T4, TResult> f4, Func<T5, TResult> f5, Func<T6, TResult> f6, Func<T7, TResult> f7, Func<T8, TResult> f8, Func<T9, TResult> f9, Func<T10, TResult> f10, Func<T11, TResult> f11, Func<T12, TResult> f12, Func<T13, TResult> f13, Func<T14, TResult> f14, Func<T15, TResult> f15, Func<T16, TResult> f16);
}