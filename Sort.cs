
namespace day_2
{
    internal class Sort
    {
        public static void BubbleSort(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                for(int j = 0; j<arr.Length - i -1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
        }

        public static void InsertionSort(int[] arr)
        {
            int temp, i, j;
            for (i = 1; i < arr.Length; ++i)
            {
                if (arr[i] < arr[i - 1])
                {
                    temp = arr[i];
                    j = i;
                    do
                    {
                        arr[j] = arr[--j];
                    } while (j > 0 && arr[j - 1] > temp);
                    arr[j] = temp;
                }
            }
        }

        public static void SelectionSort(int[] arr)
        {
            int i;
            int IMin;
            for (i = 0; i < arr.Length; ++i)
            {
                IMin = MinIndex(arr, i);
                Switch(arr, i, IMin);
            }
        }

        public static int MinIndex(int[] nums, int start)
        {
            int IMin = start;
            for (int i = start; i < nums.Length; ++i)
            {
                if (nums[i] < nums[IMin])
                {
                    IMin = i;
                }
            }
            return IMin;
        }
        public static void Switch(int[] arr, int i, int j)
        {
            int temp = arr[i];
            arr[i] = arr[j];
            arr[j] = temp;
        }

    }
}
