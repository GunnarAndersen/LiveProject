using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;

namespace ManagementPortal.Enums
{
    public enum Avatar
    {
        [Description("Unselected")] Unselected = 0,
        [Description("Fox")] Fox,
        [Description("Cat")] Cat,
        [Description("Dog")] Dog,
        [Description("Human")] Human,
    }
    public class GetImageInfo
    {
        public static void GetImageName()
        {
            string path = "ye";
            Avatar avatar = Avatar.Unselected;

            switch (avatar)
            {
                case Avatar.Fox:
                    Console.WriteLine("One"); //this is all placeholder stuff, please feel free to change it in the future! 
                    break;
                case Avatar.Cat:
                    Console.WriteLine("Two");
                    break;
                case Avatar.Dog:
                    Console.WriteLine("Three");
                    break;
                case Avatar.Human:
                    Console.WriteLine("Four");
                    break;
                default:
                    Console.WriteLine("Unselected");
                    break;
            }
        }
    }
   
}

