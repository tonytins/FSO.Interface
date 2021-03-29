using System.IO;
using FSO.Interfaces.Vitaboy.Models;

namespace FSO.Interfaces.Vitaboy
{
    public interface ISkeleton
    {
        Bone GetBone(string name);
        Skeleton Clone();
        void Read(Stream stream, bool bcf);
    }
}