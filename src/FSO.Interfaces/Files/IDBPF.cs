using System;
using System.Collections.Generic;

namespace FSO.Interfaces.Files
{

    public interface IDBPF : IFileStream, IDisposable
    {
        IEnumerable<byte> GetEntry(IDBPF entry);

        IEnumerable<byte> GetItemByID(ulong Id);

        IEnumerable<Dictionary<uint, IEnumerable<byte>>> GetItemsByType(DBPFTypeID type);
    }
}