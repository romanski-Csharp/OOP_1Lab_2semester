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

            bool isCorrect = IsSorted(arrayToSort, name);
            Console.WriteLine($"{name,-20} | Час: {sw.Elapsed.TotalMilliseconds,8} мс | ");
            return sw.ElapsedMilliseconds;
    }

    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        Random rnd = new Random();
        int[] data = Enumerable.Range(0, 2000).Select(x => rnd.Next(0, 10000)).ToArray();


        Console.WriteLine("Еталони:");
        

        long tEtaSelection = TestSort("Selection Sort", SelectionSort, data);
        long tEtaShaker = TestSort("Shaker Sort", ShakerSort, data);
        
        Console.WriteLine(new string('-', 55));
        Console.WriteLine("Порівняння алгоритмів сортування:");

        long tStudentSelection = TestSort("Selection Sort Student", SelectionSortStudent, data);
        Console.WriteLine(GetTimeStatus(tEtaSelection, tStudentSelection));
        
        long tStudentShaker = TestSort("Shaker Sort Student", ShakerSortStudent, data);
        Console.WriteLine(GetTimeStatus(tEtaShaker, tStudentShaker));
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
        List<int> data = arr.ToList();
        List<int> sortedList = new List<int>();

        while (data.Count > 0)
        {
            int minVal = data.Min();

            int minIdx = data.IndexOf(minVal);

            sortedList.Add(minVal);
            data.RemoveAt(minIdx);
        }

        arr = sortedList.ToArray();
    }


static void ShakerSort(int[] arr)
    {
        int left = 0, right = arr.Length - 1;
        while (left <= right)
        {
            for (int i = left; i < right; i++)
                if (arr[i] > arr[i + 1]) Swap(arr, i, i + 1);
            right--;
            for (int i = right; i > left; i--)
                if (arr[i - 1] > arr[i]) Swap(arr, i - 1, i);
            left++;
        }
    }
    static void ShakerSortStudent(int[] arr)
    {
        List<int> list = arr.ToList();
        bool swapped = true;

        while (swapped)
        {
            swapped = false;

            for (int i = 0; i < list.Count - 1; i++)
            {
                if (list[i] > list[i + 1])
                {
                    int temp = list[i];
                    list.RemoveAt(i);
                    list.Insert(i + 1, temp);
                    swapped = true;
                }
            }

            if (!swapped) break;
            swapped = false;

            for (int i = list.Count - 2; i >= 0; i--)
            {
                if (list[i] > list[i + 1])
                {
                    int temp = list[i];
                    list.RemoveAt(i);
                    list.Insert(i + 1, temp);
                    swapped = true;
                }
            }
        }
        arr = list.ToArray();
    }
    static void Swap(int[] arr, int i, int j) => (arr[i], arr[j]) = (arr[j], arr[i]);

    static bool IsSorted(int[] arr, string name)
    {
        for (int i = 0; i < arr.Length - 1; i++)
        {
            if (arr[i] > arr[i + 1])
            {   
                Console.WriteLine($"Метод '{name}' не відсортовує масив");
                return false;
            }
        }
        return true;
    }
    static string GetTimeStatus(long tEta, long tStd)
    {
        bool status = Math.Max(0, tEta / 5 - 200) <= tStd && tStd <= tEta / 5 + 200;
        return status ? "OK" : "Time limit Exceed!";
    }
}