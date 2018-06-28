using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace SnippingTool
{
    /// <summary>
    /// 热键类
    /// </summary>
   public class HotKey
    {
       /// <summary>
        /// 注册系统热键,详细信息参考：http://msdn.microsoft.com/en-us/library/windows/desktop/ms646309(v=vs.85).aspx
       /// 如果函数执行成功，返回值不为0，如果执行失败，返回值为0
       /// </summary>
       /// <returns></returns>
       [DllImport("user32.dll", SetLastError = true)]
       public static extern bool RegisterHotKey(
           IntPtr hWnd,           // 窗口的句柄, 当热键按下时，会产生WM_HOTKEY信息，该信息该会发送该窗口句柄
           int id,                      // 定义热键ID,属于唯一标识热键的作用
           uint fsModifiers,                    // 热键只有在按下Alt、 Ctrl、Shift、Windows等键时才会生效，即才会产生WM_HOTKEY信息
           Keys vk                   // 虚拟键,即按了Alt+Ctrl+ X ，X就是代表虚拟键
           );

       [DllImport("user32.dll",SetLastError=true)]
       public static extern bool UnregisterHotKey(
           IntPtr hWnd,                   // 窗口句柄
           int id                              // 要取消热键的ID
           );
    }
}
