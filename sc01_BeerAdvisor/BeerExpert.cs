using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace sc01_BeerAdvisor
{
    //Helper class that we call from the MainActivity to consult on beer brands that match certain colors
    public class BeerExpert
    {
        public List<string> getBrands(string color)
        {
            List<string> brands = new List<string>();

            if (color.Equals("Amber"))
            {
                brands.Add("Jack Amber");
                brands.Add("Amber Bach");
            } else if (color.Equals("Light"))
            {
                brands.Add("Corona Light");
                brands.Add("Amstel Light");
            } else if (color.Equals("Brown"))
            {
                brands.Add("Yuengling");
                brands.Add("Gout Stout");
            }
            else
            {
                brands.Add("Guiness");
            }

            return brands;
        }
    }
}