using Antlr4.Runtime;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Xunit;

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
    }
}

    
