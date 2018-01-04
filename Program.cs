using System;
using System.Globalization;

using Antlr.Runtime;
using Antlr.Runtime.Tree;
using System.Text;

namespace MathLang
{
    public class Program
    {
        // "культуронезависимый" формат для чисел (с разделителем точкой)
        public static readonly NumberFormatInfo NFI = new NumberFormatInfo();


        public static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            try
            {
                // в зависимости от наличия параметров командной строки разбираем
                // либо файл с именем, переданным первым параметром, либо стандартный ввод
                ICharStream input = args.Length == 1 ? (ICharStream)new ANTLRFileStream(args[0])
                                                     : (ICharStream)new ANTLRReaderStream(Console.In);
                MathLangLexer lexer = new MathLangLexer(input);
                CommonTokenStream tokens = new CommonTokenStream(lexer);
                MathLangParser parser = new MathLangParser(tokens);
                ITree program = (ITree)parser.execute().Tree;
                AstNodePrinter.Print(program);
                SemanticAnalyzer semanticAnalyzer = new SemanticAnalyzer(program);
                semanticAnalyzer.CreateTable("tables.txt");
                Console.WriteLine();
                semanticAnalyzer.StartAnalyze();
                //Console.WriteLine();
                //MathLangIntepreter.Execute(program);
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: {0}", e);
            }
            Console.ReadLine();
        }
    }
}
