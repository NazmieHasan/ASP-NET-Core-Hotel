namespace Hotel.Common
{
    public static class EntityValidationConstants
    {
        public static class Category
        {
            public const int NameMinLength = 5;
            public const int NameMaxLength = 50;

            public const int DescriptionMinLength = 50;
            public const int DescriptionMaxLength = 500;

            public const string BedsMinValue = "1";
            public const string BedsMaxValue = "10";

            public const string PriceMinValue = "0";
            public const string PriceMaxValue = "2000";

            public const int ImageUrlMaxLength = 2048;
        }

        public class Booking
        {
            public const int PhoneNumberMinLength = 7;
            public const int PhoneNumberMaxLength = 15;
        }
    }
}