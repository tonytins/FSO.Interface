using FSO.Interface.Files.Models;

namespace FSO.Interface.Files
{
    public interface ISTR : IIffChunkWriter
    {
        StrLanguageSet GetLanguageSet(StrLangCode language);
        bool IsSetInit(StrLangCode language);
        void InitLanguageSet(StrLangCode language);
        void GetString(int index);
        void SetString(int index, string value);
        void SetString(int index, string value, StrLangCode lang);
        void SwapString(int srcindex, int intdstindex);
        void InsertString(int index, StrItem item);
        void RemoveString(int index);
        StrItem GetStringEntry(int index);
    }
}