using Avalonia.Controls;
using Avalonia.Interactivity;
using System;

namespace gorgosValeria;

public partial class MainWindow : Window
{
    private readonly Button[] menuButtons;

    public MainWindow()
    {
        InitializeComponent();

        menuButtons = new Button[]
        {
            BtnOverview,
            BtnProjects,
            BtnTasks,
            BtnCalendar,
            BtnTeam,
            BtnSettings,
            BtnProfile
        };

        ShowLogin();
    }

    private void ShowLogin()
    {
        Sidebar.IsVisible = false;

        avtoriz loginPage = new avtoriz();
        loginPage.LoginSuccess += Login_Success;

        MainContent.Content = loginPage;
    }

    private void Login_Success(object? sender, EventArgs e)
    {
        Sidebar.IsVisible = true;
        OpenPage(BtnOverview);
    }

    private void Menu_Click(object? sender, RoutedEventArgs e)
    {
        if (sender is Button button)
        {
            OpenPage(button);
        }
    }

    private void Logout_Click(object? sender, RoutedEventArgs e)
    {
        ShowLogin();
    }

    private void OpenPage(Button button)
    {
        foreach (Button menuButton in menuButtons)
        {
            menuButton.Classes.Remove("active");
        }

        button.Classes.Add("active");

        switch (button.Content?.ToString())
        {
            case "Обзор":
                MainContent.Content = new glavnPage();
                break;

            case "Проекты":
                MainContent.Content = new proect();
                break;

            case "Задачи":
                MainContent.Content = new zadachipage();
                break;

            case "Календарь":
                MainContent.Content = new kalendarpage();
                break;

            case "Команда":
                MainContent.Content = new komandapage();
                break;

            case "Настройки":
                MainContent.Content = new settingspage();
                break;

            case "Мой профиль":
                MainContent.Content = new profilepage();
                break;
        }
    }
}
