using System;
namespace Interface14._02._2023
{
    class Class : IOutput, IMath , ISort
    {
        string inform = "Hello";
        int[] Mass = new int[6] { 4,5,2,8,12,3};

        public void Show()
        {
            for (int i = 0; i<Mass.Length; i++)
            {
                
                Console.Write("{0,4}", Mass[i]);
            }
            Console.WriteLine();
        }
        public void Show_()
        {
            Console.WriteLine(inform);
        }



        public void Max()
        {
            int Max = Mass[0];
            for (int i = 0; i<Mass.Length; i++)
            {
                if (Mass[i]>Max)
                {
                    Max = Mass[i];
                }
            }
            Console.WriteLine("Максимум = " + Max);
        }

        public void Min()
        {
            int Min = Mass[0];
            for (int i = 0; i < Mass.Length; i++)
            {
                if (Mass[i] < Min)
                {
                    Min = Mass[i];
                }

            }
            
            Console.WriteLine("Минимум = " + Min);
        }

        public void Avg()
        {
            
            int Avg = 0;
            int Summ = 0;
            for (int i = 0; i<Mass.Length; i++)
            {
                Summ += Mass[i];
                Avg = Summ / 6;
            }
            Console.WriteLine("Среднее арифметическое = " + Avg);
        }

        public void SortAsc()
        {
            int t = 0;

            for (int i = 0; i<Mass.Length; i++)
            {
                for (int j = 0; j<Mass.Length-1; j++)
                {
                    if (Mass[j]>Mass[j+1])
                    {
                        t = Mass[j];
                        Mass[j] = Mass[j + 1];
                        Mass[j + 1] = t;
                    }
                }
            }
            for (int i = 0; i<Mass.Length; i++)
            {
                Console.WriteLine(Mass[i]);
            }
        }
        public void SortDesc()
        {
            int t = 0;

            for (int i = 0; i < Mass.Length; i++)
            {
                for (int j = 0; j < Mass.Length - 1; j++)
                {
                    if (Mass[j] < Mass[j + 1])
                    {
                        t = Mass[j];
                        Mass[j] = Mass[j + 1];
                        Mass[j + 1] = t;
                    }
                }
            }
            for (int i = 0; i < Mass.Length; i++)
            {
                Console.WriteLine(Mass[i]);
            }
        }



    }


}
