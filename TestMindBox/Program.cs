using MindBoxLibrary;

class Program
{
    static void Main(string[] args)
    {
        int row = 0;
        string?[] sideTrian = new string[3];
        IGeometricalFigure figure = new BaseFigure();
        do
        {
            if (row == 0 || row >= 25)
                ResetConsole();
            Console.WriteLine("************************************************************************************************");
            Console.WriteLine("Если Вы желаете вычислить площадь круга(нажмите 0)  , если треугольника (нажмите 1)");
        string? input = Console.ReadLine();
            switch (input)
            {
                case "0":
                    Circle();
                    break;
                case "1":
                    Triangle();
                    break;
                default:
                    Console.WriteLine(" Ведено не верное значения. Введите пожалуйста одно из значений 1 или 0");
                    break;
            }
        } while (true);
     

        //// Declare a ResetConsole local method
        void ResetConsole()
        {
            if (row > 0)
            {
                Console.WriteLine("Press any key to continue...");
                Console.ReadKey();
            }
            Console.Clear();
         // Console.WriteLine($"{Environment.NewLine}Нажмите  <Enter> если вы желаете завершить работу:{Environment.NewLine}");
            row = 3;
        }
        //читаем   вводимые данные
        void EnterDataTriangle()
        {
            Console.WriteLine("Введите первую сторону треугольника и нажмите Enter");
            sideTrian[0] = Console.ReadLine();
            Console.WriteLine("Введите вторую сторону треугольника и нажмите Enter");
            sideTrian[1] = Console.ReadLine();
            Console.WriteLine("Введите третью сторону треугольника и нажмите Enter");
            sideTrian[2] = Console.ReadLine();
        }
        string?  EnterDataCircle()
        {
            Console.WriteLine("Введите радиус круга и нажмите Enter");
            string? input = Console.ReadLine();
            return input;
        }
        void Circle()
        {
                CircleBase? figure = null;
                try
                {
                    figure = new CircleBase(Convert.ToDouble(EnterDataCircle()));
                    Console.WriteLine("Площадь круга равна {0}", figure.SquareFigure());
                }
                finally
                {
                    figure?.Dispose();
                }
            }
        void Triangle()
        {
            BaseTriangle? figure = null;
            try
            {
                EnterDataTriangle();
                figure = new BaseTriangle(sideTrian);
                double dbResult = figure.SquareFigure();
                if (dbResult > 0.0) Console.WriteLine("Площадь треугольника равна {0}", dbResult);
            }
            finally
            {
                figure?.Dispose();
            }
        }
    }
}