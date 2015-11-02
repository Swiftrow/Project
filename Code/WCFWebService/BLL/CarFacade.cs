using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCFWebService.DAL;
using WCFWebService.Model;

namespace WCFWebService.BLL
{
    public class CarFacade
    {
        private CarRepository carRepository;
        private EngineRepository engineRepository;

        public CarFacade()
        {
            carRepository = new CarRepository();
            engineRepository = new EngineRepository();
        }

        public List<Car> LoadAllCars()
        {
            return carRepository.LoadAll();
        }

        public void DeleteCar(int id)
        {
            Car car = carRepository.Load(id);
            bool canDelete = car != null;
            if(canDelete)
            {
                carRepository.Delete(id);
            }
        }

        public Engine LoadEngineFromCar(int carId)
        {
            return engineRepository.Load(carId);
        }
    }
}