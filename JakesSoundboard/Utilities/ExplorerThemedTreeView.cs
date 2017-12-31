namespace LucasStuff
{
    public class ExplorerThemedTreeView : System.Windows.Forms.TreeView
    {
        [System.ComponentModel.DefaultValue(false)]
        public new bool HideSelection
        {
            get
            {
                return base.HideSelection;
            }
            set
            {
                base.HideSelection = value;
            }
        }
        
        [System.ComponentModel.Browsable(false)]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        [System.ComponentModel.Bindable(false)]
        [System.ComponentModel.DesignerSerializationVisibility(System.ComponentModel.DesignerSerializationVisibility.Hidden)]
        public new bool HotTracking
        {
            get
            {
                return base.HotTracking;
            }
            set
            {
                throw new System.NotSupportedException();
            }
        }

        public ExplorerThemedTreeView()
        {
            //if (!this.DesignMode)//TODO: Look into this
            {
                this.HideSelection = false;
                base.HotTracking = System.Windows.Forms.Application.RenderWithVisualStyles;
                Microsoft.Win32.SystemEvents.UserPreferenceChanged += SystemEvents_UserPreferenceChanged;
            }
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                //if (!this.DesignMode)//TODO: Look into this
                    Microsoft.Win32.SystemEvents.UserPreferenceChanged += SystemEvents_UserPreferenceChanged;
            }
            base.Dispose(disposing);
        }

        private void SystemEvents_UserPreferenceChanged(object sender, Microsoft.Win32.UserPreferenceChangedEventArgs e)
        {
            switch (e.Category)
            {
                case Microsoft.Win32.UserPreferenceCategory.VisualStyle:
                    base.HotTracking = System.Windows.Forms.Application.RenderWithVisualStyles;
                    break;
            }
        }
        
        [System.Runtime.InteropServices.DllImport("uxtheme.dll", ExactSpelling = true, CharSet = System.Runtime.InteropServices.CharSet.Unicode)]
        private static extern int SetWindowTheme(System.IntPtr hwnd, string pszSubAppName, string pszSubIdList);

        protected override void OnHandleCreated(System.EventArgs e)
        {
            base.OnHandleCreated(e);
            try
            {
                SetWindowTheme(this.Handle, "Explorer", null);
            }
#pragma warning disable CS0168 // Variable is declared but never used
            catch (System.EntryPointNotFoundException ex)
#pragma warning restore CS0168 // Variable is declared but never used
            {

            }
#pragma warning disable CS0168 // Variable is declared but never used
            catch (System.DllNotFoundException ex)
#pragma warning restore CS0168 // Variable is declared but never used
            {

            }
        }
    }
}
