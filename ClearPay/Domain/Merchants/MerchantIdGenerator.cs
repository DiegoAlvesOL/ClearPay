namespace ClearPay.Domain.Merchants;

public class MerchantIdGenerator
{
    /// <summary>
    /// Função para gerar o id para ser atribuido no campo merchantId
    /// </summary>
    /// <returns></returns>
    public string Generate()
    {
        string allowedCharacters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
        Random random = new Random();

        string firstBlock = "";
        string secondBlock = "";

        for (int i = 0; i < 6; i = i + 1)
        {
            int index = random.Next(allowedCharacters.Length);
            
            firstBlock = firstBlock + allowedCharacters[index];
        }
        
        for (int j = 0; j < 6; j = j + 1)
        {
            int index = random.Next(allowedCharacters.Length);

            secondBlock = secondBlock + allowedCharacters[index];
        }

        string fullIdentifier = firstBlock + "-" + secondBlock;

        return fullIdentifier;
    }
}