using System;
using System.Windows;
using System.Windows.Interop;

namespace FunctionalTest.Helpers.OsdLogger
{
    /// <summary>
    /// Interaction logic for OsdDisplayWindow.xaml
    /// </summary>
    public partial class OsdDisplayWindow : Window, IDisplayMessageService
    {

        public OsdDisplayWindow()
        {
            InitializeComponent();

        }

        protected override void OnSourceInitialized(EventArgs e)
        {
            var handle = new WindowInteropHelper(this).Handle;
            int extendedStyle = User32.GetWindowLong(handle, User32.GWL_EXSTYLE);
            User32.SetWindowLong(handle, User32.GWL_EXSTYLE, extendedStyle | (int)WSEX.WS_EX_TRANSPARENT | (int)WSEX.WS_EX_TOOLWINDOW);
        }

        public void UpdateMessage(string message)
        {
            DebugText.Text = message;
        }
    }
}
