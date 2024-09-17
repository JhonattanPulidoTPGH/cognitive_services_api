using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CognitiveServices.Controllers;

/// <summary>
/// Personally identifiable information controller
/// </summary>
[Route("api/v2/pii")]
[ApiController]
[ApiExplorerSettings(GroupName = "personally_identifiable_information")]
public class PersonallyIdentifiableInformationController : ControllerBase
{
    /// <summary>
    /// Send a personally identifying information (PII) detection API request
    /// </summary>
    /// <returns></returns>
    /// <remarks>
    /// Sample request:
    ///
    ///     POST /api/v2/pii/analyze-text
    ///     {
    ///         "texts": [
    ///             {
    ///                 "id": "1",
    ///                 "text": "Hello Paulo Santos. The latest statement for your credit card account 1111-0000-1111-0000 was mailed to 123 Any Street, Seattle, WA 98109."
    ///             }
    ///         ]
    ///     }
    ///
    /// </remarks>
    [HttpPost]
    [Route("analyze-text")]
    [Tags("Analyze Text")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<ActionResult> AnalyzeText() =>
        StatusCode(StatusCodes.Status200OK);
}
