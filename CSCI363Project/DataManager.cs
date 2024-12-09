using System.Collections.Generic;

namespace CSCI363Project
{
    public static class DataManager
    {
        public static List<DriverInfo> Drivers { get; private set; } = new List<DriverInfo>();
        public static List<VehicleInfo> Vehicles { get; private set; } = new List<VehicleInfo>();

        public static void AddDriver(DriverInfo driver)
        {
            if (driver != null)
            {
                Drivers.Add(driver);
            }
        }

        public static void UpdateDriver(int index, DriverInfo updatedDriver)
        {
            if (index >= 0 && index < Drivers.Count)
            {
                Drivers[index] = updatedDriver;
            }
        }

        public static void RemoveDriver(int index)
        {
            if (index >= 0 && index < Drivers.Count)
            {
                Drivers.RemoveAt(index);
            }
        }

        public static void AddVehicle(VehicleInfo vehicle)
        {
            if (vehicle != null)
            {
                Vehicles.Add(vehicle);
            }
        }

        public static void UpdateVehicle(int index, VehicleInfo updatedVehicle)
        {
            if (index >= 0 && index < Vehicles.Count)
            {
                Vehicles[index] = updatedVehicle;
            }
        }

        public static void RemoveVehicle(int index)
        {
            if (index >= 0 && index < Vehicles.Count)
            {
                Vehicles.RemoveAt(index);
            }
        }
    }
}
