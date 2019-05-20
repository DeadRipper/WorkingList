Добрый день.

Данный файл поможет вам в том, чтобы настроить конфигурационный файл на то, 
чтобы ваша база данных могла присоединиться к вашему серверу.

Инструкция:
1. В папке проекта необходимо найти файл App.config.
Этот файл - это конфигурация всего ПО.

Пример пути по которому он находиться:
C:\Users\hardy\source\repos\TestTask\TestTask

Данный путь лишь пример того где расположен данный файл. Файл всегда находиться в асамблее сборки и он может
быть обнаружен именно там.

2. Открыть данный файл (App.config).
3. Необходимо изменить конфигурацию указанную в <connectionStrings>:
<connectionStrings>
<add name="TestTask.Properties.Settings.Параметр" connectionString="Data Source=DESKTOP-QPKFTFN;
	Initial Catalog=TaskDB;Integrated Security=True" providerName="System.Data.SqlClient" />
</connectionStrings>

Необходимо для connectionString="Data Source= указать имя своего сервера. Имя сервера можно узнать при входе в
Microsoft SQL Server Managment Studio. 
Далее указать каталог на который будет ссылаться данная программа Initial Catalog=.
Integrated Security=True - говорит о том что соединению которое было установлено можно "доверять" 
и не указывать логин и пароль для базы данных.

Выполнив все указанные пункты, можно настроить <connectionStrings> для своей базы данных.

