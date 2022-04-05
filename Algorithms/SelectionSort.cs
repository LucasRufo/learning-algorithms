namespace Algorithms;

public static class SelectionSort
{
    public static List<int>? SelectionSortAlgorithm(List<int> list)
    {
        if(list.Count == 0)
        {
            return null;
        }

        var newList = new List<int>();

        var len = list.Count;

        for (int i = 0; i < len; i++)
        {
            var maxIndex = FindMaxValueIndex(list);
            newList.Add(list[maxIndex]);
            list.RemoveAt(maxIndex);
        }

        return newList;
    }

    private static int FindMaxValueIndex(List<int> list)
    {
        var minValueIndex = 0;
        var minValue = list[0];

        for (int i = 0; i < list.Count; i++)
        {
            if (list[i] < minValue)
            {
                minValueIndex = i;
                minValue = list[i];
            }
        }

        return minValueIndex;
    }
}
