using Microsoft.WindowsAPICodePack.Dialogs;
using Progress_Bar_App.Models;
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
using System.Drawing.Imaging;

namespace Progress_Bar_App
{
    public partial class Form1 : Form
    {
        public static readonly List<string> ImageExtensions = new List<string> { ".JPG", ".JPE", ".BMP", ".GIF", ".PNG" };
        ImageList il = new ImageList();
        List<Comic> comics = new List<Comic>();
        public Form1()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            /*
            if(string.IsNullOrEmpty(textBoxName.Text) || string.IsNullOrEmpty(textBoxMax.Text))
            {
                return;
            }
            else
            {
                ListViewItem item = new ListViewItem();

                
                //item.SubItems.Add(textBoxImagePathAdd.Text);
                //item.SubItems.Add(textBoxName.Text);
                item.SubItems.Add("PROGRESS");
                item.SubItems.Add(textBoxMax.Text);
                if (string.IsNullOrEmpty(textBoxActualValue.Text))
                {
                    item.SubItems.Add("0");
                }
                else
                {
                    item.SubItems.Add(textBoxActualValue.Text);
                }
                il.Images.Add(pictureBoxAdd.Image);

                listView1.SmallImageList = il;
                listView1.Items.Add(textBoxName.Text, listView1.Items.Count);

                listView1.Items.Add(item);

                ProgressBar pb = new ProgressBar();
                int ProgressValue = Convert.ToInt32(textBoxActualValue.Text);
                int ProgressMax = Convert.ToInt32(textBoxMax.Text);
                Rectangle r = new Rectangle();
                r = item.SubItems[1].Bounds;
                pb.Value = ProgressValue;
                pb.Maximum = ProgressMax;
                pb.SetBounds(r.X, r.Y, r.Width, r.Height);

                listView1.Controls.Add(pb);

                



                textBoxName.Clear();
                textBoxMax.Clear();
                textBoxActualValue.Clear();
            }
            */
        }

        

        private void search_Click(object sender, EventArgs e)
        {
            CommonOpenFileDialog open = new CommonOpenFileDialog();
            open.IsFolderPicker = true;
            if (open.ShowDialog() == CommonFileDialogResult.Ok)
            {
                
                string[] fileEntries = Directory.GetDirectories(open.FileName);
                int index = 1;
                foreach (string fileName in fileEntries)
                {
                    Console.WriteLine("Achou: {0}", fileName);
                    if (Directory.Exists(fileName))
                    {
                        Console.WriteLine("Achou uma comic");
                        Comic comicToAdd = new Comic();
                        comicToAdd.id = index;
                        index++;
                        comicToAdd.name = Path.GetFileName(fileName);
                        string[] ComicContent = Directory.GetFiles(fileName);
                        Console.WriteLine("Lendo" + fileName);
                        foreach (string comicFile in ComicContent)
                        {
                            if (File.Exists(comicFile))
                            {
                                if (ImageExtensions.Contains(Path.GetExtension(comicFile).ToUpperInvariant()))
                                {
                                    comicToAdd.max++;
                                    if (comicToAdd.image == null)
                                        comicToAdd.image = new Bitmap(comicFile);
                                }
                                else
                                {
                                    comicToAdd.value++;
                                }
                            }
                        }
                        int percentComplete = (int)(0.5f + ((100f * comicToAdd.value) / comicToAdd.max));
                        
                        comicToAdd.Progress = generate_pp(percentComplete);
                        comics.Add(comicToAdd);
                    }
                    else
                    {
                        Console.WriteLine("{0} is not a valid file or directory.", fileName);
                    }
                }
                Console.WriteLine("achou {0} comics", index);
                dataGridView1.DataSource = comics;
            }
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //searchGrid();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.RowTemplate.Height = 200;
        }

        public Image generate_pp(double pass)
        {
            double dgpp_d = double.Parse(dgpp_b.Width.ToString());
            double x = 0;

            x = (pass * dgpp_d) / 100;

            
            dgpp.Width = (int)Math.Round(x, 0);
            return PanelToBitmap(dgpp_b);
        }
        private static Image PanelToBitmap(Control pnl)
        {
            var bmp = new Bitmap(pnl.Width, pnl.Height);
            pnl.DrawToBitmap(bmp, new Rectangle(0, 0, bmp.Width, bmp.Height));
            return bmp;
        }

        public void printDatagrid(DataGridView gridToPrint)
        {
            int DGVOriginalHeight = gridToPrint.Height;
            gridToPrint.Height = (gridToPrint.RowCount * gridToPrint.RowTemplate.Height) +
                                    gridToPrint.ColumnHeadersHeight;

            using (Bitmap bitmap = new Bitmap(gridToPrint.Width, gridToPrint.Height))
            {
                gridToPrint.DrawToBitmap(bitmap, new Rectangle(Point.Empty, gridToPrint.Size));
                string DesktopFolder = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
                bitmap.Save(Path.Combine(DesktopFolder, "gridToPrint.png"), ImageFormat.Png);
            }
            gridToPrint.Height = DGVOriginalHeight;
        }
        public void searchGrid()
        {
            //IEnumerable<string> result = comics.Where(s => s.Contains(SearchComic.Text));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            searchGrid();
        }

        private void printImage_Click(object sender, EventArgs e)
        {
            printDatagrid(dataGridView1);
        }
    }
}
