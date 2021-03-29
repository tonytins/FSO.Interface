using FSO.Interfaces.Files;

namespace FSO.Interfaces.SimAntics.Models
{
    public record VMBHAVOwnerPair(IIffChunk bhav, GameObject owner);
}