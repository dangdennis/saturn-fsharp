namespace Migrations

open SimpleMigrations

module Migration1 =
    [<Literal>]
    let version = 2023_0513_115100L

    [<Migration(version, "Create users table")>]
    type CreateUsers() =
        inherit Migration()

        override this.Up() =
            this.Execute
                """
                CREATE TABLE users (
                    Id INTEGER PRIMARY KEY AUTOINCREMENT
                );
                """

        override this.Down() =
            this.Execute
                """
                DROP TABLE users;
                """
