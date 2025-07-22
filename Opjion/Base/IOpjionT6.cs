//
// Opjion (c) by KryKom 2025
//

namespace Opjion;

public interface IOpjion<out T0, out T1, out T2, out T3, out T4, out T5> : IOpjion { 
    public bool IsT0 { get; }
    public bool IsT1 { get; }
    public bool IsT2 { get; }
    public bool IsT3 { get; }
    public bool IsT4 { get; }
    public bool IsT5 { get; }
    
    public T0 AsT0 { get; }
    public T1 AsT1 { get; }
    public T2 AsT2 { get; }
    public T3 AsT3 { get; }
    public T4 AsT4 { get; }
    public T5 AsT5 { get; }
    
    public void Switch(Action<T0> f0, Action<T1> f1, Action<T2> f2, Action<T3> f3, Action<T4> f4, Action<T5> f5);
    public TResult Match<TResult>(Func<T0, TResult> f0, Func<T1, TResult> f1, Func<T2, TResult> f2, Func<T3, TResult> f3, Func<T4, TResult> f4, Func<T5, TResult> f5);
}