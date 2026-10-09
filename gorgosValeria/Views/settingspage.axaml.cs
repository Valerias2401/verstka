
using Avalonia;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Styling;

namespace gorgosValeria;

public partial class settingspage : UserControl
{
    public settingspage()
    {
        InitializeComponent();

        ThemeSwitch.IsChecked =
            Application.Current?.RequestedThemeVariant == ThemeVariant.Dark;

        UpdateThemeLabel();
    }

    private void ThemeSwitch_Checked(object? sender, RoutedEventArgs e)
    {
        ChangeTheme(ThemeVariant.Dark);
    }

    private void ThemeSwitch_Unchecked(object? sender, RoutedEventArgs e)
    {
        ChangeTheme(ThemeVariant.Light);
    }

    private void ChangeTheme(ThemeVariant theme)
    {
        if (Application.Current == null)
            return;

        Application.Current.RequestedThemeVariant = theme;
        UpdateThemeLabel();
    }

    private void UpdateThemeLabel()
    {
        ThemeLabel.Text = ThemeSwitch.IsChecked == true
            ? "Тёмная"
            : "Светлая";
    }
}
