using System;
using System.IO;
using System.Windows.Forms;

namespace MyApp03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "텍스트 파일|*.txt|모든 파일|*.*";
                openFileDialog.Title = "텍스트 파일 선택";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = openFileDialog.FileName;

                    try
                    {
                        // 파일 내용을 읽어와서 보여줌
                        string fileContent = File.ReadAllText(filePath);
                        textBox1.Text = fileContent; // textBox1에 파일 내용을 설정하여 보여줌
                    }
                    catch (IOException ex)
                    {
                        MessageBox.Show($"파일을 읽을 수 없습니다: {ex.Message}");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"오류 발생: {ex.Message}");
                    }
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

