namespace Going.Plaid.Webhook;

/// <summary>
/// <para>Fired when the Asset Report has been generated and <c>/asset_report/get</c> is ready to be called.  If you attempt to retrieve an Asset Report before this webhook has fired, you’ll receive a response with the HTTP status code 400 and a Plaid error code of <c>PRODUCT_NOT_READY</c>.</para>
/// </summary>
public record AssetsProductReadyWebhook : WebhookBase
{
	/// <inheritdoc />
	[JsonPropertyName("webhook_type")]
	public override WebhookType WebhookType => WebhookType.Assets;

	/// <inheritdoc />
	[JsonPropertyName("webhook_code")]
	public override WebhookCode WebhookCode => WebhookCode.ProductReady;

	/// <summary>
	/// <para>The <c>asset_report_id</c> corresponding to the Asset Report the webhook has fired for.</para>
	/// </summary>
	[JsonPropertyName("asset_report_id")]
	public string AssetReportId { get; init; } = default!;

	/// <summary>
	/// <para>The <c>user_id</c> corresponding to the User ID the webhook has fired for.</para>
	/// </summary>
	[JsonPropertyName("user_id")]
	public string? UserId { get; init; } = default!;

	/// <summary>
	/// <para>Indicates either a Fast Asset Report, which will contain only current identity and balance information, or a Full Asset Report, which will also contain historical balance information and transaction data.</para>
	/// </summary>
	[JsonPropertyName("report_type")]
	public Entity.AssetReportType? ReportType { get; init; } = default!;

}
