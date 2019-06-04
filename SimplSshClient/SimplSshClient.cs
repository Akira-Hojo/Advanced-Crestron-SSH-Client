﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Crestron.SimplSharp;
using FM.SSH;

namespace FM.SSH
{
    public class SimplSshClient : SshClientManager
    {
        #region Delegates
        public new delegate void InitializedDelegate(ushort value);
        public new delegate void ConnectionStatusDelegate(ushort connected);
        public new delegate void ReceiveDataDelegate(SimplSharpString data);
        public InitializedDelegate InitializedDataMethod { get; set; }
        public ConnectionStatusDelegate ConnectionStateMethod { get; set; }
        public ReceiveDataDelegate ReceivedDataMethod { get; set; }
        #endregion

        #region Constructor
        public SimplSshClient()
        {
        }
        #endregion

        #region Properties
        public new ushort TraceEnabled
        {
            get
            {
                if (traceEnabled)
                    return 1;
                else
                    return 0;
            }            
            set
            {
                if (value > 0)
                    traceEnabled = true;
                else
                    traceEnabled = false;
            }
        }
        #endregion

        #region Public methods
        public void Initialize()
        {
            base.Initialize(traceEnabled, hostname, port, username, password);
        }
        public new void Connect()
        {
            base.Connect();
        }
        public new void Disconnect()
        {
            base.Disconnect();
        }
        public new void Send(string s)
        {
            base.Send(s);
        }
        #endregion
    }
}
