using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/**
 * System.IO.IOException Xử lý các I/O error
System.IndexOutOfRangeException Xử lý các lỗi được tạo khi một phương thức tham chiếu tới một chỉ mục bên ngoài dãy mảng
System.ArrayTypeMismatchException   Xử lý các lỗi được tạo khi kiểu là không phù hợp với kiểu mảng
System.NullReferenceException Xử lý các lỗi được tạo từ việc tham chiếu một đối tượng null
System.DivideByZeroException Xử lý các lỗi được tạo khi chia cho số 0
System.InvalidCastException Xử lý lỗi được tạo trong khi ép kiểu
System.OutOfMemoryException Xử lý lỗi được tạo từ việc thiếu bộ nhớ rỗi
System.StackOverflowException Xử lý lỗi được tạo từ việc tràn ngăn xếp (stack)
 * @author Bu Bu Huy
*/

namespace CsharpBasic
{
    class Temperature
    {
        int temperature = 0;
        public void showTemp()
        {
            if (temperature == 0)
            {
                throw (new TempIsZeroException("Muc nhiet do 0!!!"));
            }
            else
            {
                Console.WriteLine("Nhiet do: {0}", temperature);
            }
        }
    }
    class TempIsZeroException : ApplicationException
    {
        public TempIsZeroException(string message)
            : base(message)
        {
        }
    }
    class TestCsharp
    {
        //static void Main(string[] args)
        //{
        //    Console.WriteLine("Vi du minh hoa Xu ly ngoai le trong C#");
        //    Console.WriteLine("---------------------------------");

        //    Temperature temp = new Temperature();
        //    try
        //    {
        //        temp.showTemp();
        //    }
        //    catch (TempIsZeroException e)
        //    {
        //        Console.WriteLine("TempIsZeroException: {0}", e.Message);
        //    }

        //    Console.ReadKey();
        //}
        //    class TestCsharp
        //{
        //    int result;
        //    TestCsharp()
        //    {
        //        result = 0;
        //    }
        //    public void phepChia(int num1, int num2)
        //    {
        //        try
        //        {
        //            result = num1 / num2;
        //        }
        //        catch (DivideByZeroException e)
        //        {
        //            Console.WriteLine("Bat Exception: {0}", e);
        //        }
        //        finally
        //        {
        //            Console.WriteLine("Ket qua: {0}", result);
        //        }
        //    }
        //    static void Main(string[] args)
        //    {
        //        Console.WriteLine("Vi du minh hoa Exception trong C#");
        //        Console.WriteLine("---------------------------------");

        //        TestCsharp d = new TestCsharp();
        //        d.phepChia(25, 0);
        //        Console.ReadKey();
        //    }
        //}
    }
        class ExceptionHanding
    {
        
    }
}
