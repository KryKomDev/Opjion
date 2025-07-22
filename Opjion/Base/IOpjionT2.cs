namespace Opjion;

public interface IOpjion<out T0, out T1> : IOpjion {
    public bool IsT0 { get; }
    public bool IsT1 { get; }
    
    public T0 AsT0 { get; }
    public T1 AsT1 { get; }
    
    public void Switch(Action<T0> f0, Action<T1> f1);
    public TResult Match<TResult>(Func<T0, TResult> f0, Func<T1, TResult> f1);
}