namespace FSO.SimAntics.Interface.Models;

[Flags]
public enum WallSegments
{
    TopLeft = 1,
    TopRight = 2,
    BottomRight = 4,
    BottomLeft = 8,
    HorizontalDiag = 16,
    VerticalDiag = 32
}