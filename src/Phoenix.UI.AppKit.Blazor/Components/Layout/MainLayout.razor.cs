using Microsoft.AspNetCore.Components;

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
    }
}
