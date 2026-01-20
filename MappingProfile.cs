using AutoMapper;
using CrudOperationWithDTOs.DTOs;
using CrudOperationWithDTOs.Models;

namespace CrudOperationWithDTOs

{
    
    // here we are configuring the mapping between ProductCreateDto and Product model
    public class MappingProfile:Profile
    {
        public MappingProfile()
        {

            // we can get data from ProductCreateDto and map it to  domain Product model

            //Add new field in the database 
            CreateMap<ProductCreateDto, Product>();


            // this is for the getall api
            // Product ---> Productreaddto
            CreateMap<Product, ProductReadAndUpdateDto>().ReverseMap();




            //10
            // this is for the update api

           // CreateMap<ProductReadAndUpdateDto, Product>();

        }
    }
}

//
