dotnet tool install --global autosdk.cli --prerelease
rm -rf Generated
curl -o openapi.yaml https://raw.githubusercontent.com/github/rest-api-description/main/descriptions/api.github.com/api.github.com.yaml
# dotnet run --project ../../helpers/FixOpenApiSpec openapi.yaml
# if [ $? -ne 0 ]; then
#   echo "Failed, exiting..."
#   exit 1
# fi
autosdk generate openapi.yaml \
  --namespace GitHub \
  --clientClassName GitHubClient \
  --targetFramework net8.0 \
  --output Generated \
  --exclude-deprecated-operations