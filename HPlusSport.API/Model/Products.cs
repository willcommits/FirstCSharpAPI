using System.Text.Json.Serialization;

namespace HPlusSport.API.Model
{
    public class Products
    {
        public int Id { get; set; }
        public String Sku { get; set; } = String.Empty;
        public String Name { get; set; } = String.Empty;
        public String Description { get; set; } = String.Empty;
        public Decimal Price { get; set; }
        public Boolean IsAvailable { get; set; }
        public int CategoryId { get; set; }
        [JsonIgnore]
        public virtual Category category { get; set; }

    }
}
