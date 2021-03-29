namespace FSO.Interfaces.Files.Models
{
    public record DBPFEntry(DBPFTypeID TypeId, DBPFGroupID GroupId, uint instanceId, uint FileOffset, uint FileSize);
}