namespace Ejercicio1;

public class VehicleDealership
{
    //Validate if is a Classic Vehicle
    
    public bool IsClassicVehicle(object v) 
    { 
        if (v is Car) { 
            Car c = v as Car; 
            var currentYear = DateTime.Now.Year; 
            int ageInt = currentYear - c.Year;
         
            if (ageInt > 20 && c.Brand.ClassicBrands) 
            { 
                return true; 
            }
        } 
        
        else if (v is Truck) { 
            Truck t = v as Truck; 
            var currentYear = DateTime.Now.Year; 
            int ageInt = currentYear - t.Year; 
            
            // A truck is considered classic if it's older than 30 years 
            if (ageInt > 30) 
            { 
                return true; 
            }
        }
        // No vehicle type found.
        else
        {
            return false; 
        }

        return false;
    } 
}