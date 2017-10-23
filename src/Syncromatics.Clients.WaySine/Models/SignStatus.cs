using System;
using Newtonsoft.Json;

namespace Syncromatics.Clients.WaySine.Models
{
    public class SignStatus
    {
        public double Battery { get; set; }
        public int? CellLink { get; set; }
        public double Current { get; set; }
        public int ID { get; set; }
        public string Link { get; set; }
        public double OpHrs { get; set; }
        [JsonConverter(typeof(UnixTimeMillisecondsConverter))]
        public DateTimeOffset? Polled { get; set; }
        public int Rows { get; set; }
        public double Solar { get; set; }
        public string Status { get; set; }
        public string StopID { get; set; }
        public double Temp { get; set; }
    }
}
