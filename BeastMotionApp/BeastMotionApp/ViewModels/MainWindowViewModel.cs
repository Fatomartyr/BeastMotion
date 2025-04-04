using BeastMotionApp.Models;
using BeastMotionApp.Models.Dog;
using BeastMotionApp.Models.Panther;
using BeastMotionApp.Models.Turtle;

namespace BeastMotionApp.ViewModels;

public partial class MainWindowViewModel : ViewModelBase
{
    private LivingCreature _dog = new Dog();
    private LivingCreature _panther = new Panther();
    private LivingCreature _turtle = new Turtle();
    
    private BarkObservable _dogBarkObservable = new BarkObservable();
    private RoarObservable _pantherRoarObservable = new RoarObservable();
    private ClimbTreeObservable _pantherClimbTreeObservable = new ClimbTreeObservable(); 

    private  AnimalViewModel DogViewModel { get; }
    private  AnimalViewModel PantherViewModel { get; }
    private  AnimalViewModel PantherClimbTreeViewModel { get; }
    private  AnimalViewModel TurtleViewModel { get; }
    
    public MainWindowViewModel()
    {
        _dog.InitializeSpeed(5);
        _panther.InitializeSpeed(25); 
        _turtle.InitializeSpeed(0);
        DogViewModel = new AnimalViewModel(_dog, _dogBarkObservable); 
        PantherViewModel = new AnimalViewModel(_panther, _pantherRoarObservable); 
        PantherClimbTreeViewModel = new AnimalViewModel(_panther, _pantherClimbTreeObservable); 
        TurtleViewModel = new AnimalViewModel(_turtle, null);
    }
}