﻿/*
* 窗体管理器
* 张国伟
* 2018-04-12
*/
using FirstFrame.Helper.Log;
using FirstFrame.UI.Form;
using System;
using System.Collections.Generic;
using System.Reflection;

namespace MischiefMonkey
{
    public sealed class WindowManager
    {
        private static object Lock = new object();
        private static Dictionary<string, object> WindowList = new Dictionary<string, object>();
        private static Assembly asm = Assembly.GetExecutingAssembly();
        private static AssemblyName asmName;
        public static IntPtr MainForm;
        private static readonly WindowManager instance = new WindowManager();
        private WindowManager()
        {
            asmName = asm.GetName();
        }
        public static WindowManager GetInstance() { return instance; }

        public static object InitializeWindow(Type _TargerWindow)
        {
            if (!WindowList.ContainsKey(_TargerWindow.Name))
            {
                //DevExpress 在线程中实例化会产生异常，暂时在UI线程中进行
                /*CreateWindowThread _CreateWindowThread = new CreateWindowThread(_TargerWindow);
                Thread _CreateThread = new Thread(new ThreadStart(_CreateWindowThread.InitializeWindow));
                _CreateThread.SetApartmentState(ApartmentState.STA);
                _CreateThread.Start();*/

                return CreateWindow(_TargerWindow);
            }
            else
            {
                return GetWindow(_TargerWindow);
            }
        }
        public static object GetWindow(Type _TargerWindow)
        {
            if (WindowList.ContainsKey(_TargerWindow.Name))
            {
                lock(Lock)
                {
                    return WindowList[_TargerWindow.Name];
                }                    
            }
            else
            {                
                lock(Lock)
                {
                    return CreateWindow(_TargerWindow);
                }
            }
        }
        public static object GetWindow(string _TargerWindow)
        {
            Type type = System.Reflection.Assembly.Load(asmName.Name).GetType(_TargerWindow);
            if (WindowList.ContainsKey(type.Name))
            {
                lock (Lock)
                {
                    return WindowList[type.Name];
                }
            }
            else
            {
                lock (Lock)
                {
                    return CreateWindow(_TargerWindow);
                }
            }
        }
        //在线程中进行窗体缓存
        public class CreateWindowThread
        {
            Type TargerWindow = null;
            public CreateWindowThread(Type _TargerWindow)
            {
                this.TargerWindow = _TargerWindow;
            }
            public void InitializeWindow()
            {
                lock(Lock)
                {
                    LogHelper.WriteLog(this.GetHashCode().ToString(), TargerWindow.Name);
                    //CreateWindow(TargerWindow);
                }
            }
        }
        public static void DisposeWindow(Type _TargerWindow)
        {
            if (WindowList.ContainsKey(_TargerWindow.Name))
            {
                lock(Lock)
                {
                    WindowList.Remove(_TargerWindow.Name);
                }
            }
        }private static object CreateWindow(Type _TargerWindow)
        {
            Type type = System.Reflection.Assembly.Load(asmName.Name).GetType(string.Format("{0}.{1}", _TargerWindow.Namespace, _TargerWindow.Name));
            object _Window = Activator.CreateInstance(type);

            if (!WindowList.ContainsKey(_TargerWindow.Name)) WindowList.Add(_TargerWindow.Name, _Window);
            return _Window;
        }
        private static object CreateWindow(string _TargerWindow)
        {
            Type type = System.Reflection.Assembly.Load(asmName.Name).GetType(_TargerWindow);
            object _Window = Activator.CreateInstance(type);

            if (!WindowList.ContainsKey(type.Name)) WindowList.Add(type.Name, _Window);
            return _Window;
        }
        public static object ShowWindow(Type _TargerWindow, object Sender, OnNotifyData NotifyData, OnGetData GetData, Boolean IsModel, string WaitHint = FirstFrame.Const.BaseConst.WaitWindowOpenHint)
        {
            //if (WaitHint != "")
            //{
            //    Splash.ShowWaitForm();
            //    Splash.SetWaitFormDescription(WaitHint);
            //}
            object _Window = GetWindow(_TargerWindow);
            if (_TargerWindow.BaseType == typeof(frmBase)) 
            { 
                (_Window as frmBase).Sender = Sender;
                if (NotifyData != null) (_Window as frmBase).NotifyData += new OnNotifyData(NotifyData);
                if (GetData != null) (_Window as frmBase).GetData += new OnGetData(GetData);
            }
            string _Method = IsModel ? "ShowDialog" : "Show";
            Type type = System.Reflection.Assembly.Load(asmName.Name).GetType(string.Format("{0}.{1}", _TargerWindow.Namespace, _TargerWindow.Name));
            //if (WaitHint != "") Splash.CloseWaitForm();
            type.InvokeMember(_Method, BindingFlags.InvokeMethod, null, _Window, null);
            return _Window;
        }

        public static object ShowWindow(string _TargerWindow, object Sender, OnNotifyData NotifyData, OnGetData GetData, Boolean IsModel)
        {
            Type type = System.Reflection.Assembly.Load(asmName.Name).GetType(_TargerWindow);
            object _Window = GetWindow(type);
            if ((Sender != null) && (type.BaseType == typeof(frmBase))) 
            { 
                (_Window as frmBase).Sender = Sender;
                if (NotifyData != null) (_Window as frmBase).NotifyData += new OnNotifyData(NotifyData);
                if (GetData != null) (_Window as frmBase).GetData += new OnGetData(GetData);
            }
            string _Method = IsModel ? "ShowDialog" : "Show";
            type.InvokeMember(_Method, BindingFlags.InvokeMethod, null, _Window, null);
            return _Window;
        }
    }   
}
