﻿using System;
using Newtonsoft.Json;

namespace Syncromatics.Clients.WaySine.Models
{
    public class Sign
    {
        [JsonProperty("UtcTimeStamp")]
        private DateTimeOffset _utcTimeStamp;

        [JsonProperty("SignID")]
        public int SignId { get; set; }

        // The API gives us the UTC DateTime without any timezone information,
        // so the deserializer assumes it is in system local time.  This
        // gets rid of the added timezone.
        [JsonIgnore]
        public DateTimeOffset UtcTimeStamp =>
            _utcTimeStamp.Add(_utcTimeStamp.Offset);

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