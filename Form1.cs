using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Text.RegularExpressions;

namespace Prog_lab1_2
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            textBox.ScrollBars = ScrollBars.Vertical;
            openFileDialog.Filter = "Text files(*.txt)|*.txt";
            saveFileDialog.Filter = "Text files(*.txt)|*.txt";
            saveFile.Enabled = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox.Clear();
        }

        private void openFile_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string fileName = openFileDialog.FileName;
                if (!fileName.Contains(".txt"))
                {
                    MessageBox.Show("Выбран файл неправильного формата");
                    return;
                }
                string text = File.ReadAllText(fileName);
                textBox.Text = text;
                textBox.SelectionStart = textBox.Text.Length;
                textBox.ScrollToCaret();
                saveFile.Enabled = true;
            }
        }

        private void saveAsFile_Click(object sender, EventArgs e)
        {
            string fileName;
            if (textBox.Text.Length == 0)
            {
                DialogResult result = MessageBox.Show("Вы уверены, что хотите сохранить пустой файл", "Предупреждение", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        fileName = saveFileDialog.FileName;
                        File.WriteAllText(fileName, textBox.Text);
                        MessageBox.Show($"Файл {Path.GetFileName(fileName)} сохранен");
                    }
                }
                else return;
            }
            else if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                fileName = saveFileDialog.FileName;
                File.WriteAllText(fileName, textBox.Text);
                MessageBox.Show($"Файл {Path.GetFileName(fileName)} сохранен");
            }
        }

        private void saveFile_Click(object sender, EventArgs e)
        {
            string fileName;
            if (textBox.Text.Length == 0)
            {
                DialogResult result = MessageBox.Show("Вы уверены, что хотите сохранить пустой файл", "Предупреждение", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    if (openFileDialog.FileName == String.Empty)
                    {
                        MessageBox.Show("Файл не открыт");
                        return;
                    }
                    fileName = openFileDialog.FileName;
                    File.WriteAllText(fileName, textBox.Text);
                    MessageBox.Show($"Файл {Path.GetFileName(fileName)} сохранен");
                }
                else return;
            }
            else if (openFileDialog.FileName == String.Empty)
            {
                MessageBox.Show("Файл не открыт");
                return;
            }
            else
            {
                fileName = openFileDialog.FileName;
                File.WriteAllText(fileName, textBox.Text);
                MessageBox.Show($"Файл {Path.GetFileName(fileName)} сохранен");
            }
            
        }


        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            FrameMultiplication frameMultiplication = new FrameMultiplication();

            frameMultiplication.print(topBorder, bottomBorder, rightBorder, leftBorder);
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            FrameEqual frameEqual = new FrameEqual();
            frameEqual.print(topBorder, bottomBorder, rightBorder, leftBorder);
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            FramePlus framePlus = new FramePlus();
            framePlus.print(topBorder, bottomBorder, rightBorder, leftBorder);
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            FrameMultiplication frameMultiplication = new FrameMultiplication();

            frameMultiplication.print(topBorder, bottomBorder, rightBorder, leftBorder);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
