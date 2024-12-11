# Configuring TLS support

https://stackoverflow.com/questions/11403333/httplistener-class-with-https-support

## Create a Private Key and Certificate

### Generate the Private Key


These instructions fail because the private key doesn't get attached to the cert.

~~~~
makecert -n "CN=Q.Mesh" -r -sv MeshCA.pvk MeshCA.cer
makecert -sk MeshCA -iv MeshCA.pvk -n "CN=MeshSignedByCA" -ic MeshCA.cer MeshSignedByCA.cer -sr localmachine -ss My
netsh http add sslcert ipport=0.0.0.0:15099 certhash=1aaaf214b23d9bd7e0d563f7a2c9a201d447f857 appid={9A19103F-16F7-4668-BE54-9A1E7A4F7556}
~~~~


## Command Line Tool

The Kernel mode HTTP server is configured using the netsh command line tool. It can also 
be configured via the  HttpSetServiceConfiguration API.



##  HttpSetServiceConfiguration API

This API is a C++ API because of course it is.

