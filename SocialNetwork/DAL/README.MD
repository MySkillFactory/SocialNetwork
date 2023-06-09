В папку **DB** мы добавим файл нашей базы данных (social_network.bd), который создали ранее.
В папке **Entities** будут находиться сущности нашей базы данных.
В папке **Repositories** будут находиться репозитории для каждой сущности.

**Репозиторий** — это паттерн программирования, позволяющий отделить логику извлечения, хранения, записи данных из хранилища от основной бизнес логики. Благодаря репозиториям мы не привязываемся к какой-то конкретной базе данных. В любую минуту в нашем проекте мы можем безболезненно сменить базу данных, уйти в текстовые файлы или эксель. Репозиторий — это стандарт в любом приложении, использующем базу данных.

**Сущность (Entities)** равна строке в базе данных. Отсюда, если мы взглянем на класс UserEntity, то обнаружим, что все его свойства аналогичны полям в таблице Users нашей базы данных.

**NUGETs:**
 - System.Data.SQLite.Core - упрощенный поставщик ADO.NET для SQLite;
 - Dapper - упрощенная модель ORM для БД;