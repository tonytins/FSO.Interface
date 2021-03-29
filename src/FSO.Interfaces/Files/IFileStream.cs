using System.IO;

namespace FSO.Interfaces.Files
{
    /// <summary>
    /// This can be used to implement
    /// </summary>
    public interface IFileStream
    {
        void Read(Stream stream);
        void Write(Stream stream);
    }
}