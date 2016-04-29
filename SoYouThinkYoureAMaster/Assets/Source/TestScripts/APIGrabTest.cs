using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class APIGrabTest : MonoBehaviour
{
    [SerializeField]
    private Text summonerNameText = null;
    
    // Use this for initialization
    public void GetChampionMastery()
    {        
        StartCoroutine(getSummonerInformation( summonerNameText.text ) );        
    }

    // Update is called once per frame
    void Start()
    {
        JSONUtils.initJsonObjectConversion();

        StartCoroutine(getSummonerInformation("Riktor"));
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="date"></param>
    /// <returns></returns>
    public IEnumerator getSummonerInformation( string summonerName )
    {
        string url = "";

        string[] summonerNames = { summonerName };

        if (Application.isWebPlayer)
        {
            url = "UrfQuest.php?apiCall=" + RiotAPIConstants.SUMMONERIDS_FROM_SUMMONER_NAME(summonerNames);
        }
        else
        {
            url = RiotAPIConstants.SUMMONERIDS_FROM_SUMMONER_NAME(summonerNames);
        }

        Fetch fetch = new Fetch(success,
                                failure,
                                url,
                                Summoner.fromJSON
                                );
        return fetch.WaitForUrlData();

    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="obj"></param>
    private void success(object obj)
    {
        Summoner summoner = obj as Summoner;

        Debug.Log("ID: " + summoner.ID.ToString() +
                  "Name: " + summoner.Name.ToString() );

        StartCoroutine(getMasteryInformation(summoner));
    }

    public IEnumerator getMasteryInformation(Summoner summoner)
    {
        //string url = RiotAPIConstants.CHAMPIONMASTERY_TOP_CHAMPIONS(summoner.ID);
        //string url = RiotAPIConstants.CHAMPIONMASTERY_ALL_CHAMPIONS(summoner.ID);        
        string url = RiotAPIConstants.CHAMPIONMASTERY_SINGLE_CHAMPION(summoner.ID, 133);   

        Fetch fetch = new Fetch(masterySuccess,
                            masteryFailure,
                            url,
                            ChampionMastery.fromJSON
                            );
        return fetch.WaitForUrlData();
    }

    private void masterySuccess(object obj)
    {

        Debug.Log("Mastery Success");
    }

    private void masteryFailure(string message)
    {
        Debug.LogError("Error Message: " + message);
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="message"></param>
    private void failure(string message)
    {
        Debug.LogError("Error Message: " + message);
    }   
}
