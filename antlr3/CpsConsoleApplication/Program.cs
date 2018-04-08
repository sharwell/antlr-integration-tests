using System;
using Antlr.Runtime;
using Antlr.Runtime.Tree;

[assembly: CLSCompliant(false)]

namespace DotnetValidation
{
    class Program
    {
        static void Main(string[] args)
        {
            var lexer = new GrammarLexer(new ANTLRStringStream("text"));
            var parser = new GrammarParser(new CommonTokenStream(lexer));
            var tree = parser.compilationUnit();

            Console.WriteLine(new DotTreeGenerator().ToDot((ITree)tree.Tree));
        }
    }
}
