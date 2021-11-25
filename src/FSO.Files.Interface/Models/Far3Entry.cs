namespace FSO.Interface.Files.Models;

public record Far3Entry(uint DecompressedFileSize, uint CompressedFoleSize, byte DataType, uint DataOffset,
    byte IsCompressed, byte AccessNumber, ushort FileNameLength, uint TypeId, uint FileId)
{
    public string FileName { get; set; }
};