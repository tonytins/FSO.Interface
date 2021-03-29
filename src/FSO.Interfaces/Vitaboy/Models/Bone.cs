using System.Collections.Generic;
using Microsoft.Xna.Framework;

namespace FSO.Interfaces.Vitaboy.Models
{
    public record Bone(int Unknown, string Name, string ParentName, byte HasProps, Vector2 Translation,
        Quaternion Rotation, int CanTranslate, int CanRotate, int CanBlend, int Index, float WiggleValue,
        float WigglePower, IEnumerable<Bone> Children, Vector3 AbsolutePosition, Matrix AbsoluteMatrix);
}