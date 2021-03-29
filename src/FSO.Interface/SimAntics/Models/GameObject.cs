using FSO.Interface.Files;

namespace FSO.Interface.SimAntics.Models
{
    public record GameObject(ulong GUID, IOBDJ OBJ, IGameIffResource Resource);
}