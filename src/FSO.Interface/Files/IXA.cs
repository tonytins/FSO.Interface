using System.Collections.Generic;
using System.IO;

namespace FSO.Interface.Files
{
    public interface IXA
    {
        /// <summary>
        ///
        /// </summary>
        public IEnumerable<byte> DecompressData { get; }

        /// <summary>
        ///
        /// </summary>
        public MemoryStream DecompressedStream { get; }

        /// <summary>
        ///
        /// </summary>
        /// <param name="Path"></param>
        void LoadFile(string Path);

        /// <summary>
        ///
        /// </summary>
        /// <param name="Data"></param>
        void LoadFile(byte[] Data);

        /// <summary>
        ///
        /// </summary>
        void DecompressFile();
    }
}