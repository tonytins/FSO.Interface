using System.IO;
using FSO.Interface.Vitaboy.Models;

namespace FSO.Interface.Vitaboy
{
    public interface ISkeleton
    {
        Bone GetBone(string name);
        Skeleton Clone();
        void Read(Stream stream, bool bcf);
    }
}