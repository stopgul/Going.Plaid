namespace Going.Plaid.Entity;

/// <summary>
/// <para>The details of a document income verification in Link</para>
/// </summary>
public record CreditSessionDocumentIncomeResult
{
	/// <summary>
	/// <para>The number of paystubs uploaded by the user.</para>
	/// </summary>
	[JsonPropertyName("num_paystubs_uploaded")]
	public int NumPaystubsUploaded { get; init; } = default!;

	/// <summary>
	/// <para>The number of w2s uploaded by the user.</para>
	/// </summary>
	[JsonPropertyName("num_w2s_uploaded")]
	public int NumW2sUploaded { get; init; } = default!;

	/// <summary>
	/// <para>The number of bank statements uploaded by the user.</para>
	/// </summary>
	[JsonPropertyName("num_bank_statements_uploaded")]
	public int NumBankStatementsUploaded { get; init; } = default!;

	/// <summary>
	/// <para>The number of 1099s uploaded by the user</para>
	/// </summary>
	[JsonPropertyName("num_1099s_uploaded")]
	public int Num1099sUploaded { get; init; } = default!;

}
