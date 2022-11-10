using Newtonsoft.Json;

namespace APIWithUnitOfWork.Models
{
    public class Error
    {
        public string StatusCode { get; set; }
        public string Message { get; set; }
        public override string ToString() => JsonConvert.SerializeObject(this);

    }
}
