using Important_Calls.Models;
//using ImportantCall.Services;
using Microsoft.Maui.ApplicationModel;
using Microsoft.Maui.Controls;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Plugin.ContactService;
using Plugin.ContactService.Shared;
using System.Reflection.Metadata;
using System.Collections.ObjectModel;
using System.Xml.Linq;
using Microsoft.Maui.HotReload;
using System;
using MediaManager;


//namespace Important_Calls
//{

//    public partial class MainPage : ContentPage
//    {
//        //private readonly ApiService _apiService;
//        public List<Contact1> LocalContacts { get; set; } = new List<Contact1>();

//        public MainPage()
//        {
//            InitializeComponent();
//            //_apiService = new ApiService();
//            LoadContactsBridge();
//        }

//        private async void LoadContactsBridge()
//        {
//            await LoadLocalContacts();
//        }

//        private async Task LoadLocalContacts()
//        {

//            // Запрашиваем разрешение на доступ к контактам
//            var status = await Permissions.RequestAsync<Permissions.ContactsRead>();
//            if (status == PermissionStatus.Granted)
//            {
//                var contacts = await CrossContactService.Current.GetContactListAsync();

//                // Преобразуем контакты в наш формат и добавляем их в список
//                LocalContacts.Clear();
//                foreach (var contact in contacts)
//                {
//                    LocalContacts.Add(new Contact1
//                    {
//                        Name = contact.Name,
//                        Phone = contact.Number // Берем первый номер
//                    });
//                }

//                // Обновляем ListView с локальными контактами
//                ContactsListView.ItemsSource = LocalContacts;
//            }
//            else
//            {
//                await DisplayAlert("Ошибка", "Не удалось получить доступ к контактам", "ОК");
//            }
//        }

//        private async void OnAddContactClicked(object sender, EventArgs e)
//        {
//            //var newContact = new Contact1 { Name = "Новый контакт", Phone = "123456789", Alert = true };
//            //string newContact = "{\"name\":\"" + "Name" + "\"," +
//            //"\"phone\":\"" + "88005555535" + "\"," +
//            //"\"alert\":\"" + "true"+ "\"}";
//            var newContact = new Contact1 { Name = "Новый контакт", Phone = "123456789", Alert = true };
//            //await _apiService.CreateContactAsync(newContact);
//            //Contact1 response=await GetApiResponseAsync("http://109.111.82.162:8080/addContact",newContact);
//            //LoadContacts();
//        }

//        private async void OnContactSelected(object sender, SelectedItemChangedEventArgs e)
//        {
//            if (e.SelectedItem is Contact1 contact)
//            {
//                // Здесь можно реализовать логику редактирования или удаления контакта
//                ContactsListView.SelectedItem = null; // Сбросить выделение              
//            }
//        }
//    }
//}


//namespace Important_Calls
//{
//    public partial class MainPage : ContentPage
//    {
//        //private readonly ApiService _apiService;
//        //private ObservableCollection<Contact1> _localContacts = new ObservableCollection<Contact1>();

//        public List<Contact1> LocalContacts { get; set; } = new List<Contact1>();


//        public MainPage()
//        {
//            InitializeComponent();
//            //_apiService = new ApiService();
//            LoadContactsBridge();
//        }

//        private async void LoadContactsBridge()
//        {
//            await LoadLocalContacts();
//        }

//        private async void LoadContacts()
//        {
//            try
//            {
//                //var apiContacts = await _apiService.GetContactsAsync();
//                // Дополнительная логика обработки api контактов

//                await LoadLocalContacts();
//            }
//            catch (Exception ex)
//            {
//                await DisplayAlert("Ошибка", ex.Message, "ОК");
//            }
//        }

//        private async Task LoadLocalContacts()
//        {
//            try
//            {
//                int k = 0;
//                var status = await Permissions.RequestAsync<Permissions.ContactsRead>();
//                if (status == PermissionStatus.Granted)
//                {
//                    var contacts = await CrossContactService.Current.GetContactListAsync();
//                    LocalContacts.Clear();
//                    foreach (var contact in contacts)
//                    {
//                        LocalContacts.Add(new Contact1
//                        {
//                            Id = k,
//                            Name = contact.Name,
//                            Phone = contact.Number,
//                            Alert = false
//                        });
//                        k++;
//                    }

//                    ContactsListView.ItemsSource = LocalContacts;
//                }
//                else
//                {
//                    await DisplayAlert("Ошибка", "Не удалось получить доступ к контактам", "ОК");
//                }
//            }
//            catch (Exception ex)
//            {
//                await DisplayAlert("Ошибка", ex.Message, "ОК");
//            }
//        }

//        private async void OnAddContactClicked(object sender, EventArgs e)
//        {
//            try
//            {
//                var newContact = new Contact1 { Name = "Новый контакт", Phone = "123456789", Alert = true };
//                //await _apiService.CreateContactAsync(newContact);
//                LoadContacts();
//            }
//            catch (Exception ex)
//            {
//                await DisplayAlert("Ошибка", ex.Message, "ОК");
//            }
//        }

//        private async void OnContactSelected(object sender, SelectedItemChangedEventArgs e)
//        {
//            if (e.SelectedItem is Contact1 contact)
//            {
//                // Логика при выборе контакта
//                ContactsListView.SelectedItem = null;
//            }
//        }

//        private void OnAlertToggled(object sender, SelectedItemChangedEventArgs e)
//        {
//            //if (sender is CheckBox switchControl && switchControl.BindingContext is Contact1 toggledContact)
//            //{
//            //    //(sender as CheckBox).IsChecked = true;
//            //    MoveContactToTop(toggledContact);
//            //    //(sender as CheckBox).IsChecked = true; 

//            //}
//            if (e.SelectedItem is Contact1 contact)
//            {
//                // Логика при выборе контакта
//                MoveContactToTop(contact);
//            }
//        }

//        private void MoveContactToTop(Contact1 contact)
//        {


//            LocalContacts.RemoveAt(contact.Id);
//            LocalContacts.Insert(0, contact);

//            foreach (var con in LocalContacts)
//            {
//                con.Id = LocalContacts.IndexOf(con);

//            }

//            //ContactsListView.ItemsSource = null;
//            ContactsListView.ItemsSource = new List<Contact1>(LocalContacts);
//        }



//        private void OnAlertToggled52(object sender, CheckedChangedEventArgs e)
//        {

//            var checkBox = (CheckBox)sender;
//            var contact = (Contact1)checkBox.BindingContext; // Получаем контекст, связанный с чекбоксом
//            contact.Alert = true;
//            if (checkBox.IsChecked)
//            {
//                // Устанавливаем цвет фона для выбранного контакта
//                var viewCell = (ViewCell)ContactsListView.TemplatedItems.FirstOrDefault(item => item.BindingContext == contact);

//                if (viewCell != null)
//                {
//                    var stackLayout = (StackLayout)viewCell.View;
//                    stackLayout.BackgroundColor = Colors.Cyan; // Можете использовать другой цвет
//                }
//            }
//            else
//            {
//                // Возвращаем цвет фона для невыбранного контакта
//                var viewCell = (ViewCell)ContactsListView.TemplatedItems.FirstOrDefault(item => item.BindingContext == contact);

//                if (viewCell != null)
//                {
//                    var stackLayout = (StackLayout)viewCell.View;
//                    stackLayout.BackgroundColor = Colors.Transparent; // Вернем к прозрачному цвету
//                }
//            }


//        }
//    }



public interface IPhoneCallService
{
    void StartListening();
    void StopListening();
}




namespace Important_Calls
{
    

    public partial class MainPage : ContentPage
    {
        private readonly IPhoneCallService _phoneCallService;
        public List<Contact1> LocalContacts { get; set; } = new List<Contact1>();
        
        public MainPage()
        {
           
            CrossMediaManager.Current.Init();
            InitializeComponent();
            LoadContactsBridge();
            _phoneCallService = DependencyService.Get<IPhoneCallService>();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            _phoneCallService.StartListening();
        }

        protected override void OnDisappearing()
        {
            base.OnDisappearing();
            _phoneCallService.StopListening();
        }

        private async void LoadContactsBridge()
        {
            await LoadLocalContacts();
        }

        private async Task LoadLocalContacts()
        {
            try
            {
                int k = 0;
                var status = await Permissions.RequestAsync<Permissions.ContactsRead>();
                if (status == PermissionStatus.Granted)
                {
                    var contacts = await CrossContactService.Current.GetContactListAsync();
                    LocalContacts.Clear();
                    foreach (var contact in contacts)
                    {
                        LocalContacts.Add(new Contact1
                        {
                            Id = k,
                            Name = contact.Name,
                            Phone = contact.Number,
                            Alert = false
                        });
                        k++;
                    }

                    ContactsListView.ItemsSource = LocalContacts;
                }
                else
                {
                    await DisplayAlert("Ошибка", "Не удалось получить доступ к контактам", "ОК");
                }
            }
            catch (Exception ex)
            {
                await DisplayAlert("Ошибка", ex.Message, "ОК");
            }
        }

        private async void OnAddContactClicked(object sender, EventArgs e)
        {
            try
            {
                var newContact = new Contact1 { Name = "Новый контакт", Phone = "123456789", Alert = true };
                //await _apiService.CreateContactAsync(newContact);
                //LoadContacts();
            }
            catch (Exception ex)
            {
                await DisplayAlert("Ошибка", ex.Message, "ОК");
            }
        }

        private async void OnContactSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem is Contact1 contact)
            {
                ContactsListView.SelectedItem = null;
            }
        }

        private void MoveContactToTop(Contact1 contact)
        {
            LocalContacts.Remove(contact);
            LocalContacts.Insert(0, contact);

            foreach (var con in LocalContacts)
            {
                con.Id = LocalContacts.IndexOf(con);
            }

            ContactsListView.ItemsSource = new List<Contact1>(LocalContacts);
        }

        private async void OnAlertToggled(object sender, CheckedChangedEventArgs e)
        {
            var checkBox = (CheckBox)sender;
            var contact = (Contact1)checkBox.BindingContext;
            contact.Alert = checkBox.IsChecked;
            await CrossMediaManager.Current.Play("https://ia800806.us.archive.org/15/items/Mp3Playlist_555/AaronNeville-CrazyLove.mp3");
            //await CrossMediaManager.Current.Play("http://clips.vorwaerts-gmbh.de/big_buck_bunny.mp3");
        }
    }
}