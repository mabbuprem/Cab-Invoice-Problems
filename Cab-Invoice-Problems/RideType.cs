﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cab_Invoice_Problem
{
    public enum TypeOfRide
    {
        NORMAL_RIDE, PREMIUM_RIDE
    }
    public class RideType
    {
        public int COST_PER_KM;
        public int COST_PER_MINUTE;
        public int MINIMUM_FARE;

        public TypeOfRide typeOfRide;

        public object InitializingDetailsAsPerRideType(TypeOfRide ride)
        {
            switch (ride)
            {
                case TypeOfRide.NORMAL_RIDE:
                    this.COST_PER_KM = 10;
                    this.COST_PER_MINUTE = 1;
                    this.MINIMUM_FARE = 5;
                    return this;
                case TypeOfRide.PREMIUM_RIDE:
                    this.COST_PER_KM = 15;
                    this.COST_PER_MINUTE = 2;
                    this.MINIMUM_FARE = 20;
                    return this;
                default:
                    return null;
            }
        }
    }
}
