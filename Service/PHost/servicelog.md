# MPlace2 log
## Resolve Handle
Resolve DNS _atproto.phill.hallambaker.com
Resolve Web https://phill.hallambaker.com/.well-known/atproto-did
DNS success did:plc:k647x4n6h3jm347u3t5cm6ki
Resolve DID https://plc.directory/did:plc:k647x4n6h3jm347u3t5cm6ki
# DidDocument
{
  "@context": ["https://www.w3.org/ns/did/v1",
    "https://w3id.org/security/multikey/v1",
    "https://w3id.org/security/suites/secp256k1-2019/v1"],
  "id": "did:plc:k647x4n6h3jm347u3t5cm6ki",
  "alsoKnownAs": ["at://phill.hallambaker.com"],
  "verificationMethod": [{
      "id": "did:plc:k647x4n6h3jm347u3t5cm6ki#atproto",
      "type": "Multikey",
      "controller": "did:plc:k647x4n6h3jm347u3t5cm6ki",
      "publicKeyMultibase": "zQ3shanZDJGBsZsXAina7k9SH5MZyjyCKGECmQUQcd2r8nZqG"}],
  "service": [{
      "id": "#atproto_pds",
      "type": "AtprotoPersonalDataServer",
      "serviceEndpoint": "https://shimeji.us-east.host.bsky.network"}]}
# ResourceServerMetadata
{
  "resource": "https://shimeji.us-east.host.bsky.network",
  "authorization_servers": ["https://bsky.social"],
  "scopes_supported": [],
  "bearer_methods_supported": ["header"],
  "resource_documentation": "https://atproto.com"}
# AuthorizationServerMetadata
{
  "issuer": "https://bsky.social",
  "scopes_supported": ["atproto",
    "transition:generic",
    "transition:chat.bsky"],
  "subject_types_supported": ["public"],
  "response_types_supported": ["code"],
  "response_modes_supported": ["query",
    "fragment",
    "form_post"],
  "grant_types_supported": ["authorization_code",
    "refresh_token"],
  "code_challenge_methods_supported": ["S256"],
  "ui_locales_supported": ["en-US"],
  "display_values_supported": ["page",
    "popup",
    "touch"],
  "authorization_response_iss_parameter_supported": true,
  "request_object_signing_alg_values_supported": ["RS256",
    "RS384",
    "RS512",
    "PS256",
    "PS384",
    "PS512",
    "ES256",
    "ES256K",
    "ES384",
    "ES512",
    "none"],
  "request_object_encryption_alg_values_supported": [],
  "request_object_encryption_enc_values_supported": [],
  "request_parameter_supported": true,
  "request_uri_parameter_supported": true,
  "require_request_uri_registration": true,
  "jwks_uri": "https://bsky.social/oauth/jwks",
  "authorization_endpoint": "https://bsky.social/oauth/authorize",
  "token_endpoint": "https://bsky.social/oauth/token",
  "token_endpoint_auth_methods_supported": ["none",
    "private_key_jwt"],
  "token_endpoint_auth_signing_alg_values_supported": ["RS256",
    "RS384",
    "RS512",
    "PS256",
    "PS384",
    "PS512",
    "ES256",
    "ES256K",
    "ES384",
    "ES512"],
  "revocation_endpoint": "https://bsky.social/oauth/revoke",
  "introspection_endpoint": "https://bsky.social/oauth/introspect",
  "pushed_authorization_request_endpoint": "https://bsky.social/oauth/par",
  "require_pushed_authorization_requests": true,
  "dpop_signing_alg_values_supported": ["RS256",
    "RS384",
    "RS512",
    "PS256",
    "PS384",
    "PS512",
    "ES256",
    "ES256K",
    "ES384",
    "ES512"],
  "client_id_metadata_document_supported": true}
## Begin Pre-Request
Pre Authorization Request
{
  "client_id": "https://mplace2.social/client-metadata.json",
  "response_type": "code",
  "code_challenge": "oquOEZsx2z0PGxrZ4qTil3-GVxLooufXuGy-kATs1l8",
  "code_challenge_method": "S256",
  "state": "GDMcJR4VqtPrOWU-fg3wdtyWzmLOoFyAW5quJWKXBIVsiCD_FAFbXtj-wu5YdtDfOG-9lrTUPWq4tI75Le7jd52bxQokOt-aWygbG_P9vpcLqk7I0bfQhgatT5cYhPZVQeTdlWpcI9Me_z7cDYtJ6rtIcEZueVagoIt9Sx7b19zhnMTt4qqIZqI-y4VHE13PVpiODKSL63fe8Z6VNXzAX08JYroJeeT5I4zownUjZsI-6eAVlt4y5L328_M",
  "redirect_uri": "https://mplace2.social/Redirect",
  "scope": "atproto",
  "login_hint": "phill.hallambaker.com"}
Pre Authorization Response
{
  "expires_in": 299,
  "request_uri": "urn:ietf:params:oauth:request_uri:req-9f0be685cd78fa1772265e38cf93ff92"}
Redirect Uri
https://bsky.social/oauth/authorize?client_id=https%3A%2F%2Fmplace2.social%2Fclient-metadata.json&request_uri=urn%3Aietf%3Aparams%3Aoauth%3Arequest_uri%3Areq-9f0be685cd78fa1772265e38cf93ff92
## Resolve Handle
Resolve DNS _atproto.phill.hallambaker.com
Resolve Web https://phill.hallambaker.com/.well-known/atproto-did
DNS success did:plc:k647x4n6h3jm347u3t5cm6ki
Resolve DID https://plc.directory/did:plc:k647x4n6h3jm347u3t5cm6ki
# DidDocument
{
  "@context": ["https://www.w3.org/ns/did/v1",
    "https://w3id.org/security/multikey/v1",
    "https://w3id.org/security/suites/secp256k1-2019/v1"],
  "id": "did:plc:k647x4n6h3jm347u3t5cm6ki",
  "alsoKnownAs": ["at://phill.hallambaker.com"],
  "verificationMethod": [{
      "id": "did:plc:k647x4n6h3jm347u3t5cm6ki#atproto",
      "type": "Multikey",
      "controller": "did:plc:k647x4n6h3jm347u3t5cm6ki",
      "publicKeyMultibase": "zQ3shanZDJGBsZsXAina7k9SH5MZyjyCKGECmQUQcd2r8nZqG"}],
  "service": [{
      "id": "#atproto_pds",
      "type": "AtprotoPersonalDataServer",
      "serviceEndpoint": "https://shimeji.us-east.host.bsky.network"}]}
# ResourceServerMetadata
{
  "resource": "https://shimeji.us-east.host.bsky.network",
  "authorization_servers": ["https://bsky.social"],
  "scopes_supported": [],
  "bearer_methods_supported": ["header"],
  "resource_documentation": "https://atproto.com"}
# AuthorizationServerMetadata
{
  "issuer": "https://bsky.social",
  "scopes_supported": ["atproto",
    "transition:generic",
    "transition:chat.bsky"],
  "subject_types_supported": ["public"],
  "response_types_supported": ["code"],
  "response_modes_supported": ["query",
    "fragment",
    "form_post"],
  "grant_types_supported": ["authorization_code",
    "refresh_token"],
  "code_challenge_methods_supported": ["S256"],
  "ui_locales_supported": ["en-US"],
  "display_values_supported": ["page",
    "popup",
    "touch"],
  "authorization_response_iss_parameter_supported": true,
  "request_object_signing_alg_values_supported": ["RS256",
    "RS384",
    "RS512",
    "PS256",
    "PS384",
    "PS512",
    "ES256",
    "ES256K",
    "ES384",
    "ES512",
    "none"],
  "request_object_encryption_alg_values_supported": [],
  "request_object_encryption_enc_values_supported": [],
  "request_parameter_supported": true,
  "request_uri_parameter_supported": true,
  "require_request_uri_registration": true,
  "jwks_uri": "https://bsky.social/oauth/jwks",
  "authorization_endpoint": "https://bsky.social/oauth/authorize",
  "token_endpoint": "https://bsky.social/oauth/token",
  "token_endpoint_auth_methods_supported": ["none",
    "private_key_jwt"],
  "token_endpoint_auth_signing_alg_values_supported": ["RS256",
    "RS384",
    "RS512",
    "PS256",
    "PS384",
    "PS512",
    "ES256",
    "ES256K",
    "ES384",
    "ES512"],
  "revocation_endpoint": "https://bsky.social/oauth/revoke",
  "introspection_endpoint": "https://bsky.social/oauth/introspect",
  "pushed_authorization_request_endpoint": "https://bsky.social/oauth/par",
  "require_pushed_authorization_requests": true,
  "dpop_signing_alg_values_supported": ["RS256",
    "RS384",
    "RS512",
    "PS256",
    "PS384",
    "PS512",
    "ES256",
    "ES256K",
    "ES384",
    "ES512"],
  "client_id_metadata_document_supported": true}
## Begin Pre-Request
Pre Authorization Request
{
  "client_id": "https://mplace2.social/client-metadata.json",
  "response_type": "code",
  "code_challenge": "hDoH2pVhpf3tIHoTq7SA_elQQa0QeimUx9UcYS_GjhQ",
  "code_challenge_method": "S256",
  "state": "Kk3ADnZZ2MkGtEsvFcheaidohXmof5ibQVanqc1ylurLAxw7T_CGsxqRp7Os1JVHbjGSIXUt-VlFjV6vS7rQqih_s9IbQpf3Kb9fGo4sdMIJ2zefMSaaokrZU0b0Tz8rUl29xawpZS8m8ur1IwzCQRhG4KrWhWwGiNTh2vFHqRQVltChPLcXaxoumxp7mmeQEn0jzR4jbLZ7hpaoKC6IvXVSLySPk9qHOxUTzbhroWmT9nxWkJsIqeQG7Dc",
  "redirect_uri": "https://mplace2.social/Redirect",
  "scope": "atproto",
  "login_hint": "phill.hallambaker.com"}
Web success 
Pre Authorization Response
{
  "expires_in": 299,
  "request_uri": "urn:ietf:params:oauth:request_uri:req-aafc45d5d1fb2a1ea776040c9eb18789"}
Redirect Uri
https://bsky.social/oauth/authorize?client_id=https%3A%2F%2Fmplace2.social%2Fclient-metadata.json&request_uri=urn%3Aietf%3Aparams%3Aoauth%3Arequest_uri%3Areq-aafc45d5d1fb2a1ea776040c9eb18789
## Resolve Handle
Resolve DNS _atproto.phill.hallambaker.com
Resolve Web https://phill.hallambaker.com/.well-known/atproto-did
DNS success did:plc:k647x4n6h3jm347u3t5cm6ki
Resolve DID https://plc.directory/did:plc:k647x4n6h3jm347u3t5cm6ki
# DidDocument
{
  "@context": ["https://www.w3.org/ns/did/v1",
    "https://w3id.org/security/multikey/v1",
    "https://w3id.org/security/suites/secp256k1-2019/v1"],
  "id": "did:plc:k647x4n6h3jm347u3t5cm6ki",
  "alsoKnownAs": ["at://phill.hallambaker.com"],
  "verificationMethod": [{
      "id": "did:plc:k647x4n6h3jm347u3t5cm6ki#atproto",
      "type": "Multikey",
      "controller": "did:plc:k647x4n6h3jm347u3t5cm6ki",
      "publicKeyMultibase": "zQ3shanZDJGBsZsXAina7k9SH5MZyjyCKGECmQUQcd2r8nZqG"}],
  "service": [{
      "id": "#atproto_pds",
      "type": "AtprotoPersonalDataServer",
      "serviceEndpoint": "https://shimeji.us-east.host.bsky.network"}]}
# ResourceServerMetadata
{
  "resource": "https://shimeji.us-east.host.bsky.network",
  "authorization_servers": ["https://bsky.social"],
  "scopes_supported": [],
  "bearer_methods_supported": ["header"],
  "resource_documentation": "https://atproto.com"}
# AuthorizationServerMetadata
{
  "issuer": "https://bsky.social",
  "scopes_supported": ["atproto",
    "transition:generic",
    "transition:chat.bsky"],
  "subject_types_supported": ["public"],
  "response_types_supported": ["code"],
  "response_modes_supported": ["query",
    "fragment",
    "form_post"],
  "grant_types_supported": ["authorization_code",
    "refresh_token"],
  "code_challenge_methods_supported": ["S256"],
  "ui_locales_supported": ["en-US"],
  "display_values_supported": ["page",
    "popup",
    "touch"],
  "authorization_response_iss_parameter_supported": true,
  "request_object_signing_alg_values_supported": ["RS256",
    "RS384",
    "RS512",
    "PS256",
    "PS384",
    "PS512",
    "ES256",
    "ES256K",
    "ES384",
    "ES512",
    "none"],
  "request_object_encryption_alg_values_supported": [],
  "request_object_encryption_enc_values_supported": [],
  "request_parameter_supported": true,
  "request_uri_parameter_supported": true,
  "require_request_uri_registration": true,
  "jwks_uri": "https://bsky.social/oauth/jwks",
  "authorization_endpoint": "https://bsky.social/oauth/authorize",
  "token_endpoint": "https://bsky.social/oauth/token",
  "token_endpoint_auth_methods_supported": ["none",
    "private_key_jwt"],
  "token_endpoint_auth_signing_alg_values_supported": ["RS256",
    "RS384",
    "RS512",
    "PS256",
    "PS384",
    "PS512",
    "ES256",
    "ES256K",
    "ES384",
    "ES512"],
  "revocation_endpoint": "https://bsky.social/oauth/revoke",
  "introspection_endpoint": "https://bsky.social/oauth/introspect",
  "pushed_authorization_request_endpoint": "https://bsky.social/oauth/par",
  "require_pushed_authorization_requests": true,
  "dpop_signing_alg_values_supported": ["RS256",
    "RS384",
    "RS512",
    "PS256",
    "PS384",
    "PS512",
    "ES256",
    "ES256K",
    "ES384",
    "ES512"],
  "client_id_metadata_document_supported": true}
## Begin Pre-Request
Pre Authorization Request
{
  "client_id": "https://mplace2.social/client-metadata.json",
  "response_type": "code",
  "code_challenge": "JASpwAPEd6fm58Ikis-RKH_VBsqWxiSoRl90sYHLUT8",
  "code_challenge_method": "S256",
  "state": "rhAToELggCYCPWguNpmhP3W7nKc8R2oqPTRbU_z6TiJSgle7NXLQA67IUY-Bx7E_ZFznwReiF29UslRtXamZENSQ3pMJBgqglIOm919MV-A8Z6aR6OQSHd9tl1NMGh3XnASKLMXmubnrsa73IlDxArsTfohYRy--Vjw2Q83h9scabnqKFR8tBXdQECnlFMIGaAGeOFyuKFLaVp670jq8M0f5M7V8EWDSRq7Uh6lpZRiOY-Rh9vl8bSHTYfQ",
  "redirect_uri": "https://mplace2.social/Redirect",
  "scope": "atproto",
  "login_hint": "phill.hallambaker.com"}
Pre Authorization Response
{
  "expires_in": 299,
  "request_uri": "urn:ietf:params:oauth:request_uri:req-368fcf8baeb8d3a526a427561d9ce47d"}
Redirect Uri
https://bsky.social/oauth/authorize?client_id=https%3A%2F%2Fmplace2.social%2Fclient-metadata.json&request_uri=urn%3Aietf%3Aparams%3Aoauth%3Arequest_uri%3Areq-368fcf8baeb8d3a526a427561d9ce47d
Web success 
## Resolve Handle
Resolve DNS _atproto.phill.hallambaker.com
Resolve Web https://phill.hallambaker.com/.well-known/atproto-did
Web success 
## Resolve Handle
Resolve DNS _atproto.phill.hallambaker.com
Resolve Web https://phill.hallambaker.com/.well-known/atproto-did
Web success 
## Resolve Handle
Resolve DNS _atproto.phill.hallambaker.com
Resolve Web https://phill.hallambaker.com/.well-known/atproto-did
Web success 
## Resolve Handle
Resolve DNS _atproto.phill.hallambaker.com
Resolve Web https://phill.hallambaker.com/.well-known/atproto-did
Web success 
## Resolve Handle
Resolve DNS _atproto.phill.hallambaker.com
Resolve Web https://phill.hallambaker.com/.well-known/atproto-did
Web success 
## Resolve Handle
Resolve DNS _atproto.phill.hallambaker.com
Resolve Web https://phill.hallambaker.com/.well-known/atproto-did
DNS success did:plc:k647x4n6h3jm347u3t5cm6ki
Resolve DID https://plc.directory/did:plc:k647x4n6h3jm347u3t5cm6ki
# DidDocument
{
  "@context": ["https://www.w3.org/ns/did/v1",
    "https://w3id.org/security/multikey/v1",
    "https://w3id.org/security/suites/secp256k1-2019/v1"],
  "id": "did:plc:k647x4n6h3jm347u3t5cm6ki",
  "alsoKnownAs": ["at://phill.hallambaker.com"],
  "verificationMethod": [{
      "id": "did:plc:k647x4n6h3jm347u3t5cm6ki#atproto",
      "type": "Multikey",
      "controller": "did:plc:k647x4n6h3jm347u3t5cm6ki",
      "publicKeyMultibase": "zQ3shanZDJGBsZsXAina7k9SH5MZyjyCKGECmQUQcd2r8nZqG"}],
  "service": [{
      "id": "#atproto_pds",
      "type": "AtprotoPersonalDataServer",
      "serviceEndpoint": "https://shimeji.us-east.host.bsky.network"}]}
# ResourceServerMetadata
{
  "resource": "https://shimeji.us-east.host.bsky.network",
  "authorization_servers": ["https://bsky.social"],
  "scopes_supported": [],
  "bearer_methods_supported": ["header"],
  "resource_documentation": "https://atproto.com"}
# AuthorizationServerMetadata
{
  "issuer": "https://bsky.social",
  "scopes_supported": ["atproto",
    "transition:generic",
    "transition:chat.bsky"],
  "subject_types_supported": ["public"],
  "response_types_supported": ["code"],
  "response_modes_supported": ["query",
    "fragment",
    "form_post"],
  "grant_types_supported": ["authorization_code",
    "refresh_token"],
  "code_challenge_methods_supported": ["S256"],
  "ui_locales_supported": ["en-US"],
  "display_values_supported": ["page",
    "popup",
    "touch"],
  "authorization_response_iss_parameter_supported": true,
  "request_object_signing_alg_values_supported": ["RS256",
    "RS384",
    "RS512",
    "PS256",
    "PS384",
    "PS512",
    "ES256",
    "ES256K",
    "ES384",
    "ES512",
    "none"],
  "request_object_encryption_alg_values_supported": [],
  "request_object_encryption_enc_values_supported": [],
  "request_parameter_supported": true,
  "request_uri_parameter_supported": true,
  "require_request_uri_registration": true,
  "jwks_uri": "https://bsky.social/oauth/jwks",
  "authorization_endpoint": "https://bsky.social/oauth/authorize",
  "token_endpoint": "https://bsky.social/oauth/token",
  "token_endpoint_auth_methods_supported": ["none",
    "private_key_jwt"],
  "token_endpoint_auth_signing_alg_values_supported": ["RS256",
    "RS384",
    "RS512",
    "PS256",
    "PS384",
    "PS512",
    "ES256",
    "ES256K",
    "ES384",
    "ES512"],
  "revocation_endpoint": "https://bsky.social/oauth/revoke",
  "introspection_endpoint": "https://bsky.social/oauth/introspect",
  "pushed_authorization_request_endpoint": "https://bsky.social/oauth/par",
  "require_pushed_authorization_requests": true,
  "dpop_signing_alg_values_supported": ["RS256",
    "RS384",
    "RS512",
    "PS256",
    "PS384",
    "PS512",
    "ES256",
    "ES256K",
    "ES384",
    "ES512"],
  "client_id_metadata_document_supported": true}
## Begin Pre-Request
Pre Authorization Request
{
  "client_id": "https://mplace2.social/client-metadata.json",
  "response_type": "code",
  "code_challenge": "YQsoSyMXIh68sDG1978dvc6IicQY9mjyfXxBRRm5gwA",
  "code_challenge_method": "S256",
  "state": "uct0MulNaqImWWcdnZ2A4akchS4ChWcWUbaPrbM8BsUY8ImvR5TiVOY4SwJTkferhWxLUdg7NcSR92d6Af8qKAk4G9Lkv7gs4EqFlpj_AN0rr3QNCujFIJWMKLP0OMGEj8cwOD3MJfv8XoGE_HmO6g5SIVyWyicBNL7xPz_PNs0A8h1KlW5HMpMy0c4ZyMc7MMFEynY-fC1bplPk7aygvuxTOvxp85RnLnNVA1wyQYjm3v02EFETlZyTUHk",
  "redirect_uri": "https://mplace2.social/Redirect",
  "scope": "atproto",
  "login_hint": "phill.hallambaker.com"}
Web success 
Pre Authorization Response
{
  "expires_in": 299,
  "request_uri": "urn:ietf:params:oauth:request_uri:req-ef79d7fac4d33a1859f3da5236679a77"}
Redirect Uri
https://bsky.social/oauth/authorize?client_id=https%3A%2F%2Fmplace2.social%2Fclient-metadata.json&request_uri=urn%3Aietf%3Aparams%3Aoauth%3Arequest_uri%3Areq-ef79d7fac4d33a1859f3da5236679a77
# Redirect URI
?iss=https%3A%2F%2Fbsky.social&state=uct0MulNaqImWWcdnZ2A4akchS4ChWcWUbaPrbM8BsUY8ImvR5TiVOY4SwJTkferhWxLUdg7NcSR92d6Af8qKAk4G9Lkv7gs4EqFlpj_AN0rr3QNCujFIJWMKLP0OMGEj8cwOD3MJfv8XoGE_HmO6g5SIVyWyicBNL7xPz_PNs0A8h1KlW5HMpMy0c4ZyMc7MMFEynY-fC1bplPk7aygvuxTOvxp85RnLnNVA1wyQYjm3v02EFETlZyTUHk&code=cod-13697026985b790c07c346ee4fa4cce180b30a5a53b6f627961e6653855c9aa0
iss= https://bsky.social
state= uct0MulNaqImWWcdnZ2A4akchS4ChWcWUbaPrbM8BsUY8ImvR5TiVOY4SwJTkferhWxLUdg7NcSR92d6Af8qKAk4G9Lkv7gs4EqFlpj_AN0rr3QNCujFIJWMKLP0OMGEj8cwOD3MJfv8XoGE_HmO6g5SIVyWyicBNL7xPz_PNs0A8h1KlW5HMpMy0c4ZyMc7MMFEynY-fC1bplPk7aygvuxTOvxp85RnLnNVA1wyQYjm3v02EFETlZyTUHk
code= cod-13697026985b790c07c346ee4fa4cce180b30a5a53b6f627961e6653855c9aa0
## Resolve Handle
Resolve DNS _atproto.phill.hallambaker.com
Resolve Web https://phill.hallambaker.com/.well-known/atproto-did
DNS success did:plc:k647x4n6h3jm347u3t5cm6ki
Resolve DID https://plc.directory/did:plc:k647x4n6h3jm347u3t5cm6ki
# DidDocument
{
  "@context": ["https://www.w3.org/ns/did/v1",
    "https://w3id.org/security/multikey/v1",
    "https://w3id.org/security/suites/secp256k1-2019/v1"],
  "id": "did:plc:k647x4n6h3jm347u3t5cm6ki",
  "alsoKnownAs": ["at://phill.hallambaker.com"],
  "verificationMethod": [{
      "id": "did:plc:k647x4n6h3jm347u3t5cm6ki#atproto",
      "type": "Multikey",
      "controller": "did:plc:k647x4n6h3jm347u3t5cm6ki",
      "publicKeyMultibase": "zQ3shanZDJGBsZsXAina7k9SH5MZyjyCKGECmQUQcd2r8nZqG"}],
  "service": [{
      "id": "#atproto_pds",
      "type": "AtprotoPersonalDataServer",
      "serviceEndpoint": "https://shimeji.us-east.host.bsky.network"}]}
# ResourceServerMetadata
{
  "resource": "https://shimeji.us-east.host.bsky.network",
  "authorization_servers": ["https://bsky.social"],
  "scopes_supported": [],
  "bearer_methods_supported": ["header"],
  "resource_documentation": "https://atproto.com"}
# AuthorizationServerMetadata
{
  "issuer": "https://bsky.social",
  "scopes_supported": ["atproto",
    "transition:generic",
    "transition:chat.bsky"],
  "subject_types_supported": ["public"],
  "response_types_supported": ["code"],
  "response_modes_supported": ["query",
    "fragment",
    "form_post"],
  "grant_types_supported": ["authorization_code",
    "refresh_token"],
  "code_challenge_methods_supported": ["S256"],
  "ui_locales_supported": ["en-US"],
  "display_values_supported": ["page",
    "popup",
    "touch"],
  "authorization_response_iss_parameter_supported": true,
  "request_object_signing_alg_values_supported": ["RS256",
    "RS384",
    "RS512",
    "PS256",
    "PS384",
    "PS512",
    "ES256",
    "ES256K",
    "ES384",
    "ES512",
    "none"],
  "request_object_encryption_alg_values_supported": [],
  "request_object_encryption_enc_values_supported": [],
  "request_parameter_supported": true,
  "request_uri_parameter_supported": true,
  "require_request_uri_registration": true,
  "jwks_uri": "https://bsky.social/oauth/jwks",
  "authorization_endpoint": "https://bsky.social/oauth/authorize",
  "token_endpoint": "https://bsky.social/oauth/token",
  "token_endpoint_auth_methods_supported": ["none",
    "private_key_jwt"],
  "token_endpoint_auth_signing_alg_values_supported": ["RS256",
    "RS384",
    "RS512",
    "PS256",
    "PS384",
    "PS512",
    "ES256",
    "ES256K",
    "ES384",
    "ES512"],
  "revocation_endpoint": "https://bsky.social/oauth/revoke",
  "introspection_endpoint": "https://bsky.social/oauth/introspect",
  "pushed_authorization_request_endpoint": "https://bsky.social/oauth/par",
  "require_pushed_authorization_requests": true,
  "dpop_signing_alg_values_supported": ["RS256",
    "RS384",
    "RS512",
    "PS256",
    "PS384",
    "PS512",
    "ES256",
    "ES256K",
    "ES384",
    "ES512"],
  "client_id_metadata_document_supported": true}
## Begin Pre-Request
Pre Authorization Request
{
  "client_id": "https://mplace2.social/client-metadata.json",
  "response_type": "code",
  "code_challenge": "i3aC4MSexL6Cc3c6IDdGDmQyRAzIqQ_THkiy0NTHl-c",
  "code_challenge_method": "S256",
  "state": "1B0OtfvO0ThQuFalc1dg1GQZVESfTYiRkKGmioqNt0JCNq1dBoON9gf5KouyxXAtd8cCOaZ-fqNRLFBDy5tcNjSp2Eeo8icvP9FKm0VlseINc4oPWjXHiuxK2PbUMp9h7hurDHxhhWuWB89EyEQNT8iIgpL3xwqrfJBIkWiTglQNeA-lcL37H7s57nuOju4kzuZfOopLiMKKkhCpHanOE4aJcsf0D9D_R2aOKeMuUWE5rZZQAa4-80YQr78",
  "redirect_uri": "https://mplace2.social/Redirect",
  "scope": "atproto",
  "login_hint": "phill.hallambaker.com"}
Web success 
Pre Authorization Response
{
  "expires_in": 299,
  "request_uri": "urn:ietf:params:oauth:request_uri:req-cb721ed2c120e32ba399caeefbcb8a35"}
Redirect Uri
https://bsky.social/oauth/authorize?client_id=https%3A%2F%2Fmplace2.social%2Fclient-metadata.json&request_uri=urn%3Aietf%3Aparams%3Aoauth%3Arequest_uri%3Areq-cb721ed2c120e32ba399caeefbcb8a35
# Redirect URI
?iss=https%3A%2F%2Fbsky.social&state=1B0OtfvO0ThQuFalc1dg1GQZVESfTYiRkKGmioqNt0JCNq1dBoON9gf5KouyxXAtd8cCOaZ-fqNRLFBDy5tcNjSp2Eeo8icvP9FKm0VlseINc4oPWjXHiuxK2PbUMp9h7hurDHxhhWuWB89EyEQNT8iIgpL3xwqrfJBIkWiTglQNeA-lcL37H7s57nuOju4kzuZfOopLiMKKkhCpHanOE4aJcsf0D9D_R2aOKeMuUWE5rZZQAa4-80YQr78&code=cod-0eaf0ccd63f5138a6b059376e97a2ee2d624b68822c3f3c4866aa4ca0fc7ec2f
iss= https://bsky.social
state= 1B0OtfvO0ThQuFalc1dg1GQZVESfTYiRkKGmioqNt0JCNq1dBoON9gf5KouyxXAtd8cCOaZ-fqNRLFBDy5tcNjSp2Eeo8icvP9FKm0VlseINc4oPWjXHiuxK2PbUMp9h7hurDHxhhWuWB89EyEQNT8iIgpL3xwqrfJBIkWiTglQNeA-lcL37H7s57nuOju4kzuZfOopLiMKKkhCpHanOE4aJcsf0D9D_R2aOKeMuUWE5rZZQAa4-80YQr78
code= cod-0eaf0ccd63f5138a6b059376e97a2ee2d624b68822c3f3c4866aa4ca0fc7ec2f
fHlBWZsaDNQwoiTLwzxIta33_lbVC8e7I4iLSJzxYQuPQ_rrO3CbITtJD63p6HvCH3I4HNujAGn64SonIJtX8",
  "redirect_uri": "https://mplace2.social/Redirect",
  "scope": "atproto",
  "login_hint": "phill.hallambaker.com"}
Pre Authorization Response
{
  "expires_in": 299,
  "request_uri": "urn:ietf:params:oauth:request_uri:req-3b792090b30ecb64745715433565636d"}
Redirect Uri
https://bsky.social/oauth/authorize?client_id=https%3A%2F%2Fmplace2.social%2Fclient-metadata.json&request_uri=urn%3Aietf%3Aparams%3Aoauth%3Arequest_uri%3Areq-3b792090b30ecb64745715433565636d
# Redirect URI
?iss=https%3A%2F%2Fbsky.social&state=uU9VfT8-zF1OcnXH2uwdDGYIbG2bP0KXjiPAVLbWUlGMrdABvGK2NdFE3nBdY6CQ_mZWKXPD7dyl46x7jM_jTqD_Ik1aw1yCrY3qX5wXQyI210oKhTSmWDlPxB_jwcqk5hqkiaXPNAKO33MfP029bQBi_590j_qR_0vf2wfHlBWZsaDNQwoiTLwzxIta33_lbVC8e7I4iLSJzxYQuPQ_rrO3CbITtJD63p6HvCH3I4HNujAGn64SonIJtX8&code=cod-aad999c980aa4affe6dd7559063e7e6adf594798cb9872264e0755ca159f1717
iss= https://bsky.social
state= uU9VfT8-zF1OcnXH2uwdDGYIbG2bP0KXjiPAVLbWUlGMrdABvGK2NdFE3nBdY6CQ_mZWKXPD7dyl46x7jM_jTqD_Ik1aw1yCrY3qX5wXQyI210oKhTSmWDlPxB_jwcqk5hqkiaXPNAKO33MfP029bQBi_590j_qR_0vf2wfHlBWZsaDNQwoiTLwzxIta33_lbVC8e7I4iLSJzxYQuPQ_rrO3CbITtJD63p6HvCH3I4HNujAGn64SonIJtX8
code= cod-aad999c980aa4affe6dd7559063e7e6adf594798cb9872264e0755ca159f1717
## Resolve Handle
Resolve DNS _atproto.phill.hallambaker.com
Resolve Web https://phill.hallambaker.com/.well-known/atproto-did
DNS success did:plc:k647x4n6h3jm347u3t5cm6ki
Resolve DID https://plc.directory/did:plc:k647x4n6h3jm347u3t5cm6ki
# DidDocument
{
  "@context": ["https://www.w3.org/ns/did/v1",
    "https://w3id.org/security/multikey/v1",
    "https://w3id.org/security/suites/secp256k1-2019/v1"],
  "id": "did:plc:k647x4n6h3jm347u3t5cm6ki",
  "alsoKnownAs": ["at://phill.hallambaker.com"],
  "verificationMethod": [{
      "id": "did:plc:k647x4n6h3jm347u3t5cm6ki#atproto",
      "type": "Multikey",
      "controller": "did:plc:k647x4n6h3jm347u3t5cm6ki",
      "publicKeyMultibase": "zQ3shanZDJGBsZsXAina7k9SH5MZyjyCKGECmQUQcd2r8nZqG"}],
  "service": [{
      "id": "#atproto_pds",
      "type": "AtprotoPersonalDataServer",
      "serviceEndpoint": "https://shimeji.us-east.host.bsky.network"}]}
# ResourceServerMetadata
{
  "resource": "https://shimeji.us-east.host.bsky.network",
  "authorization_servers": ["https://bsky.social"],
  "scopes_supported": [],
  "bearer_methods_supported": ["header"],
  "resource_documentation": "https://atproto.com"}
# AuthorizationServerMetadata
{
  "issuer": "https://bsky.social",
  "scopes_supported": ["atproto",
    "transition:generic",
    "transition:chat.bsky"],
  "subject_types_supported": ["public"],
  "response_types_supported": ["code"],
  "response_modes_supported": ["query",
    "fragment",
    "form_post"],
  "grant_types_supported": ["authorization_code",
    "refresh_token"],
  "code_challenge_methods_supported": ["S256"],
  "ui_locales_supported": ["en-US"],
  "display_values_supported": ["page",
    "popup",
    "touch"],
  "authorization_response_iss_parameter_supported": true,
  "request_object_signing_alg_values_supported": ["RS256",
    "RS384",
    "RS512",
    "PS256",
    "PS384",
    "PS512",
    "ES256",
    "ES256K",
    "ES384",
    "ES512",
    "none"],
  "request_object_encryption_alg_values_supported": [],
  "request_object_encryption_enc_values_supported": [],
  "request_parameter_supported": true,
  "request_uri_parameter_supported": true,
  "require_request_uri_registration": true,
  "jwks_uri": "https://bsky.social/oauth/jwks",
  "authorization_endpoint": "https://bsky.social/oauth/authorize",
  "token_endpoint": "https://bsky.social/oauth/token",
  "token_endpoint_auth_methods_supported": ["none",
    "private_key_jwt"],
  "token_endpoint_auth_signing_alg_values_supported": ["RS256",
    "RS384",
    "RS512",
    "PS256",
    "PS384",
    "PS512",
    "ES256",
    "ES256K",
    "ES384",
    "ES512"],
  "revocation_endpoint": "https://bsky.social/oauth/revoke",
  "introspection_endpoint": "https://bsky.social/oauth/introspect",
  "pushed_authorization_request_endpoint": "https://bsky.social/oauth/par",
  "require_pushed_authorization_requests": true,
  "dpop_signing_alg_values_supported": ["RS256",
    "RS384",
    "RS512",
    "PS256",
    "PS384",
    "PS512",
    "ES256",
    "ES256K",
    "ES384",
    "ES512"],
  "client_id_metadata_document_supported": true}
## Begin Pre-Request
Pre Authorization Request
{
  "client_id": "https://mplace2.social/client-metadata.json",
  "response_type": "code",
  "code_challenge": "uEzX1HZBYKVC14XlqnDmwiCnThD8wkAzXooRgjCJyT0",
  "code_challenge_method": "S256",
  "state": "CAGR_9NGx0KM9UeCYK1p1uOS6ThEqLA2fvm_uWli4l7Xd7kXFRCwEa7uBT1OcgNhd7T9uXWX8ZxLjIEcqVIq_Dz4U9ey47fKQj7yhY5HJFWiYwII8oVmqHh7_gVJ2jcbNcxCGw1KtGzUOg1U_h15szpp5CW2lD9GBQrtOsp7eJClh96ppTHkMyb_cmJGwo2VuPZPKUqg4e0C4jlRBQ0Xu2LN7Jxw87gwqzx8O7t7D9sL4PFvL0jVD6mNdpU",
  "redirect_uri": "https://mplace2.social/Redirect",
  "scope": "atproto",
  "login_hint": "phill.hallambaker.com"}
Pre Authorization Response
{
  "expires_in": 299,
  "request_uri": "urn:ietf:params:oauth:request_uri:req-3d3c1dc44679a996f70f6424bbf90b8f"}
Redirect Uri
https://bsky.social/oauth/authorize?client_id=https%3A%2F%2Fmplace2.social%2Fclient-metadata.json&request_uri=urn%3Aietf%3Aparams%3Aoauth%3Arequest_uri%3Areq-3d3c1dc44679a996f70f6424bbf90b8f
# Redirect URI
?iss=https%3A%2F%2Fbsky.social&state=CAGR_9NGx0KM9UeCYK1p1uOS6ThEqLA2fvm_uWli4l7Xd7kXFRCwEa7uBT1OcgNhd7T9uXWX8ZxLjIEcqVIq_Dz4U9ey47fKQj7yhY5HJFWiYwII8oVmqHh7_gVJ2jcbNcxCGw1KtGzUOg1U_h15szpp5CW2lD9GBQrtOsp7eJClh96ppTHkMyb_cmJGwo2VuPZPKUqg4e0C4jlRBQ0Xu2LN7Jxw87gwqzx8O7t7D9sL4PFvL0jVD6mNdpU&code=cod-ed7ecd33e82cf6156f74f1f1b7f9d35ceb11330482b21adf6f10ed57b137a5f8
iss= https://bsky.social
state= CAGR_9NGx0KM9UeCYK1p1uOS6ThEqLA2fvm_uWli4l7Xd7kXFRCwEa7uBT1OcgNhd7T9uXWX8ZxLjIEcqVIq_Dz4U9ey47fKQj7yhY5HJFWiYwII8oVmqHh7_gVJ2jcbNcxCGw1KtGzUOg1U_h15szpp5CW2lD9GBQrtOsp7eJClh96ppTHkMyb_cmJGwo2VuPZPKUqg4e0C4jlRBQ0Xu2LN7Jxw87gwqzx8O7t7D9sL4PFvL0jVD6mNdpU
code= cod-ed7ecd33e82cf6156f74f1f1b7f9d35ceb11330482b21adf6f10ed57b137a5f8
# Redirect URI
?iss=https%3A%2F%2Fbsky.social&state=CAGR_9NGx0KM9UeCYK1p1uOS6ThEqLA2fvm_uWli4l7Xd7kXFRCwEa7uBT1OcgNhd7T9uXWX8ZxLjIEcqVIq_Dz4U9ey47fKQj7yhY5HJFWiYwII8oVmqHh7_gVJ2jcbNcxCGw1KtGzUOg1U_h15szpp5CW2lD9GBQrtOsp7eJClh96ppTHkMyb_cmJGwo2VuPZPKUqg4e0C4jlRBQ0Xu2LN7Jxw87gwqzx8O7t7D9sL4PFvL0jVD6mNdpU&error=access_denied&error_description=This+request+was+already+authorized
iss= https://bsky.social
state= CAGR_9NGx0KM9UeCYK1p1uOS6ThEqLA2fvm_uWli4l7Xd7kXFRCwEa7uBT1OcgNhd7T9uXWX8ZxLjIEcqVIq_Dz4U9ey47fKQj7yhY5HJFWiYwII8oVmqHh7_gVJ2jcbNcxCGw1KtGzUOg1U_h15szpp5CW2lD9GBQrtOsp7eJClh96ppTHkMyb_cmJGwo2VuPZPKUqg4e0C4jlRBQ0Xu2LN7Jxw87gwqzx8O7t7D9sL4PFvL0jVD6mNdpU
code= 
## Resolve Handle
Resolve DNS _atproto.phill.hallambaker.com
Resolve Web https://phill.hallambaker.com/.well-known/atproto-did
DNS success did:plc:k647x4n6h3jm347u3t5cm6ki
Resolve DID https://plc.directory/did:plc:k647x4n6h3jm347u3t5cm6ki
# DidDocument
{
  "@context": ["https://www.w3.org/ns/did/v1",
    "https://w3id.org/security/multikey/v1",
    "https://w3id.org/security/suites/secp256k1-2019/v1"],
  "id": "did:plc:k647x4n6h3jm347u3t5cm6ki",
  "alsoKnownAs": ["at://phill.hallambaker.com"],
  "verificationMethod": [{
      "id": "did:plc:k647x4n6h3jm347u3t5cm6ki#atproto",
      "type": "Multikey",
      "controller": "did:plc:k647x4n6h3jm347u3t5cm6ki",
      "publicKeyMultibase": "zQ3shanZDJGBsZsXAina7k9SH5MZyjyCKGECmQUQcd2r8nZqG"}],
  "service": [{
      "id": "#atproto_pds",
      "type": "AtprotoPersonalDataServer",
      "serviceEndpoint": "https://shimeji.us-east.host.bsky.network"}]}
# ResourceServerMetadata
{
  "resource": "https://shimeji.us-east.host.bsky.network",
  "authorization_servers": ["https://bsky.social"],
  "scopes_supported": [],
  "bearer_methods_supported": ["header"],
  "resource_documentation": "https://atproto.com"}
# AuthorizationServerMetadata
{
  "issuer": "https://bsky.social",
  "scopes_supported": ["atproto",
    "transition:generic",
    "transition:chat.bsky"],
  "subject_types_supported": ["public"],
  "response_types_supported": ["code"],
  "response_modes_supported": ["query",
    "fragment",
    "form_post"],
  "grant_types_supported": ["authorization_code",
    "refresh_token"],
  "code_challenge_methods_supported": ["S256"],
  "ui_locales_supported": ["en-US"],
  "display_values_supported": ["page",
    "popup",
    "touch"],
  "authorization_response_iss_parameter_supported": true,
  "request_object_signing_alg_values_supported": ["RS256",
    "RS384",
    "RS512",
    "PS256",
    "PS384",
    "PS512",
    "ES256",
    "ES256K",
    "ES384",
    "ES512",
    "none"],
  "request_object_encryption_alg_values_supported": [],
  "request_object_encryption_enc_values_supported": [],
  "request_parameter_supported": true,
  "request_uri_parameter_supported": true,
  "require_request_uri_registration": true,
  "jwks_uri": "https://bsky.social/oauth/jwks",
  "authorization_endpoint": "https://bsky.social/oauth/authorize",
  "token_endpoint": "https://bsky.social/oauth/token",
  "token_endpoint_auth_methods_supported": ["none",
    "private_key_jwt"],
  "token_endpoint_auth_signing_alg_values_supported": ["RS256",
    "RS384",
    "RS512",
    "PS256",
    "PS384",
    "PS512",
    "ES256",
    "ES256K",
    "ES384",
    "ES512"],
  "revocation_endpoint": "https://bsky.social/oauth/revoke",
  "introspection_endpoint": "https://bsky.social/oauth/introspect",
  "pushed_authorization_request_endpoint": "https://bsky.social/oauth/par",
  "require_pushed_authorization_requests": true,
  "dpop_signing_alg_values_supported": ["RS256",
    "RS384",
    "RS512",
    "PS256",
    "PS384",
    "PS512",
    "ES256",
    "ES256K",
    "ES384",
    "ES512"],
  "client_id_metadata_document_supported": true}
## Begin Pre-Request
Pre Authorization Request
{
  "client_id": "https://mplace2.social/client-metadata.json",
  "response_type": "code",
  "code_challenge": "2zgIeWknX6_Bshllt1v_r34zRXLymjLcwp96_wASynI",
  "code_challenge_method": "S256",
  "state": "e0RS95j1-HoVw33OJfAl3_vWBczLXf-__0XeU4npT9BJGH1RjLGK7tSacFnWPyA0_hndQ7YDDoaYPYtwz40Uod2WitXFsdDjJOouDnXBb0Uju4lWu2bejL4BNB4FjWA6TVKfUVyYPUUgMqAx2_cilJoHgHLOEVc0gWvan7M4jnVv3tSgqT3xIyrCzOZH3Y6D8jZ5lY6wYnbXnSjkJb5F1VpPATmjzP9buUg2CxazxP7lC1qWcXXNdZXj98A",
  "redirect_uri": "https://mplace2.social/Redirect",
  "scope": "atproto",
  "login_hint": "phill.hallambaker.com"}
Pre Authorization Response
{
  "expires_in": 299,
  "request_uri": "urn:ietf:params:oauth:request_uri:req-b283607d2e9d49dc8f47235d7d2f7b65"}
Redirect Uri
https://bsky.social/oauth/authorize?client_id=https%3A%2F%2Fmplace2.social%2Fclient-metadata.json&request_uri=urn%3Aietf%3Aparams%3Aoauth%3Arequest_uri%3Areq-b283607d2e9d49dc8f47235d7d2f7b65
# Redirect URI
?iss=https%3A%2F%2Fbsky.social&state=e0RS95j1-HoVw33OJfAl3_vWBczLXf-__0XeU4npT9BJGH1RjLGK7tSacFnWPyA0_hndQ7YDDoaYPYtwz40Uod2WitXFsdDjJOouDnXBb0Uju4lWu2bejL4BNB4FjWA6TVKfUVyYPUUgMqAx2_cilJoHgHLOEVc0gWvan7M4jnVv3tSgqT3xIyrCzOZH3Y6D8jZ5lY6wYnbXnSjkJb5F1VpPATmjzP9buUg2CxazxP7lC1qWcXXNdZXj98A&code=cod-9c5f51977959aba9a4c8fb20d1ebb3c318d6bbc492e6589416533fa66de5ebe4
iss= https://bsky.social
state= e0RS95j1-HoVw33OJfAl3_vWBczLXf-__0XeU4npT9BJGH1RjLGK7tSacFnWPyA0_hndQ7YDDoaYPYtwz40Uod2WitXFsdDjJOouDnXBb0Uju4lWu2bejL4BNB4FjWA6TVKfUVyYPUUgMqAx2_cilJoHgHLOEVc0gWvan7M4jnVv3tSgqT3xIyrCzOZH3Y6D8jZ5lY6wYnbXnSjkJb5F1VpPATmjzP9buUg2CxazxP7lC1qWcXXNdZXj98A
code= cod-9c5f51977959aba9a4c8fb20d1ebb3c318d6bbc492e6589416533fa66de5ebe4
## Resolve Handle
Resolve DNS _atproto.phill.hallambaker.com
Resolve Web https://phill.hallambaker.com/.well-known/atproto-did
DNS success did:plc:k647x4n6h3jm347u3t5cm6ki
Resolve DID https://plc.directory/did:plc:k647x4n6h3jm347u3t5cm6ki
# DidDocument
{
  "@context": ["https://www.w3.org/ns/did/v1",
    "https://w3id.org/security/multikey/v1",
    "https://w3id.org/security/suites/secp256k1-2019/v1"],
  "id": "did:plc:k647x4n6h3jm347u3t5cm6ki",
  "alsoKnownAs": ["at://phill.hallambaker.com"],
  "verificationMethod": [{
      "id": "did:plc:k647x4n6h3jm347u3t5cm6ki#atproto",
      "type": "Multikey",
      "controller": "did:plc:k647x4n6h3jm347u3t5cm6ki",
      "publicKeyMultibase": "zQ3shanZDJGBsZsXAina7k9SH5MZyjyCKGECmQUQcd2r8nZqG"}],
  "service": [{
      "id": "#atproto_pds",
      "type": "AtprotoPersonalDataServer",
      "serviceEndpoint": "https://shimeji.us-east.host.bsky.network"}]}
# ResourceServerMetadata
{
  "resource": "https://shimeji.us-east.host.bsky.network",
  "authorization_servers": ["https://bsky.social"],
  "scopes_supported": [],
  "bearer_methods_supported": ["header"],
  "resource_documentation": "https://atproto.com"}
# AuthorizationServerMetadata
{
  "issuer": "https://bsky.social",
  "scopes_supported": ["atproto",
    "transition:generic",
    "transition:chat.bsky"],
  "subject_types_supported": ["public"],
  "response_types_supported": ["code"],
  "response_modes_supported": ["query",
    "fragment",
    "form_post"],
  "grant_types_supported": ["authorization_code",
    "refresh_token"],
  "code_challenge_methods_supported": ["S256"],
  "ui_locales_supported": ["en-US"],
  "display_values_supported": ["page",
    "popup",
    "touch"],
  "authorization_response_iss_parameter_supported": true,
  "request_object_signing_alg_values_supported": ["RS256",
    "RS384",
    "RS512",
    "PS256",
    "PS384",
    "PS512",
    "ES256",
    "ES256K",
    "ES384",
    "ES512",
    "none"],
  "request_object_encryption_alg_values_supported": [],
  "request_object_encryption_enc_values_supported": [],
  "request_parameter_supported": true,
  "request_uri_parameter_supported": true,
  "require_request_uri_registration": true,
  "jwks_uri": "https://bsky.social/oauth/jwks",
  "authorization_endpoint": "https://bsky.social/oauth/authorize",
  "token_endpoint": "https://bsky.social/oauth/token",
  "token_endpoint_auth_methods_supported": ["none",
    "private_key_jwt"],
  "token_endpoint_auth_signing_alg_values_supported": ["RS256",
    "RS384",
    "RS512",
    "PS256",
    "PS384",
    "PS512",
    "ES256",
    "ES256K",
    "ES384",
    "ES512"],
  "revocation_endpoint": "https://bsky.social/oauth/revoke",
  "introspection_endpoint": "https://bsky.social/oauth/introspect",
  "pushed_authorization_request_endpoint": "https://bsky.social/oauth/par",
  "require_pushed_authorization_requests": true,
  "dpop_signing_alg_values_supported": ["RS256",
    "RS384",
    "RS512",
    "PS256",
    "PS384",
    "PS512",
    "ES256",
    "ES256K",
    "ES384",
    "ES512"],
  "client_id_metadata_document_supported": true}
## Begin Pre-Request
Pre Authorization Request
{
  "client_id": "https://mplace2.social/client-metadata.json",
  "response_type": "code",
  "code_challenge": "BhgO9wGjXV7FLbDUSEnSJvQegpJivYmFRwtghBqb2ow",
  "code_challenge_method": "S256",
  "state": "Z4PkLI3p4IEqfQslTNNkVNJG5cAgxV0DXeVJIa9tL7QFyMQBYD3rFDTK0HjYr28BLdDTPx9RCm4Lo6KV49WxEKqcLwGM_tq7RR-TzM5Eicf0YG7MoTmYVl1sV-LhrZi1FpTjiA6R6A27Ohra1Vd_ZwMI6uyebP7Ojt1xybTuh3X-mPFhWSW1yQh-yUDjlhYZm5mCjeI-Wh83mBYMW7QLXuwaBmjPLZKttCTMw5eJdNnfP5zBZ4vzl7Z7uQs",
  "redirect_uri": "https://mplace2.social/Redirect",
  "scope": "atproto",
  "login_hint": "phill.hallambaker.com"}
Pre Authorization Response
{
  "expires_in": 299,
  "request_uri": "urn:ietf:params:oauth:request_uri:req-1be183621076a1c413e53375f611f9d5"}
Redirect Uri
https://bsky.social/oauth/authorize?client_id=https%3A%2F%2Fmplace2.social%2Fclient-metadata.json&request_uri=urn%3Aietf%3Aparams%3Aoauth%3Arequest_uri%3Areq-1be183621076a1c413e53375f611f9d5
# Redirect URI
?iss=https%3A%2F%2Fbsky.social&state=Z4PkLI3p4IEqfQslTNNkVNJG5cAgxV0DXeVJIa9tL7QFyMQBYD3rFDTK0HjYr28BLdDTPx9RCm4Lo6KV49WxEKqcLwGM_tq7RR-TzM5Eicf0YG7MoTmYVl1sV-LhrZi1FpTjiA6R6A27Ohra1Vd_ZwMI6uyebP7Ojt1xybTuh3X-mPFhWSW1yQh-yUDjlhYZm5mCjeI-Wh83mBYMW7QLXuwaBmjPLZKttCTMw5eJdNnfP5zBZ4vzl7Z7uQs&code=cod-02d8131bb198c2ddeb9f63fbc9b73704a559c98cb726e7c36155011bdf5bf3b4
iss= https://bsky.social
state= Z4PkLI3p4IEqfQslTNNkVNJG5cAgxV0DXeVJIa9tL7QFyMQBYD3rFDTK0HjYr28BLdDTPx9RCm4Lo6KV49WxEKqcLwGM_tq7RR-TzM5Eicf0YG7MoTmYVl1sV-LhrZi1FpTjiA6R6A27Ohra1Vd_ZwMI6uyebP7Ojt1xybTuh3X-mPFhWSW1yQh-yUDjlhYZm5mCjeI-Wh83mBYMW7QLXuwaBmjPLZKttCTMw5eJdNnfP5zBZ4vzl7Z7uQs
code= cod-02d8131bb198c2ddeb9f63fbc9b73704a559c98cb726e7c36155011bdf5bf3b4
## Resolve Handle
Resolve DNS _atproto.phill.hallambaker.com
Resolve Web https://phill.hallambaker.com/.well-known/atproto-did
DNS success did:plc:k647x4n6h3jm347u3t5cm6ki
Resolve DID https://plc.directory/did:plc:k647x4n6h3jm347u3t5cm6ki
# DidDocument
{
  "@context": ["https://www.w3.org/ns/did/v1",
    "https://w3id.org/security/multikey/v1",
    "https://w3id.org/security/suites/secp256k1-2019/v1"],
  "id": "did:plc:k647x4n6h3jm347u3t5cm6ki",
  "alsoKnownAs": ["at://phill.hallambaker.com"],
  "verificationMethod": [{
      "id": "did:plc:k647x4n6h3jm347u3t5cm6ki#atproto",
      "type": "Multikey",
      "controller": "did:plc:k647x4n6h3jm347u3t5cm6ki",
      "publicKeyMultibase": "zQ3shanZDJGBsZsXAina7k9SH5MZyjyCKGECmQUQcd2r8nZqG"}],
  "service": [{
      "id": "#atproto_pds",
      "type": "AtprotoPersonalDataServer",
      "serviceEndpoint": "https://shimeji.us-east.host.bsky.network"}]}
# ResourceServerMetadata
{
  "resource": "https://shimeji.us-east.host.bsky.network",
  "authorization_servers": ["https://bsky.social"],
  "scopes_supported": [],
  "bearer_methods_supported": ["header"],
  "resource_documentation": "https://atproto.com"}
# AuthorizationServerMetadata
{
  "issuer": "https://bsky.social",
  "scopes_supported": ["atproto",
    "transition:generic",
    "transition:chat.bsky"],
  "subject_types_supported": ["public"],
  "response_types_supported": ["code"],
  "response_modes_supported": ["query",
    "fragment",
    "form_post"],
  "grant_types_supported": ["authorization_code",
    "refresh_token"],
  "code_challenge_methods_supported": ["S256"],
  "ui_locales_supported": ["en-US"],
  "display_values_supported": ["page",
    "popup",
    "touch"],
  "authorization_response_iss_parameter_supported": true,
  "request_object_signing_alg_values_supported": ["RS256",
    "RS384",
    "RS512",
    "PS256",
    "PS384",
    "PS512",
    "ES256",
    "ES256K",
    "ES384",
    "ES512",
    "none"],
  "request_object_encryption_alg_values_supported": [],
  "request_object_encryption_enc_values_supported": [],
  "request_parameter_supported": true,
  "request_uri_parameter_supported": true,
  "require_request_uri_registration": true,
  "jwks_uri": "https://bsky.social/oauth/jwks",
  "authorization_endpoint": "https://bsky.social/oauth/authorize",
  "token_endpoint": "https://bsky.social/oauth/token",
  "token_endpoint_auth_methods_supported": ["none",
    "private_key_jwt"],
  "token_endpoint_auth_signing_alg_values_supported": ["RS256",
    "RS384",
    "RS512",
    "PS256",
    "PS384",
    "PS512",
    "ES256",
    "ES256K",
    "ES384",
    "ES512"],
  "revocation_endpoint": "https://bsky.social/oauth/revoke",
  "introspection_endpoint": "https://bsky.social/oauth/introspect",
  "pushed_authorization_request_endpoint": "https://bsky.social/oauth/par",
  "require_pushed_authorization_requests": true,
  "dpop_signing_alg_values_supported": ["RS256",
    "RS384",
    "RS512",
    "PS256",
    "PS384",
    "PS512",
    "ES256",
    "ES256K",
    "ES384",
    "ES512"],
  "client_id_metadata_document_supported": true}
## Begin Pre-Request
Pre Authorization Request
{
  "client_id": "https://mplace2.social/client-metadata.json",
  "response_type": "code",
  "code_challenge": "y9TzMJUrcjmYzM_Cp8bAYhYK5zXc1fLc5H9SZ9nH_9c",
  "code_challenge_method": "S256",
  "state": "I5ejVjHKOkY9dL9iekxgWhOI42vVEV_999cOAt7HFvuCfnPHIC5tJtHGZrS4luDlkvVi4EHARU-vPmLzms2bOWDYG_dTcP92fjKQZB1_3atcSlXjii-X667Vset2Tx9pjBOwKPwQ-BDnLZR9RSibPbpdJym0_vHvqsFNAb9cgbofkulA02MD9GlmqjfpJYWBo1E_YmJsrEBk1oxTveRW1n8a0bBZ3B3GPiDcAT1JQ6_wWsguHbYWWsK3KV4",
  "redirect_uri": "https://mplace2.social/Redirect",
  "scope": "atproto",
  "login_hint": "phill.hallambaker.com"}
Pre Authorization Response
{
  "expires_in": 299,
  "request_uri": "urn:ietf:params:oauth:request_uri:req-88bd67555382aaceb648b1e82b688bd5"}
Redirect Uri
https://bsky.social/oauth/authorize?client_id=https%3A%2F%2Fmplace2.social%2Fclient-metadata.json&request_uri=urn%3Aietf%3Aparams%3Aoauth%3Arequest_uri%3Areq-88bd67555382aaceb648b1e82b688bd5
# Redirect URI
?iss=https%3A%2F%2Fbsky.social&state=I5ejVjHKOkY9dL9iekxgWhOI42vVEV_999cOAt7HFvuCfnPHIC5tJtHGZrS4luDlkvVi4EHARU-vPmLzms2bOWDYG_dTcP92fjKQZB1_3atcSlXjii-X667Vset2Tx9pjBOwKPwQ-BDnLZR9RSibPbpdJym0_vHvqsFNAb9cgbofkulA02MD9GlmqjfpJYWBo1E_YmJsrEBk1oxTveRW1n8a0bBZ3B3GPiDcAT1JQ6_wWsguHbYWWsK3KV4&code=cod-b681800aa1440019f2659ba516b70727c047a83de0264cc542624621453c27e5
iss= https://bsky.social
state= I5ejVjHKOkY9dL9iekxgWhOI42vVEV_999cOAt7HFvuCfnPHIC5tJtHGZrS4luDlkvVi4EHARU-vPmLzms2bOWDYG_dTcP92fjKQZB1_3atcSlXjii-X667Vset2Tx9pjBOwKPwQ-BDnLZR9RSibPbpdJym0_vHvqsFNAb9cgbofkulA02MD9GlmqjfpJYWBo1E_YmJsrEBk1oxTveRW1n8a0bBZ3B3GPiDcAT1JQ6_wWsguHbYWWsK3KV4
code= cod-b681800aa1440019f2659ba516b70727c047a83de0264cc542624621453c27e5
