namespace Going.Plaid;

public sealed partial class PlaidClient
{
	/// <summary>
	/// <para>This endpoint allows the customer to retrieve a Base Report. Customers should pass in the <c>user_token</c> created in <c>/link/token/create</c>.</para>
	/// </summary>
	/// <remarks><see href="https://plaid.com/docs/none/" /></remarks>
	public Task<Cra.BaseReportGetResponse> CraBaseReportGetAsync(Cra.BaseReportGetRequest request) =>
		PostAsync("/cra/base_report/get", request)
			.ParseResponseAsync<Cra.BaseReportGetResponse>();

	/// <summary>
	/// <para>This endpoint allows the customer to create a Base Report by passing in a user token. The Base Report will be generated based on the most recently linked item from the user token.</para>
	/// </summary>
	/// <remarks><see href="https://plaid.com/docs/none/" /></remarks>
	public Task<Cra.BaseReportCreateResponse> CraBaseReportCreateAsync(Cra.BaseReportCreateRequest request) =>
		PostAsync("/cra/base_report/create", request)
			.ParseResponseAsync<Cra.BaseReportCreateResponse>();

	/// <summary>
	/// <para><c>/cra/bank_income/get</c> returns the bank income report(s) for a specified user.</para>
	/// </summary>
	/// <remarks><see href="https://plaid.com/docs/api/products/income/#crabank_incomeget" /></remarks>
	public Task<Cra.CraBankIncomeGetResponse> CraBankIncomeGetAsync(Cra.CraBankIncomeGetRequest request) =>
		PostAsync("/cra/bank_income/get", request)
			.ParseResponseAsync<Cra.CraBankIncomeGetResponse>();

	/// <summary>
	/// <para><c>/cra/bank_income/create</c> creates a CRA report for income verification</para>
	/// </summary>
	/// <remarks><see href="https://plaid.com/docs/api/products/income/#crabank_incomecreate" /></remarks>
	public Task<Cra.CraBankIncomeCreateResponse> CraBankIncomeCreateAsync(Cra.CraBankIncomeCreateRequest request) =>
		PostAsync("/cra/bank_income/create", request)
			.ParseResponseAsync<Cra.CraBankIncomeCreateResponse>();

	/// <summary>
	/// <para><c>/cra/partner_insights/get</c> returns cash flow insights for a specified user.</para>
	/// </summary>
	/// <remarks><see href="https://plaid.com/docs/api/products/income/#crapartner_insightsget" /></remarks>
	public Task<Cra.CraPartnerInsightsGetResponse> CraPartnerInsightsGetAsync(Cra.CraPartnerInsightsGetRequest request) =>
		PostAsync("/cra/partner_insights/get", request)
			.ParseResponseAsync<Cra.CraPartnerInsightsGetResponse>();

	/// <summary>
	/// <para>This endpoint allows you to retrieve the Income Insights report for your user.  You should call this endpoint after you've received a <c>CHECK_REPORT_READY</c> webhook, either after the Link session for the user or after calling <c>/cra/check_report/create</c>. If the most recent consumer report for the user doesn’t have sufficient data to generate the base report, or the consumer report has expired, you will receive an error indicating that you should create a new consumer report by calling <c>/cra/check_report/create</c>.</para>
	/// </summary>
	/// <remarks><see href="https://plaid.com/docs/check/api/#cracheck_reportincome_insightsget" /></remarks>
	public Task<Cra.CraCheckReportIncomeInsightsGetResponse> CraCheckReportIncomeInsightsGetAsync(Cra.CraCheckReportIncomeInsightsGetRequest request) =>
		PostAsync("/cra/check_report/income_insights/get", request)
			.ParseResponseAsync<Cra.CraCheckReportIncomeInsightsGetResponse>();

	/// <summary>
	/// <para>This endpoint allows you to retrieve the Base Report for your user, allowing you to receive comprehensive bank account and cash flow data. You should call this endpoint after you've received a <c>CHECK_REPORT_READY</c> webhook, either after the Link session for the user or after calling <c>/cra/check_report/create</c>. If the most recent consumer report for the user doesn't have sufficient data to generate the base report, or the consumer report has expired, you will receive an error indicating that you should create a new consumer report by calling <c>/cra/check_report/create</c>.</para>
	/// </summary>
	/// <remarks><see href="https://plaid.com/docs/check/api/#cracheck_reportbase_reportget" /></remarks>
	public Task<Cra.CraCheckReportBaseReportGetResponse> CraCheckReportBaseReportGetAsync(Cra.CraCheckReportBaseReportGetRequest request) =>
		PostAsync("/cra/check_report/base_report/get", request)
			.ParseResponseAsync<Cra.CraCheckReportBaseReportGetResponse>();

	/// <summary>
	/// <para><c>/cra/check_report/create</c> creates a Consumer Report powered by Plaid Check. Plaid Check automatically starts creating Consumer Report data after the user completes the Link process with a Plaid Check product, so you typically would only call this endpoint if you wish to generate an updated report, some time after the initial report was generated.</para>
	/// </summary>
	/// <remarks><see href="https://plaid.com/docs/check/api/#cracheck_reportcreate" /></remarks>
	public Task<Cra.CraCheckReportCreateResponse> CraCheckReportCreateAsync(Cra.CraCheckReportCreateRequest request) =>
		PostAsync("/cra/check_report/create", request)
			.ParseResponseAsync<Cra.CraCheckReportCreateResponse>();

	/// <summary>
	/// <para>This endpoint allows you to retrieve the Partner Insights product for your user. You should call this endpoint after you've received the <c>CHECK_REPORT_READY</c> webhook, either after the Link session for the user or after calling <c>/cra/check_report/create</c>. If the most recent consumer report for the user doesn’t have sufficient data to generate the base report, or the consumer report has expired, you will receive an error indicating that you should create a new consumer report by calling <c>/cra/check_report/create</c>.</para>
	/// <para>If you did not initialize Link with the <c>credit_partner_insights</c> product or have generated a report using <c>/cra/check_report/create</c>, we will call our partners to generate the insights when you call this endpoint. In this case, you may optionally provide parameters under <c>options</c> to configure which insights you want to receive.</para>
	/// </summary>
	/// <remarks><see href="https://plaid.com/docs/check/api/#cracheck_reportpartner_insightsget" /></remarks>
	public Task<Cra.CraCheckReportPartnerInsightsGetResponse> CraCheckReportPartnerInsightsGetAsync(Cra.CraCheckReportPartnerInsightsGetRequest request) =>
		PostAsync("/cra/check_report/partner_insights/get", request)
			.ParseResponseAsync<Cra.CraCheckReportPartnerInsightsGetResponse>();

	/// <summary>
	/// <para><c>/cra/loans/applications/register</c> registers loan applications and decisions.</para>
	/// </summary>
	/// <remarks><see href="https://plaid.com/docs/none/" /></remarks>
	public Task<Cra.CraLoansApplicationsRegisterResponse> CraLoansApplicationsRegisterAsync(Cra.CraLoansApplicationsRegisterRequest request) =>
		PostAsync("/cra/loans/applications/register", request)
			.ParseResponseAsync<Cra.CraLoansApplicationsRegisterResponse>();

	/// <summary>
	/// <para><c>/cra/loans/register</c> registers a list of loans to their applicants.</para>
	/// </summary>
	/// <remarks><see href="https://plaid.com/docs/none/" /></remarks>
	public Task<Cra.CraLoansRegisterResponse> CraLoansRegisterAsync(Cra.CRALoansRegisterRequest request) =>
		PostAsync("/cra/loans/register", request)
			.ParseResponseAsync<Cra.CraLoansRegisterResponse>();

	/// <summary>
	/// <para><c>/cra/loans/update</c> updates loan information such as the status and payment history.</para>
	/// </summary>
	/// <remarks><see href="https://plaid.com/docs/none/" /></remarks>
	public Task<Cra.CraLoansUpdateResponse> CraLoansUpdateAsync(Cra.CraLoansUpdateRequest request) =>
		PostAsync("/cra/loans/update", request)
			.ParseResponseAsync<Cra.CraLoansUpdateResponse>();

	/// <summary>
	/// <para><c>/cra/loans/unregister</c> indicates the loans have reached a final status and no further updates are expected.</para>
	/// </summary>
	/// <remarks><see href="https://plaid.com/docs/none/" /></remarks>
	public Task<Cra.CraLoanUnregisterResponse> CraLoansUnregisterAsync(Cra.CraLoansUnregisterRequest request) =>
		PostAsync("/cra/loans/unregister", request)
			.ParseResponseAsync<Cra.CraLoanUnregisterResponse>();

}
