using System;
using System.Collections.Generic;
using System.Linq;
namespace AlgorithmAndDS.Linq
{
    public class SampleLinq
    {
        private readonly List<Product> _product = new List<Product>
        {
            new Product{Id=1,Name="L1",CatgeoryId=1,DeptId=2},
            new Product{Id=2,Name="L2",CatgeoryId=2,DeptId=4},
            new Product{Id=3,Name="L3",CatgeoryId=2,DeptId=4},
            new Product{Id=4,Name="L4",CatgeoryId=1,DeptId=3},
            new Product{Id=5,Name="L5",CatgeoryId=2,DeptId=1},
            new Product{Id=6,Name="L6",CatgeoryId=1,DeptId=4},
        };
        private readonly List<Catgeory> _catgeory = new List<Catgeory>
        {
            new Catgeory{Id=1,Name="C1"},
            new Catgeory{Id=2,Name="C2"},
        };
        private readonly List<Dept> _dept = new List<Dept>
        {
            new Dept{Id=1,Name="D1"},
            new Dept{Id=2,Name="D2"},
            new Dept{Id=3,Name="D3"},
            new Dept{Id=4,Name="D4"},
        };

        public void PrintPorducts(int? catId = null, int? DeptId = null)
        {
           
            if (!catId.HasValue && !DeptId.HasValue)
            {
                Console.WriteLine("__________All product___________");
                var result = (from p in _product
                             join c in _catgeory
                                  on p.CatgeoryId equals c.Id
                             join d in _dept
                                  on p.DeptId equals d.Id
                             select new
                             {
                                 p.Id,
                                 p.Name,
                                 CName=  c.Name,
                                 DName= d.Name
                             }).ToList();
                foreach (var item in result)
                {
                    Console.WriteLine("ProductName:" + item.Name);
                    Console.WriteLine("CatgegoryName:" + item.Name);
                    Console.WriteLine("DeptNameName:" + item.Name);
                   

                }

            }

            if (!DeptId.HasValue && catId.HasValue)
            {
                Console.WriteLine("__________Cat product___________");
                var resultC = (from p in _product
                              join c in _catgeory
                                   on p.CatgeoryId equals c.Id
                              join d in _dept
                                   on p.DeptId equals d.Id where p.CatgeoryId== catId.Value
                              select new
                              {
                                  p.Id,
                                  p.Name,
                                  CName = c.Name,
                                  DName = d.Name
                              }).ToList();
                foreach (var item in resultC)
                {
                    Console.WriteLine("ProductName:" + item.Name);
                    Console.WriteLine("CatgegoryName:" + item.Name);
                    Console.WriteLine("DeptNameName:" + item.Name);

                }

            }

            if (DeptId.HasValue && !catId.HasValue)
            {
                Console.WriteLine("__________Dept product___________");
                var resultC = (from p in _product
                               join c in _catgeory
                                    on p.CatgeoryId equals c.Id
                               join d in _dept
                                    on p.DeptId equals d.Id
                               where p.DeptId == DeptId.Value
                               select new
                               {
                                   p.Id,
                                   p.Name,
                                   CName = c.Name,
                                   DName = d.Name
                               }).ToList();
                foreach (var item in resultC)
                {
                    Console.WriteLine("ProductName:" + item.Name);
                    Console.WriteLine("CatgegoryName:" + item.Name);
                    Console.WriteLine("DeptNameName:" + item.Name);
                }

            }
          
            if (DeptId.HasValue && catId.HasValue)
            {
                Console.WriteLine("__________Dept Cat product___________");
                var resultC = (from p in _product
                               join c in _catgeory
                                    on p.CatgeoryId equals c.Id
                               join d in _dept
                                    on p.DeptId equals d.Id
                               where p.DeptId == DeptId.Value &&  p.CatgeoryId==catId.Value
                               select new
                               {
                                   p.Id,
                                   p.Name,
                                   CName = c.Name,
                                   DName = d.Name
                               }).ToList();
                foreach (var item in resultC)
                {
                    Console.WriteLine("ProductName:" + item.Name);
                    Console.WriteLine("CatgegoryName:" + item.Name);
                    Console.WriteLine("DeptNameName:" + item.Name);
                }

            }
        }

        public void ArrayExample()
        {
            int[] intArry = { 1, 4, 2, 6, 9, 3, 4 };
            var sort = (from ar in intArry orderby ar select ar);
            One();
        }
        public void One()
        {
           
            //1display the lengt of word whose lengh is less then 5
            string[] word = { "hello", "linq", "prasanta", "madhu", "world", "Welcome", "ASS" };
            var lenght5 = from w in word where w.Length <= 5 select w;
            foreach (var lvlw in lenght5)
            {
                Console.WriteLine(lvlw.ToString() + Environment.NewLine);
            }

            //2 Display the word whose contain the letter a.
            var laterA = (from w in word where w.Contains('a') || w.Contains('A') select w).ToList();
            foreach (var item in word)
            {
                if (item.Contains('a'))
                {
                    Console.WriteLine(item.ToString() + Environment.NewLine);
                }
            }

            //3 Display word which start with w
            foreach (var item in word)
            {
                if (item.StartsWith("w", StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine(item.ToString() + Environment.NewLine);
                }
            }

            //4 Display the word order by there length.

            var laterOrderBy = (from w in word orderby w.Length descending select w).ToList();
            List<string> s = new List<string>();
            string it = string.Empty;
            foreach (var item in word)
            {
                it = item;
                foreach (var nitem in word)
                {
                    if (it.Length < nitem.Length)
                    {
                        s.Add(nitem);
                        break;
                    }
                }
            }
            foreach (var item in s)
            {
                Console.WriteLine(item.ToString() + Environment.NewLine);
            }
        }
        public void Two()
        {
            //word sort
            string[] words = { "Elephant", "umbrila", "apple", "Aeropleane" };
            var wordsort = from w in words orderby w select w;
            foreach (var item in wordsort)
            {
                 Console.WriteLine(item + Environment.NewLine);
            }
        }
        public void Three()
        {
            //Find all element in the arry less then 5********************************************
            int[] num = { 1, 8, 2, 29, 18 };
            var numles5 = from n in num where n < 5 select n;
            foreach (var item in numles5)
            {
                Console.WriteLine(item.ToString() + "</br>");
            }

            //OR
            //for (int i = 0; i < num.Length; i++)
            //{
            //    if (num[i]<5)
            //    {
            //           Console.WriteLine(num[i].ToString() + "</br>");
            //    }
            //}

            //or
            //foreach (var item in num)
            //{
            //    if (item<5)
            //    {
            //         Console.WriteLine(item.ToString() + "</br>");
            //    }
            //}

            //2 Find te bigest Number*************************************************************
            Console.WriteLine(num.Max().ToString());
            //OR

            //var big = (from n in num orderby n descending select n).ToList().Take(1);
            //foreach (var item in big)
            //{
            //     Console.WriteLine("Big"+item.ToString()+Environment.NewLine);
            //}


            //var big = (from n in num orderby n descending select n).ToList().Take(3);
            //foreach (var item in big)
            //{
            //     Console.WriteLine("Big" + item.ToString() + Environment.NewLine);
            //}

            //var small = (from n in num orderby n ascending select n).ToList().Take(1);
            //foreach (var item in small)
            //{
            //     Console.WriteLine("Small"+item.ToString());
            //}
            // //Find the element in the array less them 5*************************************************************

            var no5 = num.TakeWhile(n => n < 5).ToList();

            var no51 = num.SkipWhile(n => n < 5).ToList();

            // foreach (var item in no5)
            // {
            //      Console.WriteLine(item + Environment.NewLine);
            // }

            //3   Assending or Descending Order of array(big to small)**********************************************************

            //var order = from n in num orderby n descending select n;
            //    foreach (var item in order)
            //    {
            //         Console.WriteLine(item + Environment.NewLine);
            //    }

            //3   Assending or Descending Order of array(small  to big)


            //var order = from n in num orderby n ascending select n;
            //foreach (var item in order)
            //{
            //     Console.WriteLine(item + Environment.NewLine);
            //}



            //Reverise of array****************************************************************************

            for (int i = num.Length - 1; i >= 0; i--)
            {
                 Console.WriteLine(num[i].ToString() + Environment.NewLine);
            }
        }
        public void Four()
        {
            int[] num = { 1, 2, 3, 4, 56 };
            var eo = from n in num
                     select new
                     {
                         Digit = n,
                         Even = (n % 2 == 0)
                     };
            foreach (var item in eo)
            {
                Console.WriteLine(item.Digit.ToString());
                Console.WriteLine(item.Even ? "Even" : "Odd");
                Console.WriteLine(Environment.NewLine);
            }

            //OR
            //for (int i = 0; i < num.Length; i++)
            //{
            //    if (num[i] % 2 == 0)
            //    {
            //         Console.WriteLine(num[i].ToString() + ":Even"+Environment.NewLine);
            //    }
            //    else
            //    {
            //         Console.WriteLine(num[i].ToString() + ":Odd" + Environment.NewLine);
            //    }
            //}
        }
        public void Five()
        {
            int[] num = { 11, 2, 3, 4, 56 };
            //display first 2 element.

            //for (int i = 0; i < num.Length; i++)
            //{
            //    if (i<2)
            //    {
            //         Console.WriteLine(num[i].ToString()+Environment.NewLine);
            //    }
            //}

            //OR

            //var top2 = num.Take(2);
            //foreach (var item in top2)
            //{
            //     Console.WriteLine(item.ToString() + Environment.NewLine);
            //}


            //2display all element other then first 2 element.

            //var top2s = num.Skip(2);

            //foreach (var item in top2s)
            //{
            //     Console.WriteLine(item.ToString() + Environment.NewLine);
            //}

            //for (int i = 0; i < num.Length; i++)
            //{
            //    if (i > 1)
            //    {
            //         Console.WriteLine(num[i].ToString() + Environment.NewLine);
            //    }
            //}
        }
        public void Six()
        {
            //Retrive the second number grater then five.
            //int[] num = {  5, 10, 1, 2, 3, 4, 0,12,20,25,22,33 };
            //var pp = (from n in num where n > 5 select n).ToList();
            //int  numbers = (from n in num where n > 5 select n).ElementAt(2);
            // Console.WriteLine(numbers.ToString());

            ////Find even & odd number from 1o0 to 149.

            //var num = (from n in Enumerable.Range(100, 50)
            //           select new
            //               {
            //                   Number = n,
            //                   oddeven = n % 2 == 1 ? "odd" : "Even"
            //               });

            //foreach (var item in num)
            //{
            //     Console.WriteLine(item + Environment.NewLine);
            //}

            //Repeate to generate a sequency tat contai the number 7 ten timt
            //var num = Enumerable.Repeat(7, 10);
            //foreach (var item in num)
            //{
            //     Console.WriteLine(item.ToString() + Environment.NewLine);
            //}

            //Sortest word in the array
            string[] words = { "apple", "axe", "bool", "hane" };

            string s = words.Min();
            var vmin = from w in words where w.Length == words.Min(ww => ww.Length) select w;
             Console.WriteLine(vmin.FirstOrDefault().ToString());
            foreach (var item in vmin)
            {
                 Console.WriteLine(item);
            }

            //Avg

            //int[] num = { 5, 10, 1, 2, 3, 4, 0, 12, 20, 25, 22, 33 };
            //double avg = num.Average();
            // Console.WriteLine("avg" + avg.ToString());
            //var iii = 0;
            //iii = "LLL";
            dynamic j;
            j = 0;
            j = "ooo";

            object k;
            k = 1;
            k = "lll";

            //Concenent
            //int[] num1 = { 51, 101, 1, 2, 31, 41 ,01, 121, 201, 125, 122, 133 };
            //int[] num = { 5, 10, 1, 2, 3, 4, 0, 12, 20, 25, 22, 33 };
            //int tot = num.Length + num1.Length;
            // Console.WriteLine(tot.ToString()+Environment.NewLine);
            //var allnum = num.Concat(num1);
            // Console.WriteLine(allnum.ToList().Count.ToString() + Environment.NewLine);
            //foreach (var item in allnum)
            //{
            //     Console.WriteLine(item + Environment.NewLine);
            //}


            //int[] num={1,2,3};
            //int i=0;
            //var q = from n in num select ++i;
            //foreach (var item in q)
            //{
            //     Console.WriteLine(item + Environment.NewLine);
            //}

            // Console.WriteLine("--------------------" + Environment.NewLine);
            //int[] num1 = { 1, 2, 3 };
            //int i1 = 0;
            //var q1 = from n in num select ++i1;
            //foreach (var item in q1)
            //{
            //     Console.WriteLine(item + Environment.NewLine);
            //}
        }
        public void Seven()
        {
            object[] all = { null, 1.0, "two", 3, "Four", 'c', 2.1, 5, 'd' };

            var doub = all.OfType<double>();
             Console.WriteLine("Double" + Environment.NewLine);
            foreach (var item in doub)
            {
                 Console.WriteLine(item + Environment.NewLine);
            }
            var inte = all.OfType<int>();
             Console.WriteLine("int" + Environment.NewLine);
            foreach (var item in inte)
            {
                 Console.WriteLine(item + Environment.NewLine);
            }
            var str = all.OfType<string>();
             Console.WriteLine("string" + Environment.NewLine);
            foreach (var item in str)
            {
                 Console.WriteLine(item + Environment.NewLine);
            }
            var ch = all.OfType<char>();
             Console.WriteLine("char" + Environment.NewLine);
            foreach (var item in ch)
            {
                 Console.WriteLine(item + Environment.NewLine);
            }
        }
        public void Eight()
        {
            //// Remove Duplicate Value
            //int[] num = { 101,1,0,1,2,2,101};
            //var rdup = num.Distinct();
            // Console.WriteLine("Length" + num.Length +Environment.NewLine);
            // Console.WriteLine("Unique Length" + rdup.ToList().Count + Environment.NewLine);
            //foreach (var item in rdup)
            //{
            //     Console.WriteLine(item + Environment.NewLine);
            //}

            // union
            //int[] num = { 101, 1, 0, 1, 2, 2, 101 };
            //int[] num1 = { 102, 2, 1, 2, 3, 3, 102 };

            //var un = num.Union(num1);
            //foreach (var item in un)
            //{
            //     Console.WriteLine(item + Environment.NewLine);
            //}
            //common value of two list
            //int[] num = { 101, 1, 0, 1, 2, 2, 101 };
            //int[] num1 = { 102, 2, 1, 2, 3, 3, 102 };

            //var un = num.Intersect(num1);
            //foreach (var item in un)
            //{
            //     Console.WriteLine(item + Environment.NewLine);
            //}

            //Difference 

            int[] num = { 101, 1, 0, 1, 2, 2, 101 };
            int[] num1 = { 102, 2, 1, 2, 3, 3, 102 };

            var un = num.Except(num1);
            foreach (var item in un)
            {
                 Console.WriteLine(item + Environment.NewLine);
            }

        }
        public void Nine()
        {
            string[] num = { "aa", "bb", "cc", "dd", "ee", "ff" };
            //display first 2 element.

            for (int i = 0; i < num.Length; i++)
            {
                if (i < 2)
                {
                     Console.WriteLine(num[i].ToString() + Environment.NewLine);
                }
            }

            //OR

            //var top2 = num.Take(2);
            //foreach (var item in top2)
            //{
            //     Console.WriteLine(item.ToString() + Environment.NewLine);
            //}


            //2display all element other then first 2 element.

            //var top2s = num.Skip(2);

            //foreach (var item in top2s)
            //{
            //     Console.WriteLine(item.ToString() + Environment.NewLine);
            //}

            //for (int i = 0; i < num.Length; i++)
            //{
            //    if (i > 1)
            //    {
            //         Console.WriteLine(num[i].ToString() + Environment.NewLine);
            //    }
            //}
        }
    }

    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int CatgeoryId { get; set; }
        public int DeptId { get; set; }
    }
    public class Catgeory
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
    public class Dept
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
