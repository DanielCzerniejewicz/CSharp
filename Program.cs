void grzebien(int[] T, int gap)
{
    bool swapped = true;
    int tempik;
    int n = gap;
    while (gap > 1 || swapped)
    {
        gap = gap * 10 / 13;
        if (gap == 0)
        {
            gap = 1;
        }
        swapped = false;
        for (int i = 0; i < n-gap;i++)
        {
            if (T[i] > T[i + gap])
            {
                tempik = T[i];
                T[i] = T[i + gap];
                T[i + gap] = tempik;
                swapped = true;
            }
        }
    }
}