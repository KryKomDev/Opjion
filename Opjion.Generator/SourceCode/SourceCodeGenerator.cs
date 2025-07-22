namespace Opjion.Generator.SourceCode;

public static class SourceCodeGenerator {
    
    public static string GenerateInterface(int tNum) => 
        $$"""
         //
         // Opjion (c) by KryKom 2025
         //
         
         namespace Opjion;
         
         public interface IOpjion<{{Aggregate(tNum, "out T{0}")}}> : IOpjion { 
             {{Aggregate(tNum, "public bool IsT{0} {{ get; }}", "\n    ")}}
             
             {{Aggregate(tNum, "public T{0} AsT{0} {{ get; }}", "\n    ")}}
             
             public void Switch({{Aggregate(tNum, "Action<T{0}> f{0}")}});
             public TResult Match<TResult>({{Aggregate(tNum, "Func<T{0}, TResult> f{0}")}});
         }
         """;
    
    public static string GenerateClass(int tNum) => 
        $$"""
          //
          // Opjion (c) by KryKom 2025
          //

          namespace Opjion;

          public readonly struct Opjion<{{Aggregate(tNum, "T{0}")}}> : IOpjion<{{Aggregate(tNum, "T{0}")}}>, IEquatable<Opjion<{{Aggregate(tNum, "T{0}")}}>> {
              private readonly object _obj;
              private readonly byte _type;
              
              public object Value => _obj;
              public byte Index => _type;
              
              {{Aggregate(tNum, "public Opjion(T{0} value{0}) {{\n        _obj = value{0};\n        _type = {0};\n    }}", "\n    ")}}
              
              {{Aggregate(tNum, "public bool IsT{0} => _type is {0};", "\n    ")}}
              
              {{Aggregate(tNum, "public T{0} AsT{0} => _type is {0} ? (T{0})_obj : throw new InvalidOperationException($\"Cannot cast T{0} to T{{_type}}.\");", "\n    ")}}
              
              public void Switch({{Aggregate(tNum, "Action<T{0}> f{0}")}}) {
                  switch (_type) {
                      {{Aggregate(tNum, "case {0}: f{0}(AsT{0}); break;", "\n            ")}}
                      default: throw new ArgumentOutOfRangeException();
                  }
              } 
              
              public TResult Match<TResult>({{Aggregate(tNum, "Func<T{0}, TResult> f{0}")}}) {
                  return _type switch {
                      {{Aggregate(tNum, "{0} => f{0}(AsT{0}),", "\n            ")}}
                      _ => throw new ArgumentOutOfRangeException()
                  };
              }
              
              public override string ToString() => _type switch {
                  {{Aggregate(tNum, "{0} => AsT{0}.ToString(),", "\n        ")}}
                  _ => throw new ArgumentOutOfRangeException()
              };
          
              public override int GetHashCode() => _type switch {
                  {{Aggregate(tNum, "{0} => AsT{0}.GetHashCode(),", "\n        ")}}
                  _ => throw new ArgumentOutOfRangeException()
              };
          
              public override bool Equals(object obj) => 
                  obj is Opjion<{{Aggregate(tNum, "T{0}")}}> o && 
                  _type == o._type && 
                  Equals(_obj, o._obj);

              public bool Equals(Opjion<{{Aggregate(tNum, "T{0}")}}> other) => _type == other._type && Equals(_obj, other._obj);
          
              public static bool operator ==(Opjion<{{Aggregate(tNum, "T{0}")}}> left, Opjion<{{Aggregate(tNum, "T{0}")}}> right) => left.Equals(right);
              public static bool operator !=(Opjion<{{Aggregate(tNum, "T{0}")}}> left, Opjion<{{Aggregate(tNum, "T{0}")}}> right) => !left.Equals(right);
          
              {{Aggregate(tNum, $"public static Opjion<{Aggregate(tNum, "T{0}")}> FromT{{0}}(T{{0}} v) => new(v);", "\n    ")}}
              
              {{Aggregate(tNum, $"public static implicit operator Opjion<{Aggregate(tNum, "T{0}")}>(T{{0}} v) => new(v);", "\n    ")}}
          }
          """;

    private static string Aggregate(int range, string template, string separator = ", ") {
        string[] strings = new string[range];
        for (int i = 0; i < range; i++) 
            strings[i] = 
                string.Format(template, i);
        return string.Join(separator, strings);
    }
    
}