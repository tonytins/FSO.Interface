using System.Collections.Generic;

namespace FSO.Interface.Files
{
    /// <summary>
    /// Represents file compressor or decompressor.
    /// </summary>
    public interface ICompressor
    {
        long DecompressedSize { get; set; }
        long CompressedSize { get; set; }

        /// <summary>
        /// Compresses data and returns it as an array of bytes.
        /// Assumes that the array of bytes passed contains
        /// uncompressed data.
        /// </summary>
        /// <param name="data">The data to be compressed.</param>
        /// <returns>An array of bytes with compressed data.</returns>
        IEnumerable<byte> Compress(IEnumerable<byte> data);

        /// <summary>
        /// Decompresses data and returns it as an
        /// uncompressed array of bytes.
        /// </summary>
        /// <param name="data">The data to decompress.</param>
        /// <returns>An uncompressed array of bytes.</returns>
        IEnumerable<byte> Decompress(IEnumerable<byte> data);
    }
}