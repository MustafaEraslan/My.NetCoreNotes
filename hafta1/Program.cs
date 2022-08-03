using System;
using System.Collections.Generic;

namespace hafta1
{
    class Program
    {

        static void Main(string[] args)
        {
            #region STACK HEAP - REFERENCE TYPE
            //A a = new A(); //Stack bölgesinde değişken açıyor
            //a.i = 5; // heap tamam değer geldi diyip işaret gösteriyor

            //A b = a;
            //b.i = 20;

            //Console.WriteLine(a.i);
            //Console.WriteLine(b.i);


            //int x = 5;
            //int y = x;


            //y = 500;

            //Console.WriteLine(x);
            //Console.WriteLine(y);


            //A a = new A(); // A nesnesi oluşturdum.
            //a.i = 2;


            //A b = new A();
            //b.i = 6;

            //A c = b;
            //c.i = a.i;


            //Console.WriteLine(a.i);
            //Console.WriteLine(b.i);
            //Console.WriteLine(c.i);
            #endregion

            #region GOTO KEYWORD
            //var a = Sehirler.Ankara;

            //switch (a)
            //{
            //    case Sehirler.Adana:
            //        break;
            //    case Sehirler.Ankara:
            //        goto case Sehirler.Istanbul;
            //    case Sehirler.Antalya:
            //        break;
            //    case Sehirler.Istanbul:
            //        Console.WriteLine(" İstanbul !"); break;
            //    default:
            //        break;
            //}
            #endregion

            #region LOGICAL NEGOTATION
            //bool passed = false;

            //passed = !passed;
            //passed = !passed;
            //#endregion
            //#region NULL COALSING ASSIGMENT
            //int? a = null;
            //List<int> lista = new List<int>();
            //lista.Add(a ??= 0);
            #endregion

            #region BOXING UNBOXING
            //List<int> listb = new List<int>();
            //object obj = listb;

            //List<int> listc = (List<int>)obj;
            #endregion
            #region EXCEPTION
            try
            {
                ThrowEx();
            }
            catch (Exception _)
            {
                Console.WriteLine(_.Message);
            }


            try
            {
                //var arr = new int[] { 1, 2, 3, 4 };
                //Console.WriteLine(arr.GetValue(5));

                var obj = new { a = 1, b = 2 };
                obj = null;

                Console.WriteLine(obj.a);
            }
            catch (IndexOutOfRangeException e)
            {

            }
            catch (NullReferenceException e)
            {

            }
            catch (CustomException e)
            {

            }
            #endregion
            List<int> numbers = null;
            int? a = null;

            (numbers ??= new List<int>()).Add(5);
            Console.WriteLine(string.Join(" ", numbers));

            numbers.Add(a ??= 0);
            Console.WriteLine(string.Join(" ", numbers));
            Console.WriteLine(a);
        }

        static void ThrowEx()
        {
            try
            {
                throw new Exception("Try Exception");
            }
            catch (Exception _)
            {
                throw new Exception("Catch Exception");
            }
            finally
            {
                throw new Exception("Finally Exception");
            }
        }


    }

    class CustomException : Exception
    {
        CustomException(string msg) : base(msg) { }
    }

    public class A
    {
        //readonly int y = 2;
        //const int x = 3;
        //public A()
        //{
        //    y = 6;
        //}

        //public void func()
        //{
        //    y = 5;
        //}

        public int i { get; set; }
    }

    public enum Sehirler
    {
        Adana = 1,
        Ankara = 6,
        Antalya = 7,
        Istanbul = 34
    }
}