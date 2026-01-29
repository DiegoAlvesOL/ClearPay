namespace ClearPay.Domain.Merchants;

/// <summary>
/// Define as operações de armazenamento para a entidade Merchant.
/// </summary>
public interface IMerchantRepository
{
    /// <summary>
    /// Adiciona um novo Merchant ao banco de dados.
    /// </summary>
    /// <param name="merchant">A entidade Merchant populada e validada.</param>
    void Add(Merchant merchant);
}