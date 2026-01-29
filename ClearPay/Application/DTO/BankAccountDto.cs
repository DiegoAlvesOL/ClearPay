namespace ClearPay.Application.DTO;

public class BankAccountDto
{
    public string AccountHolderName {  get; set; }
    public string AccountType {  get; set; }
    public string Iban { get; set; }
    public string Bic { get;  set; }
    public string BankName { get; set; }
}