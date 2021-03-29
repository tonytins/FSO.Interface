using System.IO;

namespace FSO.Interface
{
    // Though IFileStream does not exist in FreeSO, the methods
    // used by varies IFF chunks share the same two methods and
    // can benefit from this interface.
    public interface IFileStream
    {
        void Read(Stream stream);
        void Write(Stream stream);
    }
}