namespace FSO.Interface.Files
{
    public interface IIffFile : IFileInfoUtilizer
    {
        T Get<T>(ushort id);
        void RemoveChunk(IIffFile chunk);
        void FullRemoveChunk(IIffFile chunk);
        void AddChunk(IIffFile chunk);
        void MoveAndSwap(IIffFile chunk, ushort tagId);
        void Revert();
        void Revert<T>(T chunk) where T : IIffFile;
        void Patch(IIffFile iff);
        void SetFileName(string filename);
    }
}