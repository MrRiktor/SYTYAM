#region File Header

/*******************************************************************************
 * Author: Matthew "Riktor" Baker
 * Filename: CombatState.cs
 * Date Created: 4/12/2015 8:28PM EST
 * 
 * Description: The Combat State that processes an entire traversal of the attack queue then is exited. 
 * 
 * Changelog:   - Modified: Matthew "Riktor" Baker - 4/14/2015 8:52 PM
 *              - Modified: Matthew "Riktor" Baker - 4/16/2015 9:07 PM - Added Comments
 *******************************************************************************/

#endregion

public class ResolveState : BaseState
{
    #region Constructor

    /// <summary>
    /// Default Constructor - sets this states BattleStateType.
    /// </summary>
    public ResolveState()
    {
        this.StateType = StateTypes.ResolveState;
    }

    #endregion

    #region Public Methods

    /// <summary>
    /// Overrides BattleState's OnEnter() - Occurs when the state is entered.
    /// </summary>
    public override void OnEnter()
    {
        QuizManager.GetInstance().StateMachine.TransitionToState(StateTypes.InitState);
        base.OnEnter();
    } 

    /// <summary>
    /// Overrides BattleState's OnExit() - Occurs when the state is exited.
    /// </summary>
    public override void OnExit()
    {
        base.OnExit();
    }

    /// <summary>
    /// Overrides BattleState's Update() - Occurs while the state is active.
    /// </summary>
    public override void Update()
    {        
        base.Update();
    }

    #endregion
}
