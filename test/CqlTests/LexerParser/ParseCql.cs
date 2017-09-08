using Antlr4.Runtime;
using System.IO;
using Xunit;
using Antlr4.Runtime.Misc;
using Antlr4.Runtime.Tree;

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
        }

        [Fact]
        public void RejectsBadSyntax()
        {
            var reader = new StringReader("foo bar baz");
            var lexer = new cqlLexer(new AntlrInputStream(reader));
            var tokens = new CommonTokenStream(lexer);
            var parser = new cqlParser(tokens);
            var context = parser.library();
            
            var listener = new cqlListener();
            ParseTreeWalker.Default.Walk(listener, context);

            Assert.NotNull(listener.Library);   
         
        }

        class cqlListener : cqlBaseListener
        {

            public override void VisitErrorNode([NotNull] IErrorNode node)
            {
                base.VisitErrorNode(node);
            }

            public override void EnterLibraryDefinition([NotNull] cqlParser.LibraryDefinitionContext context)
            {
                Library = context;
                base.EnterLibraryDefinition(context);
            }
            internal cqlParser.LibraryDefinitionContext Library
            {
                get; set;
            }
        }
    }
}

    
