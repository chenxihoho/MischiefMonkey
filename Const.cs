﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MischiefMonkey
{
    class Const
    {
        private const int USER_MESSAGE = 0x0800;  //用户自定义消息
        public const int USER_LOG_MESSAGE = USER_MESSAGE + 1; //发送回显日志
    }
}
