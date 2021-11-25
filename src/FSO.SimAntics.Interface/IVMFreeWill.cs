namespace FSO.SimAntics.Interface;

public interface IVMFreeWill
{
    void CheckForUsableObjects(IVM vm);
    void RunAction(IVMEntity entity);
    void Tick(IVM vm);
}