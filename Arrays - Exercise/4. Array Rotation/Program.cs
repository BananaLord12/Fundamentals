namespace _4._Array_Rotation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            int differece = int.Parse(Console.ReadLine());
            int start = 0;
            int end = arr1.Length-1;
            int temp = 0;

            while(differece > 0)
            {
                temp = arr1[0];
                for (int i = 1; i < arr1.Length; i++)
                {
                    arr1[i - 1] = arr1[i];
                }
                arr1[arr1.Length - 1] = temp;
                differece--;
            }

            foreach (int num in arr1)
            {
                Console.Write(num + " ");
            }
        }
    }
}