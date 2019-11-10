using Inbox.Models;
using System.Collections.Generic;
using System.ComponentModel;

namespace Inbox.ViewModels
{
    public class MainViewModel : INotifyPropertyChanged
    {
        public List<Conversation> Messages { get; set; } = Conversations.All;

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
