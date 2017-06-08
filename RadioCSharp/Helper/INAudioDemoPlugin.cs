﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace RadioCSharp
{
    public interface INAudioDemoPlugin
    {
        string Name { get; }
        Control CreatePanel();
    }
}
