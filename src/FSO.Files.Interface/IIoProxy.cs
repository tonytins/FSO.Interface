using FSO.Interface.Files.Utils;

namespace FSO.Interface.Files;

public interface IIoProxy
{
    ushort ReadUInt16();
    short ReadInt16();
    int ReadInt32();
    uint ReadUInt32();
    float ReadFloat();

    IoBuffer Io { get; set; }
}