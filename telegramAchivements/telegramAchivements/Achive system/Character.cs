using System.Collections.Generic;

namespace telegramAchivements.Achive_system
{
    public class Character : IObservable
    {
        private List<IObserver> observers;

        // IEntity interface implementation
        public virtual void PhysicsUpdate()
        {
            // Apply gravity and stuff...
            NotifyObservers(this, Event.FallFromHighHeightWithoutDying);
        }
        // END IEntity interface implementation

        // IObservable interface implementation
        public virtual void AddObserver(IObserver observer)
        {
            this.observers.Add(observer);
        }

        public virtual void RemoveObserver(IObserver observer)
        {
            this.observers.Remove(observer);
        }

        public virtual void NotifyObservers(IEntity entity, Event ev)
        {
            foreach (var observer in this.observers)
            {
                observer.OnNotify(entity, ev);
            }
        }
        // END IObservable interface implementation
    }
}