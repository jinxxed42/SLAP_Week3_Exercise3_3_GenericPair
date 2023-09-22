namespace SLAP_Week3_Exercise3_3_GenericPair
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Testing PairList and sorting with two strings.");
            Console.WriteLine();
            PairList<string, string> pl = new();
            pl.Add("s", "b");
            pl.Add("a", "c");
            pl.Add("b", "d");
            pl.Add("b", null!);
            pl.Add("s", "a");
            pl.Add(null!, "t");

            Console.WriteLine("Before sort:");
            Console.WriteLine();
            foreach (var s in pl.Pairs)
            {
                Console.WriteLine(s.ToString());
            }
            Console.WriteLine("-----------");

            pl.Sort();

            Console.WriteLine("After sort:");
            Console.WriteLine();
            foreach (var s in pl.Pairs)
            {
                Console.WriteLine(s.ToString());
            }
            Console.WriteLine("-----------");

            Console.WriteLine("Testing clear method, before sort:");
            Console.WriteLine();
            pl.Pairs[2].Clear();

            foreach (var s in pl.Pairs)
            {
                Console.WriteLine(s.ToString());
            }
            Console.WriteLine("-----------");

            pl.Sort();
            Console.WriteLine("After sort:");
            Console.WriteLine();
            foreach (var s in pl.Pairs)
            {
                Console.WriteLine(s.ToString());
            }

            Console.WriteLine();
            Console.WriteLine("-----------");
            Console.WriteLine();

            Console.WriteLine("Testing PairList and sorting with int and string.");
            Console.WriteLine();

            PairList<int, string> pl2 = new();
            pl2.Add(-3, "b");
            pl2.Add(4, "c");
            pl2.Add(4, "d");
            pl2.Add(-3, null!);
            pl2.Add(7, "a");
            pl2.Add(1, "t");

            Console.WriteLine("Before sort:");
            Console.WriteLine();
            foreach (var s in pl2.Pairs)
            {
                Console.WriteLine(s.ToString());
            }
            Console.WriteLine("-----------");

            pl2.Sort();

            Console.WriteLine("After sort:");
            Console.WriteLine();
            foreach (var s in pl2.Pairs)
            {
                Console.WriteLine(s.ToString());
            }
            Console.WriteLine("-----------");

            Console.WriteLine("Testing clear method, before sort:");
            Console.WriteLine();
            pl2.Pairs[2].Clear();

            foreach (var s in pl2.Pairs)
            {
                Console.WriteLine(s.ToString());
            }
            Console.WriteLine("-----------");

            pl2.Sort();
            Console.WriteLine("After sort:");
            Console.WriteLine();
            foreach (var s in pl2.Pairs)
            {
                Console.WriteLine(s.ToString());
            }
           
            Console.WriteLine();
            Console.WriteLine("-----------");
            Console.WriteLine();

            Console.WriteLine("Testing PairList and sorting with DateTime and int.");
            Console.WriteLine();

            PairList<DateTime, int> pl3 = new();
            pl3.Add(new DateTime(2019, 4, 3), 7);
            pl3.Add(new DateTime(2019, 4, 3), 3);
            pl3.Add(new DateTime(2014, 7, 1), 15);
            pl3.Add(new DateTime(2023, 12, 12), 0);
            pl3.Add(new DateTime(2012, 7, 5, 17, 18, 19), 7);
            pl3.Add(new DateTime(2012, 7, 5, 14, 15, 16), 7);

            Console.WriteLine("Before sort:");
            Console.WriteLine();
            foreach (var s in pl3.Pairs)
            {
                Console.WriteLine(s.ToString());
            }
            Console.WriteLine("-----------");

            pl3.Sort();

            Console.WriteLine("After sort:");
            Console.WriteLine();
            foreach (var s in pl3.Pairs)
            {
                Console.WriteLine(s.ToString());
            }
            Console.WriteLine("-----------");

            Console.WriteLine("Testing clear method, before sort:");
            Console.WriteLine();
            pl3.Pairs[2].Clear();

            foreach (var s in pl3.Pairs)
            {
                Console.WriteLine(s.ToString());
            }
            Console.WriteLine("-----------");

            pl3.Sort();
            Console.WriteLine("After sort:");
            Console.WriteLine();
            foreach (var s in pl3.Pairs)
            {
                Console.WriteLine(s.ToString());
            }

            Console.WriteLine();
            Console.WriteLine("-----------");
            Console.WriteLine();
        }
    }
}