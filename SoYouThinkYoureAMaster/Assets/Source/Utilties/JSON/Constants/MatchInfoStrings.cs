using UnityEngine;
using System.Collections;

public class MatchInfoStrings : MonoBehaviour
{
    [SerializeField]
    TextAsset championInfo = null;

    [SerializeField]
    TextAsset match1 = null;
    
    [SerializeField]
    TextAsset match2 = null;
    
    [SerializeField]
    TextAsset match3 = null;
    
    [SerializeField]
    TextAsset match4 = null;
    
    [SerializeField]
    TextAsset match5 = null;
    
    [SerializeField]
    TextAsset match6 = null;
    
    [SerializeField]
    TextAsset match7 = null;
    
    [SerializeField]
    TextAsset match8 = null;
    
    [SerializeField]
    TextAsset match9 = null;
    /// <summary>
    /// The instance of the sound manager
    /// </summary>
    private static MatchInfoStrings instance;

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        DontDestroyOnLoad(this);
    }
    
    /// <summary>
    /// Used to retrieve the singleton instance of the SoundManager
    /// </summary>
    /// <returns> the instance of the SoundManager </returns>
    public static MatchInfoStrings GetInstance()
    {
        if (instance == null)
        {
            Debug.LogError("MatchInfoStrings is null... it is missing from the heirarchy most likely.");
        }
        return instance;
    }
    
    public string GetChampionList()
    {
        return championInfo.text;
    }

    public string GetMatchInfo( long matchNumber )
    {
        string matchString = match1.text;

        switch (matchNumber)
        {
            case 0:
                matchString = match1.text;
                break;
            case 1:
                matchString = match2.text;
                break;
            case 2:
                matchString = match3.text;
                break;
            case 3:
                matchString = match4.text;
                break;
            case 4:
                matchString = match5.text;
                break;
            case 5:
                matchString = match6.text;
                break;
            case 6:
                matchString = match7.text;
                break;
            case 7:
                matchString = match8.text;
                break;
            case 8:
                matchString = match9.text;
                break;
        }

        return matchString;
    }
}
