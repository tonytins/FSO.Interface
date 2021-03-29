using System;
using System.Collections.Generic;

namespace FSO.Interface.Files.Models
{
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
        /// Returns a list of all FarEntry instances in this archive.
        /// </summary>
        /// <returns></returns>
        IEnumerable<Far1Entry> GetAllFarEntries();

        /// <summary>
        /// Gets an entry based on a KeyValuePair.
        /// </summary>
        /// <param name="entry">A KeyValuePair (string, byte[]) representing the entry. The byte array can be null.</param>
        /// <returns>A FarEntry or null if the entry wasn't found.</returns>
        IEnumerable<byte> GetEntry(KeyValuePair<string, byte[]> entry);

        /// <summary>
        /// Get entry's data from a FAR entry instance.
        /// </summary>
        /// <param name="entry">Far entry instance</param>
        /// <returns>Entry's data</param>
        /// <returns></returns>
        IEnumerable<byte> GetEntry(Far1Entry entry);
    }

}