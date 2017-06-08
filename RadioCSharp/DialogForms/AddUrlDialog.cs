using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RadioCSharp
{
    public partial class AddUrlDialog : Form
    {

        public string URL = "";
        public bool IsGetNewURL = false;

        public AddUrlDialog()
        {
            InitializeComponent();
        }

        private void btnAddUrl_Click(object sender, EventArgs e)
        {
            var url = txtURL.Text;
            bool isUri = CheckURLValid(url);
            if (!isUri)
            {
                errorProvider1.SetError(txtURL, "Url was wrong");
               
            }else
            {
                IsGetNewURL = true;
                URL = url;
                this.Close();
            }
        }

        private bool CheckURLValid(string uriName)
        {
            Uri uriResult;
            var tempUri = "";
            if (uriName.ToLower().StartsWith("www")||uriName.ToLower().StartsWith("rtmp"))
                uriName = "http://" + uriName;
            return Uri.TryCreate(uriName, UriKind.Absolute, out uriResult)
                && (uriResult.Scheme == Uri.UriSchemeHttp || uriResult.Scheme == Uri.UriSchemeHttps);
            
        }
        
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            txtURL.Text = Clipboard.GetText();
        }
    }
}
