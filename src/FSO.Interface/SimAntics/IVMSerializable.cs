using System.IO;

namespace FSO.Interface.SimAntics
{
    public interface IVMSerializable
    {
        void SerializeInto(BinaryWriter writer);
        void Deserialize(BinaryReader reader);
    }
}