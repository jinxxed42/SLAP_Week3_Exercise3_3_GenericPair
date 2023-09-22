using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace SLAP_Week3_Exercise3_3_GenericPair
{
    internal class Pair<T1, T2> : IComparable<Pair<T1, T2>> where T1 : IComparable<T1> where T2 : IComparable<T2>
    {
        public T1? Arg1 { get; set; }
        public T2? Arg2 { get; set; }

        public Pair()
        {
        }

        public Pair(T1 t1, T2 t2)
        {
            Arg1 = t1;
            Arg2 = t2;
        }
       
        public void Clear()
        {
            Arg1 = default(T1)!; // Suppress null warning
            Arg2 = default(T2)!;
        }

        public override string ToString()
        {
            if (Arg1 == null && Arg2 == null) { return "null, null"; }
            else if (Arg1 == null) { return string.Format("{0}, {1}", "null", Arg2!.ToString()); } // Suppress null warning. Will have been caught above.
            else if (Arg2 == null) { return string.Format("{0}, {1}", Arg1.ToString(), "null"); }
            return string.Format("{0}, {1}", Arg1.ToString(), Arg2.ToString());
        }


        public int CompareTo(Pair<T1, T2>? other)
        {
            // By definition null always compares greater or comes before any non-null values.
            if (other == null) return 1;
            int result = Comparer<T1>.Default.Compare(Arg1, other.Arg1);

            if (result != 0) return result;
            else return Comparer<T2>.Default.Compare(Arg2, other.Arg2);                     
        }
    }
}
