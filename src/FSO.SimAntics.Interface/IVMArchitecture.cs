using FSO.SimAntics.Interface.Models;

namespace FSO.SimAntics.Interface;

public interface IVMArchitecture
{
    void RegenerateSupported(int level);
    void SignalRedraw();
    void RegenRoomMap();
    void Tick();
    int SimulateCommands(IEnumerable<IVMDeserializable> commands, bool visualChange);
    int RunCommands(IEnumerable<IVMDeserializable> commands, bool transient);
    void UpdateBuildableArea(Rectangle area, int floors);
    bool RaycastWall(Point p1, Point p2, sbyte level);
    void SetWall(short tileX, short tileY, sbyte level, WallTile wall);
    void WallDirtyState(IVMDeserializable input);
    void RegenWallsAt();
}