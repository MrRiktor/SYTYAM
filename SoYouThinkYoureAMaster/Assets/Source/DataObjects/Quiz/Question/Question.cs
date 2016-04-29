using System.Collections.Generic;

public class Question
{
    private string text = "";

    private List<Answer> answerList = new List<Answer>(4);

    #region Accessors/Modifiers

    public string Text
    {
        get
        {
            return text;
        }
        set
        {
            text = value;
        }
    }

    public List<Answer> AnswerList
    {
        get
        {
            return answerList;
        }
    }
    
    #endregion

    public Answer GetCorrectAnswer()
    {
        foreach(Answer answer in answerList)
        {
            if(answer.IsCorrect)
            {
                return answer;
            }
        }

        return null;
    }
}