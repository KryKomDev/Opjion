//
// Opjion (c) by KryKom 2025
//

namespace Opjion;

public interface IOpjion<out T0, out T1, out T2, out T3> : IOpjion { 
    public bool IsT0 { get; }
    public bool IsT1 { get; }
    public bool IsT2 { get; }
    public bool IsT3 { get; }
    
    public T0 AsT0 { get; }
    public T1 AsT1 { get; }
    public T2 AsT2 { get; }
    public T3 AsT3 { get; }
    
    public void Switch(Action<T0> f0, Action<T1> f1, Action<T2> f2, Action<T3> f3);
    public TResult Match<TResult>(Func<T0, TResult> f0, Func<T1, TResult> f1, Func<T2, TResult> f2, Func<T3, TResult> f3);
}