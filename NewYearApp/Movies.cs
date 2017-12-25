using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NewYearApp
{
    public class Movies
    {
        public Dictionary<string, string> Films = new Dictionary<string, string>();

        public Movies()
        {
            Films.Add("Lava", "<iframe width=\"720\" height=\"405\" src=\"//rutube.ru/play/embed/9588943\" frameborder=\"0\" webkitAllowFullScreen mozallowfullscreen allowfullscreen></iframe>");
            Films.Add("Olaf", "<iframe src=\"http://kodik.cc/video/20167/baabc11a2fd3ed8668e4081114181448/720p\" width=\"607\" height=\"360\" frameborder=\"0\" AllowFullScreen></iframe>");
            Films.Add("Forgotten", "<iframe width=\"853\" height=\"480\" src=\"//ok.ru/videoembed/229470571103\" frameborder=\"0\" allowfullscreen></iframe>");
            Films.Add("Chess", "<iframe width=\"854\" height=\"480\" src=\"https://www.youtube.com/embed/9IYRC7g2ICg\" frameborder=\"0\" gesture=\"media\" allow=\"encrypted-media\" allowfullscreen></iframe>");
            Films.Add("Umbrella", "<iframe width=\"853\" height=\"480\" src=\"//ok.ru/videoembed/252498479723\" frameborder=\"0\" allowfullscreen></iframe>");
            Films.Add("Legend", "<iframe width=\"854\" height=\"480\" src=\"https://www.youtube.com/embed/OFkWTG2P4iY\" frameborder=\"0\" gesture=\"media\" allow=\"encrypted-media\" allowfullscreen></iframe>");
            Films.Add("Band", "<iframe width=\"853\" height=\"480\" src=\"//ok.ru/videoembed/94074178219\" frameborder=\"0\" allowfullscreen></iframe>");
            Films.Add("Lifted", "<iframe width=\"854\" height=\"480\" src=\"https://www.youtube.com/embed/MSrOCfTSNO8\" frameborder=\"0\" gesture=\"media\" allow=\"encrypted-media\" allowfullscreen></iframe>");
            Films.Add("Birds", "<iframe width=\"854\" height=\"480\" src=\"https://www.youtube.com/embed/ePxF_g5LQhc\" frameborder=\"0\" gesture=\"media\" allow=\"encrypted-media\" allowfullscreen></iframe>");
            Films.Add("DayNight", "<iframe width=\"854\" height=\"480\" src=\"https://www.youtube.com/embed/_N69mpOOJNM\" frameborder=\"0\" gesture=\"media\" allow=\"encrypted-media\" allowfullscreen></iframe>");





        }
    }
}