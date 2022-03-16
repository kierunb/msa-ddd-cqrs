# EF Core with SQLite + DDD and CQRS 

#### Project setup

```
# initial setup
dotnet tool install --global dotnet-ef
dotnet tool update --global dotnet-ef

# create migration and update db before using app
dotnet ef migrations add InitialMigration
dotnet ef database update
```

#### Versions
- V1 - Ef Core with Anemic Model

#### Knowledge Base

- https://docs.microsoft.com/en-us/dotnet/architecture/microservices/microservice-ddd-cqrs-patterns/
- https://docs.microsoft.com/en-us/dotnet/architecture/microservices/microservice-ddd-cqrs-patterns/infrastructure-persistence-layer-implementation-entity-framework-core
- https://docs.microsoft.com/en-us/azure/architecture/microservices/model/domain-analysis