
using System.Runtime.InteropServices;

ApplicationConfiguration.Initialize();

TaskDialog.ShowDialog(new TaskDialogPage()
{
    Caption = "show-args",
    Heading = "show-args",
    Text = "Command line:\n\n" + Marshal.PtrToStringAuto(GetCommandLine()) +
           "\n\nArguments:\n\n" + string.Join("\n", args),
    Icon = TaskDialogIcon.Information,
    SizeToContent = true,
    AllowCancel = true 
}); ;

[DllImport("kernel32.dll", CharSet = CharSet.Auto)]
static extern IntPtr GetCommandLine();
