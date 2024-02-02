namespace Going.Plaid.Credit;

/// <summary>
/// <para>CreditPayrollIncomeGetRequest defines the request schema for <c>/credit/payroll_income/get</c>.</para>
/// </summary>
public partial class CreditPayrollIncomeGetRequest : RequestBase
{
	/// <summary>
	/// <para>The user token associated with the User data is being requested for.</para>
	/// </summary>
	[JsonPropertyName("user_token")]
	public string? UserToken { get; set; } = default!;

	/// <summary>
	/// <para>An optional object for <c>/credit/payroll_income/get</c> request options.</para>
	/// </summary>
	[JsonPropertyName("options")]
	public Entity.CreditPayrollIncomeGetRequestOptions? Options { get; set; } = default!;

}
