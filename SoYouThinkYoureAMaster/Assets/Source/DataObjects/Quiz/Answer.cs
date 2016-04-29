public class Answer
{
    public Answer(string text, bool isCorrect)
    {
        this.text = text;
        this.isCorrect = isCorrect;        
    }

    private string text = "";

    private bool isCorrect = false;

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

    public bool IsCorrect
    {
        get
        {
            return isCorrect;
        }
        set
        {
            isCorrect = value;
        }
    }
}