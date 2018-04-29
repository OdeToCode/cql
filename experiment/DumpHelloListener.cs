using System;
using Antlr4.Runtime.Misc;
using Antlr4.Runtime.Tree;

namespace Experiment
{
    public class DumpHelloListener : helloBaseListener
    {
        public override void VisitErrorNode([NotNull] IErrorNode node)
        {
            Console.WriteLine($"Error: {node.Payload}");
            base.VisitErrorNode(node);
        }

        public override void EnterHellofile([NotNull] helloParser.HellofileContext context)
        {
            Console.WriteLine("Done file");
        }

        public override void EnterR(helloParser.RContext context)
        {            
            Console.WriteLine($"R says {context.ToStringTree()} to {context.ID().GetText()}");
        }    
    }
}