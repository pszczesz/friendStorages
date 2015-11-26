using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using FriendStories.DAL;
using FriendStories.Model;

namespace FriendStories.UI.DataProvider.Lookups {
    public class FriendLookupProvider :ILookupProvider<Friend> {
        private readonly Func<IDataServices> _dataServicesCreator;

        public FriendLookupProvider(Func<IDataServices> dataServicesCreator) {
            _dataServicesCreator = dataServicesCreator;
        }

        public IEnumerable<LookupItem> GetLookup() {
            using (var service = _dataServicesCreator()) {
                return service.GetAllFriends().Select(f => new LookupItem {
                    Id = f.Id,
                    DisplayValue = string.Format("{0} {1}", f.FirstName, f.LastName)
                }).OrderBy(l => l.DisplayValue).ToList();
            }
        }
    }
}