using FluentValidation;

namespace CognitiveServicesSDK.DTOs;

/// <summary>
/// Collection of input texts to be analyzed by the service
/// </summary>
/// <param name="texts">The input texts to be analyzed</param>
public class TextAnalysisInput<T>(T[] texts) where T : TextInput
{
    /// <summary>
    /// The input texts to be analyzed
    /// </summary>
    public T[] Texts { get; set; } = texts;

    /// <summary>
    /// Text analysis input validator
    /// </summary>
    public class TextAnalysisInputValidator : AbstractValidator<TextAnalysisInput<T>>
    {
        /// <summary>
        /// Text analysis input validator
        /// </summary>
        public TextAnalysisInputValidator()
        {
            // Texts
            RuleFor(x => x.Texts)
                .Must(x => x.Length > 0).WithMessage("Texts must have more than 0")
                .Must(x => x.Length <= 20).WithMessage("No more than 20 texts are allowed");
        }
    }
}

/// <summary>
/// Contains an input text to be analyzed by the service
/// </summary>
/// <param name="id">A unique, non-empty document identifier</param>
/// <param name="text">The text to analyze</param>
/// <param name="language">(Optional) This is the 2 letter ISO 639-1 representation of a language</param>
public class TextInput(string id, string text, string? language = null)
{
    /// <summary>
    /// A unique, non-empty text identifier
    /// </summary>
    public string Id { get; set; } = id;
    /// <summary>
    /// The text to analyze
    /// </summary>
    public string Text { get; set; } = text;
    /// <summary>
    /// (Optional) This is the 2 letter ISO 639-1 representation of a language
    /// </summary>
    public string? Language { get; set; } = language;

    /// <summary>
    /// Text input validator
    /// </summary>
    public class TextInputValidator : AbstractValidator<TextInput>
    {
        /// <summary>
        /// Text input validator
        /// </summary>
        public TextInputValidator()
        {
            // Id
            RuleFor(x => x.Id)
                .NotNull().WithMessage("Id must not be empty")
                .NotEmpty().WithMessage("Id should not be empty")
                .MaximumLength(64).WithMessage("The length of Id must be 64 characters or fewer");
        }
    }
}
