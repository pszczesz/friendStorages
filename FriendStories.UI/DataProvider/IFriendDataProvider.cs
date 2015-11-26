using FriendStories.Model;

namespace FriendStories.UI.DataProvider {
    public interface IFriendDataProvider {
        Friend GetFriendById(int id);
        void SaveFriend(Friend friend);
        void DeleteFriend(int id);
    }
}