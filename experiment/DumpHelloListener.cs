namespace Experiment
{
    public class DumpHelloListener : helloBaseListener
    {
        public override void EnterR(helloParser.RContext context)
        {            
            System.Console.WriteLine($"R says {context.ToStringTree()} to {context.ID().GetText()}");        
        }    
    }
}