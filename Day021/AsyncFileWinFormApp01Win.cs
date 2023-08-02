using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AsyncFileWinFormApp01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private async Task<long> CopyAsync(string FormPath, string ToPath) 
        {
            btnSyncCopy.Enabled = false;
            long totalCopied = 0;

            using (FileStream fromStreaam =
                new FileStream(FromPath, FileMode, Open))
            {
                using (FileStream toStream =
                    new FileStream(ToPath, FileMode.Create))
                {
                    byte[] buffer = new byte[1024];
                    int nRead = 0;
                    while ((nRead =
                        await fromStream.ReadAsync(buffer, 0, buffer.Length)) != 0)
                    {
                        await toStream.WriteAsync(buffer, 0, nRead);
                        totalCopied += nRead;

                        //프로그레바스에 현재 파일 복사 상태 표시
                        pbCopy.Value =
                            (int)(((double)totalCopied / (double)fromStreaam.Length)
                                    * pbCopy.Maximum);
                    }
                }
            }
            btnSyncCopy.Enabled = true;
            return totalCopied;
        }
        private long CopySync(string FromPath, string ToPath)
        {
            btnAsyncCopy.Enabled = false;
            long totalCopied = 0;

            using (FileStream fromStreaam =
                new FileStream(FromPath, FileMode, Open))
            {
                using (FileStream toStream =
                    new FileStream(ToPath, FileMode.Create))
                {
                    byte[] buffer = new byte[1024];
                    int nRead = 0;
                    while ((nRead =
                        fromStream.Read(buffer, 0, buffer.Length)) != 0)
                    {
                        toStream.Write(buffer, 0, nRead);
                        totalCopied += nRead;

                        //프로그레바스에 현재 파일 복사 상태 표시
                        pbCopy.Value =
                            (int)(((double)totalCopied / (double)fromStreaam.Length)
                                    * pbCopy.Maximum);
                    }
                }
            }
        }
    }
    btnAsyncCopy.Enabled = true;
    return totalCopied;
}
