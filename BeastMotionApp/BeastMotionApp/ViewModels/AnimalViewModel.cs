using System.Collections.Generic;
using System.Linq;
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

        private bool _canBark;
        private bool _canRoar;
        private bool _canClimbTree;
        
        public bool CanBark
        {
            get => _canBark;
            set => SetProperty(ref _canBark, value);
        }

        public bool CanRoar
        {
            get => _canRoar;
            set => SetProperty(ref _canRoar, value);
        }

        public bool CanClimbTree
        {
            get => _canClimbTree;
            set => SetProperty(ref _canClimbTree, value);
        }

        
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
        public IRelayCommand BarkCommand { get; }
        public IRelayCommand RoarCommand { get; }
        public IRelayCommand ClimbTreeCommand { get; }

        private readonly LivingCreature _creature;
        private readonly List<IObservable> _observables;

        public AnimalViewModel(LivingCreature creature,  List<IObservable> observables)
        {
            _creature = creature;
            _observables = observables ?? new List<IObservable>();
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
                ActionStatus = $"{_creature.GetType().Name} is slowing down. Speed: {Speed}";
            });

            BarkCommand = new RelayCommand(() =>
            {
                var barkObservable = _observables.OfType<BarkObservable>().FirstOrDefault();
                if (barkObservable != null)
                {
                    var bark = new Bark();
                    barkObservable.NotifyObservers(bark);
                    ActionStatus = bark.Content;
                }
            });        
    
            RoarCommand = new RelayCommand(() =>
            {
                var roarObservable = _observables.OfType<RoarObservable>().FirstOrDefault();
                if (roarObservable != null)
                {
                    var roar = new Roar();
                    roarObservable.NotifyObservers(roar);
                    ActionStatus = roar.Content;
                }
            });

            ClimbTreeCommand = new RelayCommand(() =>
            {
                var climbTreeObservable = _observables.OfType<ClimbTreeObservable>().FirstOrDefault();
                if (climbTreeObservable != null)
                {
                    var climbTree = new ClimbTree();
                    climbTreeObservable.NotifyObservers(climbTree);
                    ActionStatus = climbTree.Content;
                }
            });
            CanBark = _creature is Dog;
            CanRoar = _creature is Panther; 
            CanClimbTree = _creature is Panther;
        }
    }
}


