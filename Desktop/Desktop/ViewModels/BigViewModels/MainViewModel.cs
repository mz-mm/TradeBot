﻿using Desktop.Messages.NavigationMessages;
using Desktop.Services.Classes;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Messaging;

namespace Desktop.ViewModels.BigViewModels;

public class MainViewModel : ViewModelBase
{

    private ViewModelBase _currentView;
    private readonly IMessenger _messenger;
    public ViewModelBase CurrentView
    {
        get => _currentView;
        set => Set(ref _currentView, value);
    }

    public MainViewModel(IMessenger messenger)
    {
        _messenger = messenger;
        CurrentView = ServiceLocator.GetService<AuthViewModel>();

        _messenger.Register<NavigationMessage>(this, message => CurrentView = message.ViewModelType);
    }
}
