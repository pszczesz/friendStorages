using System.ComponentModel;
using System.Runtime.CompilerServices;
using FriendStories.UI.Annotations;

namespace FriendStories.UI.ViewModel
{
    public class Observable :INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            var handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(propertyName));
            }
       }
    }
}