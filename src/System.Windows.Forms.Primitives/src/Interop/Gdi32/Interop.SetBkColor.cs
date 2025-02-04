﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Runtime.InteropServices;

internal static partial class Interop
{
    internal static partial class Gdi32
    {
        [LibraryImport(Libraries.Gdi32)]
        public static partial int SetBkColor(HDC hdc, int color);

        public static int SetBkColor(IHandle hdc, int color)
        {
            int result = SetBkColor((HDC)hdc.Handle, color);
            GC.KeepAlive(hdc);
            return result;
        }

        public static int SetBkColor(HandleRef hdc, int color)
        {
            int result = SetBkColor((HDC)hdc.Handle, color);
            GC.KeepAlive(hdc.Wrapper);
            return result;
        }
    }
}
