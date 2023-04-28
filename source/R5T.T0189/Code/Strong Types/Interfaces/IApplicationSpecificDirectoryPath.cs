using System;

using R5T.T0178;
using R5T.T0180;


namespace R5T.T0189
{
    /// <summary>
    /// Strongly-types a string as an application-specific directory path.
    /// </summary>
    [StrongTypeMarker]
    public interface IApplicationSpecificDirectoryPath : IStrongTypeMarker,
        IDirectoryPath
    {
    }
}
