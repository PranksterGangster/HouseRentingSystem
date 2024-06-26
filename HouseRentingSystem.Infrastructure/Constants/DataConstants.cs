﻿namespace HouseRentingSystem.Infrastructure.Constants
{
    public static class DataConstants
    {
        public const int CategoryMaxLength = 50;

        public const int HouseTitleMinLength = 10;
        public const int HouseTitleMaxLength = 50;

        public const int HouseAddressMinLength = 30;
        public const int HouseAddressMaxLength = 150;

        public const int HouseDescMinLength = 50;
        public const int HouseDescMaxLength = 500;

        public const string HousePricePerMonthMin = "0.00";
        public const string HousePricePerMonthMax = "2000.00";

        public const int AgentPhoneMinLength = 7;
        public const int AgentPhoneMaxLength = 15;
    }
}
