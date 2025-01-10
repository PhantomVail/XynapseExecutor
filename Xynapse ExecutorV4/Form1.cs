using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuorumAPI;
using System.Runtime.InteropServices;
using System.Drawing.Text;

namespace Xynapse_ExecutorV4
{
    public partial class Form1 : Form
    {
        [DllImport("DwmApi")]
        private static extern int DwmSetWindowAttribute(IntPtr hwnd, int attr, ref int attrValue, int attrSize);

        protected override void OnHandleCreated(EventArgs e)
        {
            base.OnHandleCreated(e);
            int darkMode = 1;
            DwmSetWindowAttribute(Handle, 19, ref darkMode, sizeof(int));
        }
        public Form1()
        {
            InitializeComponent();
            OnLoad();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private async void OnLoad()
        {
            await webView21.EnsureCoreWebView2Async();
            webView21.Source = new Uri("https://dark-modz.github.io/Monaco/Editor/index.html");
        }

        private async void ExecScript()
        {
            string script = "editor.getValue();";
            string result = await webView21.CoreWebView2.ExecuteScriptAsync(script);
            string editorText = Regex.Unescape(result.Trim('"'));
            QuorumAPI.QuorumAPI.ExecuteScript(editorText);
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            QuorumAPI.QuorumAPI.AttachAPI();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            ExecScript();
        }

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            string notificationScript = @"
        game:GetService('StarterGui'):SetCore('SendNotification', {
            Title = 'Xynapse',
            Text = 'Xynapse Executor By PhantomVail',
            Duration = 3,
            Icon = 'rbxassetid://4483345998'  -- Optional icon ID
        })";

            QuorumAPI.QuorumAPI.ExecuteScript(notificationScript);
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            QuorumAPI.QuorumAPI.KillRoblox();
        }

        private async void guna2Button4_Click(object sender, EventArgs e)
        {
            string clearScript = "editor.setValue('');";
            await webView21.CoreWebView2.ExecuteScriptAsync(clearScript);
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            string plutov3Script = "loadstring(game:HttpGet(\"https://raw.githubusercontent.com/Horizon89002/PLUT0_V3/refs/heads/main/PLUT0%20V3%20(source).lua\"))()";
            QuorumAPI.QuorumAPI.ExecuteScript(plutov3Script);
        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {
            string infiniteyieldScript = "loadstring(game:HttpGet('https://raw.githubusercontent.com/EdgeIY/infiniteyield/master/source'))()";
            QuorumAPI.QuorumAPI.ExecuteScript(infiniteyieldScript);
        }

        private void guna2ToggleSwitch1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
