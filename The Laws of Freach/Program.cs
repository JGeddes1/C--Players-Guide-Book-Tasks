int[] array = new int[] { 4, 51, -7, 13, -99, 15, -8, 45, 90 };


int currentSmallest = int.MaxValue;

/*for (int i = 0; i < array.Length; i++)
{
    if (array[i] < currentSmallest)
        currentSmallest = array[i];

}
Console.WriteLine(currentSmallest);*/


foreach (int score in array)
{
    if (score < currentSmallest)
    {
        currentSmallest = score;
    }
}
Console.WriteLine(currentSmallest);