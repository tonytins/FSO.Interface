using System.Collections.Generic;

namespace FSO.Interfaces.Files
{
    public interface IUTK
    {
        IEnumerable<byte> DecompressWav { get; }

        void UTKDecode();

        void DecodeFrame();
    }
}