using System.Collections.Generic;

namespace FSO.Interfaces.Files
{
    public interface IOTF : IFileStream
    {
        IEnumerable<OTFTable> GetTable(int Id);
    }
}