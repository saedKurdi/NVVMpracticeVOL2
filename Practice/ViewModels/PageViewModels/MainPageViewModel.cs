using MaterialDesignThemes.Wpf;
using Practice.Commands;
using Practice.Models;
using Practice.Services;
using Practice.ViewModels.WindowViewModels;
using Practice.Views.Pages;
using Practice.Views.Windows;
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
using System.Windows.Media.Media3D;

namespace Practice.ViewModels.PageViewModels;
public class MainPageViewModel : NotificationService
{
    private ObservableCollection<User>? users;

    public ObservableCollection<User>? Users { get => users; set { users = value;OnPropertyChanged(); } }

    public ICommand  ? AddCommand { get; set; }
    public ICommand ? RemoveCommand { get; set;}
    public ICommand ? EditCommand { get; set; }
    public ICommand? ShowAllCommand { get; set; }

    public MainPageView ? CurrentPage { get; set; }
    public AddUserPageView ? NextPage { get; set; }
    public EditUserPageView ? NextPage_ {  get; set; }  
    public User ? User { get; set; }

    public MainPageViewModel(MainPageView ? mainPageView)
    {
        CurrentPage = mainPageView;
        Users = JsonSerializer.Deserialize<ObservableCollection<User>>(File.ReadAllText(@"..\..\..\..\Practice\DataBase\Users.json"));
        AddCommand = new RelayCommand(Add,CanAdd);
        RemoveCommand = new RelayCommand(Remove,CanRemove);
        ShowAllCommand = new RelayCommand(ShowAll,CanShowAll);  
        EditCommand = new RelayCommand(Edit,CanEdit);   
    }

    #region AddCommandFunctions


    public void Add(object ? param)
    {
        NextPage = new AddUserPageView();
        NextPage.DataContext = new AddUserPageViewModel(Users,CurrentPage, NextPage);
        CurrentPage?.NavigationService.Navigate(NextPage);
    }

    public bool CanAdd(object? param) => true;

    #endregion

    #region RemoveCommandFunctions

    public void Remove(object ? param)
    {
        int index = Convert.ToInt32(param);
        Users?.RemoveAt(index);
        File.WriteAllText(@"..\..\..\..\Practice\DataBase\Users.json", JsonSerializer.Serialize(Users));
    }

    public bool CanRemove(object? param)
    {
        int index = Convert.ToInt32(param);
        if (index != -1) return true;
        return false;
    }

    #endregion

    #region GetAllComandFunctions

    public void ShowAll(object ? param)
    {
        var showAllView = new ShowAllView();
        showAllView.DataContext = new ShowAllViewModel(Users);
        showAllView.ShowDialog();
    }

    public bool CanShowAll(object? param) => Users?.Count > 0;

    #endregion

    #region EditCommanFunctions

    public void Edit(object ? param)
    {
        int index = Convert.ToInt32(param); 
        NextPage_ = new EditUserPageView();
        NextPage_.DataContext = new EditUserPageViewModel(Users, index, CurrentPage, NextPage_);
        CurrentPage?.NavigationService.Navigate(NextPage_);
    }

    public bool CanEdit(object? param)
    {
        int ? index = Convert.ToInt32(param);
        if(index != -1 && index != null) return true;
        return false;
    }

    #endregion
}
