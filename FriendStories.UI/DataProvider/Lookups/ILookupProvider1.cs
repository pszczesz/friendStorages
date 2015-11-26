using System.Collections;
using System.Collections.Generic;

namespace FriendStories.UI.DataProvider.Lookups
{
    public interface ILookupProvider<T> {
        IEnumerable<LookupItem> GetLookup();
    }
}