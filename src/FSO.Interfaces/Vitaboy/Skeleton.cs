using System.Collections.Generic;

namespace FSO.Interfaces.Vitaboy
{
    public record Skeleton(string Name, IEnumerable<Bone> Bones, Bone RootBone);
}