using System.Collections.Generic;

namespace FSO.Interface.Files
{
    public interface IUTK
    {
        IEnumerable<byte> DecompressWav { get; }

        void UTKDecode();

        void DecodeFrame();
    }
}