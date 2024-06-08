namespace S1
{
    class s1
    {
        static void Main(string[] args)
        {
            if (args.Length == 3)
            {
                if (float.TryParse(args[0], out float value1) && float.TryParse(args[2], out float value2))
                {
                    switch (args[1])
                    {
                        case "*":
                            Console.WriteLine(value1 * value2);
                            break;

                        case "/":
                            if (value2 != 0)
                            {
                                Console.WriteLine(value1 / value2);
                            }
                            else Console.WriteLine("я не могу поделить на 0");
                            break;

                        case "+":
                            Console.WriteLine(value1 + value2);
                            break;

                        case "-":
                            Console.WriteLine(value1 - value2);
                            break;

                        default:
                            Console.WriteLine("Используй только + - / *");
                            break;

                    }
                }
                else Console.WriteLine("Первое и второе значение должны быть числами");
            }
            else Console.WriteLine("Формат ввода a + b, a - b, a / b, a * b");
        }
    }
}
