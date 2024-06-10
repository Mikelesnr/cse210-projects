using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        Console.Write("Enter number: ");
        float number = float.Parse(Console.ReadLine());
        List<float> numbers = new List<float>();

        while (number != 0)
        {
            numbers.Add(number);
            Console.Write("Enter number: ");
            number = float.Parse(Console.ReadLine());

        }
        float total = Sum(numbers);
        float mean = Average(total, numbers.Count);
        float max = Maximum(numbers);
        float min = Minimum(numbers);
        List<float> sorted = Sort(numbers);
        Console.WriteLine($"The sum is: {total}");
        Console.WriteLine($"The average is: {mean}");
        Console.WriteLine($"The largest number is: {max}");
        Console.WriteLine($"The smallest positive number is: {min}");
        Console.WriteLine("The sorted list is:");
        foreach (float value in sorted)
        {
            Console.WriteLine(value);
        }
    }

    static float Average(float valueOne, float valueTwo)
    {
        return valueOne / valueTwo;
    }

    static float Sum(List<float> values)
    {
        float sum = 0;
        foreach (float value in values)
        {
            sum += value;
        }
        return sum;
    }

    static float Maximum(List<float> values)
    {
        float max = 0;
        for (int i = 0; i < values.Count; i++)
        {
            if (i == 0)
            {
                max = values[i];
            }
            else
            {
                if (values[i] > max)
                {
                    max = values[i];
                }
            }
        }
        return max;
    }

    static float Minimum(List<float> values)
    {
        float min = 999999 ^ 10;
        for (int i = 0; i < values.Count; i++)
        {
            if (values[i] < min & values[i] > 0)
            {
                min = values[i];
            }

        }
        return min;
    }

    static List<float> Sort(List<float> values)
    {
        float temp = 0;
        for (int i = 0; i < values.Count - 1; i++)
        {
            for (int j = i + 1; j < values.Count; j++)
            {
                if (values[i] > values[j])
                {
                    temp = values[i];
                    values[i] = values[j];
                    values[j] = temp;
                }

            }

        }
        return values;
    }

}