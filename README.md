# Minimal ASP.Net Core Static Website
An ASP.Net Core program with minimal settings for a static website.

## Publishing on Heroku with Docker
Clone this repo into new folder(e.g., min-aspnetcore)

```shell
$ git clone https://github.com/gmzdev/MinimalAspNetCoreStaticWebsite min-aspnetcore

$ cd min-aspnetcore
```

Build the project

```shell
$ dotnet restore

$ dotnet build
```

Publish the project to `./app` folder

```shell
$ dotnet publish -o app
```

Deploying to Heroku, make sure Docker is installed on your system. 

Login to registry container with the following command:

```shell
$ heroku container:login
```

Create a new `min-aspnetcore` or your desired app name in Heroku

```shell
$ heroku create min-aspnetcore
```

Build the image and push to Container Registry

```shell
$ heroku container:push web
```

Open the app in your browser

```shell
$ heroku open
```

Sample Published Site
https://min-aspnetcore.herokuapp.com/








