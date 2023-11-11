using Practice.Models;
using Practice.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.ViewModels.WindowViewModels;
public class ShowAllViewModel : NotificationService
{
    ObservableCollection<User>? users;
    public ObservableCollection<User> ?Users { get => users; set { users = value; OnPropertyChanged(); } }

    public ShowAllViewModel(ObservableCollection<User> ? users)
    {
        Users = users;
    }
}
