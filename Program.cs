using System;

namespace RestaurantMenu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // let's invoke the static method PrintString from the Menu class
            // Menu.PrintString();

            Menu studioMenu = new Menu("Studio Menu");
            // this line throws an error since PrintString is a static method
            // studioMenu.PrintString();

            Console.WriteLine(studioMenu.Title);
            Console.WriteLine(studioMenu.Items);
            Console.WriteLine(studioMenu.Items.Count);
            Console.WriteLine(studioMenu.LastUpdated);

            MenuItem soup = new MenuItem(7.50, "Butternut Squash Soup", "appetizer");
            Console.WriteLine(soup.Price);
            Console.WriteLine(soup.Description);
            Console.WriteLine(soup.Category);
            Console.WriteLine();

            MenuItem pumpkinPie = new MenuItem(5.67, "Slice of pumpkin pie", "dessert");
            // add the soup item onto our menu
            // this is how we would it without defining our custom AddItem method
            // studioMenu.Items.Add(soup);
            // using the AddItem
            studioMenu.AddItem(soup);
            studioMenu.AddItem(pumpkinPie);
            studioMenu.PrintMenu();
        }
    }
}
