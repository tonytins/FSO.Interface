using System.Collections.Generic;
using FSO.Interfaces.Files.Models;

namespace FSO.Interfaces.Files
{
    public interface IOTF : IFileStream
    {
        IEnumerable<OTFTable> GetTable(int Id);
    }
}