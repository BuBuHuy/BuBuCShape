using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CsharpBasic
{
    class IEnumerableDemo
    {
        static void a()
        {
            int[] numbers = { 6, 77, 6, 1, 9, 11, 11, 18, 9 };

            // Loại bỏ các phần tử trùng nhau
            IEnumerable<int> query = (from num in numbers
                                      select num).Distinct();
            //Cách 2:  
            //IEnumerable<int> query = numbers.Distinct();
            foreach (int str in query)
                Console.WriteLine(str.ToString());

        }
        static void b()
        {
            int[] numbers1 = { 6, 77, 6, 1, 9, 11, 11, 18, 9 };
            int[] numbers2 = { 6, 8, 77, 12, 18, 7 };

            // Loại bỏ các phần tử trùng nhau
            IEnumerable<int> query = (from num1 in numbers1
                                      select num1).Intersect(from num2 in numbers2 select num2);

            // Cách 2: IEnumerable<int> query = numbers1.Intersect(numbers2);
            // Cách 3: IEnumerable<int> query = numbers1.Select(x => x).Intersect(numbers2.Select(x => x));

            foreach (int item in query)
                Console.WriteLine(item);
        }
        static void c(){
            System.Collections.ArrayList items = new System.Collections.ArrayList(4);
            items.Add("Shoes");
            items.Add("Clothes");
            items.Add(15.5); // kiểu số

            // Áp dụng OfType() vào ArrayList để tìm các phần tử là kiểu chuỗi
            IEnumerable<string> query1 = items.OfType<string>();

            // Xuất danh sách các phần tử kiểu chuỗi trong 1 ArrayList
            foreach (string item in query1)
                Console.WriteLine(item);
        }
        static void d()
        {
            int[] numbers1 = { 6, 77, 6, 1, 9, 11, 11, 18, 9 };

            // Hợp nhất các phần tử của 2 tập hợp
            IEnumerable<int> query = from num in numbers1
                                     where num > 5 && num < 10
                                     select num;
            foreach (int item in query)
                Console.WriteLine(item);
        }
        static void e()
        {
            List<string> listNames = new List<string>() { "Adam", "Adar", "Anderson", "Bob" };

            // Kiểm tra tất cả các tên bắt đầu bằng vần A hay không?
            bool result = listNames.All(x => x.StartsWith("A"));

            Console.WriteLine("All names start with letter A? " + result);
        }
        static void f()
        {
            // www.dammio.com
            List<string> listNames = new List<string>() { "Adam", "Adar", "Anderson", "Bob" };

            // Kiểm tra xem ít nhất có 1 tên bắt đầu bằng vần B hay không?
            bool result = listNames.Any(x => x.StartsWith("B"));

            Console.WriteLine("Any names start with letter B? " + result);

            /* Đoạn mã cho ra kết quả: 
               Any names start with letter B? True
            */
        }
        static void g()
        {
            // www.dammio.com
            List<string> names = new List<string>() { "welcome", "to", "dammio", "dot", "com" };

            // Lấy chữ cái đầu của từng phần tử 
            var query = from name in names
                        select name.Substring(0, 1);

            foreach (string s in query)
                Console.WriteLine(s);

            /* Đoạn mã cho ra kết quả: 
                w 
                t   
                d
                d
                c
            */
        }
        static void h()
        {
            // www.dammio.com
            List<string> names = new List<string>() { "welcome to", "dammio dot com" };

            // Lấy chữ cái đầu của từng phần tử 
            var query = from name in names
                        from word in name.Split(' ')
                        select word;

            foreach (string s in query)
                Console.WriteLine(s);
        }
        static void j()
        {
            List<int> numbers = new List<int> { 1, 6, 8, 10, 14 };

            // bỏ qua 1 phần tử đầu tiên
            var query1 = numbers.Skip(1);

            // bỏ qua các phần tử < 8 cho đến khi gặp phần tử >= 8 thì lấy tất cả phần tử tiếp theo
            var query2 = numbers.SkipWhile(x => x < 8);

            // lấy 3 phần tử đầu tiên trong danh sách
            var query3 = numbers.Take(3);

            // lấy các phần tử trong khi < 7, nếu gặp phần tử >= 7 thì dừng
            var query4 = numbers.TakeWhile(x => x < 7);

            foreach (var item1 in query1)
                Console.WriteLine(item1);
            Console.WriteLine("-----------");

            foreach (var item2 in query2)
                Console.WriteLine(item2);
            Console.WriteLine("-----------");

            foreach (var item3 in query3)
                Console.WriteLine(item3);
            Console.WriteLine("-----------");

            foreach (var item4 in query4)
                Console.WriteLine(item4);

        }
        static void k()
        {
            List<int> numbers = new List<int>() { 5, 8, 20, 18, 77, 4, 19, 29 };

            // gom nhóm các số vào theo chẵn, lẻ
            IEnumerable<IGrouping<int, int>> query = from number in numbers
                                                     group number by number % 2;

            foreach (var group in query)
            {
                Console.WriteLine(group.Key == 0 ? "\nCác số chẵn:" : "\nCác số lẻ:");
                foreach (int i in group)
                    Console.WriteLine(i);
            }
        }
        static void Main(string[] args)
        {
            k   ();
            Console.ReadKey();
        }
    }
}
