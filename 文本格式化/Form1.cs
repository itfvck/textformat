using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 文本格式化
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Text = "文本格式化工具v1.1  by Li Dong（开发_李冬） @ lidong@111.com.cn 有任何改进意见请留言";
        }

        /// <summary>
        /// 粘贴
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void richTextBoxSrc_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.V)
            {
                e.SuppressKeyPress = true;
                richTextBoxSrc.Paste(DataFormats.GetFormat(DataFormats.Text));
            }
        }


        private void buttonFormat1_Click(object sender, EventArgs e)
        {
            richTextBoxResult.Text = "";
            string textSrc = richTextBoxSrc.Text;
            textSrc = textSrc.Replace("\t"," ");
            textSrc = textSrc.Replace("\n", " ");
            textSrc = textSrc.Replace("  ", " ");

            textSrc = new System.Text.RegularExpressions.Regex("[\\s]+").Replace(textSrc, " ");
            richTextBoxResult.AppendText(textSrc.Trim());
        }

        /// <summary>
        /// 结果全选
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void richTextBoxResult_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)1)       // Ctrl-A 相当于输入了AscII=1的控制字符
            {
                richTextBoxResult.SelectAll();
                e.Handled = true;      // 不再发出“噔”的声音
            }
        }

        /// <summary>
        /// 原文本全选
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void richTextBoxSrc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)1)       // Ctrl-A 相当于输入了AscII=1的控制字符
            {
                richTextBoxSrc.SelectAll();
                e.Handled = true;      // 不再发出“噔”的声音
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

       
    }
}
