namespace telegramAchivements.Achive_system
{
    public interface IObserver
    {
        void OnNotify(IEntity entity, Event ev);
    }
}