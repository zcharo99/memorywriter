using Newtonsoft.Json;
using System.Security.Cryptography;
using System.Runtime.InteropServices;

namespace memorywriter_winforms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Point lastPoint;

        private void Form1_Load(object sender, EventArgs e)
        {
            this.monacoEditor.Source = new Uri(Path.Combine(Application.StartupPath, @"Monaco\index.html"));
            Console.WriteLine("Forlorn Version:       " + ForlornApi.Forlorn.ForlornVersion);
            Console.WriteLine("memorywriter Version:  1.0b.1");
        }

        [DllImport("kernel32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool AllocConsole();

        private async void button1_Click(object sender, EventArgs e)
        {
            if (ForlornApi.Api.IsInjected())
            {
                var result = await monacoEditor.ExecuteScriptAsync("window.editor.getValue();");
                string realResult = JsonConvert.DeserializeObject<string>(result);
                if (realResult == null)
                {
                    realResult = string.Empty;
                }
                Console.WriteLine("INFO: Executing \" " + realResult + " \"");
                ForlornApi.Api.ExecuteScript(realResult);
                Console.WriteLine("INFO-SUCCESS: Script executed");
            }
            else
            {
                MessageBox.Show("Please press Inject before executing.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Console.WriteLine("INFO: Injecting");
            if (ForlornApi.Api.IsRobloxOpen())
            {
                label2.Text = "Injecting...";
                ForlornApi.Api.Inject();
                Console.WriteLine("INFO-SUCCESS: Injected successfully");
                label2.Text = "Injected";
            }
            else
            {
                Console.WriteLine("INFO-ERROR: Roblox is not open");
                MessageBox.Show("Roblox is not open, open roblox before injecting.");
            }
        }

        private async void button4_Click(object sender, EventArgs e)
        {
            Console.WriteLine("INFO: Trying to clear Monaco...");
            await monacoEditor.ExecuteScriptAsync("window.editor.setValue(\"\");");
            Console.WriteLine("WARNING: Monaco should be cleared.");
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private async void button5_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                openFileDialog1.Title = "Open Script";
                var value = File.ReadAllText(openFileDialog1.FileName);
                await monacoEditor.ExecuteScriptAsync("window.editor.setValue(" + value + ");");
            }
        }

        private async void button6_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                using (Stream s = File.Open(saveFileDialog1.FileName, FileMode.CreateNew))
                using (StreamWriter sw = new StreamWriter(s))
                {
                    var value = await monacoEditor.ExecuteScriptAsync("window.editor.getValue();");
                    string realValue = JsonConvert.DeserializeObject<string>(value);
                    sw.Write(realValue);
                }
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (ForlornApi.Api.IsRobloxOpen())
            {
                ForlornApi.Api.KillRoblox();
            }
            else
            {
                MessageBox.Show("Roblox is not open.");
            }
        }
    }
}
