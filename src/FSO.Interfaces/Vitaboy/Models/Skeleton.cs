using System.Collections.Generic;

namespace FSO.Interfaces.Vitaboy.Models
{
    public record Skeleton(string Name, IEnumerable<Bone> Bones, Bone RootBone);
}