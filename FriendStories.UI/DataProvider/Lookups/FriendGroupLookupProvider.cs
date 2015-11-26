using System;
using System.Collections.Generic;
using System.Linq;
using FriendStories.DAL;
using FriendStories.Model;

namespace FriendStories.UI.DataProvider.Lookups {
    public class FriendGroupLookupProvider : ILookupProvider<FriendGroup> {
        private readonly Func<IDataServices> _dataServiceCreator;

        public FriendGroupLookupProvider(Func<IDataServices> dataServicecreator) {
            _dataServiceCreator = dataServicecreator;
        }

        public IEnumerable<LookupItem> GetLookup() {
            using (var service = _dataServiceCreator()) {
                return service.GetAllFriendGroup().Select(f => new LookupItem {
                    Id = f.Id,
                    DisplayValue = f.Name
                }).OrderBy(l => l.DisplayValue).ToList();
            }
        }
    }
}