#region File Header

/*******************************************************************************
 * Author: Matthew "Riktor" Baker
 * Filename: ChampionMastery.cs
 * Date Created: 4/26/2015 10:42PM EST
 * 
 * Description: ChampionMastery Data Class
 * 
 * Changelog:   - N/A
 *******************************************************************************/

#endregion

#region Using Directives

using System;
using System.Collections.Generic;

#endregion

#region ChampData Public Enumerator

public enum ChampionMasteryListData
{
    masteries,
};

#endregion

public class ChampionMasteryList
{
    #region Constant Property Names

    public static class PropertyNames
    {
        public static readonly String Masteries = "masteries";
    }

    #endregion

    #region Private Member Variables

    /// <summary>
    /// List of ChampionMastery objects
    /// </summary>
    private Object [] masteries;

    #endregion

    #region Accessors/Modifiers

    /// <summary>
    /// List of ChampionMastery objects
    /// </summary>
    public Object[] Masteries
    {
        get
        {
            return masteries;
        }
        set
        {
            masteries = value;
        }
    }

    #endregion


}

