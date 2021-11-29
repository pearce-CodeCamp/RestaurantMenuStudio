using System;
using System.Collections.Generic;
using System.Text;

namespace RestaurantMenu
{
    internal class MenuItem
    {
        // properties: name:string, price: double, description: string, category: string,
        // and isNew: bool
        // How could we tell if a menu item is new or not?
        // When we first create a menu item, isNew should probably be set to True
        // But we probably need to track when the item was created/added to the menu
        // if we want to track if the menu item is still or not
        public double Price { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
        public bool IsNew { get; set; }

        public MenuItem(double price, string desc, string category)
        {
            Price = price;
            Description = desc;
            Category = category;
            // have isNew set to true by default
            IsNew = true;
        }
    }
}
