using System;
using Microsoft.Maui.Controls.PlatformConfiguration.iOSSpecific;

namespace FormSheetSample
{
    public class ModalNavigationPage : Microsoft.Maui.Controls.NavigationPage
    {
        public ModalNavigationPage() : base()
        {
            // indicate that this is a FormSheet modal (small centered modal page)
            On<Microsoft.Maui.Controls.PlatformConfiguration.iOS>().SetModalPresentationStyle(UIModalPresentationStyle.FormSheet);
        }

        public ModalNavigationPage(Microsoft.Maui.Controls.Page page) : base(page)
        {
            // indicate that this is a FormSheet modal (small centered modal page)
            On<Microsoft.Maui.Controls.PlatformConfiguration.iOS>().SetModalPresentationStyle(UIModalPresentationStyle.FormSheet);
        }
    }
}

