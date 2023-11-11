using Practice.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Practice.Models;

public class User : NotificationService
{
    int id1;
    string? name1;
    string? username1;
    string? email1;
    Address? address1;
    string? website1;
    Company? company1;

    public int id { get => id1; set { id1 = value;OnPropertyChanged(); } }
    public string? name { get => name1; set { name1 = value; OnPropertyChanged(); } }
    public string? username { get => username1; set { username1 = value; OnPropertyChanged(); } }
    public string? email { get => email1; set { email1 = value;OnPropertyChanged(); } }
    public Address? address { get => address1; set { address1 = value; OnPropertyChanged(); } }
    public string? website { get => website1; set { website1 = value; OnPropertyChanged(); } }
    public Company? company { get => company1; set { company1 = value;OnPropertyChanged(); } }

    public User(int id , string ?name , string ? username, string  ? email , Address ? address , string ? website ,Company ? company)
    {
        this.id = id;
        this.name = name;
        this.username = username;
        this.email = email;
        this.address = address;
        this.website = website;
        this.company = company;
    }

    public User()
    {
        id = 0;
        name = "";
        username = "";
        email = "";
        address = new Address();
        website = "";
        company = new Company();
    }


    public override string ToString() => $"{name}-{username}";
}
