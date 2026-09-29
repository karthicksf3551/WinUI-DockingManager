using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Controls.Primitives;
using Microsoft.UI.Xaml.Data;
using Microsoft.UI.Xaml.Input;
using Microsoft.UI.Xaml.Media;
using Microsoft.UI.Xaml.Navigation;
using Syncfusion.UI.Xaml.Docking;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace SfDockingManager_Demo
{
    /// <summary>
    /// An empty window that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            // AddItems();
            
        }

        private void AddItems()
        {
            DockPane pane1 = new DockPane()
            { Header = "Item1",DockState=DockState.AutoHidden };
            DockPane pane2 = new DockPane()
            { Header = "Item2", DockState = DockState.Document };
            DockPane pane3 = new DockPane()
            { Header = "Item3", DockState = DockState.Floating };

            this.dockingmanager.AddPane(pane1, Dock.Left);
            this.dockingmanager.AddPane(pane2, Dock.Left);
            this.dockingmanager.AddPane(pane3, Dock.Left);
        }
    }
}
