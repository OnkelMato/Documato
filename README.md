# Documato
Onkel Matos Document Search Engine.

## Use cases

```mermaid
flowchart LR
    user["User"]

    subgraph system["Documato system"]
        upload(["Upload document"])
        index(["Index document as vector"])
        search(["Search documents"])
        metadata(["Extract metadata"])
    end

    user --> upload --> index
    user --> search
    upload --> metadata
```

## Local services

Start the ARM64 Azure SQL Database container and ChromaDB with Docker Compose:

```bash
docker compose up -d
```

The services are available at:

- Azure SQL Database: `localhost:1433`
- ChromaDB: `http://localhost:8000`

The database uses the `sa` user. The default development password is
`DocumatoDev!2026`; override it before starting the stack by setting
`MSSQL_SA_PASSWORD` in a `.env` file or in the shell environment.

The database image is a [public-preview Azure SQL Database engine](https://microsoft.github.io/azure-sql-dev-hub/container/get-started), not SQL Server 2022. It runs natively on ARM64 and uses a new `azure-sql-data` volume; any existing `mssql-data` volume from the previous image is left untouched.

Stop the containers without deleting their data:

```bash
docker compose down
```

To also remove the persisted database volumes:

```bash
docker compose down -v
```
