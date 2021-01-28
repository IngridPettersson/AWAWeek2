﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ClassesInstancesAndConstructors
{
    class Car
    {
        public int NumberOfDoors { get; set; }
        public string Brand { get; set; }
        public string Make { get; set; }
        public string TypeOfFuel { get; set; }
        public int YearOfManufacture { get; set; }
        public string LicenseNumber { get; set; }

        int currentSpeed;

        public void IncreaseCurrentSpeed(int increase)
        {
            currentSpeed += increase;
            VeryComplexInternalMethodToFeedFuelToEngine();
        }

        // ska vara privat
        void VeryComplexInternalMethodToFeedFuelToEngine()
        {
            // komplexa saker
        }
    }
}
