using UnityEngine;
using System.Collections;

public class MainMenuState : MonoBehaviour
{
    [SerializeField]
    Animator mainMenuAnimator = null;

	// Use this for initialization
	void Awake ()
    {
        JSONUtils.initJsonObjectConversion();

        if ( mainMenuAnimator != null )
        {
            mainMenuAnimator.SetTrigger("PlayIntro");
        }

    }
	
	// Update is called once per frame
	void Update ()
    {
	
	}
}
