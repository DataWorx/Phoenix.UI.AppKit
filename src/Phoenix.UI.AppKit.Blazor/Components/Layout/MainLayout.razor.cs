using Microsoft.AspNetCore.Components;
using MudBlazor;

namespace Phoenix.UI.AppKit.Blazor.Components.Layout
{
    public partial class MainLayout : LayoutComponentBase
    {
        #region Fields

        private bool drawerOpen = true; 
        
        #endregion

        private void DrawerToggle()
        {
            drawerOpen = !drawerOpen;
        }

        private string GetIcon() => drawerOpen ? Icons.Material.Rounded.MenuOpen : Icons.Material.Rounded.Menu;
    }
}
