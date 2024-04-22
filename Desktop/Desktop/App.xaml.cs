﻿using Desktop.Services.Classes;
using Desktop.Services.Interfaces;
using Desktop.ViewModels;
using Desktop.Views;
using GalaSoft.MvvmLight.Messaging;
using System.ComponentModel;
using SimpleInjector;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using Desktop.Services.Network.API;

namespace Desktop
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {

        public static SimpleInjector.Container Container { get; set; } = new SimpleInjector.Container();

        public void Register()
        {

            Container.RegisterSingleton<IMessenger, Messenger>();
            Container.RegisterSingleton<INavigationServices, NavigationService>();
            Container.RegisterSingleton<IAuthenticationService, AuthenticationService>();
            Container.RegisterSingleton<IRegistrationService, RegistrationService>();
            Container.RegisterSingleton<ITradeClient, TradeClient>();
            Container.RegisterSingleton<IHistoryService, HistoryService>();
            Container.RegisterSingleton<IWalletService, WalletService>();
            Container.RegisterSingleton<IMarketService, MarketService>();
            Container.RegisterSingleton<ITradeService, TradeService>();

            Container.RegisterSingleton<MainViewModel>();
            Container.RegisterSingleton<DashboardViewModel>();
            Container.RegisterSingleton<HistoryViewModel>();
            Container.RegisterSingleton<TradeViewModel>();
            Container.RegisterSingleton<WalletViewModel>();
            Container.RegisterSingleton<AuthViewModel>();
            Container.RegisterSingleton<RegistrationViewModel>();
            Container.RegisterSingleton<BaseViewModel>();
            Container.RegisterSingleton<RecoveryViewModel>();
            Container.RegisterSingleton<WalletListContentViewModel>();
            Container.RegisterSingleton<WalletDepositContentViewModel>();
            Container.RegisterSingleton<WalletWidthdrawContentViewModel>();


            Container.Verify();
        }

        protected override void OnStartup(StartupEventArgs e)
        {
            Register();

            var window = new MainView();

            window.DataContext = Container.GetInstance<MainViewModel>();

            window.ShowDialog();
        }
    }
}
