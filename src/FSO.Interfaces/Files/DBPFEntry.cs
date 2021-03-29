namespace FSO.Interfaces.Files
{
    public record DBPFEntry(DBPFTypeID TypeId, DBPFGroupID GroupId, uint instanceId, uint FileOffset, uint FileSize);
}