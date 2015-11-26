namespace FriendStories.UI.Services {
    public interface IMessageDialogService {
        MessageDialogResult ShowYesNoDialog(string title, string text,
            MessageDialogResult defaultResult = MessageDialogResult.Yes);
    }
}