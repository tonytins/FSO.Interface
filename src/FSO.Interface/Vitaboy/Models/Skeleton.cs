using System.Collections.Generic;

namespace FSO.Interface.Vitaboy.Models
{
    public record Skeleton(string Name, IEnumerable<Bone> Bones, Bone RootBone);
}