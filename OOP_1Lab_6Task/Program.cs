using System.Diagnostics;
using System.Xml.Linq;

public delegate void SortAlgorithm(int[] array);

class Program
{
    static long TestSort(string name, SortAlgorithm sortingMethod, int[] sourceArray)
    {
        int[] arrayToSort = (int[])sourceArray.Clone();

        Stopwatch sw = new Stopwatch();

        sw.Start();
        sortingMethod(arrayToSort);
        sw.Stop();

        if (IsSorted(sourceArray.OrderBy(x=>x).ToArray(), arrayToSort, name))
        {
            Console.Write($"\n{name} | Час: {sw.ElapsedMilliseconds} мс | ");
            return sw.ElapsedMilliseconds;
        }
        else
        {
            return long.MaxValue;
        }
    }

    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        Random rnd = new Random();
        int[] data = Enumerable.Range(0, 2000).Select(x => rnd.Next(0, 10000)).ToArray();

        Console.WriteLine("Еталони:");
        
        long tEtaSelection = TestSort("Selection Sort", SelectionSort, data);
        long tEtaShaker = TestSort("Shaker Sort", ShakerSort, data);
        
        Console.WriteLine("\n" + new string('-', 55) + "\nПорівняння алгоритмів сортування: ");

        long tStudentSelection = TestSort("Selection Sort Student", SelectionSortStudent, data);
        if(tStudentSelection != long.MaxValue) 
            GetTimeStatus(tEtaSelection, tStudentSelection);
        
        long tStudentShaker = TestSort("Shaker Sort Student", ShakerSortStudent, data);
        if (tStudentShaker != long.MaxValue) 
            GetTimeStatus(tEtaShaker, tStudentShaker);
    }

    static void SelectionSort(int[] arr)
    {
        for (int i = 0; i < arr.Length - 1; i++)
        {
            int min = i;
            for (int j = i + 1; j < arr.Length; j++)
                if (arr[j] < arr[min]) min = j;

            int temp = arr[min];
            arr[min] = arr[i];
            arr[i] = temp;
        }
    }

    static void SelectionSortStudent(int[] arr)
    {

        int n = arr.Length;

        for (int i = 0; i < n; i++)
        {
            int minIdx = i;

            for (int j = i + 1; j < n; j++)
            {
                if (arr[j] < arr[minIdx])
                {
                    minIdx = j;
                }
            }
            Swap(arr, i, minIdx);
        }
        int p = 0;
        while(p < int.MaxValue)
            p++;
    }


    static void ShakerSort(int[] arr)
    {
        int left = 0;
        int right = arr.Length - 1;

        while (left < right) 
        {
            bool swapped = false;

            for (int i = left; i < right; i++)
            {
                if (arr[i] > arr[i + 1])
                {
                    Swap(arr, i, i + 1);
                    swapped = true;
                }
            }
            right--; 

            if (!swapped) break;

            swapped = false;

            for (int i = right; i > left; i--)
            {
                if (arr[i - 1] > arr[i])
                {
                    Swap(arr, i - 1, i);
                    swapped = true;
                }
            }
            left++;

            if (!swapped) break;
        }
    }
    static void ShakerSortStudent(int[] arr)
    {
        int n = arr.Length;

        for (int k = 0; k < n / 2; k++)
        {
            for (int i = 0; i < n - 1; i++)
            {
                if (arr[i] > arr[i + 1])
                {
                    Swap(arr, i, i + 1);
                }
            }

            for (int i = n - 2; i >= 0; i--)
            {
                if (arr[i] > arr[i + 1])
                {
                    Swap(arr, i, i + 1);
                }
            }
        }
    }

    static void Swap(int[] arr, int i, int j) => (arr[i], arr[j]) = (arr[j], arr[i]);

    static bool IsSorted(int[] eta ,int[] arr, string name)
    {
        for (int i = 0; i < arr.Length - 1; i++)
        {
            if (arr[i] != eta[i])
            {   
                Console.WriteLine($"{name} - не відсортував масив");
                return false;
            }
        }
        return true;
    }
    static void GetTimeStatus(long tEta, long tStd)
    {
        bool status = Math.Max(0, tEta / 5 - 200) <= tStd && tStd <= tEta / 5 + 200;
        Console.WriteLine("Статус: " + (status ? "OK" : "Time limit Exceed!"));
    }
}