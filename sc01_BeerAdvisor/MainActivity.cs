using Android.App;
using Android.Widget;
using Android.OS;
using System.Collections.Generic;

namespace sc01_BeerAdvisor
{
    [Activity(Label = "sc01_BeerAdvisor", MainLauncher = true)]
    public class MainActivity : Activity
    {
        private BeerExpert myExpert = new BeerExpert();

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            Spinner beerColor = FindViewById<Spinner>(Resource.Id.beer_color);
            TextView brands = FindViewById<TextView>(Resource.Id.beer_brands);
            Button btnRecBeer = FindViewById<Button>(Resource.Id.btn_find_beer);

            btnRecBeer.Click += delegate
            {
                brands.Text = string.Empty;
                List<string> myBrandList = myExpert.getBrands(beerColor.SelectedItem.ToString());

                for (int i = 0; i < myBrandList.Count; i++)
                {
                    brands.Text += myBrandList[i] + "\n";
                }
            };
            
        }
    }
}

