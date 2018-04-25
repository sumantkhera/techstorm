// <copyright file="AutoMapperGenericsHelper.cs" company="FIS">
//     Copyright (c) FIS. All rights reserved.
// </copyright>
namespace Customer.BusinessLayer.Mapping
{

    using System.Collections.Generic;

    /// <summary>
    /// This is a wrapper class to handle the mapping between source and destination
    /// </summary>
    /// <typeparam name="TSource"></typeparam>
    /// <typeparam name="TDestination"></typeparam>
    public class AutoMapperHelper<TSource, TDestination>
    {
        /// <summary>
        /// Map a source entity into destination
        /// </summary>
        /// <param name="model">Source</param>
        /// <returns>Return destination type entity </returns>
        public static TDestination Map(TSource model)
        {
            return AutoMapper.Mapper.Map<TSource, TDestination>(model);
        }

        /// <summary>
        /// Map a collection of source entity into collection of destination
        /// </summary>
        /// <param name="model">collection of source entity</param>
        /// <returns>collection of destination entity</returns>
        public static List<TDestination> Map(List<TSource> model)
        {
            return AutoMapper.Mapper.Map<List<TSource>, List<TDestination>>(model);
        }
    }
}
