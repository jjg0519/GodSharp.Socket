﻿using System;

namespace GodSharp.Protocol
{
    public class SocketResult<T> where T: SocketBase
    {
        public T Socket { get; set; }
        public byte[] Bytes { get; set; }
        public Action<T, byte[]> OnData { get; set; }
    }
}
