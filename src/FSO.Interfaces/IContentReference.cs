namespace FSO.Interfaces
{
    public interface IContentReference<T>
    {
        T Get(bool ts1);
    }

    public interface IContentReference
    {
        object GetGeneric();
        object GetThrowawayGeneric();
    }
}