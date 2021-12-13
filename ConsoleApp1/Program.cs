using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.Text.RegularExpressions;
using DSA.DesignPattern;
using System.Threading;
using System.IO;
using System.Collections.Concurrent;
using DSA.Practice;

namespace DSA
{

    public class Program
    {
        void Practice<T>(T variable)
        {
            List<int> n = (List<int>)Convert.ChangeType(variable, typeof(List<int>));
            foreach (int i in n)
            {
                Console.WriteLine(i);
            }
            n = null;
        }

        void Practice(string[] q)
        {
            for (int i = 0; i < q.Length; i++)
            {
                q[i] = "123";
            }
        }

        void Practice(string s)
        {
            s = "13";
        }
        public IEnumerable<int> Get()
        {
            int size = 2;
            int skip = 2;

            IEnumerable<int> list = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            //while (list.Any())
            {
                //return list.Skip(skip).Take(size);
            }
            foreach (int i in list)
            {
                yield return i;
            }

        }

        void Th()
        {
            Console.WriteLine("fsefse");
        }
        int s = 0;
        public bool dfs(int[] arr)
        {
            return false;
        }

        void Practice(int[] arr)
        {

        }

        static void nunum()
        {
            Console.WriteLine("nunun");
        }

        void ParallelF()
        {
            List<int> smallList = new List<int>() { 98, 76, 6, 51, 5, 4, 3 };
            var source = Enumerable.Range(0, 100).ToArray();
            var rangePartition = Partitioner.Create(9, source.Length);
            var results = new int[source.Length];
            Parallel.ForEach(rangePartition, (range, loopState) =>
            {
                for (int i = range.Item1; i < range.Item2; i++)
                {
                    results[i] = source[i] + 1;
                }
            });
            var jey = Console.ReadLine();
            if (jey.ToLower() == "yes")
            {
                Console.WriteLine("yes");
            }

            Parallel.ForEach(smallList, i =>
            {
                Console.WriteLine(i);
            }
            );
            Parallel.For(0, smallList.Count, i =>
            {
                Console.WriteLine(smallList[i]);
            }
            );

            Parallel.For(0, 100, (i, j) =>
            {
                Console.WriteLine(j);
                Console.WriteLine(i);
            }
            );
            Parallel.ForEach(smallList, i =>
            {
                i.ToString();
            });

            var g = 0;
            Parallel.ForEach(smallList, () => 0, (i, loopState, local) =>
            {
                if (local == 123)
                {
                    loopState.Break();
                }
                local += smallList[i];
                return local;
            },
            (x) => Interlocked.Add(ref g, x)
            );
            Task task = new Task(() => Console.WriteLine("a"));

        }

        static void Main(string[] args)
        {
            Program program = new Program();

            int[] nums1 = { 0, 3, 0, 6, 3, 3, 4 };
            string[] nums2 = { "a", "b", "c" };
            List<List<int>> bigList = new List<List<int>>();
            List<int> smallList = new List<int>() { 98, 76, 6, 51, 5, 4, 3 };
            HashSet<int> set = new HashSet<int>();
            Dictionary<int, int> map = new Dictionary<int, int>();
            int length = nums1.Length;
            List<int> ans = new List<int>();
            Queue<int> queue = new Queue<int>();
            Stack<int> stack = new Stack<int>();
            LinkedList<int> llist = new LinkedList<int>();
            IQueryable q = ans.AsQueryable();
            DesignPattern.Animal animal = new DesignPattern.Dog();
            animal.GetAnimal();
            DesignPattern.Animal animal2 = new DesignPattern.Cat();
            animal2.GetAnimal();
            ArrayList arrayList = new ArrayList() { "asd", 2, new int[4] };


            string _string = "ababcbacadefegdehijhklij";
            _string.Remove(_string.IndexOf(""), 1);
            _string.TrimStart('0');
            program.Practice(nums1);

            // iterator
            var k = program.Get();
            foreach (int i in k)
            {
                Console.WriteLine(i);
            }


            Console.ReadLine();


            //parallel
            program.ParallelF();

            //lazy

            //async

            //lock

            //IO

            using (StreamReader reader = new StreamReader("D:\\Git\\leecode\\done.txt"))
            {
                reader.ReadToEnd();
                var dftk = reader.ReadToEnd();
                var r6t6ghtr = reader.Peek();
            }

            //extension method
            Cat cat = new Cat();
            cat.method();
        }
        public enum EnumName
        {
            one = 1,
            two,
            three,
            one2 = one
        }
        private void PracticeRefOut(ref int a, out int b)
        {
            a = a + 5;
            b = 10;

        }
        private (int x, int y) MyTuple(int k)
        {
            return (k + 1, k - 1);
        }

        private void InvokeEightQueen()
        {
            EightQueens eightQueens = new EightQueens();

            int n = int.Parse(Console.ReadLine());
            var graph = eightQueens.GetResult(n);
            foreach (var ch in graph)
            {
                int br = 0;
                foreach (var s in ch)
                {
                    Console.Write(s);
                    br++;
                    if (br % n == 0)
                    {
                        Console.WriteLine();
                    }
                }
            }
        }

    }

    static class ExtenionMethod
    {
        public static void method(this Cat cat)
        {
            Console.WriteLine("asd");
        }
    }
}
