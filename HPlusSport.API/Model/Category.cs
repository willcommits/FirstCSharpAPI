namespace HPlusSport.API.Model
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; } = String.Empty;
        public virtual List<Products>Products { get; set; }
    }
}
