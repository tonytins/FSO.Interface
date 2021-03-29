namespace FSO.Interface.Files
{
    public interface IIoProxy
    {
        ushort ReadUInt16();
        short ReadInt16();
        int ReadInt32();
        uint ReadUInt32();
        float ReadFloat();
    }
}