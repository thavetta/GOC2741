using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JenJeden
{
    /// <summary>
    /// Call Singleton5 - elegantní plně lazy load řešení s využitím .NET chování
    /// </summary>
    public sealed class Singleton5
    {
        private Singleton5()
        {
        }

        public static Singleton5 Instance => Nested.instance; 

        private class Nested
        {
            // Explicit static constructor to tell C# compiler
            // not to mark type as beforefieldinit
            static Nested()
            {
            }

            internal static readonly Singleton5 instance = new Singleton5();
        }
    }
}
