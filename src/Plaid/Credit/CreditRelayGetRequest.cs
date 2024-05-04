namespace Going.Plaid.Credit;

/// <summary>
/// <para>CreditRelayGetRequest defines the request schema for <c>/credit/relay/get</c></para>
/// </summary>
public partial class CreditRelayGetRequest : RequestBase
{
	/// <summary>
	/// <para>The <c>relay_token</c> granting access to the report you would like to get.</para>
	/// </summary>
	[JsonPropertyName("relay_token")]
	public string RelayToken { get; set; } = default!;

	/// <summary>
	/// <para>The report type. It can be <c>asset</c>. Income report types are not yet supported.</para>
	/// </summary>
	[JsonPropertyName("report_type")]
	public Entity.ReportType ReportType { get; set; } = default!;

	/// <summary>
	/// <para><c>true</c> if you would like to retrieve the Asset Report with Insights, <c>false</c> otherwise. This field defaults to <c>false</c> if omitted.</para>
	/// </summary>
	[JsonPropertyName("include_insights")]
	public bool? IncludeInsights { get; set; } = default!;

}
