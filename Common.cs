﻿using FirstFrame.Helper.Log;
using FirstFrame.UI;
using FirstFrame.WinAPI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MischiefMonkey
{
    class Common
    {
        #region 向主窗体发送日志信息
        public static void PostLogMessage(string Message)
        {
            if (WindowManager.MainForm == null) LogHelper.Debug(Message);
            else Win32API.PostLogMessage(WindowManager.MainForm, Const.USER_LOG_MESSAGE, " " +Message, true, false, 0);
        }
        #endregion
        #region 向主窗体发送用户消息
        public static bool PostUserMessage(int Message)
        {
            if (WindowManager.MainForm == null) LogHelper.Debug(Message.ToString());
            else Win32API.PostUserMessage(WindowManager.MainForm, Message);
            return true;
        }
        #endregion
    }
}
