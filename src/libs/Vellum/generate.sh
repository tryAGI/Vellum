dotnet tool install --global autosdk.cli --prerelease
rm -rf Generated
curl -o openapi.yaml https://docs.vellum.ai/openapi.json

# Fix auth: convert apiKey header → http/bearer, add top-level security,
# and remove per-operation X-API-KEY / X-API-Version header parameters
# (auth is handled via security scheme, not per-operation params)
jq '
  .components.securitySchemes = {
    "BearerAuth": {
      "type": "http",
      "scheme": "bearer"
    }
  } |
  .security = [{"BearerAuth": []}] |
  .servers = [{"url": "https://api.vellum.ai"}] |
  .paths |= with_entries(
    .value |= with_entries(
      if .value | type == "object" then
        .value.parameters |= if . then
          map(select(.name != "X-API-KEY" and .name != "X-API-Version"))
        else . end
      else . end
    )
  )
' openapi.yaml > openapi_fixed.yaml
mv openapi_fixed.yaml openapi.yaml

autosdk generate openapi.yaml \
  --namespace Vellum \
  --clientClassName VellumClient \
  --targetFramework net10.0 \
  --output Generated \
  --exclude-deprecated-operations \
  --security-scheme Http:Header:Bearer
