using System.IO;
using System.Windows.Media.Imaging;
using Autodesk.AutoCAD.Runtime;
using Autodesk.Windows;
using CadAddinManager.Command;
using CadAddinManager.Model;
using CadAddinManager.View.Control;
using ImageSource = System.Windows.Media.ImageSource;
using Orientation = System.Windows.Controls.Orientation;
[assembly: ExtensionApplication(typeof(CadAddinManager.MyPlugin))]

namespace CadAddinManager;
    public class MyPlugin : IExtensionApplication
{
    public void Initialize()
    {
    }

    public void Terminate()
    {
        try
        {
            var folderPath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
            var tempPath = Path.Combine(folderPath, "Temp");
            var directoryInfo = new DirectoryInfo(Path.Combine(tempPath, DefaultSetting.TempFolderName));
            if (directoryInfo.Exists)
            {
                directoryInfo.Delete(true);
            }
        }
        catch (System.Exception)
        {

        }
    }
}