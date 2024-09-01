using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using Plugin.MediaManager;
using MediaManager;
using Microsoft.Maui.Controls.PlatformConfiguration;


using Microsoft.Maui.Controls;


namespace Important_Calls.Models
{


    //public class Contact1
    //{
    //    //// [JsonProperty("id")]
    //    // public int Id { get; set; }

    //    //// [JsonProperty("name")]
    //    // public string Name { get; set; }

    //    //// [JsonProperty("phone")]
    //    // public string Phone { get; set; }

    //    //// [JsonProperty("alert")]
    //    // public bool Alert { get; set; }

    //    // [JsonProperty("alert")]
    //    public bool Alert { get; set; }

    //    // [JsonProperty("id")]
    //    public int Id { get; set; }

    //    private bool isSelected;
    //    public string Name { get; set; }
    //    public string Phone { get; set; }

    //    public bool IsSelected
    //    {
    //        get => isSelected;
    //        set
    //        {
    //            if (isSelected != value)
    //            {
    //                isSelected = value;
    //                OnPropertyChanged(nameof(IsSelected));
    //            }
    //        }
    //    }

    //    public event PropertyChangedEventHandler PropertyChanged;
    //    protected virtual void OnPropertyChanged(string propertyName) =>
    //        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

    //}





    //public class Contact1 : INotifyPropertyChanged
    //{
    //    // [JsonProperty("alert")]
    //    public bool Alert { get; set; }

    //    // [JsonProperty("id")]
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //    public string Phone { get; set; }
    //    public event PropertyChangedEventHandler PropertyChanged;

    //    protected virtual void OnPropertyChanged(string propertyName)
    //    {
    //        var handler = PropertyChanged;
    //        if (handler != null)
    //        {
    //            handler(this, new PropertyChangedEventArgs(propertyName));
    //        }
    //    }
    //}




    public class Contact1 : INotifyPropertyChanged
{
    private bool _alert;
    
    public int Id { get; set; }
    public string Name { get; set; }
    public string Phone { get; set; }

    public bool Alert
    {
        get => _alert;
        set
        {
            if (_alert != value)
            {
                _alert = value;
                OnPropertyChanged(nameof(Alert));
                OnAlertChanged(); // Вызываем метод при изменении Alert
            }
        }
    }

    public event PropertyChangedEventHandler PropertyChanged;

    protected virtual void OnPropertyChanged(string propertyName)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }

    private void OnAlertChanged()
    {
        // Логика включения/выключения звука звонка
        if (_alert)
        {
            EnableRingtone();
        }
        else
        {
            DisableRingtone();
        }
    }

    private void EnableRingtone()
    {
        // Добавьте код для включения звука звонка
        Console.WriteLine($"Ringtone enabled for contact {Name}");
    }

    private void DisableRingtone()
    {
        // Добавьте код для выключения звука звонка
        Console.WriteLine($"Ringtone disabled for contact {Name}");
    }
    }





}