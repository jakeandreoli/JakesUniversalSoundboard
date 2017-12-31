namespace LucasStuff
{
    public class Message
    {
        private const int WM_USER = 0x0400;

        [System.Flags()]
        private enum TASKDIALOG_FLAGS : int
        {
            TDF_ENABLE_HYPERLINKS = 0x0001,
            TDF_USE_HICON_MAIN = 0x0002,
            TDF_USE_HICON_FOOTER = 0x0004,
            TDF_ALLOW_DIALOG_CANCELLATION = 0x0008,
            TDF_USE_COMMAND_LINKS = 0x0010,
            TDF_USE_COMMAND_LINKS_NO_ICON = 0x0020,
            TDF_EXPAND_FOOTER_AREA = 0x0040,
            TDF_EXPANDED_BY_DEFAULT = 0x0080,
            TDF_VERIFICATION_FLAG_CHECKED = 0x0100,
            TDF_SHOW_PROGRESS_BAR = 0x0200,
            TDF_SHOW_MARQUEE_PROGRESS_BAR = 0x0400,
            TDF_CALLBACK_TIMER = 0x0800,
            TDF_POSITION_RELATIVE_TO_WINDOW = 0x1000,
            TDF_RTL_LAYOUT = 0x2000,
            TDF_NO_DEFAULT_RADIO_BUTTON = 0x4000,
            TDF_CAN_BE_MINIMIZED = 0x8000,
            //#if (NTDDI_VERSION >= NTDDI_WIN8)
            TDF_NO_SET_FOREGROUND = 0x00010000, // Don't call SetForegroundWindow() when activating the dialog
                                                //#endif // (NTDDI_VERSION >= NTDDI_WIN8)
            TDF_SIZE_TO_CONTENT = 0x01000000  // used by ShellMessageBox to emulate MessageBox sizing behavior
        }

        private enum TASKDIALOG_MESSAGES : int
        {
            TDM_NAVIGATE_PAGE = WM_USER + 101,
            TDM_CLICK_BUTTON = WM_USER + 102, // wParam = Button ID
            TDM_SET_MARQUEE_PROGRESS_BAR = WM_USER + 103, // wParam = 0 (nonMarque) wParam != 0 (Marquee)
            TDM_SET_PROGRESS_BAR_STATE = WM_USER + 104, // wParam = new progress state
            TDM_SET_PROGRESS_BAR_RANGE = WM_USER + 105, // lParam = MAKELPARAM(nMinRange, nMaxRange)
            TDM_SET_PROGRESS_BAR_POS = WM_USER + 106, // wParam = new position
            TDM_SET_PROGRESS_BAR_MARQUEE = WM_USER + 107, // wParam = 0 (stop marquee), wParam != 0 (start marquee), lparam = speed (milliseconds between repaints)
            TDM_SET_ELEMENT_TEXT = WM_USER + 108, // wParam = element (TASKDIALOG_ELEMENTS), lParam = new element text (LPCWSTR)
            TDM_CLICK_RADIO_BUTTON = WM_USER + 110, // wParam = Radio Button ID
            TDM_ENABLE_BUTTON = WM_USER + 111, // lParam = 0 (disable), lParam != 0 (enable), wParam = Button ID
            TDM_ENABLE_RADIO_BUTTON = WM_USER + 112, // lParam = 0 (disable), lParam != 0 (enable), wParam = Radio Button ID
            TDM_CLICK_VERIFICATION = WM_USER + 113, // wParam = 0 (unchecked), 1 (checked), lParam = 1 (set key focus)
            TDM_UPDATE_ELEMENT_TEXT = WM_USER + 114, // wParam = element (TASKDIALOG_ELEMENTS), lParam = new element text (LPCWSTR)
            TDM_SET_BUTTON_ELEVATION_REQUIRED_STATE = WM_USER + 115, // wParam = Button ID, lParam = 0 (elevation not required), lParam != 0 (elevation required)
            TDM_UPDATE_ICON = WM_USER + 116  // wParam = icon element (TASKDIALOG_ICON_ELEMENTS), lParam = new icon (hIcon if TDF_USE_HICON_* was set, PCWSTR otherwise)
        }

        private enum TASKDIALOG_NOTIFICATIONS : int
        {
            TDN_CREATED = 0,
            TDN_NAVIGATED = 1,
            TDN_BUTTON_CLICKED = 2,            // wParam = Button ID
            TDN_HYPERLINK_CLICKED = 3,            // lParam = (LPCWSTR)pszHREF
            TDN_TIMER = 4,            // wParam = Milliseconds since dialog created or timer reset
            TDN_DESTROYED = 5,
            TDN_RADIO_BUTTON_CLICKED = 6,            // wParam = Radio Button ID
            TDN_DIALOG_CONSTRUCTED = 7,
            TDN_VERIFICATION_CLICKED = 8,             // wParam = 1 if checkbox checked, 0 if not, lParam is unused and always 0
            TDN_HELP = 9,
            TDN_EXPANDO_BUTTON_CLICKED = 10            // wParam = 0 (dialog is now collapsed), wParam != 0 (dialog is now expanded)
        }

        [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential, CharSet = System.Runtime.InteropServices.CharSet.Unicode, Pack = 1)]
        private struct TASKDIALOG_BUTTON
        {
            public int nButtonID;
            [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.LPWStr)]
            public string pszButtonText;
        }

        private enum TASKDIALOG_ELEMENTS : int
        {
            TDE_CONTENT,
            TDE_EXPANDED_INFORMATION,
            TDE_FOOTER,
            TDE_MAIN_INSTRUCTION
        }

        private enum TASKDIALOG_ICON_ELEMENTS : int
        {
            TDIE_ICON_MAIN,
            TDIE_ICON_FOOTER
        }

        public static System.IntPtr TD_WARNING_ICON = new System.IntPtr(0x10000 - 1);
        public static System.IntPtr TD_ERROR_ICON = new System.IntPtr(0x10000 - 2);
        public static System.IntPtr TD_INFORMATION_ICON = new System.IntPtr(0x10000 - 3);
        public static System.IntPtr TD_SHIELD_ICON = new System.IntPtr(0x10000 - 4);

        [System.Flags()]
        public enum TASKDIALOG_COMMON_BUTTON_FLAGS : int
        {
            TDCBF_OK_BUTTON = 0x0001, // selected control return value IDOK
            TDCBF_YES_BUTTON = 0x0002, // selected control return value IDYES
            TDCBF_NO_BUTTON = 0x0004, // selected control return value IDNO
            TDCBF_CANCEL_BUTTON = 0x0008, // selected control return value IDCANCEL
            TDCBF_RETRY_BUTTON = 0x0010, // selected control return value IDRETRY
            TDCBF_CLOSE_BUTTON = 0x0020  // selected control return value IDCLOSE
        }

        private delegate int PFTASKDIALOGCALLBACK([System.Runtime.InteropServices.In] System.IntPtr hwnd, [System.Runtime.InteropServices.In] uint msg, [System.Runtime.InteropServices.In] int wParam, [System.Runtime.InteropServices.In] int lParam, [System.Runtime.InteropServices.In] System.IntPtr lpRefData);

        [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential, CharSet = System.Runtime.InteropServices.CharSet.Unicode, Pack = 1)]
        private struct TASKDIALOGCONFIG
        {
            public uint cbSize;
            public System.IntPtr hwndParent;                             // incorrectly named, this is the owner window, not a parent.
            public System.IntPtr hInstance;                              // used for MAKEINTRESOURCE() strings
            public TASKDIALOG_FLAGS dwFlags;            // TASKDIALOG_FLAGS (TDF_XXX) flags
            public TASKDIALOG_COMMON_BUTTON_FLAGS dwCommonButtons;    // TASKDIALOG_COMMON_BUTTON (TDCBF_XXX) flags
            [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.LPWStr)]
            public string pszWindowTitle;                         // string or MAKEINTRESOURCE()
            public System.IntPtr hMainIcon;
            [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.LPWStr)]
            public string pszMainInstruction;
            [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.LPWStr)]
            public string pszContent;
            public uint cButtons;
            public System.IntPtr pButtons;
            public int nDefaultButton;
            public uint cRadioButtons;
            public System.IntPtr pRadioButtons;
            public int nDefaultRadioButton;
            [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.LPWStr)]
            public string pszVerificationText;
            [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.LPWStr)]
            public string pszExpandedInformation;
            [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.LPWStr)]
            public string pszExpandedControlText;
            [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.LPWStr)]
            public string pszCollapsedControlText;
            public System.IntPtr hFooterIcon;
            [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.LPWStr)]
            public string pszFooter;
            public PFTASKDIALOGCALLBACK pfCallback;
            public System.IntPtr lpCallbackData;
            public uint cxWidth;
        }
        
        [System.Runtime.InteropServices.DllImport("comctl32.dll", SetLastError = true)]
        private static extern int TaskDialogIndirect([System.Runtime.InteropServices.In] ref TASKDIALOGCONFIG pTaskConfig, [System.Runtime.InteropServices.Out] out int pnButton, System.IntPtr pnRadioButton, System.IntPtr pfVerificationFlagChecked);

        private static bool TaskDialogIndirect(ref TASKDIALOGCONFIG pTaskConfig, out int pnButton, System.IntPtr pnRadioButton, System.IntPtr pfVerificationFlagChecked, out int phr)
        {
            try
            {
                phr = TaskDialogIndirect(ref pTaskConfig, out pnButton, pnRadioButton, pfVerificationFlagChecked);
            }
            catch (System.EntryPointNotFoundException)
            {
                pnButton = default(int);
                phr = default(int);
                return false;
            }
            return true;
        }

        public static System.Windows.Forms.DialogResult Show(string Content, string Title, System.Windows.Forms.MessageBoxButtons Buttons, System.Windows.Forms.MessageBoxIcon Icon, TASKDIALOG_COMMON_BUTTON_FLAGS CommonButtons, System.IntPtr MainIcon, System.Windows.Forms.IWin32Window Window = null)
        {
            TASKDIALOGCONFIG TaskConfig = new TASKDIALOGCONFIG();
            TaskConfig.cbSize = (uint)System.Runtime.InteropServices.Marshal.SizeOf(typeof(TASKDIALOGCONFIG));
            TaskConfig.hwndParent = (Window != null) ? Window.Handle : System.IntPtr.Zero;
            TaskConfig.hInstance = System.IntPtr.Zero;
            TaskConfig.dwFlags = TASKDIALOG_FLAGS.TDF_SIZE_TO_CONTENT;
            TaskConfig.dwCommonButtons = CommonButtons;
            TaskConfig.pszWindowTitle = Title;
            TaskConfig.hMainIcon = MainIcon;
            TaskConfig.pszMainInstruction = null;
            TaskConfig.pszContent = Content;
            TaskConfig.cButtons = 0;
            TaskConfig.nDefaultButton = 0;
            TaskConfig.cRadioButtons = 0;
            TaskConfig.pszVerificationText = null;
            TaskConfig.pszExpandedInformation = null;
            TaskConfig.pszExpandedControlText = null;
            TaskConfig.pszCollapsedControlText = null;
            TaskConfig.hFooterIcon = System.IntPtr.Zero;
            TaskConfig.pszFooter = null;
            TaskConfig.pfCallback = null;
            TaskConfig.cxWidth = 0;
            int iButton;
            int hr;
            if (TaskDialogIndirect(ref TaskConfig, out iButton, System.IntPtr.Zero, System.IntPtr.Zero, out hr))
            {
                if (hr == 0)
                    return (System.Windows.Forms.DialogResult)iButton;
                else
                    System.Diagnostics.Trace.Assert(false);
            }
            return System.Windows.Forms.MessageBox.Show(Window, Content, Title, Buttons, Icon);
        }

        public struct Buttons
        {
            public System.Windows.Forms.MessageBoxButtons Buttons2;
            public TASKDIALOG_COMMON_BUTTON_FLAGS CommonButtons;

            public static Buttons OK = new Buttons { Buttons2 = System.Windows.Forms.MessageBoxButtons.OK, CommonButtons = TASKDIALOG_COMMON_BUTTON_FLAGS.TDCBF_OK_BUTTON };
            public static Buttons OKCancel = new Buttons { Buttons2 = System.Windows.Forms.MessageBoxButtons.OKCancel, CommonButtons = TASKDIALOG_COMMON_BUTTON_FLAGS.TDCBF_OK_BUTTON | TASKDIALOG_COMMON_BUTTON_FLAGS.TDCBF_CANCEL_BUTTON };
            public static Buttons YesNoCancel = new Buttons { Buttons2 = System.Windows.Forms.MessageBoxButtons.YesNoCancel, CommonButtons = TASKDIALOG_COMMON_BUTTON_FLAGS.TDCBF_YES_BUTTON | TASKDIALOG_COMMON_BUTTON_FLAGS.TDCBF_NO_BUTTON | TASKDIALOG_COMMON_BUTTON_FLAGS.TDCBF_CANCEL_BUTTON };
            public static Buttons YesNo = new Buttons { Buttons2 = System.Windows.Forms.MessageBoxButtons.YesNo, CommonButtons = TASKDIALOG_COMMON_BUTTON_FLAGS.TDCBF_YES_BUTTON | TASKDIALOG_COMMON_BUTTON_FLAGS.TDCBF_NO_BUTTON };
            public static Buttons RetryCancel = new Buttons { Buttons2 = System.Windows.Forms.MessageBoxButtons.RetryCancel, CommonButtons = TASKDIALOG_COMMON_BUTTON_FLAGS.TDCBF_RETRY_BUTTON | TASKDIALOG_COMMON_BUTTON_FLAGS.TDCBF_CANCEL_BUTTON };
        }
        
        public struct Icon
        {
            public System.Windows.Forms.MessageBoxIcon Icon2;
            public System.IntPtr MainIcon;

            public static Icon None = new Icon { Icon2 = System.Windows.Forms.MessageBoxIcon.None, MainIcon = System.IntPtr.Zero };
            public static Icon Warning = new Icon { Icon2 = System.Windows.Forms.MessageBoxIcon.Warning, MainIcon = TD_WARNING_ICON };
            public static Icon Error = new Icon { Icon2 = System.Windows.Forms.MessageBoxIcon.Error, MainIcon = TD_ERROR_ICON };
            public static Icon Information = new Icon { Icon2 = System.Windows.Forms.MessageBoxIcon.Information, MainIcon = TD_INFORMATION_ICON };
        }
        
        public static System.Windows.Forms.DialogResult Show(string Content, string Title, Buttons Buttons, Icon Icon, System.Windows.Forms.IWin32Window Window = null)
        {
            return Show(Content, Title, Buttons.Buttons2, Icon.Icon2, Buttons.CommonButtons, Icon.MainIcon, Window);
        }

        public static void Alert(string Content, string Title, System.Windows.Forms.IWin32Window Window = null)
        {
            Show(Content, Title, Buttons.OK, Icon.Information, Window);
        }

        public static bool Confirm(string Content, string Title, System.Windows.Forms.IWin32Window Window = null)
        {
            return Show(Content, Title, Buttons.OKCancel, Icon.Information, Window) == System.Windows.Forms.DialogResult.OK;
        }
    }
}