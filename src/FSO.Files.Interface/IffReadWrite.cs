namespace FSO.Interface.Files;

public interface IffReadWrite : IffRead
{
    bool Write(IIffFile iff, Stream stream);
}