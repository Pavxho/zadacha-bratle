using System;
using System.Linq;

class Program
{
    static void Main()
    {
        int[] arr = { 4, 3, 2, 36, 6, 12, 11, 23, 5, 8, 1, 7 };

        // Сортиране
        Array.Sort(arr);
        Console.WriteLine("Подреден масив: " + string.Join(" ", arr));

        // Намиране на най-малкото число
        int min = arr[0];

        // Намиране на най-дългата поредица започваща от най-малкото число
        var sequence = arr.Where((val, index) => index == 0 || val == arr[index - 1] + 1).ToList();

        var longest = new System.Collections.Generic.List<int>();
        int current = min;

        foreach (int num in arr)
        {
            if (num == current)
            {
                longest.Add(num);
                current++;
            }
        }

        Console.WriteLine("Най-дълга поредица от най-малкото: " + string.Join(" ", longest));
        Console.WriteLine("Дължина: " + longest.Count);
    }   
}
