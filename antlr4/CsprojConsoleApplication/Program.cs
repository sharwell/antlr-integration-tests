using System;
using Antlr4.Runtime;

[assembly: CLSCompliant(false)]

namespace DotnetValidation
{
    class Program
    {
        static void Main(string[] args)
        {
            var lexer = new global::DotnetValidation.GrammarLexer(new AntlrInputStream("text"));
            var parser = new GrammarParser(new CommonTokenStream(lexer));
            var tree = parser.compilationUnit();
            Console.WriteLine(tree.ToStringTree(parser));

            var subLexer = new global::DotnetValidation.SubFolder.SubGrammarLexer(new AntlrInputStream("text"));
            var subParser = new SubFolder.SubGrammarParser(new CommonTokenStream(subLexer));
            var subTree = subParser.compilationUnit();
            Console.WriteLine(subTree.ToStringTree(subParser));
        }
    }
}
