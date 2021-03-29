using System;
using System.Collections.Generic;

namespace FSO.Interfaces.Files
{
    /// <summary>
    /// Represents a single FAR3 entry
    /// </summary>
    public interface IFar3Archive : IDisposable
    {
        /// <summary>
        /// Get entry based on a key value pair.
        /// </summary>
        /// <param name="entry">A dictionary representing the entry.</returns>
        /// <returns>A far entry or null if entry wasn't found</returns>
        IEnumerable<byte> GetEntry(Dictionary<string, IEnumerable<byte>> entry);

        /// <summary>
        /// Get entry's data from a FAR3 entry instance.
        /// </summary>
        /// <param name="entry">Far entry instance</param>
        /// <returns>Entry's data</param>
        /// <returns></returns>
        IEnumerable<byte> GetEntry(Far3Entry entry);

        /// <summary>
        /// Get an entry from a file Id
        /// </summary>
        /// <param name="FileID">Entry's file Id</param>
        /// <returns>Entry's data</returns>
        IEnumerable<byte> GetItemById(uint FileID);

        /// <summary>
        /// Get entry based on Id
        /// </summary>
        /// <param name="Id">The Id of the entry</param>
        /// <returns>The entry's data</returns>
        IEnumerable<byte> GetItemById(long Id);
    }
}