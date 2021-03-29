namespace FSO.Interfaces.Files
{
    public interface IOBDJ : IIIffChunk
    {
        T GetPropertyByName<T>(string name);
        void SetPropertyByName(string name, object value);
    }
}