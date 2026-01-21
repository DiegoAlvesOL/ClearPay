namespace ClearPay.Domain.Merchants;

/// <summary>
/// Este enum define se o merchant é uma empresa, autônomo ou pessoa física
/// </summary>
public enum LegalEntityType
{
    Company,
    SoleTrader,
    Individual
}