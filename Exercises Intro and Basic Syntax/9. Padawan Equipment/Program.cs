using System;
using System.Security.Cryptography;

namespace _9._Padawan_Equipment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double money = double.Parse(Console.ReadLine());
            int studentscount = int.Parse(Console.ReadLine());
            double lightsaberprice = double.Parse(Console.ReadLine());
            double robePrice = double.Parse(Console.ReadLine());
            double beltPrice = double.Parse(Console.ReadLine());
            int beltstudents = studentscount;
            double totalPrice = 0;

            for (int i = 6; i <= studentscount; i += 6)
            {
                beltstudents--;
            }
            totalPrice = (Math.Ceiling(studentscount * 1.1) * lightsaberprice) + (beltstudents * beltPrice) + (studentscount * robePrice);


            if(money >= totalPrice)
            {
                Console.WriteLine($"The money is enough - it would cost {totalPrice:f2}lv.");
            }
            else
            {
                Console.WriteLine($"John will need {(totalPrice - money):F2}lv more.");
            }
        }
    }
}