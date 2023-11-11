using Practice.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.Models;
public class Address : NotificationService
{
    string? street1;
    string? city1;


    public string? street { get => street1; set { street1 = value;OnPropertyChanged(); } }
        
   public string ? city { get => city1; set { city1 = value;OnPropertyChanged(); } }


    public Address(string ? street,string ? city)
    {
        this.street = street;
        this.city = city;
    }


    public Address()
    {
        street = "";
        city = "";
    }


    public override string ToString()
    {
        return $"{city}/{street}";
    }

}
