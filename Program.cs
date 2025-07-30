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
            for (int i = 0; i < n; i++) // Loop to read elements into the array
            {
                arr[i] = Convert.ToInt32(Console.ReadLine()); // Read each element from the console
            }
            Console.WriteLine("The unique elements in the array are: ");
            for (int i = 0; i < n; i++)// Loop to find and print unique elements
            {
                bool isUnique = true; // Assume the current element is unique
                for (int j = 0; j < n; j++) // Loop to compare the current element with all other elements
                {
                    if (i != j && arr[i] == arr[j]) // If the current element is found in another position
                    {
                        isUnique = false; // Set isUnique to false
                        break;
                    }
                }
                if (isUnique) // If the current element is unique
                {
                    Console.Write(arr[i] + " "); // Print the unique element
                }
            }
            Console.WriteLine();
        }
    }
}
