﻿using System;

namespace AddressBooks
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Address Book System!");
            AddrBook.GetCustomer();
            AddrBook.ListingPeople();
        }
    }
}
