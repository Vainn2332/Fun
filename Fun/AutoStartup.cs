using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fun
{
    internal class AutoStartup
    {
        private const string registryKeyPath= @"SOFTWARE\Microsoft\Windows\CurrentVersion\Run";
        public void SetStartup(bool enable)
        {
            try
            {
                RegistryKey key = Registry.CurrentUser.OpenSubKey(registryKeyPath, true);
                if (key == null)
                    return;
                if (enable)//добавляем
                {
                    string executablePath=Application.ExecutablePath;
                    key.SetValue("Fun", executablePath);
                   
                }
                else//удаляем из автозагрузки
                {
                    if (key.GetValue("Fun") != null)
                        key.DeleteValue("Fun");
                }
            }
            catch
            {
                MessageBox.Show("Ошибка автозагрузки(((");
            }
        }
    }
}
