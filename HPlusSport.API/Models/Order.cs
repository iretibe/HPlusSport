using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace HPlusSport.API.Models
{
    public class Order
    {
        public int Id { get; set; }
        public DateTime OrderDate { get; set; }
        public int UserId { get; set; }

        [JsonIgnore]
        public virtual Users User { get; set; }
        public List<Product> Products { get; set; }
    }
}
