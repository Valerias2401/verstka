using Avalonia.Controls;
using Avalonia.Interactivity;
using System;

namespace gorgosValeria;

public partial class avtoriz : UserControl
{
    public event EventHandler? LoginSuccess;

    public avtoriz()
    {
        InitializeComponent();
    }

    private void Login_Click(object? sender, RoutedEventArgs e)
    {
        LoginSuccess?.Invoke(this, EventArgs.Empty);
    }
}
