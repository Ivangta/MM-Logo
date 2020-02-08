using System;

namespace MentorMate_MM
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            CheckIfEven(number);
            CheckLimits(number);

            CreateLogo(number);

        }

        static void CheckIfEven(int number)
        {
            if (number % 2 == 0)
            {
                throw new ArgumentOutOfRangeException("Number must be odd!");
            }
        }

        static void CheckLimits(int number)
        {
            if (number < 1 || number > 150000)
            {
                throw new ArgumentOutOfRangeException("The number that you entered is out of range!");
            }
        }

        static void CreateLogo(int number)
        {
            int firstPattern = number - 1;
            int secondPattern = number + 2;
            int thirdPattern = number - 2;
            int fourthPattern = (number * 2) - 2;

            int fifthPattern = number;
            int sixthPattern = 1;
            int seventhPattern = (number * 2) - 1;

            for (int i = 1; i <= number + 1; i++)
            {
                if (i == 1)
                {
                    for (int j = 0; j < 9; j++)
                    {
                        if (j != 4)
                        {
                            if (j % 2 == 0)
                            {
                                for (int t = 0; t < number; t++)
                                {
                                    Console.Write("-");
                                }
                            }
                            else
                            {
                                for (int t = 0; t < number; t++)
                                {
                                    Console.Write("*");
                                }
                            }
                        }
                        else
                        {
                            for (int r = 0; r < number * 2; r++)
                            {
                                Console.Write("-");
                            }
                        }
                    }
                }
                else if (i != 1 && i != number + 1)
                {
                    if (i <= (number + 1) / 2)
                    {
                        for (int u = 0; u < 9; u++)
                        {
                            if (u != 4)
                            {
                                if (u == 0 || u == 8)
                                {
                                    for (int b = 0; b < firstPattern; b++)
                                    {
                                        Console.Write("-");
                                    }
                                }
                                else if (u % 2 != 0)
                                {
                                    for (int p = 0; p < secondPattern; p++)
                                    {
                                        Console.Write("*");
                                    }

                                }
                                else if (u % 2 == 0)
                                {
                                    for (int p = 0; p < thirdPattern; p++)
                                    {
                                        Console.Write("-");
                                    }
                                }
                            }
                            else
                            {
                                for (int r = 0; r < fourthPattern; r++)
                                {
                                    Console.Write("-");
                                }
                            }
                        }
                        firstPattern--;
                        secondPattern += 2;
                        thirdPattern -= 2;
                        fourthPattern -= 2;
                    }
                    else if (i > (number + 1) / 2 && i < number + 1)
                    {
                        for (int u = 0; u < 13; u++)
                        {
                            if (u != 3 && u != 9 && u != 6)
                            {
                                if (u == 0 || u == 12)
                                {
                                    for (int b = 0; b < firstPattern; b++)
                                    {
                                        Console.Write("-");
                                    }
                                }
                                else if (u % 2 != 0)
                                {
                                    for (int p = 0; p < fifthPattern; p++)
                                    {
                                        Console.Write("*");
                                    }

                                }
                                else if (u % 2 == 0)
                                {
                                    for (int p = 0; p < sixthPattern; p++)
                                    {
                                        Console.Write("-");
                                    }
                                }
                            }
                            else if (u == 3 || u == 9)
                            {
                                for (int r = 0; r < seventhPattern; r++)
                                {
                                    Console.Write("*");
                                }
                            }
                            else if (u == 6)
                            {
                                for (int r = 0; r < fourthPattern; r++)
                                {
                                    Console.Write("-");
                                }
                            }
                        }
                        firstPattern--;
                        sixthPattern += 2;
                        fourthPattern -= 2;
                        seventhPattern -= 2;
                    }
                }
                else if (i == number + 1)
                {
                    for (int j = 0; j < 9; j++)
                    {
                        if (j != 4)
                        {
                            if (j % 2 == 0)
                            {
                                for (int t = 0; t < number; t++)
                                {
                                    Console.Write("*");
                                }
                            }
                            else
                            {
                                for (int t = 0; t < number; t++)
                                {
                                    Console.Write("-");
                                }
                            }
                        }
                        else
                        {
                            for (int r = 0; r < number * 2; r++)
                            {
                                Console.Write("*");
                            }
                        }
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
