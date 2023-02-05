namespace _10._Top_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            TopNumbers(num);
        }

        private static void TopNumbers(int num)
        {

            for (int i = 1; i <= num; i++)
            {
                int sum = 0;
                int odddigitcount = 0;
                bool issum8 = false;
                int tempnum = i;

                for (int j = 1; j <= i.ToString().Length; j++)
                {
                    int digit = tempnum % 10;
                    sum += digit;
                    if (tempnum % 2 != 0)
                    {
                        odddigitcount++;
                    }
                    tempnum = tempnum / 10;
                }
                if(sum % 8 == 0)
                {
                    issum8 = true;
                }

                if(odddigitcount >= 1 && issum8 == true)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}