using System;

using R5T.T0178;
using R5T.T0179;


namespace R5T.T0189
{
    /// <inheritdoc cref="IApplicationSpecificDirectoryPath"/>
    [StrongTypeImplementationMarker]
    public class ApplicationSpecificDirectoryPath : TypedBase<string>, IStrongTypeMarker,
        IApplicationSpecificDirectoryPath
    {
        public ApplicationSpecificDirectoryPath(string value)
            : base(value)
        {
        }
    }
}
