using UnityEngine;

public class QuizLadderController : MonoBehaviour
{
    public static ushort[] TierArray = 
    {
        100,
        600,
        1200,
        1800,
        3200,
        4600,
        6000,
        8200,
        10400,
        12600,
        17100,
        21600,
        27300,
        33000,
        46800,
    };

    [SerializeField]
    private GameObject quizLadderItemPrefab = null;
    
    // Use this for initialization
	void Awake()
    {
        foreach( ushort tierValue in TierArray )
        {
            GameObject gameObject = GameObject.Instantiate(quizLadderItemPrefab);

            gameObject.transform.SetParent(this.transform);
            gameObject.transform.localPosition = Vector3.zero;
            gameObject.transform.localScale = Vector3.one;
            
            gameObject.GetComponent<QuizLadderItem>().SetTierValue(tierValue);
        }        
    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
