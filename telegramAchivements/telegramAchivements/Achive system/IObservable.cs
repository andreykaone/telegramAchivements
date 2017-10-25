namespace telegramAchivements.Achive_system
{
    public interface IObservable
    {
        void AddObserver(IObserver observer);

        void RemoveObserver(IObserver observer);

        void NotifyObservers(IEntity entity, Event ev);
    }
}