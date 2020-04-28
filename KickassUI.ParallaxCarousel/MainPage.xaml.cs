using System;
using System.Collections.Generic;
using System.Linq;
using KickassUI.ParallaxCarousel.Models;
using KickassUI.ParallaxCarousel.ViewModels;
using Xamarin.Forms;

namespace KickassUI.ParallaxCarousel
{
    public partial class MainPage : ContentPage
    {
        //private List<Color> _backgroundColors = new List<Color>();

        public MainPage()
        {
            InitializeComponent();

            var model = new MainPageViewModel
            {
                Appetizers = new List<CarouselItem>()
                {
                    // Just create some dummy data here for now.
                    new CarouselItem{ ImageSrc="oranges.png", Name = "ORANGE AWESOMENESS", Price = 120, BackgroundColor= Color.Maroon, StartColor=Color.Maroon,  EndColor=Color.Black, Description="An orange has a tough shiny orange skin. Inside, the fruit is divided into segments, which have thin tough skins that hold together many little sections with juice inside."},//BackgroundColor= Color.FromHex("#9866d5") //FromHex("#f3463f") //FromHex("#fece49")
                    new CarouselItem{ ImageSrc="tomato.png", Name = "TERRIBLE TOMATO", Price = 129, BackgroundColor= Color.Maroon, StartColor=Color.Maroon,  EndColor=Color.Black, Description=" Labelled as a vegetable for nutritional purposes, tomatoes are a good source of vitamin C and the phytochemical lycopene."},//FromHex("#fab62a")  //FromHex("#fab62a")
                    new CarouselItem{ ImageSrc="pear.png", Name = "PEAR PARTY", Price = 140, BackgroundColor= Color.Maroon, StartColor=Color.Maroon,  EndColor=Color.Black, Description="A pear is a sweet, juicy fruit which is narrow near its stalk, and wider and rounded at the bottom. Pears have white flesh and thin green or yellow skin."}//FromHex("#425cfc")  //FromHex("#ccee44")
                },

                Entrées = new List<CarouselItem>()
                {
                    // Just create some dummy data here for now.
                    new CarouselItem{ ImageSrc="oranges.png", Name = "ORANGE AWESOMENESS", Price = 120, BackgroundColor= Color.FromHex("#42a7ff"), StartColor=Color.FromHex("#42a7ff"),  EndColor=Color.Black, Description="An orange has a tough shiny orange skin. Inside, the fruit is divided into segments, which have thin tough skins that hold together many little sections with juice inside."},//FromHex("#f3463f") //FromHex("#fece49")
                    new CarouselItem{ ImageSrc="tomato.png", Name = "TERRIBLE TOMATO", Price = 129, BackgroundColor= Color.FromHex("#42a7ff"), StartColor=Color.FromHex("#42a7ff"),  EndColor=Color.Black, Description=" Labelled as a vegetable for nutritional purposes, tomatoes are a good source of vitamin C and the phytochemical lycopene."}, //FromHex("#fab62a")
                    new CarouselItem{ ImageSrc="pear.png", Name = "PEAR PARTY", Price = 140, BackgroundColor= Color.FromHex("#42a7ff"), StartColor=Color.FromHex("#42a7ff"),  EndColor=Color.Black, Description="A pear is a sweet, juicy fruit which is narrow near its stalk, and wider and rounded at the bottom. Pears have white flesh and thin green or yellow skin."} //FromHex("#ccee44")
                },

                Desserts = new List<CarouselItem>()
                {
                    // Just create some dummy data here for now.
                    new CarouselItem{ ImageSrc="oranges.png", Name = "ORANGE AWESOMENESS", Price = 120, BackgroundColor= Color.FromHex("#33ccf3"), StartColor=Color.FromHex("#33ccf3"),  EndColor=Color.Black, Description="An orange has a tough shiny orange skin. Inside, the fruit is divided into segments, which have thin tough skins that hold together many little sections with juice inside."},//FromHex("#f3463f") //FromHex("#fece49")
                    new CarouselItem{ ImageSrc="tomato.png", Name = "TERRIBLE TOMATO", Price = 129, BackgroundColor= Color.FromHex("#33ccf3"), StartColor=Color.FromHex("#33ccf3"),  EndColor=Color.Black, Description=" Labelled as a vegetable for nutritional purposes, tomatoes are a good source of vitamin C and the phytochemical lycopene."}, //FromHex("#fab62a")
                    new CarouselItem{ ImageSrc="pear.png", Name = "PEAR PARTY", Price = 140, BackgroundColor= Color.FromHex("#33ccf3"), StartColor=Color.FromHex("#33ccf3"),  EndColor=Color.Black, Description="A pear is a sweet, juicy fruit which is narrow near its stalk, and wider and rounded at the bottom. Pears have white flesh and thin green or yellow skin."} //FromHex("#ccee44")
                },

                Drinks = new List<CarouselItem>()
                {
                    // Just create some dummy data here for now.
                    new CarouselItem{ ImageSrc="coffee.png", Name = "COFFEE DELIGHT", Price = 120, BackgroundColor= Color.ForestGreen, StartColor=Color.ForestGreen,  EndColor=Color.Black, Description="An orange has a tough shiny orange skin. Inside, the fruit is divided into segments, which have thin tough skins that hold together many little sections with juice inside."},//FromHex("#f3463f") //FromHex("#fece49")
                    new CarouselItem{ ImageSrc="marshmallows.png", Name = "GOOEY MARSHMALLOWS", Price = 129, BackgroundColor= Color.ForestGreen, StartColor=Color.ForestGreen,  EndColor=Color.Black, Description=" Labelled as a vegetable for nutritional purposes, tomatoes are a good source of vitamin C and the phytochemical lycopene."}, //FromHex("#fab62a")
                    new CarouselItem{ ImageSrc="strawberry.png", Name = "STRAWBERRY LIVIN", Price = 140, BackgroundColor= Color.ForestGreen, StartColor=Color.ForestGreen,  EndColor=Color.Black, Description="A pear is a sweet, juicy fruit which is narrow near its stalk, and wider and rounded at the bottom. Pears have white flesh and thin green or yellow skin."} //FromHex("#ccee44")
                }
            };

            BindingContext = model;

            //    // Create out a list of background colors based on our items colors so we can do a gradient on scroll.
            //    for (int i = 0; i < model.Items.Count; i++)
            //    {
            //        var current = model.Items[i];
            //        var next = model.Items.Count > i + 1 ? model.Items[i + 1] : null;

            //        if (next != null)
            //            _backgroundColors.AddRange(SetGradients(current.BackgroundColor, next.BackgroundColor, 375));
            //        else
            //            _backgroundColors.Add(current.BackgroundColor);
            //    }
        }

        // Function to go into "CartPage" which is a list view page
        private void CartButton_Clicked(object sender, EventArgs e)
        {
            App.Current.MainPage = new CartPage();
        }

        public void Handle_Scrolled(object sender, ItemsViewScrolledEventArgs e)
        {
            //var position = e.HorizontalOffset;

            //Set the background color of our page to the item in the color gradient
            /*array, matching the current scrollindex.
        if (position > _backgroundColors.Count - 1)
        page.BackgroundColor = _backgroundColors.Last();
        else if (position < 0)
        page.BackgroundColor = _backgroundColors.First();
        else
        page.BackgroundColor = _backgroundColors[(int)position];


         Set the background color of our page1 to the item in the color gradient
         array, matching the current scrollindex.
        if (position > _backgroundColors.Count - 1)
            page1.BackgroundColor = _backgroundColors.Last();
        else if (position < 0)
            page1.BackgroundColor = _backgroundColors.First();
        else
            page1.BackgroundColor = _backgroundColors[(int)position];


         Set the background color of our page2 to the item in the color gradient
         array, matching the current scrollindex.
        if (position > _backgroundColors.Count - 1)
            page2.BackgroundColor = _backgroundColors.Last();
        else if (position < 0)
            page2.BackgroundColor = _backgroundColors.First();
        else
            page2.BackgroundColor = _backgroundColors[(int)position];


         Set the background color of our page3 to the item in the color gradient
         array, matching the current scrollindex.
        if (position > _backgroundColors.Count - 1)
            page3.BackgroundColor = _backgroundColors.Last();
        else if (position < 0)
            page3.BackgroundColor = _backgroundColors.First();
        else
            page3.BackgroundColor = _backgroundColors[(int)position];*/
        }


        //protected override void OnAppearing()
        //{
        //base.OnAppearing();

        // Need to start somewhere...
        /*page.BackgroundColor = _backgroundColors.First();
        page1.BackgroundColor = _backgroundColors.Last();
        page2.BackgroundColor = _backgroundColors.Last();
        page3.BackgroundColor = _backgroundColors.Last();*/
        //}

        // Create a list of all the colors in between our start and end color.
        //public static IEnumerable<Color> SetGradients(Color start, Color end, int steps)
        //{
        //    var colorList = new List<Color>();

        //    double aStep = ((end.A * 255) - (start.A * 255)) / steps;
        //    double rStep = ((end.R * 255) - (start.R * 255)) / steps;
        //    double gStep = ((end.G * 255) - (start.G * 255)) / steps;
        //    double bStep = ((end.B * 255) - (start.B * 255)) / steps;

        //    for (int i = 0; i < steps; i++)
        //    {
        //        var a = (start.A * 255) + (int)(aStep * i);
        //        var r = (start.R * 255) + (int)(rStep * i);
        //        var g = (start.G * 255) + (int)(gStep * i);
        //        var b = (start.B * 255) + (int)(bStep * i);

        //        colorList.Add(Color.FromRgba(r / 255, g / 255, b / 255, a / 255));
        //    }

        //    return colorList;
        //}
    }
}
