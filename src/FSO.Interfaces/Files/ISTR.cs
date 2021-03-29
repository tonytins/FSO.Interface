using FSO.Interfaces.Files.Models;

namespace FSO.Interfaces.Files
{
    public interface ISTR : IIIffChunk
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