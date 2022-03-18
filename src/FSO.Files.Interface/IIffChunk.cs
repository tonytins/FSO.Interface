using FSO.Interface.Files.Utils;

namespace FSO.Interface.Files;

public interface IIffChunk
{
    void Read(IIffFile iff, Stream stream);

    void Dispose();
}