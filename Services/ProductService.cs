using AutoMapper;
using CrudOperationWithDTOs.DTOs;
using CrudOperationWithDTOs.Services.IServices;

namespace CrudOperationWithDTOs.Services
{

    // here we also implement encapsulation because all the database related code is in this service class
    // means data and methods are wrapped in a single unit. we also its like business logic layer
    public class ProductService : IProductService
    {
        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;
        public ProductService(ApplicationDbContext context, IMapper mapper)
        { 
            _context = context;
            _mapper = mapper;
        }
        public async Task<ProductReadAndUpdateDto> Create(ProductCreateDto productCreateDto)
        {
            throw new NotImplementedException();
        }

        public async Task<ProductReadAndUpdateDto> DeleteById(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<ProductReadAndUpdateDto>> GetAll()
        {
            throw new NotImplementedException();
        }

        public async Task<ProductReadAndUpdateDto> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<ProductReadAndUpdateDto> Update(ProductReadAndUpdateDto productReadAndUpdateDto)
        {
            throw new NotImplementedException();
        }
    }
}
