﻿using FirstFrame.WinAPI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.IO.MemoryMappedFiles;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MischiefMonkey
{
    public partial class frmMain : Form
    {
        internal readonly SynchronizationContext Context;
        private const string PiFilePath = @"D:\Downloads\MischiefMonkey\Pi\圆周率小数点后{0:D3}00000001到{1:D3}00000000一共1亿位.txt";
        private static long MaxPosition = 0;
        private static long FILE_SIZE = 0;

        public frmMain()
        {
            InitializeComponent();

            WindowManager.MainForm = this.Handle;
            Context = SynchronizationContext.Current;
        }
        #region 自定义消息处理
        protected override void DefWndProc(ref System.Windows.Forms.Message m)
        {
            switch (m.Msg)
            {
                #region 回显日志
                case Const.USER_LOG_MESSAGE:
                {
                    Win32API.COPYDATASTRUCT LogString = new Win32API.COPYDATASTRUCT();
                    Type type = LogString.GetType();
                    LogString = (Win32API.COPYDATASTRUCT)m.GetLParam(type);
                    AppendLog(LogString.lpData);
                    break;
                }
                #endregion
                #region default
                default:
                {
                    base.DefWndProc(ref m); //调用基类函数，以便系统处理其它消息。
                    break;
                }
                #endregion
            }
        }
        #endregion
        #region 添加日志
        private List<string> MessageList = new List<string>();
        private void AppendLog(string Message)
        {
            if (MessageList.Count >= 2 << 10)
            {//日志达到 2048 条清除一半
                MessageList.RemoveRange(0, 1 << 10);
                edLog.Clear();
                foreach (string OldMessage in MessageList) edLog.AppendText(OldMessage);
            }
            edLog.AppendText(Message);
            MessageList.Add(Message);
        }
        #endregion
        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// 创建内存映射文件
        /// </summary>
        private static bool CreateMemoryMapFile(long FileIndex, string FilePath, string Keyword, string TranslateKword)
        {
            using (FileStream _FileStream = new FileStream(FilePath, FileMode.Open, FileAccess.ReadWrite))
            {
                FILE_SIZE = _FileStream.Length;
                using (MemoryMappedFile _MMF = MemoryMappedFile.CreateFromFile(_FileStream, "Pi", _FileStream.Length, MemoryMappedFileAccess.ReadWrite, null, HandleInheritability.None, false))
                {
                    long Offset = 0; //当前搜索位置
                    int SearchScope = 10000000; //每次搜索长度
                    try
                    {
                        do
                        {
                            long Remaining = _FileStream.Length - Offset;
                            using (MemoryMappedViewStream _MMStream = _MMF.CreateViewStream(Offset, Remaining > SearchScope ? SearchScope : Remaining))
                            {
                                Offset += SearchScope;

                                //Common.PostLogMessage(string.Format("开始搜索第 {0}-{1} 位", Offset - SearchScope, Remaining + Offset));
                                using (StreamReader sr = new StreamReader(_MMStream))
                                {
                                    string TempString = sr.ReadToEnd();
                                    if (TempString.Contains(TranslateKword))
                                    {
                                        long ThisPosition = Offset + TempString.IndexOf(TranslateKword) - SearchScope + 1 + FileIndex * 100000000;
                                        if (ThisPosition >= MaxPosition) { MaxPosition = ThisPosition; }
                                        Common.PostLogMessage(string.Format("{0} 在第 {1:N0} 位出现", Keyword, MaxPosition));
                                        return true;
                                    }

                                    sr.Dispose();
                                }

                                _MMStream.Dispose();
                            }
                        } while (Offset < _FileStream.Length);
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                    }
                }
            }

            return false;
        }

        private void btSearch_Click(object sender, EventArgs e)
        {
            bool SearchResult = false;
            DateTime beginTime = DateTime.Now;

            for (int i = 0; i < 250; i++)
            {
                Common.PostLogMessage(string.Format("在 {0} 亿范围内开始搜索", i + 1));

                SearchResult = CreateMemoryMapFile(i, string.Format(PiFilePath, i, i + 1), tbKeyword.Text, TranslateLetter(tbKeyword.Text));
                if (SearchResult) break;
            }

            
            double totalSeconds = DateTime.Now.Subtract(beginTime).TotalSeconds;
            if(SearchResult)
                Common.PostLogMessage(string.Format("共耗时:{0} 秒，最大出现位置为 {1:N0}", totalSeconds, MaxPosition));
            else
                Common.PostLogMessage(string.Format("共耗时:{0} 秒，没有搜索到指定内容", totalSeconds));

            MaxPosition = 0;
        }

        public string TranslateLetter(string _String)
        {
            _String = _String.ToUpper();
            //return _String.Replace("A", "0").Replace("B", "1").Replace("C", "2").Replace("D", "3")
            //              .Replace("E", "4").Replace("F", "5").Replace("G", "6").Replace("H", "7")
            //              .Replace("I", "8").Replace("J", "9").Replace("K", "10").Replace("L", "11")
            //              .Replace("M", "12").Replace("N", "13").Replace("O", "14").Replace("P", "15")
            //              .Replace("Q", "16").Replace("R", "17").Replace("S", "18").Replace("T", "19")
            //              .Replace("U", "21").Replace("V", "21").Replace("W", "22").Replace("X", "23")
            //              .Replace("Y", "24").Replace("Z", "25");

            decimal StartPos = nudStartPos.Value;
            return _String.Replace("A", StartPos++.ToString()).Replace("B", StartPos++.ToString()).Replace("C", StartPos++.ToString()).Replace("D", StartPos++.ToString())
                          .Replace("E", StartPos++.ToString()).Replace("F", StartPos++.ToString()).Replace("G", StartPos++.ToString()).Replace("H", StartPos++.ToString())
                          .Replace("I", StartPos++.ToString()).Replace("J", StartPos++.ToString()).Replace("K", StartPos++.ToString()).Replace("L", StartPos++.ToString())
                          .Replace("M", StartPos++.ToString()).Replace("N", StartPos++.ToString()).Replace("O", StartPos++.ToString()).Replace("P", StartPos++.ToString())
                          .Replace("Q", StartPos++.ToString()).Replace("R", StartPos++.ToString()).Replace("S", StartPos++.ToString()).Replace("T", StartPos++.ToString())
                          .Replace("U", StartPos++.ToString()).Replace("V", StartPos++.ToString()).Replace("W", StartPos++.ToString()).Replace("X", StartPos++.ToString())
                          .Replace("Y", StartPos++.ToString()).Replace("Z", StartPos++.ToString());
        }

        private void tbKeyword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) btSearch_Click(sender, null);
        }

        private void btSearchBankPassword_Click(object sender, EventArgs e)
        {
            for (int i = 0; i <= 999999; i++)
            {
                string Password = string.Format("{0:D6}", i);
                tbKeyword.Text = Password;

                btSearch_Click(sender, null);
            }
        }
    }
}
