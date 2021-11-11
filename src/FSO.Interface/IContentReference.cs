namespace FSO.Interface;

public interface IContentReference<out T>
{
    T Get(bool ts1);
}

public interface IContentReference
{
    object GetGeneric();
    object GetThrowawayGeneric();
}