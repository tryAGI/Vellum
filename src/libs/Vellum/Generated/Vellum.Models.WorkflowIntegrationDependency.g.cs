
#nullable enable

namespace Vellum
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WorkflowIntegrationDependency
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vellum.JsonConverters.IntegrationEnumJsonConverter))]
        public global::Vellum.IntegrationEnum Type { get; set; }

        /// <summary>
        /// * `SLACK` - Slack<br/>
        /// * `NOTION` - Notion<br/>
        /// * `GOOGLE` - Google<br/>
        /// * `CALENDLY` - Calendly<br/>
        /// * `CANVA` - Canva<br/>
        /// * `CLICKUP` - ClickUp<br/>
        /// * `CODA` - Coda<br/>
        /// * `HUBSPOT` - Hubspot<br/>
        /// * `INTERCOM` - Intercom<br/>
        /// * `INSTAGRAM` - Instagram<br/>
        /// * `LINEAR` - Linear<br/>
        /// * `LINKUP` - Linkup<br/>
        /// * `LISTENNOTES` - Listen Notes<br/>
        /// * `LMNT` - LMNT<br/>
        /// * `LINKEDIN` - LinkedIn<br/>
        /// * `MAILCHIMP` - Mailchimp<br/>
        /// * `MIRO` - Miro<br/>
        /// * `MEM0` - Mem0<br/>
        /// * `MONDAY` - Monday<br/>
        /// * `NEON` - Neon<br/>
        /// * `OUTLOOK` - Outlook<br/>
        /// * `MICROSOFT_TEAMS` - Microsoft Teams<br/>
        /// * `GITHUB` - Github<br/>
        /// * `GOOGLE_SHEETS` - Google Sheets<br/>
        /// * `GOOGLE_CALENDAR` - Google Calendar<br/>
        /// * `GOOGLE_CLASSROOM` - Google Classroom<br/>
        /// * `GOOGLE_DRIVE` - Google Drive<br/>
        /// * `GMAIL` - Gmail<br/>
        /// * `GOOGLE_ADS` - Google Ads<br/>
        /// * `GOOGLE_ANALYTICS` - Google Analytics<br/>
        /// * `GOOGLE_BIGQUERY` - Google BigQuery<br/>
        /// * `GOOGLE_DOCS` - Google Docs<br/>
        /// * `GOOGLE_PHOTOS` - Google Photos<br/>
        /// * `GOOGLE_SEARCH_CONSOLE` - Google Search Console<br/>
        /// * `GOOGLE_SLIDES` - Google Slides<br/>
        /// * `GOOGLE_TASKS` - Google Tasks<br/>
        /// * `ACCULYNX` - AccuLynx<br/>
        /// * `AFFINITY` - Affinity<br/>
        /// * `AGENCYZOOM` - AgencyZoom<br/>
        /// * `AHREFS` - Ahrefs<br/>
        /// * `AIRTABLE` - Airtable<br/>
        /// * `APOLLO` - Apollo<br/>
        /// * `ASANA` - Asana<br/>
        /// * `ATLASSIAN` - Atlassian<br/>
        /// * `BITBUCKET` - Bitbucket<br/>
        /// * `BOX` - Box<br/>
        /// * `BREVO` - Brevo<br/>
        /// * `BREX` - Brex<br/>
        /// * `BROWSERBASE_TOOL` - Browserbase Tool<br/>
        /// * `CAL` - Cal<br/>
        /// * `CANVAS` - Canvas<br/>
        /// * `ELEVENLABS` - ElevenLabs<br/>
        /// * `EXA` - Exa<br/>
        /// * `GAMMA` - Gamma<br/>
        /// * `GITLAB` - Gitlab<br/>
        /// * `GONG` - Gong<br/>
        /// * `FIRECRAWL` - Firecrawl<br/>
        /// * `FIGMA` - Figma<br/>
        /// * `FIREFLIES` - Fireflies<br/>
        /// * `GOOGLE_MAPS` - Google Maps<br/>
        /// * `GOOGLEMEET` - Google Meet<br/>
        /// * `HEYGEN` - HeyGen<br/>
        /// * `JIRA` - Jira<br/>
        /// * `JUNGLESCOUT` - Jungle Scout<br/>
        /// * `KLAVIYO` - Klaviyo<br/>
        /// * `PAGERDUTY` - PagerDuty<br/>
        /// * `PARSERA` - Parsera<br/>
        /// * `PEOPLEDATALABS` - People Data Labs<br/>
        /// * `PERPLEXITY` - Perplexity<br/>
        /// * `POSTHOG` - PostHog<br/>
        /// * `PRODUCTBOARD` - Productboard<br/>
        /// * `QUICKBOOKS` - QuickBooks<br/>
        /// * `REDDIT` - Reddit<br/>
        /// * `SALESFORCE` - Salesforce<br/>
        /// * `SEMRUSH` - Semrush<br/>
        /// * `SEMANTICSCHOLAR` - Semantic Scholar<br/>
        /// * `SENDGRID` - SendGrid<br/>
        /// * `SERPAPI` - Serp Api<br/>
        /// * `SHARE_POINT` - SharePoint<br/>
        /// * `SHOPIFY` - Shopify<br/>
        /// * `SHORTCUT` - Shortcut<br/>
        /// * `SLACKBOT` - Slackbot<br/>
        /// * `SPOTIFY` - Spotify<br/>
        /// * `STRIPE` - Stripe<br/>
        /// * `SUPABASE` - Supabase<br/>
        /// * `TAVILY` - Tavily<br/>
        /// * `TELEGRAM` - Telegram<br/>
        /// * `TIKTOK` - TikTok<br/>
        /// * `TODOIST` - Todoist<br/>
        /// * `WEBFLOW` - Webflow<br/>
        /// * `YOUSEARCH` - You Search<br/>
        /// * `ZENDESK` - Zendesk<br/>
        /// * `ZENROWS` - ZenRows<br/>
        /// * `DROPBOX` - Dropbox<br/>
        /// * `EVENTBRITE` - Eventbrite<br/>
        /// * `FACEBOOK` - Facebook<br/>
        /// * `CONFLUENCE` - Confluence<br/>
        /// * `COINBASE` - Coinbase<br/>
        /// * `DISCORD` - Discord<br/>
        /// * `DOCUSIGN` - DocuSign<br/>
        /// * `TRELLO` - Trello<br/>
        /// * `TWITTER` - Twitter<br/>
        /// * `HEYREACH` - HeyReach<br/>
        /// * `ACTIVE_CAMPAIGN` - Active Campaign<br/>
        /// * `CUSTOMER_IO` - Customer.io<br/>
        /// * `SEGMENT` - Segment<br/>
        /// * `WHATSAPP` - WhatsApp<br/>
        /// * `YOUTUBE` - YouTube
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vellum.JsonConverters.IntegrationNameJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vellum.IntegrationName Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("provider")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Provider { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("label")]
        public string? Label { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkflowIntegrationDependency" /> class.
        /// </summary>
        /// <param name="name">
        /// * `SLACK` - Slack<br/>
        /// * `NOTION` - Notion<br/>
        /// * `GOOGLE` - Google<br/>
        /// * `CALENDLY` - Calendly<br/>
        /// * `CANVA` - Canva<br/>
        /// * `CLICKUP` - ClickUp<br/>
        /// * `CODA` - Coda<br/>
        /// * `HUBSPOT` - Hubspot<br/>
        /// * `INTERCOM` - Intercom<br/>
        /// * `INSTAGRAM` - Instagram<br/>
        /// * `LINEAR` - Linear<br/>
        /// * `LINKUP` - Linkup<br/>
        /// * `LISTENNOTES` - Listen Notes<br/>
        /// * `LMNT` - LMNT<br/>
        /// * `LINKEDIN` - LinkedIn<br/>
        /// * `MAILCHIMP` - Mailchimp<br/>
        /// * `MIRO` - Miro<br/>
        /// * `MEM0` - Mem0<br/>
        /// * `MONDAY` - Monday<br/>
        /// * `NEON` - Neon<br/>
        /// * `OUTLOOK` - Outlook<br/>
        /// * `MICROSOFT_TEAMS` - Microsoft Teams<br/>
        /// * `GITHUB` - Github<br/>
        /// * `GOOGLE_SHEETS` - Google Sheets<br/>
        /// * `GOOGLE_CALENDAR` - Google Calendar<br/>
        /// * `GOOGLE_CLASSROOM` - Google Classroom<br/>
        /// * `GOOGLE_DRIVE` - Google Drive<br/>
        /// * `GMAIL` - Gmail<br/>
        /// * `GOOGLE_ADS` - Google Ads<br/>
        /// * `GOOGLE_ANALYTICS` - Google Analytics<br/>
        /// * `GOOGLE_BIGQUERY` - Google BigQuery<br/>
        /// * `GOOGLE_DOCS` - Google Docs<br/>
        /// * `GOOGLE_PHOTOS` - Google Photos<br/>
        /// * `GOOGLE_SEARCH_CONSOLE` - Google Search Console<br/>
        /// * `GOOGLE_SLIDES` - Google Slides<br/>
        /// * `GOOGLE_TASKS` - Google Tasks<br/>
        /// * `ACCULYNX` - AccuLynx<br/>
        /// * `AFFINITY` - Affinity<br/>
        /// * `AGENCYZOOM` - AgencyZoom<br/>
        /// * `AHREFS` - Ahrefs<br/>
        /// * `AIRTABLE` - Airtable<br/>
        /// * `APOLLO` - Apollo<br/>
        /// * `ASANA` - Asana<br/>
        /// * `ATLASSIAN` - Atlassian<br/>
        /// * `BITBUCKET` - Bitbucket<br/>
        /// * `BOX` - Box<br/>
        /// * `BREVO` - Brevo<br/>
        /// * `BREX` - Brex<br/>
        /// * `BROWSERBASE_TOOL` - Browserbase Tool<br/>
        /// * `CAL` - Cal<br/>
        /// * `CANVAS` - Canvas<br/>
        /// * `ELEVENLABS` - ElevenLabs<br/>
        /// * `EXA` - Exa<br/>
        /// * `GAMMA` - Gamma<br/>
        /// * `GITLAB` - Gitlab<br/>
        /// * `GONG` - Gong<br/>
        /// * `FIRECRAWL` - Firecrawl<br/>
        /// * `FIGMA` - Figma<br/>
        /// * `FIREFLIES` - Fireflies<br/>
        /// * `GOOGLE_MAPS` - Google Maps<br/>
        /// * `GOOGLEMEET` - Google Meet<br/>
        /// * `HEYGEN` - HeyGen<br/>
        /// * `JIRA` - Jira<br/>
        /// * `JUNGLESCOUT` - Jungle Scout<br/>
        /// * `KLAVIYO` - Klaviyo<br/>
        /// * `PAGERDUTY` - PagerDuty<br/>
        /// * `PARSERA` - Parsera<br/>
        /// * `PEOPLEDATALABS` - People Data Labs<br/>
        /// * `PERPLEXITY` - Perplexity<br/>
        /// * `POSTHOG` - PostHog<br/>
        /// * `PRODUCTBOARD` - Productboard<br/>
        /// * `QUICKBOOKS` - QuickBooks<br/>
        /// * `REDDIT` - Reddit<br/>
        /// * `SALESFORCE` - Salesforce<br/>
        /// * `SEMRUSH` - Semrush<br/>
        /// * `SEMANTICSCHOLAR` - Semantic Scholar<br/>
        /// * `SENDGRID` - SendGrid<br/>
        /// * `SERPAPI` - Serp Api<br/>
        /// * `SHARE_POINT` - SharePoint<br/>
        /// * `SHOPIFY` - Shopify<br/>
        /// * `SHORTCUT` - Shortcut<br/>
        /// * `SLACKBOT` - Slackbot<br/>
        /// * `SPOTIFY` - Spotify<br/>
        /// * `STRIPE` - Stripe<br/>
        /// * `SUPABASE` - Supabase<br/>
        /// * `TAVILY` - Tavily<br/>
        /// * `TELEGRAM` - Telegram<br/>
        /// * `TIKTOK` - TikTok<br/>
        /// * `TODOIST` - Todoist<br/>
        /// * `WEBFLOW` - Webflow<br/>
        /// * `YOUSEARCH` - You Search<br/>
        /// * `ZENDESK` - Zendesk<br/>
        /// * `ZENROWS` - ZenRows<br/>
        /// * `DROPBOX` - Dropbox<br/>
        /// * `EVENTBRITE` - Eventbrite<br/>
        /// * `FACEBOOK` - Facebook<br/>
        /// * `CONFLUENCE` - Confluence<br/>
        /// * `COINBASE` - Coinbase<br/>
        /// * `DISCORD` - Discord<br/>
        /// * `DOCUSIGN` - DocuSign<br/>
        /// * `TRELLO` - Trello<br/>
        /// * `TWITTER` - Twitter<br/>
        /// * `HEYREACH` - HeyReach<br/>
        /// * `ACTIVE_CAMPAIGN` - Active Campaign<br/>
        /// * `CUSTOMER_IO` - Customer.io<br/>
        /// * `SEGMENT` - Segment<br/>
        /// * `WHATSAPP` - WhatsApp<br/>
        /// * `YOUTUBE` - YouTube
        /// </param>
        /// <param name="provider"></param>
        /// <param name="type"></param>
        /// <param name="label"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WorkflowIntegrationDependency(
            global::Vellum.IntegrationName name,
            string provider,
            global::Vellum.IntegrationEnum type,
            string? label)
        {
            this.Type = type;
            this.Name = name;
            this.Provider = provider ?? throw new global::System.ArgumentNullException(nameof(provider));
            this.Label = label;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkflowIntegrationDependency" /> class.
        /// </summary>
        public WorkflowIntegrationDependency()
        {
        }
    }
}