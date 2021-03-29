using System.Collections.Generic;
using FSO.Interface.Files.Models;

namespace FSO.Interface.Files
{
    public interface IOTF : IFileStream
    {
        IEnumerable<OTFTable> GetTable(int Id);
    }
}