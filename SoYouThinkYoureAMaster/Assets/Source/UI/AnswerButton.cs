using UnityEngine;
using UnityEngine.UI;

public class AnswerButton : MonoBehaviour
{
    public delegate void AnswerButtonCallback(string selectedAnswer);

    private AnswerButtonCallback AnswerButtonCallbackHandler;

    [SerializeField]
    private Text buttonText = null;

    public void InitAnswerButton( string answerText, AnswerButtonCallback callback )
    {
        buttonText.text = answerText;

        AnswerButtonCallbackHandler = callback;
    }    

    public void OnAnswerButtonClick()
    {
        AnswerButtonCallbackHandler( this.buttonText.text );
    }
}
