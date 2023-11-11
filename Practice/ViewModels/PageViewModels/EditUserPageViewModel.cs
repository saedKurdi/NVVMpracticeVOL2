using Practice.Commands;
using Practice.Models;
using Practice.Services;
using Practice.Views.Pages;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Practice.ViewModels.PageViewModels;
public class EditUserPageViewModel : NotificationService
{
    ObservableCollection<User> ? users;
    public ObservableCollection<User> ?Users { get => users; set { users = value;OnPropertyChanged(); } }



    ObservableCollection<User>? users_copy;
    public ObservableCollection<User>? UsersCopy { get => users_copy; set { users_copy = value;OnPropertyChanged(); } }



    User? user_from_main_page;
    public User ? UserFromMainPage { get => user_from_main_page; set { user_from_main_page = value;OnPropertyChanged(); } }


    User? this_user;
    public User? ThisUser { get => this_user; set { this_user = value;OnPropertyChanged(); } }


    public MainPageView? PreviousPage { get; set; }

    public EditUserPageView ? CurrentPage { get; set; }


    int index;

    public ICommand ? SaveCommand { get; set; }
    public ICommand ? CancelCommand { get; set;}

    public EditUserPageViewModel(ObservableCollection<User> ? users,int index,MainPageView ? previousPage,EditUserPageView ? currentPage)
    {
        this.index = index;
        UsersCopy = new ObservableCollection<User>() { };

        foreach (var user in users!)
        {
            UsersCopy.Add(user);
        }

        PreviousPage = previousPage;
        CurrentPage = currentPage;


        Users = users;
        UserFromMainPage = Users![index];

        ThisUser = new User(UserFromMainPage.id,UserFromMainPage.name,UserFromMainPage.username,UserFromMainPage.email,new Address(UserFromMainPage?.address?.street,UserFromMainPage?.address?.city),UserFromMainPage?.website,new Company(UserFromMainPage?.company?.name,UserFromMainPage?.company?.bs));
        SaveCommand = new RelayCommand(Save,CanSave);
        CancelCommand = new RelayCommand(Cancel,CanCancel);
    }


    #region SaveCommandFunctions

    public void Save(object ? param)
    {

        UserFromMainPage.id = ThisUser.id;
        UserFromMainPage.name = ThisUser.name;
        UserFromMainPage.username = ThisUser.username;
        UserFromMainPage.email = ThisUser.email;

        UserFromMainPage.company.name = ThisUser.company.name;
        UserFromMainPage.company.bs = ThisUser.company.bs;
        UserFromMainPage.address.city = UserFromMainPage.address.city;
        UserFromMainPage.address.street = UserFromMainPage.address.street;


        UsersCopy![index] = UserFromMainPage!;

        Users = null;
        Users = UsersCopy;

        for (int i = 0; i < Users?.Count; i++)
        {
            Users[i] = UsersCopy![i];
        }


       File.WriteAllText(@"..\..\..\..\Practice\DataBase\Users.json",JsonSerializer.Serialize(Users));  
        CurrentPage?.NavigationService.Navigate(PreviousPage);
    }

    public bool CanSave(object? param)
    => ThisUser.name != "" && ThisUser.username != "" && ThisUser.email != "" && ThisUser.website != "" && ThisUser.company.name != "" && ThisUser.company.bs != "" && ThisUser.address.city != "" && ThisUser.address.street != "";

    #endregion

    #region CancelCommandFunctions

    public void Cancel(object ? param) => CurrentPage?.NavigationService.Navigate(PreviousPage);

    public bool CanCancel(object? param) => true;

    #endregion
}
