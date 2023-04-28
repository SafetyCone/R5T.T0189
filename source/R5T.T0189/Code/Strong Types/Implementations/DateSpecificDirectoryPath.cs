using System;

using R5T.T0178;
using R5T.T0179;


namespace R5T.T0189
{
    /// <inheritdoc cref="IDateSpecificDirectoryPath"/>
    [StrongTypeImplementationMarker]
    public class DateSpecificDirectoryPath : TypedBase<string>, IStrongTypeMarker,
        IDateSpecificDirectoryPath
    {
        public DateSpecificDirectoryPath(string value)
            : base(value)
        {
        }
    }
}
