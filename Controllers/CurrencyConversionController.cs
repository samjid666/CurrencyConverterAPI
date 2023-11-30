using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/[controller]")]
public class CurrencyConversionController : ControllerBase
{
    [HttpGet]
    public IActionResult ConvertCurrency(decimal amount, string fromCurrency, string toCurrency)
    {
        // Your currency conversion logic here
        // Example: Convert from USD to EUR using a fixed rate
        decimal conversionRate = 0.85M;
        decimal convertedAmount = amount * conversionRate;

        return Ok(new { Amount = convertedAmount, FromCurrency = fromCurrency, ToCurrency = toCurrency });
    }
}
