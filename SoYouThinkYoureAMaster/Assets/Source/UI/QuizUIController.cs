using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class QuizUIController : MonoBehaviour
{
    [SerializeField]
    private AnswerButtonsController answerButtonsController = null;

    [SerializeField]
    private Text questionTextField = null;

    public void SetupQuestion(Question question, AnswerButton.AnswerButtonCallback callback)
    {
        questionTextField.text = question.Text;

        answerButtonsController.InitButtons(question.AnswerList, callback);
    }
}
