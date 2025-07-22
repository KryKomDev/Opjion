using Opjion.Generator.SourceCode;

namespace Opjion.Generator;

class Program {
    static void Main(string[] args) {
        for (int i = 4; i <= 20; i++) {
            File.Create($"../../../../Opjion/Base/IOpjionT{i}.cs").Dispose();
            File.Create($"../../../../Opjion/OpjionT{i}.cs").Dispose();
            File.WriteAllText($"../../../../Opjion/Base/IOpjionT{i}.cs", SourceCodeGenerator.GenerateInterface(i));
            File.WriteAllText($"../../../../Opjion/OpjionT{i}.cs", SourceCodeGenerator.GenerateClass(i));
        }
    }
}