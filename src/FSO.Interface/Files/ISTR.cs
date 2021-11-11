using FSO.Interface.Files.Models;

namespace FSO.Interface.Files;

public interface ISTR : IffReadWrite
{
    StrItem GetStringEntry(int index);
}