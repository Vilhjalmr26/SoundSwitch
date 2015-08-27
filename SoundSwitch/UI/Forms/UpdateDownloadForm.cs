﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SoundSwitch.Properties;

namespace SoundSwitch.UI.Forms
{
    public partial class UpdateDownloadForm : Form
    {
        public UpdateDownloadForm()
        {
            InitializeComponent();
            Icon = Icon.FromHandle(Resources.Update.GetHicon());
        }
    }
}
