using System.Collections;
using System.Collections.Generic;

namespace FriendStories.UI.DataProvider.Lookups {
    public interface ILookupProvider {
        IEnumerable<LookupItem> GetLookup();
    }
}