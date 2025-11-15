using System.Net;

namespace MetroVMS.Entity
{
    public class ResponseEntity<T>
    {
        public HttpStatusCode transactionStatus { get; set; }
        public string returnMessage { get; set; }
        public T returnData { get; set; }
        public string status
        {
            get
            {
                return transactionStatus.ToString();
            }
        }

    }
}
