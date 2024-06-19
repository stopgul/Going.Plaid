namespace Going.Plaid.Entity;

/// <summary>
/// <para>The secrets for the newly created end customer in non-Production environments.</para>
/// </summary>
public record PartnerEndCustomerSecrets
{
	/// <summary>
	/// <para>The end customer's secret key for the Sandbox environment.</para>
	/// </summary>
	[JsonPropertyName("sandbox")]
	public string? Sandbox { get; init; } = default!;

	/// <summary>
	/// <para>The end customer's secret key for the Development environment. The Development environment will be decommissioned on June 20, 2024.</para>
	/// </summary>
	[JsonPropertyName("development")]
	public string? Development { get; init; } = default!;

	/// <summary>
	/// <para>The end customer's secret key for the Production environment. The end customer will be provided with a limited number of credits to test in the Production environment before full enablement.</para>
	/// </summary>
	[JsonPropertyName("production")]
	public string? Production { get; init; } = default!;

}
