using FSO.Interfaces.Files;

namespace FSO.Interfaces.SimAntics
{
    public record GameObject(ulong GUID, IOBDJ OBJ, IGameIffResource Resource);
}