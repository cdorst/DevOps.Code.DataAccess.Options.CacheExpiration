// Copyright © Christopher Dorst. All rights reserved.
// Licensed under the GNU General Public License, Version 3.0. See the LICENSE document in the repository root for license information.

namespace DevOps.Code.DataAccess.Options.CacheExpiration
{
    /// <summary>Contains properties indicating how long objects should be held in cache</summary>
    public class CacheSlidingExpiration
    {
        /// <summary>Indicates how many days to cache entities</summary>
        public int? Days { get; set; }

        /// <summary>Indicates how many hours to cache entities</summary>
        public int? Hours { get; set; }

        /// <summary>Indicates how many minutes to cache entities</summary>
        public int? Minutes { get; set; }

        /// <summary>Indicates how many seconds to cache entities</summary>
        public int? Seconds { get; set; }
    }
}
