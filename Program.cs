using System;

namespace zadanie1
{
    class lib1
    {
        public string stpow(string a, int b)
        {
            string d = a;
            for(int i = 0; i < b; i++) { d += a; }
            return d;
        }
        public string rev(string a)
        {
            int b = a.Length;
            string z = "";
            for (int i = b - 1; i >= 0; i--) { z += a[i]; }
            return z;
        }
        public string remov(string str, string s)
        {
            for(int i = 0; i < str.Length; i++) { str = str.Replace(s, ""); }
            return str;
        }
        public int leng(string str)
        {
            int a = str.Length;
            return a;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            lib1 la = new lib1();
            Console.WriteLine(la.stpow("Ha", 6));
            Console.WriteLine(la.rev("Hant"));
            Console.WriteLine(la.remov("Hhhhello", "h"));
            Console.WriteLine(la.leng("Hant"));
        }
    }
}
