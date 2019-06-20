using System.Collections.Generic;

namespace SmartSchoolApp.Models.ServiceModels
{
    public class EventsGalleryResponse
    {
        public string Status { get; set; }

        public List<Event> GalleryDetails { get; set; }
    }
}
