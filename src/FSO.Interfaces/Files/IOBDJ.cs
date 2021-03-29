namespace FSO.Interfaces.Files
{
    public interface IOBDJ : IIffChunk
    {
        T GetPropertyByName<T>(string name);
        void SetPropertyByName(string name, object value);
    }
}