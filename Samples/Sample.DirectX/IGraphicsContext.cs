﻿using System;
using WinApi.Core;

namespace Sample.DirectX
{
    internal interface IGraphicsContext {
        void Init(IntPtr hwnd, ref Size size, bool deferInitUntilFirstDraw = true);
        void Draw();
        void Resize(ref Size size);
    }
}