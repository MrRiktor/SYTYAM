using UnityEngine;
using System.Collections;

public class InGameState : MonoBehaviour
{
    [SerializeField]
    private QuizUIController quizUiController = null;

    // Use this for initialization
    private void Awake()
    {
        QuizManager.GetInstance().InitializeQuizManager( QuizBuilder.BuildQuiz( null ), quizUiController );
    }

    // Update is called once per frame
    private void Update ()
    {
        QuizManager.GetInstance().StateMachine.CurrentState.Update();
	}
}
