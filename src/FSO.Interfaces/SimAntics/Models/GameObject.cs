using FSO.Interfaces.Files;

namespace FSO.Interfaces.SimAntics.Models
{
    public record GameObject(ulong GUID, IOBDJ OBJ, IGameIffResource Resource);
}