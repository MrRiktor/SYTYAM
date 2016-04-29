#region File Header

/*******************************************************************************
 * Author: Matthew "Riktor" Baker
 * Filename: BattleStateMachine.cs
 * Date Created: 4/12/2015 4:58PM EST
 * 
 * Description: The state machine that drives our battle system.
 * 
 * Changelog:   - Modified: Matthew "Riktor" Baker - 4/16/2015 9:01 PM - Added Comments
 *******************************************************************************/

#endregion

#region Using Directives

using System.Collections.Generic;

#endregion

public abstract class StateMachine
{
    #region Private Member Variables

    /// <summary>
    /// The current state of the state machine.
    /// </summary>
    private IBaseState currentState;

    /// <summary>
    /// The Dictionary of acceptable state transitions.
    /// </summary>
    private Dictionary<StateTransition, IBaseState> transitions = new Dictionary<StateTransition, IBaseState>();

    #endregion
    
    #region Accessors/Modifiers

    /// <summary>
    /// Accessor for the current state of the state machine.
    /// </summary>
    public IBaseState CurrentState
    {
        get
        {
            return currentState;
        }
    }

    /// <summary>
    /// Accessor for the transitions dictionary. Use this to add state transitions in the extended statemachines.
    /// </summary>
    protected Dictionary<StateTransition, IBaseState> Transitions
    {
        get
        {
            return transitions;
        }
    }
    
    #endregion

    #region Constructor

    /// <summary>
    /// Default Constructor
    /// </summary>
    /// <param name="startingState"> The starting state of the state machine. </param>
    public StateMachine( IBaseState startingState )
    {
        currentState = startingState;
        InitializeTransitions();
    }

    #endregion

    #region Public Methods

    /// <summary>
    /// A call to transition to the nextState passed in.
    /// </summary>
    /// <param name="nextState"> the desired state to transition to. </param>
    public void TransitionToState(StateTypes nextState)
    {
        IBaseState battleState = GetNextState(nextState);

        currentState.OnExit();

        currentState = battleState;

        currentState.OnEnter();
    }

    /// <summary>
    /// Initializes the state transitions Dictionary.
    ///   * Note: required for any class that inherits from StateMachine
    /// </summary>
    public abstract void InitializeTransitions();

    #endregion

    #region Private Methods

    /// <summary>
    /// Validates the transition from the current state to the nextBattleState passed in.
    /// </summary>
    /// <param name="nextBattleState"> The desired next battle state. </param>
    /// <returns> Returns the next state or null depending on the validity of the state transition requested. </returns>
    private IBaseState ValidateStateTransition( StateTypes nextBattleState)
    {
        IBaseState nextState = null;
        
        StateTransition transition = new StateTransition( currentState.StateType, nextBattleState );
        if(!transitions.TryGetValue( transition, out nextState ))
        {
            UnityEngine.Debug.LogError("Invalid Transition");
        }

        return nextState;
    }
    
    /// <summary>
    /// Requests a next state.
    /// </summary>
    /// <param name="nextState"> the next state we want. </param>
    /// <returns> returns a valid next state or null. </returns>
    private IBaseState GetNextState(StateTypes nextState)
    {
        return ValidateStateTransition(nextState);
    }

    #endregion
}