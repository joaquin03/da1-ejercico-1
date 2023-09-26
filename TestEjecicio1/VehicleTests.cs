namespace TestEjecicio1;
using Ejercicio1;


[TestClass]
public class VehicleTests
{
    private VehicleDealership vehicleDealership;
    

    [TestInitialize]
    public void TestInitialize()
    {
        vehicleDealership = new VehicleDealership();
    }
    
    [TestMethod]
    public void TestIsClassicCarTrue()
    {
        Car car = new Car { Year = 1990, Brand = new Brand { ClassicBrands = true } };
        Assert.IsTrue(vehicleDealership.IsClassicVehicle(car));
    }

    [TestMethod]
    public void TestIsClassicCarFalseDueToYear()
    {
        Car car = new Car { Year = 2005, Brand = new Brand { ClassicBrands = true } };
        Assert.IsFalse(vehicleDealership.IsClassicVehicle(car));
    }

    [TestMethod]
    public void TestIsClassicCarFalseDueToBrand()
    {
        Car car = new Car { Year = 1990, Brand = new Brand { ClassicBrands = false } };
        Assert.IsFalse(vehicleDealership.IsClassicVehicle(car));
    }

    [TestMethod]
    public void TestIsClassicTruckTrue()
    {
        Truck truck = new Truck { Year = 1980 };
        Assert.IsTrue(vehicleDealership.IsClassicVehicle(truck));
    }

    [TestMethod]
    public void TestIsClassicTruckFalse()
    {
        Truck truck = new Truck { Year = 2000 };
        Assert.IsFalse(vehicleDealership.IsClassicVehicle(truck));
    }
    
    
}