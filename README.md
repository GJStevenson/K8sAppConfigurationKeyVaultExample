# Setup

1. Right click the K8sAppConfigurationKeyVaultExample and select "Manage User Secrets"

2. Add the following:

```json
   "ConnectionStrings": {
       "AppConfig": "YOUR-CONNECTION-STRING-HERE"
   },
   "KeyVaultEndpoint": "YOUR-KEYVAULT-ENDPOINT"
}
```

3. KeyVault auths locally using your AAD account, so be signed into account that has read access to the keyvault instance you specified in the secrets.json file.
