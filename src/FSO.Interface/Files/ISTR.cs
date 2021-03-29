using FSO.Interface.Files.Models;

namespace FSO.Interface.Files
{
    public interface ISTR : IIffChunk
    {
        STRLanguageSet GetLanguageSet(STRLangCode language);
        bool IsSetInit(STRLangCode language);
        void InitLanguageSet(STRLangCode language);
        void GetString(int index);
        void SetString(int index, string value);
        void SetString(int index, string value, STRLangCode lang);
        void SwapString(int srcindex, int intdstindex);
        void InsertString(int index, STRItem item);
        void RemoveString(int index);
        STRItem GetStringEntry(int index);
    }
}