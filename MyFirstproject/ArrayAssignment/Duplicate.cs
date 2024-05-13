namespace MyFirstproject.ArrayAssignment
{
    public class Duplicate
    {
        public static void FindDuplicate(int[] arr)
        {
            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        Console.WriteLine($"Duplicate element is {arr[i]}");
                        break;
                    }
                }
            }
        }

        static void Main(string[] args)
        {
            int[] arr = { 2, 3, 4, 3, 2, 5, 6, 7, 6 ,2,3};
            FindDuplicate(arr);
        }
    }
}