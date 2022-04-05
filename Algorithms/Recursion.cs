namespace Algorithms;

public static class Recursion
{
    public static int RecursionListSum(List<int> list)
    {
        if (list.Count == 0)
        {
            return 0;
        }

        var last = list[list.Count - 1];
        list.RemoveAt(list.Count - 1);

        return last + RecursionListSum(list);
    }

    public static int RecursionListCount(List<int> list)
    {
        if (list.Count == 0)
        {
            return 0;
        }

        list.RemoveAt(list.Count - 1);
        return 1 + RecursionListCount(list);
    }

    public static int RecursionMaxValue(List<int> list)
    {
        if (list.Count == 2)
        {
            var max = list[0];

            if (max < list[1])
                max = list[1];

            return max;
        }

        var firstItem = list[0];
        list.RemoveAt(0);
        int subMax = RecursionMaxValue(list);

        return firstItem > subMax ? firstItem : subMax;
    }
}
