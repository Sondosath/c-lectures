using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace examples_21_1_2024
{
    internal class Program
    {
        class HotelReservationSystem
        {
            public string roomNum { set; get; }
            public string roomType { set; get; }
            public string pricePerNight { set; get; }
            public const string hotelName = "Grand Stay Hotel";
            public string isBooked { set; get; }
            HotelReservationSystem()
            {


            }
            HotelReservationSystem(string roomNum, string roomType, string pricePerNight, string isBooked)
            {
                this.roomNum = roomNum;
                this.roomType = roomType;
                this.pricePerNight = pricePerNight;
                this.isBooked = isBooked;
            }
            ~HotelReservationSystem() { }
        }
        static void Main(string[] args)
        {
            
            int n = 5;
            for (int i = 1; i < n; i++)
            {
                for (int k = n - i; k > 0; --k)
                {
                    Console.Write(" ");

                }
                for (int j = 0; j < i; j++)
                {
                    
                    Console.Write("*"+" ");
                }
                Console.WriteLine();
            }


        }

    }
}
