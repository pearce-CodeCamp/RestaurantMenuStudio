using System;
using System.Collections.Generic;
using System.Text;

namespace RestaurantMenu
{
    internal class Menu
    {
        // properties: title, items, last updated
        public string Title { get; set; }
        public List<MenuItem> Items { get; set; }
        public DateTime LastUpdated { get; set; }

        public Menu(string title)
        {
            Title = title;
            // initialize Items to be an empty list of menu items upon creating a Menu,
            // then from there, we can add menu items in after the fact
            Items = new List<MenuItem>();
            // set lastUpdated to be today's date
            // can use DateTime.Today or DateTime.Now
            LastUpdated = DateTime.Now;
        }
        // add a menu item to the menu
        // add a menu item into our list of menu items
        // instance or static?
        // input is some menu item object
        // take that menu item and add it into the Items list
        public void AddItem(MenuItem item)
        {
            // since we are modifying a non-static property of our class,
            // we need this method to be an instace method
            Items.Add(item);
        }

        // print all the descriptions of all of the menu items on our menu
        // instance or static?
        // what are our inputs/outputs if any? nope, it just prints stuff
        // how do we print all the items in a list?
        public void PrintMenu()
        {
            foreach (MenuItem item in Items)
            {
                // specifically we want to print the descriptions of each item
                Console.WriteLine(item.Description);
            }
        }





        // static method example!!!
        public static void PrintString()
        {
            Console.WriteLine("This method is static!");
        }
    }
}
