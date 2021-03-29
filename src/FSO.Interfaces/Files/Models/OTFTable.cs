using System.Collections.Generic;

namespace FSO.Interfaces.Files.Models
{
    public record OTFTable(int Id, string Name, IEnumerable<OTFTableKey> Keys);
}