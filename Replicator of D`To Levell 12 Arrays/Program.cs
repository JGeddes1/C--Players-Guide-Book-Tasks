int[] array = new int[5];

for  (int i = 0; i <= 5; i++)
{
    Console.Write("Enter a number: ");
    int number = Convert.ToInt32(Console.ReadLine());
    array[i] = number;
    Console.WriteLine(array[i]);



}
int[] secondarray = new int[5];

// copy values out of array into new one
for (int index = 0; index < 5; index++)
    secondarray[index] = array[index];
