namespace FSO.Interface.Files.Models;

public record DBPFEntry(DBPFTypeID TypeId, DBPFGroupID GroupId, uint instanceId, uint FileOffset, uint FileSize);