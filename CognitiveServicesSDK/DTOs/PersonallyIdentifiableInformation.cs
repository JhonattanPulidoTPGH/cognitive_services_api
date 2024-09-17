namespace CognitiveServicesSDK.DTOs;

public class PersonallyIdentifiableInformation
{
    /// <summary>
    /// Collection of input texts to be analyzed by the service
    /// </summary>
    /// <param name="texts">The input texts to be analyzed</param>
    public class PiiInput(PiiInputText[] texts) : TextAnalysisInput<PiiInputText>(texts)
    {

    }

    /// <summary>
    /// Contains an input text to be analyzed by the PII service
    /// </summary>
    /// <param name="id">A unique, non-empty document identifier</param>
    /// <param name="text">The text to analyze</param>
    /// <param name="language">(Optional) This is the 2 letter ISO 639-1 representation of a language</param>
    public class PiiInputText(string id, string text, string? language = null) : TextInput(id, text, language)
    {

    }
}
