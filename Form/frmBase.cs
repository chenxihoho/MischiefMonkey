﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MischiefMonkey
{
    public delegate void OnNotifyData(object Object);
    public delegate object OnGetData(object[] Args);
    public partial class frmBase : Form
    {
        public object Sender;
        public event OnNotifyData NotifyData;
        public event OnGetData GetData;
        public frmBase()
        {
            InitializeComponent();
        }
        public void Close(bool Dispose)
        {
            if (Dispose)
            {
                WindowManager.DisposeWindow(this.GetType());
                base.Dispose(true);
                return;
            }
            Hide();
        }
        protected override void OnClosed(EventArgs e)
        {
            if (NotifyData != null) NotifyData -= NotifyData;
            if (GetData != null) GetData -= GetData;
            base.OnClosed(e);
        }
        protected override void Dispose(bool disposing) { Hide(); }
        protected void DoNotifyData(object Object) { if (NotifyData != null) NotifyData(Object); }
        protected object DoGetData(object[] Args)
        {
            if (GetData == null) return null;
            return GetData(Args);
        }
    }
}
