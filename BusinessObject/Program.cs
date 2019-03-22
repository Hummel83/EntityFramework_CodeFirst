using System;
using System.Linq;
using Repo.MsAccess;


namespace BusinessObjectLib
{
    

    using MsAccess;

    internal static class Solution
    {
        public static void Main()
        {
            Mirgationstart.Muh();
            Console.WriteLine(@"Migration fertig");
            Console.ReadKey();
        }
    }
}
