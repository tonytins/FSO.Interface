using System.Collections.Generic;
using Microsoft.Xna.Framework;

namespace FSO.Interfaces.SimAntics
{
    public interface IVMArchitecture
    {
        void RegenerateSupported(int level);
        void SignalRedraw();
        void RegenRoomMap();
        void Tick();
        // int SimulateCommands(IEnumerable<IVMArchitectureCommand> commands, bool visualChange);
        // int RunCommands(IEnumerable<IVMArchitectureCommand> commands, bool transient);
        void UpdateBuildableArea(Rectangle area, int floors);
        bool RaycastWall(Point p1, Point p2, sbyte level);
        // void SetWall(short tileX, short tileY, sbyte level, WallTile wall);
        // void WallDirtyState(VMArchitectureMarshal input);
        void RegenWallsAt();
    }
}