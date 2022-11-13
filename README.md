# .NET Core Microservices


## Products.API 

### Package Manager Command in **Products.API**
```
Install-Package AutoMapper
Install-Package AutoMapper.Extensions.Microsoft.DependencyInjection
Install-Package Swashbuckle.AspNetCore.SwaggerUI 
Install-Package Swashbuckle.AspNetCore.Annotations 
Install-Package Microsoft.AspNetCore.Authentication.Jwtbearer
Install-Package Microsoft.EntityFrameworkCore.SqlServer 
Install-Package Microsoft.EntityFrameworkCore.Tools 
```

### Migration scripts for the database in **Products.API**
```
Add-Migration AddProductToDb
Update-Database
```

### Deployment

1. Run *Articles.API* microservice **locally**
- Run :
```
docker start articles-mongo
```
- In *appsettings.Development.json*, set : "ConnectionString" : "mongodb://localhost:27017"
- Hit **Articles.API**

<img src="/pictures/article_swagger.png" title="article swagger"  width="800">

2. Run *Articles.API* microservice **containerized**
- In *appsettings.Development.json*, set : "ConnectionString" : "mongodb://articlemongodb:27017"
- Hit **Docker Compose**

3. Run *Articles.API* microservice **docker compose**
```
docker-compose -f .\docker-compose.yml -f .\docker-compose.override.yml down
docker-compose -f .\docker-compose.yml -f .\docker-compose.override.yml up -d
```
- go to *Articles.API* : http://localhost:8000/swagger/index.html

<img src="/pictures/article_swagger_docker.png" title="article swagger_docker"  width="800">
