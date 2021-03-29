namespace FSO.Interface
{
    public interface IMonoGameLinker
    {
        /// <summary>
        /// Detects OS and copy the correct version of MonoGame into the parent directory.
        /// </summary>
        /// <remarks>You DO NOT have to the implement the actual linker, if you don't want to.
        /// This is only meant to comply with FreeSO's APIs.</remarks>
        bool Link(bool preferDX11 = false);
    }
}