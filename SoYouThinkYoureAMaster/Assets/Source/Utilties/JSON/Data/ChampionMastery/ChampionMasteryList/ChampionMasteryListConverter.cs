#region File Header

/*******************************************************************************
 * Author: Matthew "Riktor" Baker
 * Filename: ChampionMasteryConverter.cs
 * Date Created: 4/26/2016 10:42PM EST
 * 
 * Description: Converter for ChampionMastery Data Class
 * 
 * Changelog:   - N/A
 *******************************************************************************/

#endregion

#region Using Directives

using System;
using System.Collections;
using System.Collections.Generic;
using JsonFx.Json;

#endregion

public class ChampionMasteryListConverter : JsonConverter
{
    #region Public Methods

    #region Converters

    /// <summary>
    /// 
    /// </summary>
    /// <param name="propToValueMap"></param>
    /// <returns></returns>
    public static ChampionMasteryList DictionaryToChampionMasteryList(Dictionary<String, Object> propToValueMap)
    {
        ChampionMasteryList championMasteryList = new ChampionMasteryList();

        #region ChampionId Property

        if (propToValueMap.ContainsKey(ChampionMasteryList.PropertyNames.Masteries) && propToValueMap[ChampionMasteryList.PropertyNames.Masteries] is Dictionary<String, Object>)
        {
            Dictionary<String, Object> championMasteryPropValueMap = (Dictionary<String, Object>)propToValueMap[ChampionDB.PropertyNames.Data];

            foreach (KeyValuePair<String, Object> championMasteryDict in championMasteryPropValueMap)
            {
                ChampionMastery championMastery = ChampionMasteryConverter.DictionaryToChampionMastery(championMasteryDict.Value as Dictionary<String, Object>);

                //championMasteryList.Data.Add(championMastery);                
            }
        }

        #endregion

        return championMasteryList;
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="summoner"></param>
    /// <returns></returns>
    public static Dictionary<String, Object> ChampionMasteryListToDictionary(ChampionMasteryList championMasteryList)
    {
        if (championMasteryList == null)
        {
            throw new ArgumentException("parameter player is required.");
        }

        Dictionary<String, Object> propToValueMap = new Dictionary<String, Object>();

        return propToValueMap;
    }

    #endregion

    #region Json Converter Inherited Methods

    /// <summary>
    /// Tests to see if the current type can be converted by this converter class
    /// </summary>
    /// <param name="t">Optional - the type to be tested</param>
    /// <returns>true if the type can be converted, false otherwise</returns>
    public override bool CanConvert(Type t)
    {
        if (typeof(ChampionMasteryList).Equals(t))
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    /// <summary>
    /// Converts a dictionary into a Summoner
    /// </summary>
    /// <param name="type">Optional - the type of the value parameter</param>
    /// <param name="value">Optional - the dictionary that is to be converted into an instance</param>
    /// <returns>A MatchDetail instance if type and value are not null, null otherwise</returns>
    public override Object ReadJson(Type type, Dictionary<String, Object> value)
    {
        if (!CanConvert(type))
        {
            return null;
        }

        if ((type == null) || (value == null))
        {
            return null;
        }

        return DictionaryToChampionMasteryList(value);
    }

    /// <summary>
    /// Converts a Summoner into a dictionary
    /// </summary>
    /// <param name="type">Optional - the type of the value parameter</param>
    /// <param name="value">Optional - the instance that is to be converted into a dictionary</param>
    /// <returns>A Dictionary containing the data contained in the value parameter</returns>
    public override Dictionary<String, Object> WriteJson(Type type, Object value)
    {
        ChampionMasteryList championMasteryList = (ChampionMasteryList)value;
        return ChampionMasteryListToDictionary(championMasteryList);
    }

    #endregion

    #endregion
}