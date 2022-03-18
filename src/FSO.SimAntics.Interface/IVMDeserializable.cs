namespace FSO.SimAntics.Interface;

public interface IVMDeserializable : IVMSerializable
{
    void Deserialize(BinaryReader reader);
}