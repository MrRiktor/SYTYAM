using System.Collections.Generic;

public class Quiz
{
    #region Private Member Variables

    /// <summary>
    /// The list containing all the questions for this quiz
    /// </summary>
    private List<Question> questionList = new List<Question>();

    /// <summary>
    /// The index of the current question.
    /// </summary>
    private int currentQuestionIndex = 0;

    #endregion

    #region Constructor

    /// <summary>
    /// Force this object to be initialized by the defined constructor.
    /// </summary>
    private Quiz()
    {
    }

    /// <summary>
    /// The default constructor.
    /// </summary>
    /// <param name="quiz"> the list of questions for this quiz.</param>
    public Quiz( List<Question> questionList)
    {
        this.questionList = questionList;
    }

    #endregion

    #region Public Methods

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

    /// <summary>
    /// Checks the answer passed in compared to the current questions correct answer.
    /// </summary>
    /// <param name="answer"> The Answer object to check. </param>
    /// <returns> If true the answer was correct, else incorrect. </returns>
    public bool CheckAnswer( Answer answer )
    {
        if( questionList[currentQuestionIndex].GetCorrectAnswer().Text == answer.Text )
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
    public bool CheckAnswer( string answer )
    {
        if ( questionList[currentQuestionIndex].GetCorrectAnswer().Text == answer)
        {
            return true;
        }

        return false;
    }

    #endregion
}
