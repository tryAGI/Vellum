install_autosdk_cli() {
  dotnet tool update --global autosdk.cli --prerelease >/dev/null 2>&1 || \
    dotnet tool install --global autosdk.cli --prerelease
}

fetch_spec() {
  curl "$@" \
    --fail --silent --show-error --location \
    --retry 5 --retry-delay 10 --retry-all-errors \
    --connect-timeout 30 --max-time 300
}

install_autosdk_cli
rm -rf Generated
fetch_spec -o openapi.yaml https://docs.vellum.ai/openapi.json

# Fix: add server URL and remove per-operation X-API-KEY / X-API-Version header parameters
# (auth is handled via --security-scheme, not per-operation params)
jq '
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
  --security-scheme ApiKey:Header:X-API-KEY
