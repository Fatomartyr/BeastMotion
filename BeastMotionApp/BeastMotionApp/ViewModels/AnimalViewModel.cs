using BeastMotionApp.Models;
using BeastMotionApp.Models.Dog;
using BeastMotionApp.Models.ObserverPattern;
using BeastMotionApp.Models.Panther;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace BeastMotionApp.ViewModels
{
    public class AnimalViewModel : ObservableObject
    {
        private string _actionStatus;
        private double _speed;

        public string ActionStatus
        {
            get => _actionStatus;
            set => SetProperty(ref _actionStatus, value);
        }
        
        public double Speed
        {
            get => _speed;
            set => SetProperty(ref _speed, value);
        }

        public IRelayCommand MoveCommand { get; }
        public IRelayCommand StopCommand { get; }
        public IRelayCommand ActionCommand { get; }

        private readonly IObservable _observable;
        private readonly LivingCreature _creature;

        public AnimalViewModel(LivingCreature creature, IObservable observable)
        {
            _creature = creature;
            _observable = observable;
            Speed = creature.Speed;
            
            MoveCommand = new RelayCommand(() =>
            {
                _creature.Move();
                Speed = _creature.Speed;
                ActionStatus = $"{_creature.GetType().Name} is moving. Speed: {Speed}";
            });

            StopCommand = new RelayCommand(() =>
            {
                _creature.Stop();
                Speed = _creature.Speed;
                ActionStatus = $"{_creature.GetType().Name} stopped. Speed: {Speed}";
            });

            ActionCommand = new RelayCommand(() =>
            {
                IAction action = null;
                if (_observable is BarkObservable)
                {
                    action = new Bark();
                }
                else if (_observable is RoarObservable)
                {
                    action = new Roar();
                }
                else if (_observable is ClimbTreeObservable)
                {
                    action = new ClimbTree();
                }
                if (action != null)
                {
                    _observable.NotifyObservers(action);
                    ActionStatus = action.Content;
                }
            });
        }
    }
}


