namespace telegramAchivements.Achive_system
{
    public class AchievementsManager : IObserver
    {
        public void OnNotify(IEntity entity, Event ev)
        {
            switch (ev)
            {
                case Event.FallFromHighHeightWithoutDying:
                    bool isEntityCharacter = (entity as Character) != null;
                    if (isEntityCharacter)
                    {
                        this.UnlockAchievement(Achievement.FallFromHighHeightWithoutDying);
                    }

                    break;

                // Other cases...
            }
        }

        private void UnlockAchievement(Achievement achievement)
        {
            // Unlock if not already unlocked...
        }
    }
}