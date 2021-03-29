using System;
using System.Collections.Generic;
using System.IO;

namespace FSO.Interface.Files
{
    public interface IIffChunk
    {
        ushort ChunkID { get; set; }
        ushort ChunkFlags { get; set; }
        string ChunkType { get; set; } //just making it easier to access
        string ChunkLabel { get; set; }
        bool ChunkProcessed { get; set; }
        IEnumerable<byte> OriginalData { get; set; } //IDE ONLY: always contains base data for any chunk.
        ushort OriginalID { get; set; }
        bool AddedByPatch { get; set; }
        string OriginalLabel { get; set; }
        IEnumerable<byte> ChunkData { get; set; }
        IIffFile ChunkParent { get; set; }

        ChunkRuntimeState RuntimeInfo { get; set; }

        void Read(IIffFile iff, Stream stream);

        void Dispose();
    }
}