static class Service{ 
    public static int[] FilterManual(int[] array, Func<int,bool> predicate)
    {
        int count = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (predicate(array[i]))
            {
                count++;
            }
        }

        int[] result = new int[count];
        int index = 0;

        for (int i = 0; i < array.Length; i++)
        {
            if (predicate(array[i]))
            {
                result[index] = array[i];
                index++;
            }
        }

        return result;
    }
}