using FSO.Interface.Files.Models;

namespace FSO.Interface.Files;

/// <summary>
/// Represents a single FAR3 entry
/// </summary>
public interface IFar3Archive : IDisposable
{
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
    IEnumerable<byte> GetItemById(uint fileId);

    /// <summary>
    /// Get entry based on Id
    /// </summary>
    /// <param name="Id">The Id of the entry</param>
    /// <returns>The entry's data</returns>
    IEnumerable<byte> GetItemById(ulong id);

    /// <summary>
    /// Returns the entries of this FAR3Archive as byte arrays together with their corresponding FileIDs.
    /// </summary>
    /// <returns>A List of KeyValuePair instances.</returns>
    IEnumerable<KeyValuePair<uint, IEnumerable<byte>>> GetAllEntries();

    /// <summary>
    /// Returns the entries of this FAR3Archive as FAR3Entry instances in a List.
    /// </summary>
    /// <returns>Returns the entries of this FAR3Archive as FAR3Entry instances in a List.</returns>
    IEnumerable<Far3Entry> GetAllFar3Entries();

    /// <summary>
    /// Gets an entry's data from a filename.
    /// </summary>
    /// <param name="filename">The filename of the entry.</param>
    /// <returns>The entry's data.</returns>
    IEnumerable<byte> this[string filename] { get; }
}