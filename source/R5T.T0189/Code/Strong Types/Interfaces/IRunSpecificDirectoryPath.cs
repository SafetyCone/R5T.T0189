using System;

using R5T.T0178;
using R5T.T0180;


namespace R5T.T0189
{
    /// <summary>
    /// Strongly-types a string as a run-specific directory path.
    /// </summary>
    [StrongTypeMarker]
    public interface IRunSpecificDirectoryPath : IStrongTypeMarker,
        IDirectoryPath
    {
    }
}
