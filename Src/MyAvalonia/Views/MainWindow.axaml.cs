using Avalonia.Controls;

namespace MyAvalonia.Views;

public partial class MainWindow : Window
{
   public MainWindow()
   {
      InitializeComponent();
#if WINDOWS
      Title = "MyAvalonia for Windows";
#elif MACOS
        Title = "MyAvalonia for macOS";
#else
        Title = "MyAvalonia for Linux";
#endif
   }
}