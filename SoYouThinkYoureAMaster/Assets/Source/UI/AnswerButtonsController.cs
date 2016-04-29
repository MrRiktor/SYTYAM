using UnityEngine;
using UnityEngine.UI;

using System.Collections.Generic;


public class AnswerButtonsController : MonoBehaviour
{
    [SerializeField]
    private AnswerButton AnswerOneButton = null;

    [SerializeField]
    private AnswerButton AnswerTwoButton = null;

    [SerializeField]
    private AnswerButton AnswerThreeButton = null;

    [SerializeField]
    private AnswerButton AnswerFourButton = null;
    
    public void InitButtons( List<Answer> answerList, AnswerButton.AnswerButtonCallback callback )
    {
        AnswerOneButton.InitAnswerButton(answerList[0].Text, callback);

        AnswerTwoButton.InitAnswerButton(answerList[1].Text, callback);

        AnswerThreeButton.InitAnswerButton(answerList[2].Text, callback);

        AnswerFourButton.InitAnswerButton(answerList[3].Text, callback);
    }
}
