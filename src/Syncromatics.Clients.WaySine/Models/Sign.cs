using System;
using Newtonsoft.Json;

namespace Syncromatics.Clients.WaySine.Models
{
    public class Sign
    {
        [JsonProperty("SignID")]
        public int SignId { get; set; }
        public DateTimeOffset UtcTimeStamp { get; set; }
        public DateTime ClientTimeStamp { get; set; }
        public double SolarVoltage { get; set; }
        public double BatteryVoltage { get; set; }
        public double ChargingCurrent { get; set; }
        public double Temperature { get; set; }
        public string Status { get; set; }
        public int CellLinkStrength { get; set; }
        [JsonProperty("StopID")]
        public string StopId { get; set; }
    }
}