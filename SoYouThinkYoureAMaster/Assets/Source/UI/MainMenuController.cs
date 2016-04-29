using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System;

public class MainMenuController : MonoBehaviour
{
    [SerializeField]
    private Text summonerName = null;

    [SerializeField]
    private Dropdown regionDropDown = null;
    
    public void OnStartButtonClick()
    {
        StartCoroutine(GetSummonerInformation());
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="date"></param>
    /// <returns></returns>
    public IEnumerator GetSummonerInformation()
    {
        string url = "";

        string[] summonerNames = { summonerName.text };

        Region.RegionEnum region = (Region.RegionEnum)Enum.Parse( typeof(Region.RegionEnum), regionDropDown.options[regionDropDown.value].text.ToLower() );

        if (Application.isWebPlayer)
        {
            url = "UrfQuest.php?apiCall=" + RiotAPIConstants.SUMMONERIDS_FROM_SUMMONER_NAME(summonerNames, region);
        }
        else
        {
            url = RiotAPIConstants.SUMMONERIDS_FROM_SUMMONER_NAME(summonerNames, region);
        }

        Fetch fetch = new Fetch(GetSummonerInformationSuccess,
                                GetSummonerInformationFailure,
                                url,
                                Summoner.fromJSON
                                );
        return fetch.WaitForUrlData();
    }

    private void GetSummonerInformationSuccess( object obj )
    {
        GameData.Summoner = obj as Summoner;

        UnityEngine.SceneManagement.SceneManager.LoadScene("InGameScene");
    }

    private void GetSummonerInformationFailure(string message)
    {
        //Handle bad requests here...
        Debug.LogError("message");
    }
}
