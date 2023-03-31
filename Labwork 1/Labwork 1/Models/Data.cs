using System.Collections.Generic;

namespace Labwork_1.Models
{
    public class Data
    {
       public static List<Slider> sliderList = new List<Slider> {
                new Slider { Id=1,Desc="Amin Yek",Title="Bilirsinizmi?",ButtonLink="google.com",ButtonText="Bura bas",ImgSrc="url(../assets/img/slide/slide-1.jpg)"},
                new Slider { Id=2,Desc="Elvin Yekdir",Title="Bilirsinizmi?",ButtonLink="google.com",ButtonText="Bura bas",ImgSrc="url(../assets/img/slide/slide-2.jpg)"},
                new Slider { Id=3,Desc="Tural Yekdi",Title="Bilirsinizmi?",ButtonLink="google.com",ButtonText="Bura bas",ImgSrc="url(../assets/img/slide/slide-3.jpg)"},
                new Slider { Id=4,Desc="Reshad Yek deyil",Title="Bilirsinizmi?",ButtonLink="google.com",ButtonText="Bura bas",ImgSrc="url(../assets/img/slide/slide-2.jpg)"},
                };
        public static List<Service> serviceList = new List<Service> {
                new Service { Id=1,Desc="Amin Yek",Title="Bilirsinizmi?",IconUrl="bi bi-briefcase"},
                new Service { Id=2,Desc="Amin Yek",Title="Bilirsinizmi?",IconUrl="bi bi-card-checklist"},
                new Service { Id=3,Desc="Amin Yek",Title="Bilirsinizmi?",IconUrl="bi bi-bar-chart"},
                new Service { Id=4,Desc="Amin Yek",Title="Bilirsinizmi?",IconUrl="bi bi-binoculars"},
                new Service { Id=5,Desc="Amin Yek",Title="Bilirsinizmi?",IconUrl="bi bi-brightness-high"},
                new Service { Id=6,Desc="Amin Yek",Title="Bilirsinizmi?",IconUrl="bi bi-calendar4-week"},
                };


    }
}
