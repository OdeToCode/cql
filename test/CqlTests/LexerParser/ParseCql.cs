using Antlr4.Runtime;
using System.IO;
using Xunit;
using Antlr4.Runtime.Misc;
using Antlr4.Runtime.Tree;
using static cqlParser;

namespace CqlTests.LexerParser
{
    public class ParseCql
    {
        [Fact]
        public void CanParse_146()
        {
            var lexer = new cqlLexer(new AntlrFileStream("cms146v2.cql"));
            var tokens = new CommonTokenStream(lexer);
            var parser = new cqlParser(tokens);
            var walker = new ParseTreeWalker();
            var listener = new cqlListener();

            walker.Walk(listener, parser.library());

            Assert.NotNull(listener.Library);
        }

        [Fact]
        public void RejectsBadSyntax()
        {
            var reader = new StringReader("context bam");
            var lexer = new cqlLexer(new AntlrInputStream(reader));
            var tokens = new CommonTokenStream(lexer);
            var parser = new cqlParser(tokens);
            var walker = new ParseTreeWalker();
            var listener = new cqlListener();

            walker.Walk(listener, parser.library());

            Assert.Null(listener.Library);
        }

        class cqlListener : cqlBaseListener
        {
            public LibraryContext Library { get; set; }

            public override void EnterLibrary([NotNull] LibraryContext context)
            {
                Library = context;
                base.EnterLibrary(context);
            }
        }
    }
}

    
