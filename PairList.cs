using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace SLAP_Week3_Exercise3_3_GenericPair
{
    internal class PairList<T1, T2> where T1 : IComparable<T1> where T2 : IComparable<T2>
    {

        public List<Pair<T1, T2>> Pairs { get; set; }

        public PairList()
        {
            Pairs = new();
        }

        public void Add(T1 t1, T2 t2)
        {
            Pairs.Add(new Pair<T1, T2>(t1, t2));
        }

        public void Sort()
        {
            Pairs.Sort();
        }


    }
}
