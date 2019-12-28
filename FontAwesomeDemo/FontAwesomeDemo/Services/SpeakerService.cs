using FontAwesomeDemo.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace FontAwesomeDemo.Services
{
    public class SpeakerService
    {
        public List<Speaker> Getspeaker()
        {
            return new List<Speaker>()
            {
                new Speaker
                {
                  Name ="Emilio Barrera",
                  ShortDescription = "Emilio Barrera Veleoper from Colombia, Of Asp.Net core, Xmarin",
                  ImageUrl = "Emilio.jpg",
                  TwitterUrl = "https://twitter.com/EmilioBarreraS2",
                  YoutubeUrl = "https://www.youtube.com/channel/UClHVioCA72FmdlJXxMBzWyg?view_as=subscriber",
                  FacebookUrl = "https://www.facebook.com/emilio.barrera.10",
                },

                new Speaker
                {
                  Name ="Mister Cat",
                  ShortDescription = "CAt CEO founder of c# Corner.",
                  ImageUrl = "gato.jpg",
                  TwitterUrl = "https://twitter.com/EmilioBarreraS2",
                  YoutubeUrl = "https://www.youtube.com/channel/UClHVioCA72FmdlJXxMBzWyg?view_as=subscriber",
                  FacebookUrl = "https://www.facebook.com/emilio.barrera.10",
                },
                new Speaker
                {
                  Name ="Mister Dog",
                  ShortDescription = "Dog is a SqlServer Senior..",
                  ImageUrl = "perro.jpg",
                  TwitterUrl = "https://twitter.com/EmilioBarreraS2",
                  YoutubeUrl = "https://www.youtube.com/channel/UClHVioCA72FmdlJXxMBzWyg?view_as=subscriber",
                  FacebookUrl = "https://www.facebook.com/emilio.barrera.10",
                },
            };
        }
    }
}
