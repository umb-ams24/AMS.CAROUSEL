namespace AMST4.carousel.mvc.Models
{
    public class Category
    {
        public Guid Id { get; set; }
        public string Description { get; set; }
        public string ImageUrl {  get; set; }
        public bool IsActive {  get; set; }
    }
}
