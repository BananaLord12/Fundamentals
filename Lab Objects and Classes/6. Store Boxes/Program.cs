using System;

namespace _6._Store_Boxes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            List<Box> boxes = new List<Box>();

            while(input != "end")
            {
                string[] token = input.Split();

                Box box = new Box();

                box.Item = new Item();
                box.Item.Name = token[1];
                box.Item.Price = decimal.Parse(token[3]);
                box.SerialNumber = token[0];
                box.Quantity = int.Parse(token[2]);
                
                boxes.Add(box);
                input = Console.ReadLine();
            }

            List<Box> filtered = boxes.OrderByDescending(box => box.PriceBox).ToList();
            foreach(Box box in filtered)
            {
                Console.WriteLine(box.SerialNumber);
                Console.WriteLine($"-- {box.Item.Name} - ${box.Item.Price.ToString("F2")}: {box.Quantity}");
                Console.WriteLine($"-- ${box.PriceBox.ToString("F2")}");
            }
        }
    }

    class Item
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
    }
    class Box
    {
        public Box()
        {
            Item = new Item();
        }
        public string SerialNumber { get; set; }
        public Item Item { get; set; }
        public int Quantity { get; set; }
        public decimal PriceBox
        {
            get
            {
                return Item.Price * Quantity;
            }
        }
    }
}