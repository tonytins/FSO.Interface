using System;
using System.Collections.Generic;
using FSO.Interfaces.Files.Models;

namespace FSO.Interfaces.Files
{

    public interface IDBPF : IFileStream, IDisposable
    {
        IEnumerable<byte> GetEntry(IDBPF entry);

        IEnumerable<byte> GetItemByID(ulong Id);

        IEnumerable<IDictionary<uint, IEnumerable<byte>>> GetItemsByType(DBPFTypeID type);
    }
}