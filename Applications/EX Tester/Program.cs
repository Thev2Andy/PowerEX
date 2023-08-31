using System;
using System.Diagnostics;
using System.Linq.Expressions;
using PowerEX;

namespace EXTester
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Console.Write("Enter an expression: ");

            string Expression = Console.ReadLine();

            Stopwatch SW = Stopwatch.StartNew();
            Decimal Result = Parser.Parse(Expression, new DefaultContext());
            SW.Stop();

            Console.WriteLine($"The result is `{Result}` (Calculated in {SW.ElapsedMilliseconds} ms.)");
        }
    }

    public class DefaultContext : IContext
    {
        public Decimal Call(string Identifier, Decimal[] Arguments)
        {
            if (Identifier.ToUpper() == "POW")
            {
                return ((Decimal)(Math.Pow((Double)Arguments[0], (Double)Arguments[1])));
            }

            throw new Exception($"Unknown function `{Identifier}`.");
        }

        public Decimal Resolve(string Identifier)
        {
            if (Identifier.ToUpper() == "PI")
            {
                return ((Decimal)(Math.PI));
            }
            
            throw new Exception($"Unknown variable `{Identifier}`.");
        }
    }
}