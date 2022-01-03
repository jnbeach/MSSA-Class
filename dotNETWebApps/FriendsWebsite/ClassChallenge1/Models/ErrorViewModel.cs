namespace ClassChallenge1.Models
{
    public class ErrorViewModel
    {
        //Removed ? from string to make it not nullable.
        public string RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}