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

