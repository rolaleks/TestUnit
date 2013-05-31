using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
namespace TestUnit
{
    [TestFixture]
    class Program
    {
        static void Main(string[] args)
        {
        }
        static int Divide(int a, int b)
        {
            if(b==0){
                throw new DivideByZeroException(); 
            }else{
     
            return a / b;
            }

        }
        static int count = 0;
        static string[] Arr(String s) {

            string[] words = s.Split(' ');
            return words;
        }
        static void Incr()
        {

            count++;
        }

        [Test]
        public static void MyTestFunc(){       
            ///2 переменные-аргумента
            int a = 2, b = 3;           
            Assert.AreEqual(a / b, Divide(a, b));
        }

        [Test]
         public static void Exception()
        {
            int a = 2, b = 0;
            Assert.That(() => Divide(a, b), Throws.TypeOf<DivideByZeroException>());
        }

        [Test]
        public static void Type()
        {
            int a = 2, b = 1;
            Assert.IsInstanceOf<int>(Divide(a, b));          
        }

        [Test]
        public static void Array()
        {
            String s = "Hello world !";
            Assert.That(Arr(s), Is.All.Not.Null);
            Assert.That(Arr(s), Is.All.InstanceOfType(typeof(string)));
        }

        [Test]
        public static void Incrcount()
        {
            int c = count;
            Incr();
            Assert.AreEqual(c + 1,count );          

        }
    }


}
