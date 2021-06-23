using System;
using LanguageExt;

namespace optional
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            
            var notNull = new NotNull();
            Option<Argument> name = notNull.ReturnArgumentOrNone();

            var test = name.Match<string>(arg => "not null", () => "null");
            Console.WriteLine($"name: {test}");


            var optional = new Optional();

            string? resOrNull1 = optional.GetStringOrNull();
            
            var resOrNull2 = optional.GetStringOrNull();

            // error
            // string res = optional.GetStringOrNull().ToUpper();

            // handling
            string res = optional.GetStringOrNull()?.ToUpper();
            Console.WriteLine($"string res: {res}");

            // error because GetInt isn't optional
            // int number = optional?.GetInt();
        }
    }
}
