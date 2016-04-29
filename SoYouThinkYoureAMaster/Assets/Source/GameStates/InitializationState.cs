using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class InitializationState : MonoBehaviour
{
    [SerializeField]
    private Animator logoAnimator = null;

	// Use this for initialization
	private void Awake()
    {
        //Initialize JSON Object converters.
        JSONUtils.initJsonObjectConversion();
    }

    private void Start()
    {
        logoAnimator.SetTrigger("StartLogoRoll");
    }

    // Update is called once per frame
    private void Update()
    {
	
	}
}
