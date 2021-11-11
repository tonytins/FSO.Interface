using FSO.Interface.Files;

namespace FSO.Interface.SimAntics.Models;

public record VMBHAVOwnerPair(IffRead bhav, GameObject owner);