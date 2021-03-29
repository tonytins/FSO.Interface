using System;
using System.Collections.Generic;
using FSO.Interface.Files.Models;

namespace FSO.Interface.Files
{

    public interface IDBPF : IFileStream, IDisposable
    {
        IEnumerable<byte> GetEntry(IDBPF entry);

        IEnumerable<byte> GetItemByID(ulong Id);

        IEnumerable<IDictionary<uint, IEnumerable<byte>>> GetItemsByType(DBPFTypeID type);
    }
}