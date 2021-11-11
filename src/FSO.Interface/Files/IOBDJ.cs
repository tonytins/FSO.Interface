namespace FSO.Interface.Files;

public interface IOBDJ : IffReadWrite
{
    T GetPropertyByName<T>(string name);
    void SetPropertyByName(string name, object value);
}