using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCFWebService.Model;

namespace WCFWebService.DAL
{
    public class CarRepository
    {
        //CRUD operations
        public void SaveCar(Car car)
        {
            //save it to the database
        }

        public void UpdateCar(Car car)
        {
            Car existingCar = Load(car.Id);
            //update existing car object and update the database with an
            // update sql statement
        }

        public Car Load(int id)
        {
            //load from database and return
            return null; //for making the compile errors go away
        }

        public List<Car> LoadAll()
        {
            //loads all the cars from the database
            return new List<Car>();
        }

        public void Delete(int id)
        {
            //delete the car in the database
            //notice: no check for exists in this class, 
            //not its responsibility and besides its business logic
        }
    }
}
