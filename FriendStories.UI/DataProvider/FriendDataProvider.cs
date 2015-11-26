using System;
using FriendStories.DAL;
using FriendStories.Model;

namespace FriendStories.UI.DataProvider {
    public class FriendDataProvider:IFriendDataProvider {
        private readonly Func<IDataServices> _dataServiceCreator;

        public FriendDataProvider(Func<IDataServices> dataServiceCreator) {
            _dataServiceCreator = dataServiceCreator;
        }
        public Friend GetFriendById(int id) {
            using (var dataService = _dataServiceCreator()) {
                return dataService.GetFriendById(id);
            }
        }

        public void SaveFriend(Friend friend) {
            using (var dataService = _dataServiceCreator())
            {
                dataService.SaveFriend(friend);
            }
        }

        public void DeleteFriend(int id) {
            using (var dataService = _dataServiceCreator())
            {
               dataService.DeleteFriend(id);
            }
        }
    }
}