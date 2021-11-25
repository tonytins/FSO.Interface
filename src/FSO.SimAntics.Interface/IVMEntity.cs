using FSO.SimAntics.Interface.Models;

namespace FSO.SimAntics.Interface;

public interface IVMEntity
{
    bool GetBadObjects();
    bool GetBadNames();
    void UseTreeTableOf(GameObject obj, bool ts1);
    void UseSemiGlobalTTAB(string sgFile, ushort id, bool ts1);
    bool IsInUse(IVMContext context, bool multitile);
    bool IsInUse(IVMContext context, bool multitile, bool stackObjSafety);
    void TickSounds();
    IEnumerable<IVMSoundTransfer> GetActiveSounds();
    bool ExecuteEntryPoint(int entry, IVMContext context, bool runImmediately);
    bool ExecuteEntryPoint(int entry, IVMContext context, bool runImmediately, IVMEntity stackOBJ);
    bool ExecuteEntryPoint(int entry, IVMContext context, bool runImmediately, IVMEntity stackOBJ, IEnumerable<short> args);
    VMBHAVOwnerPair GetBHAVWithOwner(ushort ActionID, IVMContext context);
}