# DailyMoneyBoost - Bannerlord mod (ready-to-build)


This project contains a minimal implementation of a mod for **Mount & Blade II: Bannerlord**,
which awards the player 1,000,000 denarii every in-game day.

## What's Included If you want just mod download it from releases 
place in X:\...\steamapps\common\Mount & Blade II Bannerlord\Modules


## What's Included
- Visual Studio project (Class Library, .NET Framework 4.7.2)
- SubModule.xml
- C# source `SubModule.cs`
- Build and Installation Instructions

```
<PATH_TO_BANNERLORD>\bin\Win64_Shipping_Client\
```
Add the following DLLs to References:
- TaleWorlds.Core.dll
- TaleWorlds.CampaignSystem.dll
- TaleWorlds.MountAndBlade.dll

## Build
1. Open `DailyMoneyBoost.sln` or `DailyMoneyBoost.csproj` project in Visual Studio.
2. Make sure Target Framework is set to **.NET Framework 4.7.2**.
3. Add references (see above).
4. Build the project (Build => Build Solution).
5. Copy the `bin\Win64_Shipping_Client\` folder (it will contain `DailyMoneyBoost.dll`) to:
```
<PATH_TO_BANNERLORD>\Modules\DailyMoneyBoost\bin\Win64_Shipping_Client\
```
6. Copy `SubModule.xml` to:
```
<PATH_TO_BANNERLORD>\Modules\DailyMoneyBoost\
```

## Behavior
When the campaign starts, the mod will subscribe to the daily tick event (`CampaignEvents.DailyTickEvent`)
and add 1,000,000 denarii to the player, and also show a message in the game.

## Note on multiplayer
The mod is marked as SingleplayerModule. Do not include it in the server build.


# DailyMoneyBoost - Bannerlord mod (ready-to-build)

Этот проект содержит минимальную реализацию мода для **Mount & Blade II: Bannerlord**,
который начисляет игроку 1,000,000 денариев каждый игровой день.

## Что включено
- Visual Studio проект (Class Library, .NET Framework 4.7.2)
- SubModule.xml
- C# исходник `SubModule.cs`
- Инструкции по сборке и установке

## Важно — добавить ссылки вручную
В проект **нужно вручную добавить ссылки** на библиотеки Bannerlord, которые находятся в папке игры:
```
<PATH_TO_BANNERLORD>\bin\Win64_Shipping_Client\
```
Добавь следующие DLLs в References:
- TaleWorlds.Core.dll
- TaleWorlds.CampaignSystem.dll
- TaleWorlds.MountAndBlade.dll

## Сборка
1. Открой `DailyMoneyBoost.sln` или проект `DailyMoneyBoost.csproj` в Visual Studio.
2. Убедись, что установлен Target Framework **.NET Framework 4.7.2**.
3. Добавь ссылки (см. выше).
4. Построй проект (Build => Build Solution).
5. Скопируй папку `bin\Win64_Shipping_Client\` (в ней будет `DailyMoneyBoost.dll`) в:
   ```
   <PATH_TO_BANNERLORD>\Modules\DailyMoneyBoost\bin\Win64_Shipping_Client\
   ```
6. Скопируй `SubModule.xml` в:
   ```
   <PATH_TO_BANNERLORD>\Modules\DailyMoneyBoost\
   ```

## Поведение
При старте кампании мод подпишется на событие ежедневного тика (`CampaignEvents.DailyTickEvent`)
и добавит игроку 1,000,000 денариев, а также покажет сообщение в игре.

## Примечание по мультиплееру
Мод помечен как SingleplayerModule. Не включай в серверную сборку.

