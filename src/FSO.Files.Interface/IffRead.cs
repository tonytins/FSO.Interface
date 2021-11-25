namespace FSO.Interface.Files;

public interface IffRead
{
    void Read(IIffFile iff, Stream stream);

    void Dispose();
}