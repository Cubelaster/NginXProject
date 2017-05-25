# NginXProject
Demo NginX and Kestrel project

Created using 
https://github.com/aspnet/Docs/tree/master/aspnetcore/fundamentals/servers/kestrel/sample

Used OpenSSL to generate a self signed cert for test
http://stackoverflow.com/questions/14267010/how-to-create-self-signed-ssl-certificate-for-test-purposes

OpenSSL binaries are no longer supported by OpenSSL, so you have to download it from another source
https://code.google.com/archive/p/openssl-for-windows/downloads - try this one
Once "installed" use cmd to fire it up using openssl command

These 2 tutorials are the way to go basically:
http://www.blinkingcaret.com/2017/03/01/https-asp-net-core/
http://www.blinkingcaret.com/2017/02/01/using-openssl-to-create-certificates/

Along with this one:
https://docs.microsoft.com/en-us/aspnet/core/fundamentals/servers/kestrel

Other valuable resources:
https://docs.microsoft.com/en-us/aspnet/core/fundamentals/servers/
https://docs.microsoft.com/en-us/aspnet/core/publishing/linuxproduction
https://aspnetmonsters.com/2016/07/2016-07-17-nginx/
https://www.nginx.com/blog/tutorial-proxy-net-core-kestrel-nginx-plus/
https://rehansaeed.com/nginx-asp-net-core-depth/
http://nginx.org/en/docs/http/ngx_http_v2_module.html
https://www.digitalocean.com/community/tutorials/how-to-set-up-nginx-with-http-2-support-on-ubuntu-16-04
