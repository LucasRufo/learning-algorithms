namespace Algorithms;

public class BinarySearch
{
    public static int? BinarySearchAlgorithm(int[] array, int itemToFind)
    {
        int start = 0;
        int end = array.Length - 1;

        while (start <= end)
        {
            int mid = (start + end) / 2;
            var itemInMid = array[mid];

            if (itemInMid == itemToFind)
            {
                return mid;
            }

            if (itemInMid < itemToFind)
            {
                start = mid + 1;
            }

            if (itemInMid > itemToFind)
            {
                end = mid - 1;
            }
        }

        return null;
    }
}
