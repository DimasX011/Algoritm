namespace quest2
{
    public class BynarySearch
    {
        public int LineSearch(int[] array, int value) //поиск элемента с определённым значением
        {
            for(int i = 0; i < array.Length; i++)
            {
                if (array[i] == value)
                    return i;
            }

            return -1;
        }

        public int InterpolationSearch(int[] a, int length, int value)
        {
            int min = 0;
            int max = length - 1;
            while (min <= max)
            {
                // Находим разделяющий элемент
                int mid = min + (max - min) * (value - a[min]) / (a[max] - a[min]);
                if (a[mid] == value)
                    return mid;
                else if (a[mid] < value)
                    min = mid + 1;
                else if (a[mid] > value)
                    max = mid - 1;
            }
            return -1;   // Элемент не найден
        }
        public int BinarySearch(int[] inputArray, int searchValue)
        {
            int min = 0;//O(1)
            int max = inputArray.Length - 1;//O(1)
            while (min <= max) //O(Log(N))
            {
               
                int mid = (min + max) / 2;
                if(searchValue == inputArray[mid])
                {
                    return mid;
                }
                else if (searchValue < inputArray[mid])
                {
                    max = mid - 1;
                }
                else
                {
                    min = mid + 1;
                }
               
            }
            return -1;//O(1)
            //O(N)= O(Log(N)+3)
            
            
        }
        
        

    }

}