using System;

namespace HTMLtemplateMVC.Models
{
    public class ErrorViewModel
    {

        public ErrorViewModel()
        {
            CustomMessage = " Error Occured while processing your request";
            ActualMessage = " Please Contact Admin";
        }

        public string RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);

        public string CustomMessage { get; set; }
        public string ActualMessage { get; set; }
    }
}
