using System;

using R5T.T0178;
using R5T.T0179;


namespace R5T.T0189
{
    /// <inheritdoc cref="IRunSpecificDirectoryPath"/>
    [StrongTypeImplementationMarker]
    public class RunSpecificDirectoryPath : TypedBase<string>, IStrongTypeMarker,
        IRunSpecificDirectoryPath
    {
        public RunSpecificDirectoryPath(string value)
            : base(value)
        {
        }
    }
}
