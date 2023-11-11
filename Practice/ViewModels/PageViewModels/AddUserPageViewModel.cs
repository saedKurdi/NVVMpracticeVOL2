using Practice.Commands;
using Practice.Models;
using Practice.Services;
using Practice.Views.Pages;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Configuration;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media.Animation;

namespace Practice.ViewModels.PageViewModels;

public class AddUserPageViewModel : NotificationService
{
    User? user;
    public User ? User { get=>user; set { user = value;OnPropertyChanged(); } }


    ObservableCollection<User> ? users;

    public ObservableCollection<User>? Users { get => users; set { users = value;OnPropertyChanged(); } }




    public MainPageView ? PreviousPage { get; set; }
    public AddUserPageView ? CurrentPage { get; set; }

    public ICommand ? SaveCommand { get; set; }
    public ICommand ? BackCommand { get; set; }



    public AddUserPageViewModel(ObservableCollection<User> ? users,MainPageView ? previousPage,AddUserPageView ? currentPage)
    {
        Users = users;
        PreviousPage = previousPage;
        CurrentPage = currentPage;

        User = new User();
        SaveCommand = new RelayCommand(Save, CanSave);
        BackCommand = new RelayCommand(Back, CanBack);
        
        
    }


    #region SaveCommandFunctions

    public void Save(object? param)
    {
        User!.id = Users!.Count + 1;
        Users?.Add(User!);
        File.WriteAllText(@"..\..\..\..\Practice\DataBase\Users.json",JsonSerializer.Serialize(Users));
        User = new User();
    }

    public bool CanSave(object? param)=>
     User?.name != "" && User?.username != "" && User?.company?.name != "" && User?.company?.bs != "" && User?.website != "" && User?.address?.city != "" && User?.address?.street != "" && User?.email != "";

    #endregion

    #region BackCommandFunctions

    public void Back(object ? param) => CurrentPage?.NavigationService.Navigate(PreviousPage);

    public bool CanBack(object ? param) => true;

    #endregion
}
