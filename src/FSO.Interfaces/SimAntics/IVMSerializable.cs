using System.IO;

namespace FSO.Interfaces.SimAntics
{
    public interface IVMSerializable
    {
        void SerializeInto(BinaryWriter writer);
        void Deserialize(BinaryReader reader);
    }
}