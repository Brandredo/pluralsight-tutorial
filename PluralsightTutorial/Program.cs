using System;

namespace Startup
{

    public class HelloWorld
    {
        public int Num { get; init; }
        public string Name { get; set; } = "brandon";
    }

    public class Startup
    {

        public static void Main(string[] args)
        {

            Stack<int> stack = new Stack<int>();

            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);
            stack.Push(5);


            Dictionary<string, int> dic = new();
            while(stack.Any())
            {
                int num = stack.Pop();
                Console.WriteLine(num);
                dic.Add("brandon" + num, num);
            }

            foreach(var item in dic)
            {
                Console.WriteLine(item);
            }
        }

    }
}