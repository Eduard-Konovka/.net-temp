using System;

int[] array1 = { 0, 1, 2 };
int[] array2 = { 1, 2, 3, 4 , 5, 6, 7, 8, 9, 10};

int[] result1 = GetSumAndProduct(array1);

int[] GetSumAndProduct(int[] arr) 
{
    int sum = 0;
    for (int i = 0; i < arr.Length - 1; i++)
       {
           sum = sum + arr[i];
       }

    int product = 1;
    for (int i = 1; i < arr.Length; i++)
       {
           product = product * arr[i];
       }

    int[] res = { sum, product };

    return res;
}

for (int i = 0; i < result1.Length; i++) Console.Write(result1[i] + " ");
 
// public class Class1
// {
//    // функція пошуку максимального та мінімального елементу масиву
//    static int[] MinMaxValue(int[] intArray)
//    {
//        int min = intArray[0];
//        int max = intArray[0];
//        int minNamb = 0;
//        int maxNamb = 0;
//        for (int i = 1; i < intArray.Length; i++)
//        {
//            if (intArray[i] > max) { max = intArray[i]; maxNamb = i; }
//            if (intArray[i] < min) { min = intArray[i]; minNamb = i; }
//        }
//        int[] res = { min, max, minNamb, maxNamb };
//        return res;
//    }

//    // основна програма
//    static void Main(string[] args)
//    {
//        int[] a = { 11, 2, 10, 21, 12, 2, 17, 38, 13, 5, 37, 20, 23 };
//        Console.WriteLine("Array:");
//        int n = a.Length;
//        for (int i = 0; i < n; i++) Console.Write(a[i] + " ");
//        Console.WriteLine();
//        int[] res = MinMaxValue(a);
//        int min = res[0];
//        int max = res[1];
//        int minNamb = res[2];
//        int maxNamb = res[3];
 
//        Console.WriteLine("Min елемент масиву = {0}", min);
//        Console.WriteLine("Max елемент масиву = {0}", max);
//        //swap min and max
//        a[minNamb] = max; 
//        a[maxNamb] = min;
//        Console.WriteLine("let's swap min and max - Array:");
//        int m = a.Length;
//        for (int i = 0; i < m; i++) Console.Write(a[i] + " ");
//        Console.WriteLine();
 
//        Console.ReadKey();
//    }
// }

// public class Class2
// {
//    // функція пошуку першого позитивного чи негативного елементу масиву
//    static int[] FindIndex(int[] intArray)
//    {
//        int pos = intArray[0];
//        int neg = intArray[0];
//        int posNumb = -1;
//        int negNumb = -1;
//        bool FindPos = false;
//        bool FindNeg = false;
 
      
//                for (int i = 0; i < intArray.Length; i++)
//                {
//                    if (intArray[i] >= 0 & FindPos == false) { pos = intArray[i]; posNumb = i; FindPos = true; }                   
//                    if (intArray[i] < 0 & FindNeg == false) { neg = intArray[i]; negNumb = i; FindNeg = true; }               
//                }
                          
//        int[] res = { pos, neg, posNumb, negNumb };   
//        return res;
//    }
//    // основна програма
//    static void Main(string[] args)
//    {
//        int[] a = {  11, -2, 10, 10, 12 };
//        Console.WriteLine("Array:");
//        int n = a.Length;
//        for (int i = 0; i < n; i++) Console.Write(a[i] + " ");
//        Console.WriteLine();
//        int[] res = FindIndex(a);
//        int pos = res[0];
//        int neg = res[1];
//        int posNumb = res[2];
//        int negNumb = res[3];
 
//        if (posNumb > -1)
//        {
//            Console.Write("First positive index = [{0}],", posNumb);
//            Console.WriteLine(" element value = {0}", pos);
//        }
//        else { Console.WriteLine("Позитивних елементів не знайдено", posNumb); }
 
//        if (negNumb > -1)
//        {
//            Console.Write("First negative index = [{0}],", negNumb);
//            Console.WriteLine(" element value = {0}", neg);
//        }
//        else { Console.WriteLine("Негативних елементів не знайдено", posNumb); }
 
//        Console.ReadKey();
//    }
// }