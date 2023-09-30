using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractAndInterface
{
    public interface IVehicle
    {
        void Go();
        void Stop();
    }

    public interface IReadable
    {
        void Ride();
    }

    public interface IFlyable 
    { 
        void Soar();
    }

    public abstract class BaseVehicle: IVehicle
    {
        public void Go()
        {
            Console.WriteLine("Vehicle is going..");
        }
        public void Stop()
        {
            Console.WriteLine("Vehicle is stopped..");
        }
    }

    public class Car : BaseVehicle
    {
       
    }

    public class Bike : BaseVehicle, IReadable
    {
        public void Ride()
        {
            throw new NotImplementedException();
        }
    }

    public class Plane : BaseVehicle, IFlyable
    {
        public void Soar()
        {
            throw new NotImplementedException();
        }
    }
}
