namespace FSO.Interface.Files;

public interface IIffChunkWriter : IIffChunk
{
    bool Write(IIffFile iff, Stream stream);
}