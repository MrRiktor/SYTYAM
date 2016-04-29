public class QuizStateMachine : StateMachine
{
    /// <summary>
    /// Initializes the state transitions Dictionary.
    ///   * Note: required for any class that inherits from StateMachine
    /// </summary>
    public override void InitializeTransitions()
    {
        this.Transitions.Add(new StateTransition(StateTypes.InitState, StateTypes.IdleState), new IdleState());
        this.Transitions.Add(new StateTransition(StateTypes.IdleState, StateTypes.ResolveState), new ResolveState());
        this.Transitions.Add(new StateTransition(StateTypes.ResolveState, StateTypes.InitState), new InitState());
    }

    /// <summary>
    /// Default Constructor
    /// </summary>
    /// <param name="startingState"> The starting state of the state machine. </param>
    public QuizStateMachine() : base( new InitState() )
    {
    }
}
