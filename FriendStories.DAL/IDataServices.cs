using System;
using System.Collections;
using System.Collections.Generic;
using FriendStories.Model;

namespace FriendStories.DAL {
    public interface IDataServices : IDisposable {
        Friend GetFriendById(int friendId);
        void SaveFriend(Friend friend);
        void DeleteFriend(int friendId);
        IEnumerable<Friend> GetAllFriends();
        IEnumerable<FriendGroup> GetAllFriendGroup();
    }
}