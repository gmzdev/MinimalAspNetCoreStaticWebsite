FROM microsoft/aspnetcore:2.0

ADD /app /app 

WORKDIR /app 

CMD ASPNETCORE_URLS=http://*:$PORT dotnet minimalAspNetCore.dll