using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tugas_Praktikum_Minggu_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<string> NPizza = new List<string>();
        List<string> NMeat = new List<string>();
        List<string> NTopping = new List<string>();
        List<string> NSauce = new List<string>();
        List<string> NVF = new List<string>();

        List<int> HPizza = new List<int>();
        List<int> HMeat = new List<int>();
        List<int> HTopping = new List<int>();
        List<int> HSauce = new List<int>();
        List<int> HVF = new List<int>();

        List<int> SPizza = new List<int>();
        List<int> SMeat = new List<int>();
        List<int> STopping = new List<int>();
        List<int> SSauce = new List<int>();
        List<int> SVF = new List<int>();

        Size Icon = new Size(50, 50);

        Image Pizza;
        Point pPizza = new Point(270, 25);
        Rectangle rPizza;

        Image Meat;
        Point pMeat = new Point(270, 80);
        int xOMeat = 270;
        int yOMeat = 80;
        Rectangle rMeat;

        Image Topping;
        Point pTopping = new Point(270, 135);
        int xOTopping = 270;
        int yOTopping = 135;
        Rectangle rTopping;

        Brush Sauce;
        Point pSauce = new Point(270, 195);
        Rectangle rSauce;
            
        Image VF;
        Point pVF = new Point(270, 245);
        int xOVF = 270;
        int yOVF = 245;
        Rectangle rVF;

        Image OPizza;
        Image OMeat;
        Image OTopping;
        Brush OSauce;
        Image OVF;

        int XPizza, YPizza;
        int UPizza, TUPizza;
        int XSauce, YSauce;
        int USauce, TUSauce;
        int UBahan, TUBahan;
        bool pOrder = false;

        Image Pilih;
        List<Image> Klik = new List<Image>();
        List<int> xKlik = new List<int>();
        List<int> yKlik = new List<int>();

        bool Report = false;
        int xrPizza = 25;
        int xrMeat = 65;
        int xrTopping = 105;
        int xrSauce = 145;
        int xrVF = 185;
        int yReport = 225;

        int tSPizza;
        int tSMeat;
        int tSTopping;
        int tSSauce;
        int tSVF;

        int xNota;
        int yNota;
        string Nota;
        string HNota;
        int panjangNota;
        int totalNota;

        private void Form1_Load(object sender, EventArgs e)
        {
            rPizza = new Rectangle(pPizza, Icon);
            rMeat = new Rectangle(pMeat, Icon);
            rTopping = new Rectangle(pTopping, Icon);
            rSauce = new Rectangle(pSauce, Icon);
            rVF = new Rectangle(pVF, Icon);
            XPizza = 375;
            YPizza = 0;
            XSauce = XPizza + 25;
            YSauce = YPizza + 25;
            xNota = 375;
            yNota = 425;

            NPizza.Add("Plain Pizza");
            NPizza.Add("Black Pizza");

            NMeat.Add("Beef");
            NMeat.Add("Chicken");
            NMeat.Add("Fish");

            NTopping.Add("Cheese");
            NTopping.Add("Marshmellow");
            NTopping.Add("Shrimp");

            NSauce.Add("Ketchup");
            NSauce.Add("Mustard");
            NSauce.Add("BBQ");

            NVF.Add("Tomatoes");
            NVF.Add("Mushroom");
            NVF.Add("Pepper");
            NVF.Add("Pineapple");

            HPizza.Add(50000);
            HPizza.Add(70000);

            HMeat.Add(40000);
            HMeat.Add(25000);
            HMeat.Add(20000);

            HTopping.Add(20000);
            HTopping.Add(25000);
            HTopping.Add(30000);

            HSauce.Add(10000);
            HSauce.Add(20000);
            HSauce.Add(25000);

            HVF.Add(5000);
            HVF.Add(15000);
            HVF.Add(7500);
            HVF.Add(25000);

            SPizza.Add(10);
            SPizza.Add(10);

            SMeat.Add(10);
            SMeat.Add(10);
            SMeat.Add(10);

            STopping.Add(10);
            STopping.Add(10);
            STopping.Add(10);

            SSauce.Add(10);
            SSauce.Add(10);
            SSauce.Add(10);

            SVF.Add(10);
            SVF.Add(10);
            SVF.Add(10);
        }
        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            if (pOrder)
            {
                if (Pilih != null && (e.Location.X >= XPizza + TUPizza && e.Location.X <= XPizza + UPizza && e.Location.Y >= YPizza + TUPizza && e.Location.Y <= YPizza + UPizza))
                {
                    Klik.Add(Pilih);
                    xKlik.Add(e.Location.X - TUBahan);
                    yKlik.Add(e.Location.Y - TUBahan);
                }
                if (e.Location.X >= xOMeat && e.Location.X <= xOMeat + 50 && e.Location.Y >= yOMeat && e.Location.Y <= yOMeat + 50)
                {
                    Pilih = OMeat;
                }
                if (e.Location.X >= xOTopping && e.Location.X <= xOTopping + 50 && e.Location.Y >= yOTopping && e.Location.Y <= yOTopping + 50)
                {
                    Pilih = OTopping;
                }
                if (e.Location.X >= xOVF && e.Location.X <= xOVF + 50 && e.Location.Y >= yOVF && e.Location.Y <= yOVF + 50)
                {
                    Pilih = OVF;
                }
                this.Invalidate();
            }
            //MessageBox.Show(e.Location.ToString());
        }

        private void cbPizza_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbPizza.SelectedIndex == 0)
            {
                Pizza = Image.FromFile("plain pizza.png");
            }
            else if(cbPizza.SelectedIndex == 1)
            {
                Pizza = Image.FromFile("black pizza.png");
            }
            this.Invalidate();
        }

        private void cbMeat_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbMeat.SelectedIndex == 0)
            {
                Meat = Image.FromFile("beef.png");
            }
            else if(cbMeat.SelectedIndex == 1)
            {
                Meat = Image.FromFile("chicken.png");
            }
            else if(cbMeat.SelectedIndex == 2)
            {
                Meat = Image.FromFile("fish.png");
            }
            this.Invalidate();
        }

        private void cbTopping_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbTopping.SelectedIndex == 0)
            {
                Topping = Image.FromFile("cheese.png");
            }
            else if(cbTopping.SelectedIndex == 1)
            {
                Topping = Image.FromFile("marshmellow.png");
            }
            else if(cbTopping.SelectedIndex == 2)
            {
                Topping = Image.FromFile("shrimp.png");
            }
            this.Invalidate();
        }

        private void cbSauce_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbSauce.SelectedIndex == 0)
            {
                Sauce = new SolidBrush(Color.Red);
            }
            else if(cbSauce.SelectedIndex == 1)
            {
                Sauce = new SolidBrush(Color.Orange);
            }
            else if(cbSauce.SelectedIndex == 2)
            {
                Sauce = new SolidBrush(Color.SaddleBrown);
            }
            this.Invalidate();
        }

        private void cbVF_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbVF.SelectedIndex == 0)
            {
                VF = Image.FromFile("tomatoes.png");
            }   
            else if(cbVF.SelectedIndex == 1)
            {
                VF = Image.FromFile("mushroom.png");
            }
            else if(cbVF.SelectedIndex == 2)
            {
                VF = Image.FromFile("pepper.png");
            }
            else if(cbVF.SelectedIndex == 3)
            {
                VF = Image.FromFile("pineapple.png");
            }
            this.Invalidate();
        }
        string nl = "\n";
        private void btnOrder_Click(object sender, EventArgs e)
        {
            Pilih = null;
            Klik.Clear();
            xKlik.Clear();
            yKlik.Clear();
            panjangNota = 0;
            Nota = "";
            HNota = "";
            totalNota = 0;

            OPizza = null;
            OSauce = null;
            OMeat = null;
            OTopping = null;
            OVF = null;

            Pizza = null;
            Meat = null;
            Topping = null;
            Sauce = null;
            VF = null;

            int HSize = 0;

            if(rbSmall.Checked || rbMedium.Checked || rbLarge.Checked)
            {
                if (rbSmall.Checked)
                {
                    UPizza = 300;
                    TUPizza = 50;
                    TUSauce = TUPizza + 8;
                    UBahan = 30;
                    TUBahan = 15;
                }
                if (rbMedium.Checked)
                {
                    UPizza = 350;
                    TUPizza = 25;
                    TUSauce = TUPizza + 15;
                    UBahan = 40;
                    TUBahan = 20;
                }
                if (rbLarge.Checked)
                {
                    UPizza = 400;
                    TUPizza = 0;
                    TUSauce = TUPizza+ 20;
                    UBahan = 50;
                    TUBahan = 30;
                }
                pOrder = true;
                if (cbPizza.SelectedIndex != -1)
                {
                    if(SPizza[cbPizza.SelectedIndex] > 0)
                    {
                        SPizza[cbPizza.SelectedIndex]--;
                        cbPizza.Items[cbPizza.SelectedIndex] = NPizza[cbPizza.SelectedIndex] + " - " + SPizza[cbPizza.SelectedIndex];
                        OPizza = Pizza;
                        panjangNota += 15;
                        Nota += NPizza[cbPizza.SelectedIndex] + nl;
                        HSize = HPizza[cbPizza.SelectedIndex];
                        HNota += "Rp. " + HPizza[cbPizza.SelectedIndex].ToString("#,##0") + nl;
                        totalNota += HPizza[cbPizza.SelectedIndex];
                    }
                    else
                    {
                        MessageBox.Show(NPizza[cbPizza.SelectedIndex] + " Tidak Cukup Stock");
                    }
                    cbPizza.SelectedIndex = -1;
                }
                if (cbMeat.SelectedIndex != -1)
                {
                    if (SMeat[cbMeat.SelectedIndex] > 0)
                    {
                        SMeat[cbMeat.SelectedIndex]--;
                        cbMeat.Items[cbMeat.SelectedIndex] = NMeat[cbMeat.SelectedIndex] + " - " + SMeat[cbMeat.SelectedIndex];
                        OMeat = Meat;
                        panjangNota += 15;
                        Nota += NMeat[cbMeat.SelectedIndex] + nl;
                        HNota += "Rp. " + HMeat[cbMeat.SelectedIndex].ToString("#,##0") + nl;
                        totalNota += HMeat[cbMeat.SelectedIndex];
                    }
                    else
                    {
                        MessageBox.Show(NMeat[cbMeat.SelectedIndex] + " Tidak Cukup Stock");
                    }
                    cbMeat.SelectedIndex = -1;
                }
                if (cbTopping.SelectedIndex != -1)
                {
                    if (STopping[cbTopping.SelectedIndex] > 0)
                    {
                        STopping[cbTopping.SelectedIndex]--;
                        cbTopping.Items[cbTopping.SelectedIndex] = NTopping[cbTopping.SelectedIndex] + " - " + STopping[cbTopping.SelectedIndex];
                        OTopping = Topping;
                        panjangNota += 15;
                        Nota += NTopping[cbTopping.SelectedIndex] + nl;
                        HNota += "Rp. " + HTopping[cbTopping.SelectedIndex].ToString("#,##0") + nl;
                        totalNota += HTopping[cbTopping.SelectedIndex];
                    }
                    else
                    {
                        MessageBox.Show(NTopping[cbTopping.SelectedIndex] + " Tidak Cukup Stock");
                    }
                    cbTopping.SelectedIndex = -1;
                }
                if (cbSauce.SelectedIndex != -1)
                {
                    if (SSauce[cbSauce.SelectedIndex] > 0)
                    {
                        SSauce[cbSauce.SelectedIndex]--;
                        cbSauce.Items[cbSauce.SelectedIndex] = NSauce[cbSauce.SelectedIndex] + " - " + SSauce[cbSauce.SelectedIndex];
                        OSauce = Sauce;
                        panjangNota += 15;
                        Nota += NSauce[cbSauce.SelectedIndex] + nl;
                        HNota += "Rp. " + HSauce[cbSauce.SelectedIndex].ToString("#,##0") + nl;
                        totalNota += HSauce[cbSauce.SelectedIndex];
                    }
                    else
                    {
                        MessageBox.Show(NSauce[cbSauce.SelectedIndex] + " Tidak Cukup Stock");
                    }
                    cbSauce.SelectedIndex = -1;
                }
                if (cbVF.SelectedIndex != -1)
                {
                    if (SVF[cbVF.SelectedIndex] > 0)
                    {
                        SVF[cbVF.SelectedIndex]--;
                        cbVF.Items[cbVF.SelectedIndex] = NVF[cbVF.SelectedIndex] + " - " + SVF[cbVF.SelectedIndex];
                        OVF = VF;
                        panjangNota += 15;
                        Nota += NVF[cbVF.SelectedIndex] + nl;
                        HNota += "Rp. " + HVF[cbVF.SelectedIndex].ToString("#,##0") + nl;
                        totalNota += HVF[cbVF.SelectedIndex];
                    }
                    else
                    {
                        MessageBox.Show(NVF[cbVF.SelectedIndex] + " Tidak Cukup Stock");
                    }
                    cbVF.SelectedIndex = -1;
                }
                if(rbSmall.Checked || rbMedium.Checked || rbLarge.Checked)
                {
                    panjangNota += 15;
                    if (rbSmall.Checked)
                    {
                        Nota += "Small";
                        HNota += "Rp. " + ((int)(HSize * 0.25)).ToString("#,##0") + nl;
                        totalNota += (int)(HSize * 0.25);
                    }
                    else if (rbMedium.Checked)
                    {
                        Nota += "Medium";
                        HNota += "Rp. " + (HSize * 0.5).ToString("#,##0") + nl;
                        totalNota += (int)(HSize * 0.5);
                    }
                    else if (rbLarge.Checked)
                    {
                        Nota += "Large";
                        HNota += "Rp. " + (HSize * 0.75).ToString("#,##0") + nl;
                        totalNota += (int)(HSize * 0.75);
                    }
                }
                USauce = UPizza * 3 / 4;
                this.Invalidate();
            }
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Font fn = new Font("Arial", 16, FontStyle.Regular);
            Font fin = new Font("Arial", 12, FontStyle.Regular);
            if (Pizza != null)
            {
                g.DrawImage(Pizza, rPizza);
            }
            if(Meat != null)
            {
                g.DrawImage(Meat, rMeat);
            }
            if(Topping != null)
            {
                g.DrawImage(Topping, rTopping);
            }
            if(Sauce != null)
            {
                g.FillRectangle(Sauce, rSauce);
            }
            if(VF != null)
            {
                g.DrawImage(VF, rVF);
            }
            if (pOrder)
            {
                if(OPizza != null)
                {
                    g.DrawImage(OPizza, XPizza + TUPizza, YPizza + TUPizza, UPizza, UPizza);
                }
                if(OSauce != null)
                {
                    g.FillEllipse(OSauce, XSauce + TUSauce, YSauce + TUSauce + 10, USauce, USauce);
                }
                g.DrawRectangle(Pens.Black, xNota, yNota, 325, 150 + panjangNota);
                g.DrawString("Nota Pembelian", fn, Brushes.Black, xNota + 10, yNota + 10);
                g.DrawString(Nota, fin, Brushes.Black, xNota + 10, yNota + 75);
                g.DrawString(HNota, fin, Brushes.Black, xNota + 200, yNota + 75);
                g.FillRectangle(Brushes.Black, xNota + 10, yNota + 100 + panjangNota, 305, 10);
                g.DrawString("TOTAL", fin, Brushes.Black, xNota + 10, yNota + 120 + panjangNota);
                g.DrawString("Rp. " + totalNota.ToString("#,##0"), fin, Brushes.Black, xNota + 200, yNota + 120 + panjangNota);

            }
            for (int i = 0; i < Klik.Count; i++)
            {
                g.DrawImage(Klik[i], xKlik[i], yKlik[i], UBahan, UBahan);
            }
        }

        private void gbStok_Paint(object sender, PaintEventArgs e)
        {
            if (Report)
            {
                Graphics g = e.Graphics;
                Font fr = new Font("Arial", 14, FontStyle.Regular);
                g.FillRectangle(Brushes.Yellow, xrPizza, yReport - 15 * tSPizza, 40, tSPizza * 15);

                if(tSPizza.ToString().Length > 1)
                {
                    g.DrawString(tSPizza.ToString(), fr, Brushes.Black, xrPizza + 5, yReport - 30);
                }
                else if(tSPizza.ToString().Length == 1)
                {
                    g.DrawString(tSPizza.ToString(), fr, Brushes.Black, xrPizza + 10, yReport - 30);
                }

                g.FillRectangle(Brushes.Lime, xrMeat, yReport - 15 * tSMeat, 40, tSMeat * 15);

                if (tSMeat.ToString().Length > 1)
                {
                    g.DrawString(tSMeat.ToString(), fr, Brushes.Black, xrMeat + 5, yReport - 30);
                }
                else if (tSMeat.ToString().Length == 1)
                {
                    g.DrawString(tSMeat.ToString(), fr, Brushes.Black, xrMeat + 10, yReport - 30);
                }

                g.FillRectangle(Brushes.Cyan, xrTopping, yReport - 15 * tSTopping, 40, tSTopping * 15);

                if (tSTopping.ToString().Length > 1)
                {
                    g.DrawString(tSTopping.ToString(), fr, Brushes.Black, xrTopping + 5, yReport - 30);
                }
                else if (tSTopping.ToString().Length == 1)
                {
                    g.DrawString(tSTopping.ToString(), fr, Brushes.Black, xrTopping + 10, yReport - 30);
                }

                g.FillRectangle(Brushes.Pink, xrSauce, yReport - 15 * tSSauce, 40, tSSauce * 15);

                if (tSSauce.ToString().Length > 1)
                {
                    g.DrawString(tSSauce.ToString(), fr, Brushes.Black, xrSauce + 5, yReport - 30);
                }
                else if (tSSauce.ToString().Length == 1)
                {
                    g.DrawString(tSSauce.ToString(), fr, Brushes.Black, xrSauce + 10, yReport - 30);
                }

                g.FillRectangle(Brushes.Purple, xrVF, yReport - 15 * tSVF, 40, tSVF * 15);

                if (tSVF.ToString().Length > 1)
                {
                    g.DrawString(tSVF.ToString(), fr, Brushes.Black, xrVF + 5, yReport - 30);
                }
                else if (tSVF.ToString().Length == 1)
                {
                    g.DrawString(tSVF.ToString(), fr, Brushes.Black, xrVF + 10, yReport - 30);
                }
            }
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            tSPizza = 0;
            for (int i = 0; i < SPizza.Count; i++)
            {
                tSPizza += SPizza[i];
            }
            tSPizza = tSPizza / SPizza.Count;

            tSMeat = 0;
            for(int i = 0; i < SMeat.Count; i++)
            {
                tSMeat += SMeat[i];
            }
            tSMeat = tSMeat / SMeat.Count;

            tSTopping = 0;
            for(int i = 0; i < STopping.Count; i++)
            {
                tSTopping += STopping[i];
            }
            tSTopping = tSTopping / STopping.Count;

            tSSauce = 0;
            for(int i = 0; i < SSauce.Count; i++)
            {
                tSSauce += SSauce[i];
            }
            tSSauce = tSSauce / SSauce.Count;

            tSVF = 0;
            for (int i = 0; i < SVF.Count; i++)
            {
                tSVF += SVF[i];
            }
            tSVF = tSVF / SVF.Count;

            Report = true;

            gbStok.Invalidate();
        }
    }
}
