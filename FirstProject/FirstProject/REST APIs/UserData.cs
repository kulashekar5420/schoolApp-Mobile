﻿using SQLite;
using System;
using System.Windows.Input;
using Xamarin.Forms;

public class UserData
{
    [PrimaryKey, AutoIncrement]
    public int id { get; set; }
    public string email { get; set; }
    public string first_name { get; set; }
    public string last_name { get; set; }
    public string avatar { get; set; }

}

