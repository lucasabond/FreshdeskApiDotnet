﻿using Newtonsoft.Json;

namespace FreshdeskApi.Client.Companies.Models
{
    public class ExportCsv
    {
        /// <summary>
        /// The Id of the export being processed
        /// </summary>
        [JsonProperty("id")]
        public string? Id { get; set; }

        /// <summary>
        /// The status of the export being carried out (in progress/finished/etc)
        /// </summary>
        [JsonProperty("status")]
        public string? Status { get; set; }

        /// <summary>
        /// The URL for the csv contents of the download when the export is complete
        /// </summary>
        [JsonProperty("download_url")]
        public string? DownloadUrl { get; set; }

        /// <summary>
        /// Error message if an error occurs
        /// </summary>
        [JsonProperty("message")]
        public string? Message { get; set; }

        /// <summary>
        /// Code error if an error occurs
        /// </summary>
        [JsonProperty("code")]
        public string? CodeError { get; set; }
    }
}
