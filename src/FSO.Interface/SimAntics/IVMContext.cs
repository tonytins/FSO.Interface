using Microsoft.Xna.Framework;

namespace FSO.Interface.SimAntics
{
    public interface IVMContext
    {
        ulong NextRandom(ulong max);
        void WallsChanged(IVMArchitecture caller);
        // ObjectComponent MakeObjectComponent(GameObject obj);
        void UpdateTSOBuildableArea();
        Rectangle GetTSOBuildableArea(int lotSInfo);
        void RegeneratePortalInfo();
        void RefreshLighting(ushort room, bool commit);
        void RemoveRoomPortal(IVMEntity obj, ushort room);
        void RegisterObjectPos(IVMEntity obj);
        void UnregisterObjectPos(IVMEntity obj);
        // bool CheckWallValid(LotTilePos pos, WallTile wall);
        // bool CheckFloorValid(LotTilePos pos, FloorTile floor);
        // VMSolidResult SolidToAvatars(LotTilePos pos);
        // IsOutOfBounds(LotTilePos pos);
        // VMPlacementResult GetAvatarPlace(IVMEntity target, LotTilePos pos, Direction dir);
        // VMPlacementResult GetObjPlace(IVMEntity target, LotTilePos pos, Direction dir);
        ushort GetObjectRoom(IVMEntity obj);
        // ushort GetRoomAt(LotTilePos pos);
        short GetRoomScore(ushort room);
        // VMMultitileGroup GhostCopyGroup(VMMultitileGroup group);
        // VMMultitileGroup CreateObjectInstance(UInt32 GUID, LotTilePos pos, Direction direction, bool ghostImage, bool ts1);
        // VMMultitileGroup CreateObjectInstance(uint GUID, LotTilePos pos, Direction direction, bool ts1);
        // VMMultitileGroup CreateObjectInstance(uint GUID, LotTilePos pos, Direction direction, short MainStackOBJ, short MainParam, bool ghostImage, bool ts1);
        void RemoveObjectInstance(IVMEntity target);
        // void AddPrimitive(VMPrimitiveRegistration primitive);
    }
}