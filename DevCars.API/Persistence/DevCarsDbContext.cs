using DevCars.API.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevCars.API.Persistence
{
    public class DevCarsDbContext
    {
        public DevCarsDbContext()
        {
            Cars = new List<Car>
            {
                new Car(1, "123ABC", "HONDA", "CIVC", 2021, 85999, "CINZA", new DateTime(2021, 1, 1)),
                new Car(2, "152FAS", "VW", "GOL", 2021, 52333, "ROXO", new DateTime(2021, 2, 2)),
                new Car(3, "235ASD", "HYUNDAI", "HB20", 2021, 49555, "ROZA", new DateTime(2021, 5, 19)),
            };

            Customers = new List<Customer>
            {
                new Customer(1, "EZEQUIEL", "15161511", new DateTime(2000, 11, 11)),
                new Customer(2, "JOSE", "5165115", new DateTime(2001, 12, 05)),
                new Customer(3, "PAOLA", "9481181", new DateTime(1998, 05, 21)),
            };
        }
        
        public List<Car> Cars { get; set; }
        public List<Customer> Customers { get; set; }
}
}
