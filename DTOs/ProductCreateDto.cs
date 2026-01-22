namespace CrudOperationWithDTOs.DTOs
{
    public class ProductCreateDto
    {
        public string Name { get; set; }
        public string Description { get; set; }

        public int Price   { get; set; }
        public string ProductCode { get; set; }

    }
}
