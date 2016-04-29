using UnityEngine;
using System.Collections;

public class QuizLadderItem : MonoBehaviour
{
    [SerializeField]
    private UnityEngine.UI.Text text = null;

    // Use this for initialization
    public void SetTierValue(ushort tierValue)
    {
        text.text = tierValue.ToString();
    }
}
