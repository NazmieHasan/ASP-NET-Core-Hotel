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

            public const int BedsMinValue = 1;
            public const int BedsMaxValue = 10;

            public const string PriceMinValue = "0";
            public const string PriceMaxValue = "2000";

            public const int ImageUrlMaxLength = 2048;
        }

        public static class Room
        {
            public const int NumberMinValue = 201;
            public const int NumberMaxValue = 1000;
        }

        public class Booking
        {
            public const int PhoneNumberMinLength = 7;
            public const int PhoneNumberMaxLength = 15;
        }

        public static class User
        {
            public const int PasswordMinLength = 6;
            public const int PasswordMaxLength = 100;

            public const int FirstNameMinLength = 1;
            public const int FirstNameMaxLength = 15;

            public const int LastNameMinLength = 1;
            public const int LastNameMaxLength = 15;
        }
    }
}