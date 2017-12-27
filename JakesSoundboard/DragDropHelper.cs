using System;
using System.Drawing;

[System.Runtime.InteropServices.ComVisible(true)]
[System.Runtime.InteropServices.ComImport()]
[System.Runtime.InteropServices.Guid("4657278B-411B-11D2-839A-00C04FD918D0")]
[System.Runtime.InteropServices.InterfaceType(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsIUnknown)]
public interface IDropTargetHelper {
	void DragEnter([System.Runtime.InteropServices.In()]
IntPtr hwndTarget, [System.Runtime.InteropServices.In(), System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.Interface)]
System.Runtime.InteropServices.ComTypes.IDataObject dataObject, [System.Runtime.InteropServices.In()]
ref Point pt, [System.Runtime.InteropServices.In()]
int effect);
	void DragLeave();
	void DragOver([System.Runtime.InteropServices.In()]
ref Point pt, [System.Runtime.InteropServices.In()]
int effect);
	void Drop([System.Runtime.InteropServices.In(), System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.Interface)]
System.Runtime.InteropServices.ComTypes.IDataObject dataObject, [System.Runtime.InteropServices.In()]
ref Point pt, [System.Runtime.InteropServices.In()]
int effect);
	void Show([System.Runtime.InteropServices.In()]
bool show__1);
}

[System.Runtime.InteropServices.ComImport()]
[System.Runtime.InteropServices.Guid("4657278A-411B-11d2-839A-00C04FD918D0")]
public class DragDropHelper {
}