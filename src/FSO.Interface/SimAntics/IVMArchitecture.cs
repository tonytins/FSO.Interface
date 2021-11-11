using FSO.Interface.SimAntics.Models;

namespace FSO.Interface.SimAntics;

public interface IVMArchitecture
{
    void RegenerateSupported(int level);
    void SignalRedraw();
    void RegenRoomMap();
    void Tick();
    int SimulateCommands(IEnumerable<VMArchitectureCommand> commands, bool visualChange);
    int RunCommands(IEnumerable<VMArchitectureCommand> commands, bool transient);
    void UpdateBuildableArea(Rectangle area, int floors);
    bool RaycastWall(Point p1, Point p2, sbyte level);
    void SetWall(short tileX, short tileY, sbyte level, WallTile wall);
    void WallDirtyState(IVMSerializable input);
    void RegenWallsAt();
}