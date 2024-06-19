namespace Going.Plaid.Signal;

/// <summary>
/// <para>SignalReturnReportRequest defines the request schema for <c>/signal/return/report</c></para>
/// </summary>
public partial class SignalReturnReportRequest : RequestBase
{
	/// <summary>
	/// <para>Must be the same as the <c>client_transaction_id</c> supplied when calling <c>/signal/evaluate</c> or <c>/accounts/balance/get</c>.</para>
	/// </summary>
	[JsonPropertyName("client_transaction_id")]
	public string ClientTransactionId { get; set; } = default!;

	/// <summary>
	/// <para>Must be a valid ACH return code (e.g. "R01")</para>
	/// <para>If formatted incorrectly, this will result in an <a href="https://plaid.com/docs/errors/invalid-request/#invalid_field"><c>INVALID_FIELD</c></a> error.</para>
	/// </summary>
	[JsonPropertyName("return_code")]
	public string ReturnCode { get; set; } = default!;

	/// <summary>
	/// <para>Date and time when you receive the returns from your payment processors, in ISO 8601 format (<c>YYYY-MM-DDTHH:mm:ssZ</c>).</para>
	/// </summary>
	[JsonPropertyName("returned_at")]
	public DateTimeOffset? ReturnedAt { get; set; } = default!;

}
