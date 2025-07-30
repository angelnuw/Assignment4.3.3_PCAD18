namespace Assignment4._3._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input the number of elements to be stored in the array: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[n];
            Console.WriteLine("input 3 elements of the aray: ");
            
            //print unique elements in the array
            for (int i = 0; i < n; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("The unique elements in the array are: ");
            for (int i = 0; i < n; i++)
            {
                bool isUnique = true;
                for (int j = 0; j < n; j++)
                {
                    if (i != j && arr[i] == arr[j])
                    {
                        isUnique = false;
                        break;
                    }
                }
                if (isUnique)
                {
                    Console.Write(arr[i] + " ");
                }
            }
            Console.WriteLine();
        }
    }
}
