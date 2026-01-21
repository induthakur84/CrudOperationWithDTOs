namespace CrudOperationWithDTOs.DTOs
{
    public class ProductReadAndUpdateDto
    {
        public int Id { get; set; }//1,2,3
        public string Name { get; set; }
        public string Description { get; set; }

        public int Price { get; set; }
    }
}
