using System;

namespace optional
{
    public class Optional
    {
        Random random = new Random();

        /// <summary>this won't compile</summary>
        // public int GetOnlyInt()
        // {
        //     // some logic...
        //     return random.Next(0, 2) == 1 ? 4 : null;
        // }

        public string? GetStringOrNull() =>
            random.Next(0, 2) == 1 ? "welcome" : null;

        public int GetInt() => 4;
    }
}