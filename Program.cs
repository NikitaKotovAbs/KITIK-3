namespace Pianino
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine("Переключение между октавами F1 - F2");
            Fine();


        }
        static void Fine()
        {
            bool Octave = true;
            int[] latter = new int[] { 261, 277, 293, 311, 329, 349, 369, 391, 415, 440, 466, 493 };
            do
            {

                ConsoleKeyInfo Misk = Console.ReadKey();

                if (Misk.Key == ConsoleKey.Q)
                {
                Console.Beep(latter[0], 300);
                }
                if (Misk.Key == ConsoleKey.W)
                {
                Console.Beep(latter[1], 300);
                }
                if (Misk.Key == ConsoleKey.E)
                {
                Console.Beep(latter[2], 300);
                }
                if (Misk.Key == ConsoleKey.R)
                {
                Console.Beep(latter[3], 300);
                }
                if (Misk.Key == ConsoleKey.T)
                {
                Console.Beep(latter[4], 300);
                }
                if (Misk.Key == ConsoleKey.Y)
                {
                Console.Beep(latter[5], 300);
                }
                if (Misk.Key == ConsoleKey.U)
                {
                Console.Beep(latter[6], 300);
                }
                if (Misk.Key == ConsoleKey.I)
                {
                Console.Beep(latter[7], 300);
                }
                if (Misk.Key == ConsoleKey.O)
                {
                Console.Beep(latter[8], 300);
                }
                if (Misk.Key == ConsoleKey.P)
                {
                Console.Beep(latter[9], 300);
                }
                if (Misk.Key == ConsoleKey.A)
                {
                Console.Beep(latter[10], 300);
                }
                if (Misk.Key == ConsoleKey.S)
                {
                Console.Beep(latter[11], 300);
                }
                if ((Misk.Key == ConsoleKey.F1) || (Misk.Key == ConsoleKey.F2))
                {
                    Perecluch();
                }
                if (Misk.Key == ConsoleKey.Escape)
                {
                    break;
                }
                Console.Clear();
            } while (Octave == true);
            
        }

        static void two()
        {
            bool Octave = true;
            int[] latter = new int[] { 523, 554, 587, 622, 659, 698, 740, 784, 830, 880, 932, 987 };
            do
            {

                ConsoleKeyInfo Misk = Console.ReadKey();

                if (Misk.Key == ConsoleKey.Q)
                {
                    Console.Beep(latter[0], 300);
                }
                if (Misk.Key == ConsoleKey.W)
                {
                    Console.Beep(latter[1], 300);
                }
                if (Misk.Key == ConsoleKey.E)
                {
                    Console.Beep(latter[2], 300);
                }
                if (Misk.Key == ConsoleKey.R)
                {
                    Console.Beep(latter[3], 300);
                }
                if (Misk.Key == ConsoleKey.T)
                {
                    Console.Beep(latter[4], 300);
                }
                if (Misk.Key == ConsoleKey.Y)
                {
                    Console.Beep(latter[5], 300);
                }
                if (Misk.Key == ConsoleKey.U)
                {
                    Console.Beep(latter[6], 300);
                }
                if (Misk.Key == ConsoleKey.I)
                {
                    Console.Beep(latter[7], 300);
                }
                if (Misk.Key == ConsoleKey.O)
                {
                    Console.Beep(latter[8], 300);
                }
                if (Misk.Key == ConsoleKey.P)
                {
                    Console.Beep(latter[9], 300);
                }
                if (Misk.Key == ConsoleKey.A)
                {
                    Console.Beep(latter[10], 300);
                }
                if (Misk.Key == ConsoleKey.S)
                {
                    Console.Beep(latter[11], 300);
                }
                if ((Misk.Key == ConsoleKey.F1) || (Misk.Key == ConsoleKey.F2)) 
                {
                    Perecluch2();
                }
                if (Misk.Key == ConsoleKey.Escape)
                {
                    break;
                }
                Console.Clear();
            } while (Octave == true);
        }
        static void Perecluch()
        {
                Console.WriteLine("\nВы переключились на вторую Актаву");
                two();
        }
        static void Perecluch2()
        {
            Console.WriteLine("\nВы переключились на первую Актаву");
            Fine();
        }
    }
}


