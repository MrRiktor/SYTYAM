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
public class ChampionMasteryConverter : JsonConverter
{
    #region Public Methods

    #region Converters

    /// <summary>
    /// 
    /// </summary>
    /// <param name="propToValueMap"></param>
    /// <returns></returns>
    public static ChampionMastery DictionaryToChampionMastery(Dictionary<String, Object> propToValueMap)
    {
        ChampionMastery championMastery = new ChampionMastery();
        
        #region ChampionId Property

        if (propToValueMap[ChampionMastery.PropertyNames.ChampionId] is long)
        {
            championMastery.ChampionId = (long)propToValueMap[ChampionMastery.PropertyNames.ChampionId];
        }

        else if (propToValueMap[ChampionMastery.PropertyNames.ChampionId] is int)
        {
            championMastery.ChampionId = (int)propToValueMap[ChampionMastery.PropertyNames.ChampionId];
        }

        #endregion

        #region ChampionLevel Property

        if (propToValueMap[ChampionMastery.PropertyNames.ChampionLevel] is int)
        {
            championMastery.ChampionLevel = (int)propToValueMap[ChampionMastery.PropertyNames.ChampionLevel];
        }

        #endregion

        #region ChampionPoints Property

        if (propToValueMap[ChampionMastery.PropertyNames.ChampionPoints] is int)
        {
            championMastery.ChampionPoints = (int)propToValueMap[ChampionMastery.PropertyNames.ChampionPoints];
        }

        #endregion

        #region ChampionPointsSinceLastLevel Property

        if (propToValueMap[ChampionMastery.PropertyNames.ChampionPointsSinceLastLevel] is long)
        {
            championMastery.ChampionPointsSinceLastLevel = (long)propToValueMap[ChampionMastery.PropertyNames.ChampionPointsSinceLastLevel];
        }

        else if (propToValueMap[ChampionMastery.PropertyNames.ChampionPointsSinceLastLevel] is int)
        {
            championMastery.ChampionPointsSinceLastLevel = (int)propToValueMap[ChampionMastery.PropertyNames.ChampionPointsSinceLastLevel];
        }

        #endregion

        #region ChampionPointsUntilNextLevel Property

        if (propToValueMap[ChampionMastery.PropertyNames.ChampionPointsUntilNextLevel] is long)
        {
            championMastery.ChampionPointsUntilNextLevel = (long)propToValueMap[ChampionMastery.PropertyNames.ChampionPointsUntilNextLevel];
        }

        else if (propToValueMap[ChampionMastery.PropertyNames.ChampionPointsUntilNextLevel] is int)
        {
            championMastery.ChampionPointsUntilNextLevel = (int)propToValueMap[ChampionMastery.PropertyNames.ChampionPointsUntilNextLevel];
        }

        #endregion

        #region ChestGranted Property

        if (propToValueMap[ChampionMastery.PropertyNames.ChestGranted] is bool)
        {
            championMastery.ChestGranted = (bool)propToValueMap[ChampionMastery.PropertyNames.ChestGranted];
        }

        #endregion

        #region HighestGrade Property

        if (propToValueMap.ContainsKey(ChampionMastery.PropertyNames.HighestGrade) && propToValueMap[ChampionMastery.PropertyNames.HighestGrade] is string)
        {
            championMastery.HighestGrade = (string)propToValueMap[ChampionMastery.PropertyNames.HighestGrade];
        }

        #endregion

        #region LastPlayTime Property

        if (propToValueMap[ChampionMastery.PropertyNames.LastPlayTime] is long)
        {
            championMastery.LastPlayTime = (long)propToValueMap[ChampionMastery.PropertyNames.LastPlayTime];
        }

        else if (propToValueMap[ChampionMastery.PropertyNames.LastPlayTime] is int)
        {
            championMastery.LastPlayTime = (int)propToValueMap[ChampionMastery.PropertyNames.LastPlayTime];
        }

        #endregion

        #region PlayerId Property

        if (propToValueMap[ChampionMastery.PropertyNames.PlayerId] is long)
        {
            championMastery.PlayerId = (long)propToValueMap[ChampionMastery.PropertyNames.PlayerId];
        }

        else if (propToValueMap[ChampionMastery.PropertyNames.PlayerId] is int)
        {
            championMastery.PlayerId = (int)propToValueMap[ChampionMastery.PropertyNames.PlayerId];
        }

        #endregion
        
        return championMastery;
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="summoner"></param>
    /// <returns></returns>
    public static Dictionary<String, Object> ChampionMasteryToDictionary(ChampionMastery championMastery)
    {
        if (championMastery == null)
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
        if (typeof(ChampionMastery).Equals(t))
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

        return DictionaryToChampionMastery(value);
    }

    /// <summary>
    /// Converts a Summoner into a dictionary
    /// </summary>
    /// <param name="type">Optional - the type of the value parameter</param>
    /// <param name="value">Optional - the instance that is to be converted into a dictionary</param>
    /// <returns>A Dictionary containing the data contained in the value parameter</returns>
    public override Dictionary<String, Object> WriteJson(Type type, Object value)
    {
        ChampionMastery championMastery = (ChampionMastery)value;
        return ChampionMasteryToDictionary(championMastery);
    }

    #endregion

    #endregion
}