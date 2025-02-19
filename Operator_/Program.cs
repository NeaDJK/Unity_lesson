namespace Operator_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int age = 16;
            Console.Write("Введите ваш рост: ");
            float.TryParse(Console.ReadLine(), out float height);

            Console.Write("Введите ваш вес: ");
            float.TryParse(Console.ReadLine(), out float weight);

            float BMI = weight / (height * height);

            Console.WriteLine(BMI);
        }
    }
}
