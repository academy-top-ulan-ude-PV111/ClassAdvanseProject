namespace ClassAdvanseProject
{
    sealed class SealesClass 
    {

    }

    class Parent
    {
        public virtual void Method() 
        {
            Console.WriteLine("parent class");
        }
    }

    class SealedMethod : Parent
    {
        sealed public override void Method()
        {
            Console.WriteLine("saled method class");
        }
    }

    class Child : SealedMethod
    {
        //public override void Method()
        //{
        //    Console.WriteLine("childe class");
        //}
    }

    class MyString 
    {
        String str;

        public string ToUpper()
        {
            return str.ToUpper();
        }

        public int CountChar(char ch)
        {
            return str.Length;
        }
    }

    public static class StringExtension
    {
        public static int CountChar(this string str, char ch)
        {
            int countChar = 0;
            for (int i = 0; i < str.Length; i++)
                if (str[i] == ch)
                    countChar++;
            return countChar;
        }
    }

    internal partial class PartialClass
    {
        public int Age { set; get; }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            //Parent parent = new Child();
            //parent.Method();

            String s = "hello world";

            Console.WriteLine(s.CountChar('l'));

            PartialClass partialClass = new PartialClass();
            partialClass.Name = "Joe";
            partialClass.Age = 27;

            var obj = new { Title = "Yandex", City = "Moscow", Year = 2022 };
            Console.WriteLine(obj.GetType());
        }
    }
}