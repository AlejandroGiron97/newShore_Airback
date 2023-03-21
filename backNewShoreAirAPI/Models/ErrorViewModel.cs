using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace backNewShoreAirAPI.Models
{
    public class ErrorViewModel
    {
        public string? RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}
