using System.IO;

namespace FSO.Interfaces.Files
{
    public interface IIIffChunk
    {
        void Read(IIffFile iff, Stream stream);
        void Write(IIffFile iff, Stream stream);
    }
}