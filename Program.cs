namespace CollectionDemo
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to c# collection!");
            Demo.doListDemo();
            Demo.doStackDemo();
            Demo.doDictionaryDemo();
            Demo.doQueueDemo();
            Demo.doSetDemo();
            Console.ReadKey();
        }
    }
}