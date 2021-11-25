namespace FSO.SimAntics.Interface;

public interface IVMSerializable
{
    void SerializeInto(BinaryWriter writer);
    void Deserialize(BinaryReader reader);
}