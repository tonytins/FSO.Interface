namespace FSO.Interface.Files
{
    public interface IOBDJ : IIffChunkWriter
    {
        T GetPropertyByName<T>(string name);
        void SetPropertyByName(string name, object value);
    }
}