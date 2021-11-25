using FSO.Interface.Files;

namespace FSO.SimAntics.Interface.Models;

public record GameObject(ulong GUID, IOBDJ OBJ, IGameIffResource Resource);