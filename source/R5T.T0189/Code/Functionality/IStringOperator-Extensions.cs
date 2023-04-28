using System;

using R5T.T0132;


namespace R5T.T0189.Extensions
{
    [FunctionalityMarker]
    public partial interface IStringOperator : IFunctionalityMarker
    {
        public IApplicationSpecificDirectoryPath ToApplicationSpecificDirectoryPath(string value)
        {
            var output = new ApplicationSpecificDirectoryPath(value);
            return output;
        }

        public IDateSpecificDirectoryPath ToDateSpecificDirectoryPath(string value)
        {
            var output = new DateSpecificDirectoryPath(value);
            return output;
        }

        public IRunSpecificDirectoryPath ToRunSpecificDirectoryPath(string value)
        {
            var output = new RunSpecificDirectoryPath(value);
            return output;
        }
    }
}
