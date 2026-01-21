namespace CrudOperationWithDTOs.Models
{
    public class Product
    {
        public int Id { get; set; }//1,2,3
        public string Name { get; set; }
        public string Description { get; set; }
        //Add new field in the database
        public int Price { get; set; }
        //i added here mistakely
        public string ProductCode { get; set; }


    }
}


//Single Responsibility Principle-


/// a class should have only one reaposibility and one reason to change



//student--
//Profuct
//order




///

// domain model-- dto----service layer--controller layer

//Dto
//Data Transfer Object

// we can use dto for security purpose, we can hide some properties from the client side

// we can use dto for validation purpose, improve our application performance


//client want only name




//user 
//


//