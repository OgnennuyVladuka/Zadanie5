namespace z5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите предложение без знаков препинаний:");
            string s = Console.ReadLine();
            string[] names = s.Split(' ');
            int dlin = names.Length;
            int indexofmax = 0;
            for (int i = 0; i < dlin; i++)
            {
                if (names[i].Length > names[indexofmax].Length)
                {
                    indexofmax = i;
                }
            }
            Console.WriteLine("Самое длинное слово:\r\n" +
                (names[indexofmax]));
        }
    }
}