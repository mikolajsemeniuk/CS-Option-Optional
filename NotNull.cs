using System;
using LanguageExt;

namespace optional
{
    public class Argument
    {
        public string Name { get; set; }
    }

    public class NotNull
    {
        Random random = new Random();
        public Option<Argument> ReturnArgumentOrNone()
        {
            return random.Next(0, 2) == 1 ? new Argument { Name = "hi there" } : Option<Argument>.None;
        }

        public SomeCase<Argument> CreateOrReturnArgument(Argument arg)
        {
            return random.Next(0, 2) == 1 ? arg : Some.Create(new Argument { Name = "created" });
        }
    }
}