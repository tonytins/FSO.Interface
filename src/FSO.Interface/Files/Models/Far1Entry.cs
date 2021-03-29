namespace FSO.Interface.Files.Models
{
    public record Far1Entry(int DataLength, int DataLength2, int DataOffset, short FileNameLength)
    {
        public string FileName { get; set; }
    };
}