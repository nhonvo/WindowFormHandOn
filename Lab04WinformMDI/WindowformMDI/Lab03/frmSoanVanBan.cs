using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab03
{
    public partial class frmSoanVanBan : Form
    {
        public string path = "";
        public frmSoanVanBan()
        {
            InitializeComponent();
        }

        private void địnhDạngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog fontDlg = new FontDialog();
            fontDlg.ShowColor = true;
            fontDlg.ShowApply = true;
            fontDlg.ShowEffects = true;
            fontDlg.ShowHelp = true;
            if (fontDlg.ShowDialog() != DialogResult.Cancel)
            {
                richbox.ForeColor = fontDlg.Color;
                richbox.Font = fontDlg.Font;
            }
        }


        private void frmSoanVanBan_Load(object sender, EventArgs e)
        {
            newVanBan();
            tsbfont.SelectedItem = "Tahoma";
            tsbsize.SelectedItem = "14";
        }

        private void newVanBan()
        {
            foreach (FontFamily item in new InstalledFontCollection().Families)
            {
                tsbfont.Items.Add(item.Name);
            }

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            richbox.Clear();
            richbox.Font = new Font("Tahoma", 14, FontStyle.Regular);
            tsbsize.SelectedItem = "14";
            tsbfont.SelectedItem = "Tahoma";
            path = "";
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            SaveFileDialog savefile = new SaveFileDialog();
            savefile.CheckPathExists = true;
            savefile.DefaultExt = "rtf";
            savefile.Filter = "richbox files|*.rtf";
            savefile.RestoreDirectory = true;
            if (savefile.ShowDialog() == DialogResult.OK)
            {
                richbox.SaveFile(savefile.FileName, RichTextBoxStreamType.PlainText);
                MessageBox.Show("Lưu file thành công - " + savefile.FileName, "thông báo");
            }
        }

        private void tạoVănBảnMớiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richbox.Clear();
            richbox.Font = new Font("Tahoma", 14, FontStyle.Regular);
            tsbsize.SelectedItem = "14";
            tsbfont.SelectedItem = "Tahoma";
            path = "";
        }

        private void mởTậpTinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();

            dlg.Filter = "Text file| *.txt| RTF File | *.rtf";

            if (dlg.ShowDialog() == DialogResult.OK)
                richbox.LoadFile(dlg.FileName, RichTextBoxStreamType.PlainText);
            path = dlg.FileName;
        }

        private void lưuNộiDungVănBảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog savefile = new SaveFileDialog();
            savefile.CheckPathExists = true;
            savefile.DefaultExt = "rtf";
            savefile.Filter = "richbox files|*.rtf";
            savefile.RestoreDirectory = true;
            if(savefile.ShowDialog() == DialogResult.OK)
            {
                richbox.SaveFile(savefile.FileName, RichTextBoxStreamType.PlainText);
                MessageBox.Show("Lưu file thành công - " + savefile.FileName, "thông báo");
            }
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            if(richbox.SelectionFont.Bold)
            {
                richbox.SelectionFont = new Font(richbox.SelectionFont, richbox.SelectionFont.Style & ~FontStyle.Bold);

            }

            else
            {
                richbox.SelectionFont = new Font(richbox.SelectionFont, richbox.SelectionFont.Style | FontStyle.Bold);

            }
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            if (richbox.SelectionFont.Italic)
            {
                richbox.SelectionFont = new Font(richbox.SelectionFont, richbox.SelectionFont.Style & ~FontStyle.Italic);

            }

            else
            {
                richbox.SelectionFont = new Font(richbox.SelectionFont, richbox.SelectionFont.Style | FontStyle.Italic);

            }
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            if (richbox.SelectionFont.Underline)
            {
                richbox.SelectionFont = new Font(richbox.SelectionFont, richbox.SelectionFont.Style & ~FontStyle.Underline);

            }

            else
            {
                richbox.SelectionFont = new Font(richbox.SelectionFont, richbox.SelectionFont.Style | FontStyle.Underline);

            }
        }

        private void tsbfont_Click(object sender, EventArgs e)
        {
            foreach (FontFamily font in new InstalledFontCollection().Families)
            {
                tsbfont.Items.Add(font.Name);
            }
            richbox.SelectionFont = new Font(tsbfont.Text, float.Parse(tsbsize.Text));
        }



        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void tsbsize_SelectedIndexChanged(object sender, EventArgs e)
        {
            richbox.SelectionFont = new Font(tsbfont.Text, float.Parse(tsbsize.Text));
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                StreamWriter writer = new StreamWriter(path.Trim());
                writer.WriteLine(richbox.Text);
                writer.Close();
                MessageBox.Show("luu thanh cong");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}