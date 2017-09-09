using System.IO;
using Antlr4.Runtime;
using Antlr4.Runtime.Tree;

namespace Experiment
{

    public class Program
    {
        public static void Main()
        {
           RunArrayInit();
           RunHello();
        }

        static void RunHello()
        {
            var reader = new StringReader("hello a\rhello b");
            var input = new AntlrInputStream(reader);
            var lexer = new helloLexer(input);
            var tokens = new CommonTokenStream(lexer);
            var parser = new helloParser(tokens);
            var walker = new ParseTreeWalker();
            var listener = new DumpHelloListener();
            walker.Walk(listener, parser.r());
        }

        static void RunArrayInit()
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