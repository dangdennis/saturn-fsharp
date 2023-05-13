### How to develop your application

1. Run `dotnet tool restore` to restore all necessary tools
2. Run `dotnet saturn migration` to create sqlite database
3. Run `dotnet run --project ./src/Migrations` to migrate sqlite database.
4. Run `dotnet watch --project ./src/App` to run your server in watch mode. 

### How to build and deploy onto Fly.io

1. WIP

### How to use `dotnet saturn`

Templates comes with `Saturn.Cli` tool installed by default. It's a CLI tool that can be used for project scaffold and managing generated DB migrations

#### Commands

`dotnet saturn` supports following commands:

* `gen NAME NAMES COLUMN:TYPE COLUMN:TYPE COLUMN:TYPE ...` - creates model, database layer, views and controller returning HTML views
* `gen.json NAME NAMES COLUMN:TYPE COLUMN:TYPE COLUMN:TYPE ...` - creates model, database layer and JSON API controller
* `gen.model NAME NAMES COLUMN:TYPE COLUMN:TYPE COLUMN:TYPE ...` - creates model and database layer
* `migration` - runs all migration scripts for the database

#### Supported Types

Generator supports following types:

* `string`
* `int`
* `float`
* `double`
* `decimal`
* `guid`
* `datetime`
* `bool`
