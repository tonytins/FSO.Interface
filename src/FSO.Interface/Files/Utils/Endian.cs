/*
 * This Source Code Form is subject to the terms of the Mozilla Public License, v. 2.0.
 * If a copy of the MPL was not distributed with this file, You can obtain one at
 * http://mozilla.org/MPL/2.0/.
 */

using System;

namespace FSO.Interface.Files.Utils
{
    public class Endian
    {
        static Endian()
        {
            LittleEndian = BitConverter.IsLittleEndian;
        }

        public static short SwapInt16(short v)
        {
            return (short)(((v & 0xff) << 8) | ((v >> 8) & 0xff));
        }

        public static ushort SwapUInt16(ushort v)
        {
            return (ushort)(((v & 0xff) << 8) | ((v >> 8) & 0xff));
        }

        public static int SwapInt32(int v)
        {
            return ((SwapInt16((short)v) & 0xffff) << 0x10) |
                   (SwapInt16((short)(v >> 0x10)) & 0xffff);
        }

        public static uint SwapUInt32(uint v)
        {
            return (uint)(((SwapUInt16((ushort)v) & 0xffff) << 0x10) |
                           (SwapUInt16((ushort)(v >> 0x10)) & 0xffff));
        }

        public static long SwapInt64(long v)
        {
            return ((SwapInt32((int)v) & 0xffffffffL) << 0x20) |
                   (SwapInt32((int)(v >> 0x20)) & 0xffffffffL);
        }

        public static ulong SwapUInt64(ulong v)
        {
            return (ulong)(((SwapUInt32((uint)v) & 0xffffffffL) << 0x20) |
                            (SwapUInt32((uint)(v >> 0x20)) & 0xffffffffL));
        }

        public static bool IsBigEndian => !LittleEndian;

        public static bool IsLittleEndian => LittleEndian;

        private static readonly bool LittleEndian;
    }
}
