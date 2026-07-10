# Руководство по запуску

## Установка зависимостей

Проект требует .NET 8.0 SDK.

### Установка пакетов

Пакеты для работы с БД уже настроены в проекте. При установке правильных версий выполните:

```powershell
cd TashGresOpto.Data
dotnet add package Microsoft.EntityFrameworkCore --version 8.0.11
dotnet add package Microsoft.EntityFrameworkCore.Sqlite --version 8.0.11
dotnet add package Microsoft.EntityFrameworkCore.Tools --version 8.0.11
```

## Инициализация базы данных

После установки пакетов создайте миграции:

```powershell
cd TashGresOpto.Data
dotnet ef migrations add InitialCreate --startup-project ..\TashGresOpto.UI
dotnet ef database update --startup-project ..\TashGresOpto.UI
```

## Запуск приложения

```powershell
cd TashGresOpto.UI
dotnet run
```

Или откройте `TashGresOpto.sln` в Visual Studio и нажмите F5.

## Структура проекта

- **TashGresOpto.UI** - Windows Forms интерфейс
- **TashGresOpto.Core** - Бизнес-логика и калькуляторы
- **TashGresOpto.Data** - Entity Framework и работа с БД
- **TashGresOpto.Reports** - Генерация отчетов

## Реализованные модули

### Готовые:
- ✅ Базовая структура проекта
- ✅ Entity модели для всех основных таблиц
- ✅ DbContext с настройкой связей
- ✅ Калькуляторы расчетов (FuelCalculator, PowerCalculator, OverburnCalculator)
- ✅ Сервис BaxtaService, O2GolService
- ✅ Основные формы и модули

### В разработке:
- 🔄 Полная UI для всех модулей
- 🔄 Отображение результатов расчетов
- 🔄 Генерация отчетов

### Запланировано:
- 📋 Остальные сервисы (PerejegService, WyrabotkaService, SelektorService)
- 📋 Импорт данных из DBF
- 📋 Экспорт отчетов в PDF/Excel
- 📋 Графики и визуализация

## Важные особенности

### Портирование формул
Все формулы портированы с точностью из оригинальных FoxPro процедур:
- SCHET → FuelCalculator
- PERERAS → OverburnCalculator
- RASCH → PowerCalculator

### Выбор БД
Используется SQLite для простоты развертывания. Можно легко переключиться на SQL Server, изменив строку подключения в Program.cs.

### Dependency Injection
Приложение использует Microsoft.Extensions.DependencyInjection для управления зависимостями.

## Следующие шаги

1. Установить правильные версии EF Core пакетов
2. Создать миграции и инициализировать БД
3. Протестировать все основные модули
4. Добавить генерацию отчетов
5. Протестировать работу на реальных данных

## Быстрый старт

Для быстрого запуска на новом компьютере:

```bash
# 1. Клонировать репозиторий
git clone https://github.com/mufasadullaev/optonew.git
cd optonew/CSharp_Migration

# 2. Восстановить зависимости
dotnet restore

# 3. Собрать проект
dotnet build

# 4. Применить миграции БД
cd TashGresOpto.Data
dotnet ef database update --startup-project ..\TashGresOpto.UI

# 5. Запустить приложение
cd ..\TashGresOpto.UI
dotnet run
```

## Требования к системе

- Windows 10/11
- .NET 8.0 SDK
- Visual Studio 2022 или VS Code (опционально)
- 4 ГБ RAM (минимум)
- 500 МБ свободного места на диске

## Полезные команды

```bash
# Сборка проекта
dotnet build

# Запуск приложения
dotnet run --project TashGresOpto.UI

# Создание новой миграции
dotnet ef migrations add НазваниеМиграции --startup-project ..\TashGresOpto.UI

# Откат миграции
dotnet ef migrations remove --startup-project ..\TashGresOpto.UI

# Обновление БД
dotnet ef database update --startup-project ..\TashGresOpto.UI

# Очистка сборки
dotnet clean

# Публикация приложения
dotnet publish -c Release -r win-x64
```

## Решение проблем

### Проблема: "dotnet ef не найден"

Установите инструменты EF Core глобально:
```bash
dotnet tool install --global dotnet-ef
```

### Проблема: "Unable to resolve service for DbContext"

Убедитесь, что создан `OptoDbContextFactory.cs` в проекте TashGresOpto.Data.

### Проблема: Кириллица отображается некорректно

Убедитесь, что все `.cs` файлы сохранены в кодировке UTF-8 BOM.

## Документация

- **Полная документация**: `DOCUMENTATION.md` (150+ страниц)
- **Инструкция по установке**: `INSTALLATION_GUIDE.md`
- **README проекта**: `README.md`

## Поддержка

При возникновении проблем:
1. Проверьте раздел "Решение проблем" выше
2. Посмотрите Issues на GitHub
3. Создайте новый Issue с описанием проблемы
