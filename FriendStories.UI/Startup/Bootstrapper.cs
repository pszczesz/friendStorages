using Autofac;
using Microsoft.Practices.Prism.PubSubEvents;

namespace FriendStories.UI.Startup {
    public class Bootstrapper {
        public IContainer Bootstrap() {
            var builder = new ContainerBuilder();

            builder.RegisterType<EventAggregator>().As<IEventAggregator>().SingleInstance();
       /*     builder.RegisterType<MessageDialogService>().As<IMessageDialogService>();

            builder.RegisterType<FileDataService>().As<IDataService>();
            builder.RegisterType<FriendLookupProvider>().As<ILookupProvider<Friend>>();
            builder.RegisterType<FriendGroupLookupProvider>().As<ILookupProvider<FriendGroup>>();
            builder.RegisterType<FriendDataProvider>().As<IFriendDataProvider>();

            builder.RegisterType<FriendEditViewModel>().As<IFriendEditViewModel>();
            builder.RegisterType<NavigationViewModel>().As<INavigationViewModel>();
            builder.RegisterType<MainViewModel>().AsSelf();*/

            return builder.Build();

        }
    }
}