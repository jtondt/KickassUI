using System.Collections.Generic;
using KickassUI.ParallaxCarousel.Models;

namespace KickassUI.ParallaxCarousel.ViewModels
{
    public class MainPageViewModel
    {
        public List<CarouselItem> Appetizers { get; set; } = new List<CarouselItem>();
        public List<CarouselItem> Entrées { get; set; } = new List<CarouselItem>();
        public List<CarouselItem> Desserts { get; set; } = new List<CarouselItem>();
        public List<CarouselItem> Drinks { get; set; } = new List<CarouselItem>();
    }
}
