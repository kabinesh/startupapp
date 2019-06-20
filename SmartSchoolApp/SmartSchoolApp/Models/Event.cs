using System;
using System.Collections.Generic;
using System.Text;

namespace SmartSchoolApp.Models
{
    public class Event
    {
        public int GalleryId { get; set; }

        public string Msg { get; set; }

        public string Description { get; set; }

        public int ImageCount
        {
            get
            {
                return ImgUrl != null ? ImgUrl.Count : 0;
            }
        }

        public string EventOn { get; set; }

        public List<string> ImgUrl { get; set; }

        public string FirstImage
        {
            get
            {
                return ImgUrl != null && ImgUrl.Count > 0 ? string.Format("{0}{1}", App.BaseUrl, ImgUrl[0]) : null;
            }
         }
        public string SecondImage
        {
            get
            {
                return ImgUrl != null && ImgUrl.Count > 1 ? string.Format("{0}{1}", App.BaseUrl, ImgUrl[1]) : null;
            }
        }
        public string ThirdImage
        {
            get
            {
                return ImgUrl != null && ImgUrl.Count > 2 ? string.Format("{0}{1}", App.BaseUrl, ImgUrl[2]) : null;
            }
        }
        public string FourthImage
        {
            get
            {
                return ImgUrl != null && ImgUrl.Count > 3 ? string.Format("{0}{1}", App.BaseUrl, ImgUrl[3]) : null;
            }
        }
        public string FifthImage
        {
            get
            {
                return ImgUrl != null && ImgUrl.Count > 4 ? string.Format("{0}{1}", App.BaseUrl, ImgUrl[4]) : null;
            }
        }
    }
}
