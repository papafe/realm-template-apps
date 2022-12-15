﻿using System;
using System.Threading;
using System.Threading.Tasks;
using CommunityToolkit.Maui.Alerts;
using CommunityToolkit.Maui.Core;
using CommunityToolkit.Maui.Views;
using RealmTodo.Views;

namespace RealmTodo.Services
{
    public static class DialogService
    {
        public static Task ShowAlertAsync(string title, string message, string accept)
        {
            return Application.Current.MainPage.DisplayAlert(title, message, accept);
        }

        public static Task<string> ShowPromptAsync(string title, string initialValue = "")
        {
            return Application.Current.MainPage.DisplayPromptAsync(title, "", initialValue: initialValue);
        }

        public static Action ShowActivityIndicator()
        {
            var popup = new BusyPopup();
            Application.Current.MainPage.ShowPopup(popup);
            return () => popup.Close();
        }

        public static Task ShowToast(string text)
        {
            var toast = Toast.Make(text, ToastDuration.Short);
            return toast.Show();
        }
    }
}

