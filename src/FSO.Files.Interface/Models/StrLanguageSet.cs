namespace FSO.Interface.Files.Models;

public record StrLanguageSet
{
    public IEnumerable<StrItem> Strings { get; set; }
};