using CommonCompressors;
using Ionic.Zip;
using LibEveryFileExplorer.Files.SimpleFileSystem;
using NDS.NitroSystem.FND;
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

namespace SZS_Tool {

    public partial class Form1 : Form {

        public Form1() {
            InitializeComponent();
        }

        private void compressBtn_Click(object sender, EventArgs e) {
            if(openZIPDialog.ShowDialog() == DialogResult.OK) {
                YAZ0 y = new YAZ0();
                NARC SzsArch = new NARC();
                SFSDirectory dir = new SFSDirectory("", true);
                using(ZipFile z = ZipFile.Read(openZIPDialog.FileName)) {
                    for(int i = 0; i < z.Entries.Count; i++) {
                        ZipEntry ze = z.Entries.ToArray()[i];
                        SFSFile file = new SFSFile(i, ze.FileName, dir);

                        MemoryStream data = new MemoryStream();
                        ze.Extract(data);
                        file.Data = data.ToArray();
                        data.Dispose();

                        dir.Files.Add(file);
                    }
                    foreach(ZipEntry ze in z) {
                        Console.WriteLine(ze);
                    }
                }
                SzsArch.FromFileSystem(dir);
                if(saveSZSDialog.ShowDialog() == DialogResult.OK) {
                    File.WriteAllBytes(saveSZSDialog.FileName, y.Compress(SzsArch.Write()));
                    MessageBox.Show("Done!");
                }
            }
        }

        private void decompressBtn_Click(object sender, EventArgs e) {
            if(openSZSDialog.ShowDialog() == DialogResult.OK) {
                string of = openSZSDialog.FileName;
                if(IsYaz0(of)) {
                    if(folderBrowserDialog1.ShowDialog() == DialogResult.OK) {
                        string ep = folderBrowserDialog1.SelectedPath;
                        YAZ0 y = new YAZ0();
                        NARC f = new NARC(y.Decompress(File.ReadAllBytes(of)));
                        foreach(SFSFile file in f.ToFileSystem().Files) {
                            Console.WriteLine(file.FileName);
                            File.WriteAllBytes(ep + "\\" + file.FileName, file.Data);
                        }
                        MessageBox.Show("Done!");
                    }
                } else {
                    MessageBox.Show("The SZS file is not compressed with Yaz0.");
                }
            }
        }

        private bool IsYaz0(string f) {
            byte[] b = File.ReadAllBytes(f);
            return (b[0] == 89 && b[1] == 97 && b[2] == 122 && b[3] == 48);
        }
    }
}