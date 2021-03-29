using System;
using System.Collections.Generic;

namespace FSO.Interface.Files
{
    public record Far1Entry(int DataLength, int DataLength2, int DataOffset, short FileNameLength, string FileName);

    /// <summary>
    /// Represents a single FAR entry
    /// </summary>
    public interface IFarArchive : IDisposable
    {

        /// <summary>
        /// The offset into the archive of the manifest.
        /// </summary>
        public uint ManifestOffset { get; }

        /// <summary>
        /// The number of files/entries in the archive.
        /// </summary>
        public uint NumFiles { get; }

        /// <summary>
        /// Gets all entries in the archive.
        /// </summary>
        /// <returns>A List of KeyValuePair instances.</returns>
        IEnumerable<IDictionary<string, IEnumerable<byte>>> GetAllEntries();

        /// <summary>
        /// Get entry based on a key value pair.
        /// </summary>
        /// <param name="entry">A dictionary representing the entry.</returns>
        /// <returns>A far entry or null if entry wasn't found</returns>
        IEnumerable<byte> GetEntry(KeyValuePair<string, IEnumerable<byte>> entry);

        /// <summary>
        /// Get entry's data from a FAR entry instance.
        /// </summary>
        /// <param name="entry">Far entry instance</param>
        /// <returns>Entry's data</param>
        /// <returns></returns>
        IEnumerable<byte> GetEntry(Far1Entry entry);
    }

}