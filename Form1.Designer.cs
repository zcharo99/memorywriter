namespace memorywriter_winforms
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            monacoEditor = new Microsoft.Web.WebView2.WinForms.WebView2();
            button1 = new Button();
            panel1 = new Panel();
            button3 = new Button();
            button2 = new Button();
            label1 = new Label();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            label2 = new Label();
            button8 = new Button();
            ((System.ComponentModel.ISupportInitialize)monacoEditor).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // monacoEditor
            // 
            monacoEditor.AllowExternalDrop = true;
            monacoEditor.CreationProperties = null;
            monacoEditor.DefaultBackgroundColor = Color.White;
            monacoEditor.Location = new Point(12, 33);
            monacoEditor.Name = "monacoEditor";
            monacoEditor.Size = new Size(662, 280);
            monacoEditor.TabIndex = 0;
            monacoEditor.ZoomFactor = 1D;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(30, 30, 30);
            button1.FlatAppearance.BorderColor = Color.FromArgb(30, 30, 30);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.White;
            button1.Location = new Point(12, 319);
            button1.Name = "button1";
            button1.Size = new Size(75, 30);
            button1.TabIndex = 1;
            button1.Text = "Execute";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(30, 30, 30);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(-1, -2);
            panel1.Name = "panel1";
            panel1.Size = new Size(688, 29);
            panel1.TabIndex = 2;
            panel1.MouseDown += panel1_MouseDown;
            panel1.MouseMove += panel1_MouseMove;
            // 
            // button3
            // 
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI", 11F);
            button3.ForeColor = Color.White;
            button3.Location = new Point(629, 0);
            button3.Name = "button3";
            button3.Size = new Size(29, 29);
            button3.TabIndex = 2;
            button3.Text = "–";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 11F);
            button2.ForeColor = Color.White;
            button2.Location = new Point(658, 0);
            button2.Name = "button2";
            button2.Size = new Size(29, 29);
            button2.TabIndex = 1;
            button2.Text = "X";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F);
            label1.ForeColor = Color.White;
            label1.Location = new Point(9, 4);
            label1.Name = "label1";
            label1.Size = new Size(102, 20);
            label1.TabIndex = 0;
            label1.Text = "memorywriter";
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(30, 30, 30);
            button4.FlatAppearance.BorderColor = Color.FromArgb(30, 30, 30);
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.ForeColor = Color.White;
            button4.Location = new Point(93, 319);
            button4.Name = "button4";
            button4.Size = new Size(75, 30);
            button4.TabIndex = 3;
            button4.Text = "Clear";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.FromArgb(30, 30, 30);
            button5.FlatAppearance.BorderColor = Color.FromArgb(30, 30, 30);
            button5.FlatAppearance.BorderSize = 0;
            button5.FlatStyle = FlatStyle.Flat;
            button5.ForeColor = Color.White;
            button5.Location = new Point(174, 319);
            button5.Name = "button5";
            button5.Size = new Size(75, 30);
            button5.TabIndex = 4;
            button5.Text = "Open File";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.BackColor = Color.FromArgb(30, 30, 30);
            button6.FlatAppearance.BorderColor = Color.FromArgb(30, 30, 30);
            button6.FlatAppearance.BorderSize = 0;
            button6.FlatStyle = FlatStyle.Flat;
            button6.ForeColor = Color.White;
            button6.Location = new Point(255, 319);
            button6.Name = "button6";
            button6.Size = new Size(75, 30);
            button6.TabIndex = 5;
            button6.Text = "Save File";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // button7
            // 
            button7.BackColor = Color.FromArgb(30, 30, 30);
            button7.FlatAppearance.BorderColor = Color.FromArgb(30, 30, 30);
            button7.FlatAppearance.BorderSize = 0;
            button7.FlatStyle = FlatStyle.Flat;
            button7.ForeColor = Color.White;
            button7.Location = new Point(599, 319);
            button7.Name = "button7";
            button7.Size = new Size(75, 30);
            button7.TabIndex = 6;
            button7.Text = "Inject";
            button7.UseVisualStyleBackColor = false;
            button7.Click += button7_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F);
            label2.ForeColor = Color.White;
            label2.Location = new Point(509, 324);
            label2.Name = "label2";
            label2.Size = new Size(84, 19);
            label2.TabIndex = 7;
            label2.Text = "Not Injected";
            // 
            // button8
            // 
            button8.BackColor = Color.FromArgb(30, 30, 30);
            button8.FlatAppearance.BorderColor = Color.FromArgb(30, 30, 30);
            button8.FlatAppearance.BorderSize = 0;
            button8.FlatStyle = FlatStyle.Flat;
            button8.ForeColor = Color.White;
            button8.Location = new Point(336, 319);
            button8.Name = "button8";
            button8.Size = new Size(75, 30);
            button8.TabIndex = 8;
            button8.Text = "Kill Roblox";
            button8.UseVisualStyleBackColor = false;
            button8.Click += button8_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(40, 40, 40);
            ClientSize = new Size(686, 354);
            Controls.Add(button8);
            Controls.Add(label2);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(panel1);
            Controls.Add(button1);
            Controls.Add(monacoEditor);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "memorywriter";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)monacoEditor).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Microsoft.Web.WebView2.WinForms.WebView2 monacoEditor;
        private Button button1;
        private Panel panel1;
        private Label label1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Label label2;
        private Button button8;
    }
}
