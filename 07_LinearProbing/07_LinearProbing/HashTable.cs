using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_LinearProbing
{
    public class HashTable
    {
        private KeyValuePair<string, double>[] ht;

        public HashTable(int size)
        {
            int m = (int)Math.Round(size * 1.3);
            if(m % 2 == 0) m++;
            while(!isPrime(m)) m += 2;

            ht = new KeyValuePair<string, double>[m];
        }

        private bool isPrime(int m)
        {
            for (int i = 3; i < Math.Sqrt(m); i += 2)
            {
                if(m % i == 0) return false;
            }
            return true;
        }

        public double GetPrice(string key)
        {
            return ht[HashFunction(key)].Value;
        }

        public void AddItem(string key, double value)
        {
            //check if spot taken
            //if taken search for next open spot
            int spot = HashFunctionHorner(key);
            if(ht[spot].Key != null)
            {
                spot = NextSpot(spot);
            }

            if (spot != -1)
            {
                ht[spot] = new KeyValuePair<string, double>(key, value);
            }
            else
            {
                Console.WriteLine("Resize HashTable");
            }
        }

        private int NextSpot(int spot)
        {
            for(int i = spot; i < ht.Length; i++)
            {
                if (ht[i].Key == null) return i;
            }
            for(int i = 0; i < spot; i++)
            {
                if (ht[i].Key == null) return i;
            }
            return -1;
        }

        private int HashFunction(string s)
        {
            int h = 0;
            foreach (char c in s) h += (int)c;
            return h % ht.Length;
        }

        private int HashFunctionHorner(string s)
        {
            long h = 0;
            foreach (char c in s) h = (31 * h) + (int)c;
            return (int)(h % ht.Length);
        }

        private int HashFunction(int i)
        {
            return i % ht.Length;
        }

        public override string ToString()
        {
            string s = "";
            foreach(KeyValuePair<string, double> kvp in ht)
            {
                s += kvp.Key + " " + kvp.Value + "\n";
            }
            return s.Remove(s.Length -1,1);
        }
    }
}
