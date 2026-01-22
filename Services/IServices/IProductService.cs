using CrudOperationWithDTOs.DTOs;

namespace CrudOperationWithDTOs.Services.IServices
{
    public interface IProductService
    {
        Task<IEnumerable<ProductReadAndUpdateDto>> GetAll();   

        //Get Product by Id
        Task<ProductReadAndUpdateDto> GetById(int id);
        //Create Product

        Task<ProductReadAndUpdateDto> Create(ProductCreateDto productCreateDto);
        Task<ProductReadAndUpdateDto> Update(ProductReadAndUpdateDto productReadAndUpdateDto);

        Task<ProductReadAndUpdateDto> DeleteById(int id);

      //  Task<bool> ProductExists(int id);
      //  Task<bool> SaveChangesAsync();

    }
}


//interface segregation principle-> clients should not be forced to depend on methods they do not use
// and we make small and specific interfaces rather than large interfaces







//


// Dependency Inversion Principle-> high level module should not depend on low level module both should depend on abstraction

// O-Open-closed principle-> a class should be open for extension but closed for modification




// we can abstraction with the help of interface because in the controller we inject the interface rather than 
//writing all the code in the controller


//C# We can mulitiple inheritance with the help of interface but not with class

