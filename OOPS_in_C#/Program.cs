using OOPS_in_C_;
using System;
namespace OOPS_in_C_
{
    internal class InternalProj
    {
        internal InternalProj() {
            Console.WriteLine("Works in same project or dll or aseembly commonly known as exe");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            new Classes();
        }
    }
}