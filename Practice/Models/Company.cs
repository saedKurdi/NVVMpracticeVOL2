using Practice.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.Models;
public class Company : NotificationService
{
    string? name1;
    string? bs1;

    public string? name { get => name1; set { name1 = value;OnPropertyChanged(); } }
    public string? bs { get => bs1; set { bs1 = value; OnPropertyChanged(); } }

    public Company(string?name,string ? bs )
    {
        this.name = name;
        this.bs = bs;
    }

    public Company()
    {
        name = "";
        bs = "";
    }

    public override string ToString()
    {
        return $"{name}";
    }
}
