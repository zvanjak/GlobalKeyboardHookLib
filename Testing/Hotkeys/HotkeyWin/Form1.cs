using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Hotkeys;

namespace HotkeyWin
{
    public partial class Form1 : Form
    {
        private Hotkeys.GlobalHotkey ghk;

        public Form1()
        {
            InitializeComponent();
            ghk = new Hotkeys.GlobalHotkey(Constants.ALT + Constants.CTRL, Keys.D, this);
        }

        private void HandleHotkey()
        {
            WriteLine("Hotkey pressed!");
            Form2 dlg = new Form2();
            dlg.ShowDialog();
        }

        protected override void WndProc(ref Message m)
        {
            if (m.Msg == Hotkeys.Constants.WM_HOTKEY_MSG_ID)
                HandleHotkey();
            base.WndProc(ref m);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
          if (!ghk.Register())
            MessageBox.Show("Couldn't register");
          
          /* WriteLine("Trying to register SHIFT+ALT+O");
            if (ghk.Register())
                WriteLine("Hotkey registered.");
            else
                WriteLine("Hotkey failed to register");
           */
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!ghk.Unregiser())
                MessageBox.Show("Hotkey failed to unregister!");
        }

        private void WriteLine(string text)
        {
            textBox1.Text += text + Environment.NewLine;
        }
    }
}
