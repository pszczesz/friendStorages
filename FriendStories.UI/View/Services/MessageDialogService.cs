using System.Windows;
using FriendStories.UI.Services;

namespace FriendStories.UI.View.Services
{
    public class MessageDialogService :IMessageDialogService
    {
        public MessageDialogResult ShowYesNoDialog(string title, string text,
            MessageDialogResult defaultResult = MessageDialogResult.Yes)
        {
            var dlg = new MessageDialog(title,text,defaultResult,MessageDialogResult.Yes,MessageDialogResult.No);
            dlg.Owner = Application.Current.MainWindow;
            return dlg.ShowDialog();
        }
    }
}