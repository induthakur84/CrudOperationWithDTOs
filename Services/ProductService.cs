using AutoMapper;
using CrudOperationWithDTOs.DTOs;
using CrudOperationWithDTOs.Models;
using CrudOperationWithDTOs.Services.IServices;
using Microsoft.EntityFrameworkCore;

namespace CrudOperationWithDTOs.Services
{

    // here we also implement encapsulation because all the database related code is in this service class
    // means data and methods are wrapped in a single unit. we also its like business logic layer
    public class ProductService : IProductService
    {
        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;

        // constructor injection
        //Constructor  is the special member function which is automatically called when the object of the class is created
        public ProductService(ApplicationDbContext context, IMapper mapper)
        { 
            _context = context;
            _mapper = mapper;
        }

        //here we can get the data from the request body and we can map it to the enitity model using automapper and 
        // then we can save it to the database

        // productCreateDto-> Product (entity model) -> save to database

        //
        public async Task<ProductReadAndUpdateDto> Create(ProductCreateDto productCreateDto)
        {

            var product=_mapper.Map<Product>(productCreateDto);
            // when we can add data the database that we can await and when we can get the data from the
            // database that we can use await keyword
            

            await _context.Products.AddAsync(product);
            await _context.SaveChangesAsync();

            //after saving the data to the database
            //we can map the entity model to the dto and return it to the client

            //Product (entity model)->  ProductReadAndUpdateDto->  give to client
          

            return _mapper.Map<ProductReadAndUpdateDto>(product);

        }

        public async Task<ProductReadAndUpdateDto> DeleteById(int id)
        {
           var product= await _context.Products.FindAsync(id);
            if(product==null)
            {
                return null;
            }
            _context.Products.Remove(product);
            await _context.SaveChangesAsync();
            return _mapper.Map<ProductReadAndUpdateDto>(product);
        }


        //this is our query method
        public async Task<IEnumerable<ProductReadAndUpdateDto>> GetAll()
        {
            var products= await _context.Products.ToListAsync();
            return _mapper.Map<IEnumerable<ProductReadAndUpdateDto>>(products);
        }

        public async Task<ProductReadAndUpdateDto> GetById(int id)
        {
            var product= await _context.Products.FindAsync(id);
            if(product==null)
            {
                return null;
            }
            return _mapper.Map<ProductReadAndUpdateDto>(product);

            // return _mapper.Map<destination>(source);
        }



        public async Task<ProductReadAndUpdateDto> Update(ProductReadAndUpdateDto productReadAndUpdateDto)
        {
           var product= await _context.Products.FindAsync(productReadAndUpdateDto.Id);
            if(product==null)
            {
                return null;
            }

            //  _mapper.Map(source, destination);
            _mapper.Map(productReadAndUpdateDto, product);
            //save the changes to the database
            await _context.SaveChangesAsync();
            return _mapper.Map<ProductReadAndUpdateDto>(product);
        }
    }
}
