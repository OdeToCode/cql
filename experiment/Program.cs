using System.IO;
using Antlr4.Runtime;

namespace Experiment
{

    public class Program
    {
        public static void Main()
        {
            var reader = new StringReader("{1, 2, { 3, 4}, 3, 4}");
            var input = new AntlrInputStream(reader);
            var lexer = new ArrayInitLexer(input);
            var tokens = new CommonTokenStream(lexer);
            var parser = new ArrayInitParser(tokens);
            var tree = parser.init();

            System.Console.WriteLine(tree.ToStringTree(parser));
        }
    }

}