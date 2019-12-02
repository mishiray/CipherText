using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeftRotation
{
    class Program
    {
        public void shift(int[] a, int d)
        {
            Queue<int> q = new Queue<int>();
            List<int> temp = a.ToList();
            for (int i = 0; i < d; i++)
            {
                q.Enqueue(a[i]);
                temp.Remove(a[i]);
            }
            int[] arr = q.ToArray();
            for (int i = 0; i < q.Count; i++)
            {

                temp.Add(arr[i]);
            }
            foreach (int c in temp)
            {
                Console.Write(c + " ");
            }

        }

        static void Main(string[] args)
        {
            string[] nd = Console.ReadLine().Split(' ');

            int n = Convert.ToInt32(nd[0]);

            int d = Convert.ToInt32(nd[1]);

            int[] a = Array.ConvertAll(Console.ReadLine().Split(' '), aTemp => Convert.ToInt32(aTemp))
            ;

            Program pee = new Program();

            pee.shift(a,d);
            Console.ReadLine();
        }

    }
}
