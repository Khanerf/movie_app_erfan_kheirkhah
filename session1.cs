Console.Write("Enter number of students: ");
            int numberOfStudents = int.Parse(Console.ReadLine());

            string[] names = new string[numberOfStudents];
            double[] scores = new double[numberOfStudents];

            for (int i = 0; i < numberOfStudents; i++)
            {
                Console.Write($"Enter students name {i + 1} : ");
                names[i] = Console.ReadLine();

                Console.Write($"Enter students score {i + 1} : ");
                scores[i] = double.Parse(Console.ReadLine());
            }

            Console.WriteLine("nResult:");
            for (int i = 0; i < numberOfStudents; i++)
            {
                double roundedScore = (int)Math.Round(scores[i]);
                string status = roundedScore > 10 ? "Pass" : "Fail";

                Console.WriteLine($"Name: {names[i]}, Score: {roundedScore}, Status: {status}");
            }
            Console.ReadKey();
