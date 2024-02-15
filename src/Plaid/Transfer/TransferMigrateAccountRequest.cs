namespace Going.Plaid.Transfer;

/// <summary>
/// <para>Defines the request schema for <c>/transfer/migrate_account</c></para>
/// </summary>
public partial class TransferMigrateAccountRequest : RequestBase
{
	/// <summary>
	/// <para>The user's account number.</para>
	/// </summary>
	[JsonPropertyName("account_number")]
	public string AccountNumber { get; set; } = default!;

	/// <summary>
	/// <para>The user's routing number.</para>
	/// </summary>
	[JsonPropertyName("routing_number")]
	public string RoutingNumber { get; set; } = default!;

	/// <summary>
	/// <para>The user's wire transfer routing number. This is the ABA number; for some institutions, this may differ from the ACH number used in <c>routing_number</c>. This field must be set for the created item to be eligible for wire transfers.</para>
	/// </summary>
	[JsonPropertyName("wire_routing_number")]
	public string? WireRoutingNumber { get; set; } = default!;

	/// <summary>
	/// <para>The type of the bank account (<c>checking</c> or <c>savings</c>).</para>
	/// </summary>
	[JsonPropertyName("account_type")]
	public string AccountType { get; set; } = default!;

}
