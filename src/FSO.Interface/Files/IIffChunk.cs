using System.IO;

namespace FSO.Interface.Files
{
    public interface IIffChunk
    {
        void Read(IIffFile iff, Stream stream);
        void Write(IIffFile iff, Stream stream);
    }
}