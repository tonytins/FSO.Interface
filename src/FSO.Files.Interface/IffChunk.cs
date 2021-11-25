using FSO.Interface.Files.Utils;

namespace FSO.Interface.Files;

public abstract class IffChunk : IffRead
{
    public ushort ChunkID { get; set; }
    public ushort ChunkFlags { get; set; }
    public string? ChunkType { get; set; } //just making it easier to access
    public string? ChunkLabel { get; set; }
    public bool ChunkProcessed { get; set; }
    public IEnumerable<byte>? OriginalData { get; set; } // IDE ONLY: always contains base data for any chunk.
    public ushort OriginalID { get; set; }
    public bool AddedByPatch { get; set; }
    public string? OriginalLabel { get; set; }
    public IEnumerable<byte>? ChunkData { get; set; }
    public IIffFile? ChunkParent { get; set; }

    public ChunkRuntimeState RuntimeInfo { get; set; }

    public abstract void Dispose();
    public abstract void Read(IIffFile iff, Stream stream);
}