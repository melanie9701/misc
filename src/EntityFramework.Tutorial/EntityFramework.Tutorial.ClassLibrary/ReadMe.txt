https://msdn.microsoft.com/en-us/library/jj591621(v=vs.113).aspx

Es muss mindestens ein DBContext vorhanden sein.
Tools –> Library Package Manager –> Package Manager Console

Grundsätzliches Einrichten von Migrations
Enable-Migrations
Zum Entfernen einfach den "Migrations"-Ordner löschen

Add-Migration will scaffold the next migration based on changes you have made to your model since the last migration was created
Update-Database will apply any pending migrations to the database

add-migration InitialCreate

