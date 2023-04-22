namespace algorithmsdotNET;

public static class dotNetAlgorithms
{

    /// <summary>
    ///  - La declaracion de variables:         O(1)
    ///  *************************************************
    ///  - Primer for:                          O(n)
    ///  - Segundo for:                         O(n)
    ///  _________________________________________________
    ///                                         O(2n)
    ///  _________________________________________________
    ///     El algoritmo es:                    O(n)
    /// </summary>
    public static (decimal sum, decimal multiplication) LinealComplex(int[] numbers)
    {
        decimal sum = 0, multiplication = 0;

        for (int i = 0; i < numbers.Length; i++)
        {
            sum += numbers[i];
        }

        for (int i = 0; i < numbers.Length; i++)
        {
            multiplication *= numbers[i];
        }

        return (sum,multiplication);
    }

    /// <summary>
    ///  - Primer for:                       O(n)
    ///  - Segundo for:                      O(5)
    /// _______________________________________________
    ///                                      O(5n)
    /// -----------------------------------------------
    ///                                      O(n)
    /// </summary>
    public static decimal LineaComplex2(int[] numbers){
        decimal calculate = 0;

        for (int i = 0; i < numbers.Length; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                calculate += (i * j);
            }
        }
        return calculate;
    }

    /// <summary>
    /// Algoritmo: O(logn)
    /// </summary>
    public static int BinarySearch(int[] numbers, int target)
    {
        int start = 0;
        int end = numbers.Length - 1;

        while (start < end)
        {
            int middle = (start + end) / 2;

            if (numbers[middle] == target) return middle;

            if (numbers[middle] < target) start = middle + 1;
            else end = middle - 1;
        }

        return -1;
    }
}