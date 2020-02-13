using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoMessageAppUiLib
{
    public enum ChatListItemState
    {
        /// <summary>
        /// Unknowing State of ChatListItem.
        /// </summary>
        Unknown = 0,

        /// <summary>
        /// The Normal State of ChatListItem.
        /// </summary>
        Normal,

        /// <summary>
        /// Active State of ChatListItem.
        /// </summary>
        Active,

        /// <summary>
        /// Focusing on ChatListItem by Pointer or something else.
        /// </summary>
        Focused,

        /// <summary>
        /// Inactive State of ChatListItem(Do nothing).
        /// </summary>
        Inactive,

        /// <summary>
        /// Get banned ChatListItem by User or Admin.
        /// </summary>
        Banned
    }
}
