namespace FSO.Interface.Files.Models;

public record OTFTable(int Id, string Name, IEnumerable<OTFTableKey> Keys);