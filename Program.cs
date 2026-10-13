            Console.Write("Введите первую сторону:");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Введите вторую сторону:");
            double b = double.Parse(Console.ReadLine());
            Console.Write("Введите третью сторону:");
            double c = double.Parse(Console.ReadLine());

            Console.WriteLine($"Периметр:{a + b + c}");
            double p=(a+b+c)/2;
            Console.WriteLine($"Площадь:{Math.Sqrt(p*(p-a)*(p-b)*(p-c)):F2}");
