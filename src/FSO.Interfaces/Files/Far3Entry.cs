namespace FSO.Interfaces.Files
{
    public record Far3Entry(uint DecompressedFileSize, uint CompressedFoleSize, byte DataType, uint DataOffset,
        byte IsCompressed, byte AccessNumber, ushort FileNameLength, uint TypeId, uint FileId, string FileName);
}