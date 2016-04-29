#region File Header

/*******************************************************************************
 * Author: Matthew "Riktor" Baker
 * Filename: SummonerConverter.cs
 * Date Created: 4/26/2016 10:42PM EST
 * 
 * Description: Converter for Summoner Data Class
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

public class SummonerConverter : JsonConverter
{
    #region Public Methods

    #region Converters

    /// <summary>
    /// 
    /// </summary>
    /// <param name="propToValueMap"></param>
    /// <returns></returns>
    public static Summoner DictionaryToSummoner(Dictionary<String, Object> propToValueMap)
    {
        foreach (KeyValuePair<String, Object> summonerObject in propToValueMap)
        {
            Summoner summoner = new Summoner();

            Dictionary<String, Object> summonerProperties = summonerObject.Value as Dictionary<String, Object>;

            #region ID Property

            if (summonerProperties[Summoner.PropertyNames.ID] is long)
            {
                summoner.ID = (long)summonerProperties[Summoner.PropertyNames.ID];
            }

            else if (summonerProperties[Summoner.PropertyNames.ID] is int)
            {
                summoner.ID = (int)summonerProperties[Summoner.PropertyNames.ID];
            }

            #endregion

            #region Name Property

            if (summonerProperties[Summoner.PropertyNames.Name] is string)
            {
                summoner.Name = (string)summonerProperties[Summoner.PropertyNames.Name];
            }

            #endregion

            #region ProfileIconId Property

            if (summonerProperties[Summoner.PropertyNames.ProfileIconID] is int)
            {
                summoner.ProfileIconID = (int)summonerProperties[Summoner.PropertyNames.ProfileIconID];
            }

            #endregion

            #region RevisionDate Property

            if (summonerProperties[Summoner.PropertyNames.RevisionDate] is long)
            {
                summoner.RevisionDate = (long)summonerProperties[Summoner.PropertyNames.RevisionDate];
            }

            else if (summonerProperties[Summoner.PropertyNames.RevisionDate] is int)
            {
                summoner.RevisionDate = (int)summonerProperties[Summoner.PropertyNames.RevisionDate];
            }

            #endregion

            #region SummonerLevel Property

            if (summonerProperties[Summoner.PropertyNames.SummonerLevel] is long)
            {
                summoner.SummonerLevel = (long)summonerProperties[Summoner.PropertyNames.SummonerLevel];
            }

            else if (summonerProperties[Summoner.PropertyNames.SummonerLevel] is int)
            {
                summoner.SummonerLevel = (int)summonerProperties[Summoner.PropertyNames.SummonerLevel];
            }

            #endregion

            return summoner;
        }

        return new Summoner();
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="summoner"></param>
    /// <returns></returns>
    public static Dictionary<String, Object> SummonerToDictionary(Summoner summoner)
    {
        if (summoner == null)
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
        if (typeof(Summoner).Equals(t))
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

        return DictionaryToSummoner(value);
    }

    /// <summary>
    /// Converts a Summoner into a dictionary
    /// </summary>
    /// <param name="type">Optional - the type of the value parameter</param>
    /// <param name="value">Optional - the instance that is to be converted into a dictionary</param>
    /// <returns>A Dictionary containing the data contained in the value parameter</returns>
    public override Dictionary<String, Object> WriteJson(Type type, Object value)
    {
        Summoner summoner = (Summoner)value;
        return SummonerToDictionary(summoner);
    }

    #endregion

    #endregion
}