using FSO.Interface.Files;

namespace FSO.SimAntics.Interface.Models;

public record VMBHAVOwnerPair(IffRead bhav, GameObject owner);