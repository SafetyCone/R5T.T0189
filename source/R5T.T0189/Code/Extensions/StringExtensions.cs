using System;


namespace R5T.T0189.Extensions
{
    public static class StringExtensions
    {
        public static IApplicationSpecificDirectoryPath ToApplicationSpecificDirectoryPath(this string value)
        {
            return Instances.StringOperator_Extensions.ToApplicationSpecificDirectoryPath(value);
        }

        public static IDateSpecificDirectoryPath ToDateSpecificDirectoryPath(this string value)
        {
            return Instances.StringOperator_Extensions.ToDateSpecificDirectoryPath(value);
        }

        public static IRunSpecificDirectoryPath ToRunSpecificDirectoryPath(this string value)
        {
            return Instances.StringOperator_Extensions.ToRunSpecificDirectoryPath(value);
        }
    }
}
