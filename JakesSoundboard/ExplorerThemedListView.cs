namespace LucasStuff
{
    public class ExplorerThemedListView : System.Windows.Forms.ListView
    {
        [System.ComponentModel.DefaultValue(true)]
        public new bool DoubleBuffered
        {
            get
            {
                return base.DoubleBuffered;
            }
            set
            {
                base.DoubleBuffered = value;
            }
        }

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

        [System.ComponentModel.DefaultValue(true)]
        public new bool FullRowSelect
        {
            get
            {
                return base.FullRowSelect;
            }
            set
            {
                base.FullRowSelect = value;
            }
        }

        public ExplorerThemedListView()
        {
            //if (!this.DesignMode)//TODO: Look into this
            {
                this.DoubleBuffered = true;
                this.HideSelection = false;
                this.FullRowSelect = true;
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
