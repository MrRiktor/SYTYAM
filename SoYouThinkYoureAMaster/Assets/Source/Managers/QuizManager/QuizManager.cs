using System.Collections.Generic;
using UnityEngine;

public class QuizManager
{
    #region Singleton Stuff

    /// <summary>
    /// The singleton instance of this manager.
    /// </summary>
    private static QuizManager instance = null;
    
    /// <summary>
    /// The accessor to this singleton QuizManager.GetInstance().
    /// </summary>
    /// <returns> Returns the instance of this manager. </returns>
    public static QuizManager GetInstance()
    {
        if (instance == null)
        {
            instance = new QuizManager();
        }
        return instance;
    }

    #endregion

    #region Private Member Variables

    /// <summary>
    /// The list containing all the questions for this quiz
    /// </summary>
    private List<Question> questionList = new List<Question>();

    /// <summary>
    /// The index of the current question.
    /// </summary>
    private int currentQuestionIndex = 0;

    /// <summary>
    /// The statemachine that drives quiz flow.
    /// </summary>
    private QuizStateMachine stateMachine = null;

    /// <summary>
    /// Reference to the Controller for our quiz UI.
    /// </summary>
    private QuizUIController quizUIController = null;

    #endregion

    #region Accessors/Modifiers

    /// <summary>
    /// Accessor to the quiz ui controller reference.
    /// </summary>
    public QuizUIController QuizUIController
    {
        get
        {
            return quizUIController;
        }
    }

    /// <summary>
    /// Accessor to statemachine that drives quiz flow. This allows objects outside of this quiz manager to tell the statemachine to transition.
    /// </summary>
    public QuizStateMachine StateMachine
    {
        get
        {
            return stateMachine;
        }
    }
    
    #endregion
    
    #region Constructor

    /// <summary>
    /// Private constructor for singleton purposes.
    /// </summary>
    private QuizManager() {}

    #endregion

    #region Public Methods

    /// <summary>
    /// The default constructor.
    /// </summary>
    /// <param name="quiz"> the list of questions for this quiz.</param>
    public void InitializeQuizManager( List<Question> questionList, QuizUIController quizUIController )
    {
        this.questionList = questionList;
        this.quizUIController = quizUIController;

        this.stateMachine = new QuizStateMachine();
        this.stateMachine.CurrentState.OnEnter();     
    }    

    /// <summary>
    /// The current question we are looking at.
    /// </summary>
    /// <returns> The current question we are looking at. </returns>
    public Question CurrentQuestion()
    {
        return questionList[currentQuestionIndex];
    }

    /// <summary>
    /// Increments the current question index and then returns the currentquestion (aka the next question).
    /// </summary>
    /// <returns> The next question. </returns>
    public Question NextQuestion()
    {
        currentQuestionIndex++;
        return CurrentQuestion();
    }

    public void HandlerUserAnswer(string selectedAnswer)
    {
        Debug.Log("HandlerUserAnswer - is answer correct? " + CheckAnswer(selectedAnswer).ToString());

        stateMachine.TransitionToState(StateTypes.ResolveState);
    }

    #endregion

    #region Private Methods

    /// <summary>
    /// Checks the answer passed in compared to the current questions correct answer.
    /// </summary>
    /// <param name="answer"> The Answer object to check. </param>
    /// <returns> If true the answer was correct, else incorrect. </returns>
    private bool CheckAnswer(Answer answer)
    {
        if (questionList[currentQuestionIndex].GetCorrectAnswer().Text == answer.Text)
        {
            return true;
        }

        return false;
    }

    /// <summary>
    /// Checks the answer passed in compared to the current questions correct answer.
    /// </summary>
    /// <param name="answer"> The answer string to check. </param>
    /// <returns> If true the answer was correct, else incorrect. </returns>
    private bool CheckAnswer(string answer)
    {
        if (questionList[currentQuestionIndex].GetCorrectAnswer().Text == answer)
        {
            return true;
        }

        return false;
    }

    #endregion
}
