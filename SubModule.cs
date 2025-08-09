using TaleWorlds.CampaignSystem;
using TaleWorlds.Core;
using TaleWorlds.MountAndBlade;
using TaleWorlds.Library;

namespace DailyMoneyBoost
{
    public class SubModule : MBSubModuleBase
    {
        protected override void OnGameStart(Game game, IGameStarter gameStarter)
        {
            base.OnGameStart(game, gameStarter);

            if (game.GameType is Campaign)
            {
                CampaignEvents.DailyTickEvent.AddNonSerializedListener(this, OnDailyTick);
            }
        }

        private void OnDailyTick()
        {
            if (Hero.MainHero != null)
            {
                // Добавляем 1 000 000 денариев игроку
                Hero.MainHero.ChangeHeroGold(1_000_000);
                InformationManager.DisplayMessage(new InformationMessage("Вы получили 1,000,000 денариев!"));
            }
        }
    }
}
