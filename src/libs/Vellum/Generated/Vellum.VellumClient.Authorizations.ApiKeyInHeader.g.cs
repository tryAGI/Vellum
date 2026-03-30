
#nullable enable

namespace Vellum
{
    public sealed partial class VellumClient
    {
        /// <inheritdoc/>
        public void AuthorizeUsingApiKeyInHeader(
            string apiKey)
        {
            apiKey = apiKey ?? throw new global::System.ArgumentNullException(nameof(apiKey));

            Authorizations.Clear();
            Authorizations.Add(new global::Vellum.EndPointAuthorization
            {
                Type = "ApiKey",
                Location = "Header",
                Name = "X-API-KEY",
                Value = apiKey,
            });
        }
    }
}