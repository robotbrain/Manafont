﻿using System.Runtime.InteropServices;
using Manafont.Packets.IO;

namespace Manafont.Session
{
    [StructLayout(LayoutKind.Sequential)]
    public struct SessionRevokedPacket
    {
        public const ushort Opcode = 3;
    }
}