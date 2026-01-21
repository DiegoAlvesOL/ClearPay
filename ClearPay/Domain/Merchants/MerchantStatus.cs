namespace ClearPay.Domain.Merchants;

/// <summary>
/// Define os estados possíveis de um merchant conforme o documento de domínio
/// </summary>
public enum MerchantStatus
{
    Pending,
    Active,
    Suspended,
    Closed
}