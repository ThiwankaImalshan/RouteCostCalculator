using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RouteCostCalculator
{

    public partial class Form1 : Form
    {
        long Ref = 374990417360;
        string[] Destin = { "Colombo", "Maligawatte", "Kelanitissa", "4th Mile Post", "Thorana junction", "Kelani campus", "Kirirbathgoda", "Mahara junction", "Kadawatha", "Gonahena junction", "Indigahamula junction", "Kirillawala", "Trackmo junction", "Mudungoda", "Miriswatte", "Yakkala", "Aluthgama", "Kalagedihena", "Thihariya", "Sangabodhi", "Nittambuwa", "Kalalpitiya", "Pasyala", "Kajugama", "Radawadunna", "Wewaldeniya", "Danowita", "Dummaladeniya", "Warakapola", "Ambepussa", "Mahena", "Tholangamuwa", "Gasnawa Junction", "Nelumdeniya", "Batapothella", "Siyambalapitiya", "Ballapana Junction", "Galigamuwa", "Ambanpitiya", "Ranwala Junction", "Kegalle", "Meepitiya", "Karadupona", "Molagoda", "Mangalagama", "Uthuwankanda", "Anwarama", "Mawanella", "Beligammana", "Hegula", "Ganethanna", "Pahala Kadugannawa", "Kadugannawa", "Henawala", "Pilimathalawa", "Ambilmeegama", "Kiribathkumbura", "Peradeniya", "Getambe", "Mulgampola", "Kandy" };
        string[] Journey = {"0 KM","1 KM","2 KM","4 KM","8 KM","10 KM","12 KM","14 KM","16 KM","18 KM","20 KM","22 KM","24 KM","26 KM","28 KM", "30 KM", "32 KM", "34 KM", "36 KM", "38 KM", "40 KM", "42 KM", "44 KM", "46 KM", "48 KM", "50 KM", "52 KM", "54 KM", "56 KM", "58 KM", "60 KM", "62 KM", "64 KM", "66 KM", "68 KM", "70 KM", "72 KM", "74 KM", "76 KM", "78 KM", "80 KM", "82 KM", "84 KM", "86 KM", "88 KM", "90 KM", "92 KM", "94 KM", "96 KM", "98 KM", "100 KM", "102 KM", "104 KM", "106 KM", "108 KM", "110 KM", "112 KM", "114 KM", "116 KM", "118 KM", "120 KM"};
        float[] Fare = { 0, 30, 38, 50, 61, 73, 84, 96, 99, 107, 115, 122, 128, 136, 143, 149, 155, 163, 168, 176, 182, 189, 195, 203, 209, 216, 222, 230, 235, 243, 251, 256, 264, 270, 277, 283, 291, 297, 304, 310, 318, 323, 331, 337, 344, 350, 358, 364, 371, 377, 385, 390, 398, 404, 411, 419, 425, 432, 438, 446, 452 };
        float[] FareChild = { 0, 15, 19, 25, 30.5F, 36.5F, 42, 48, 49.5F, 53.5F, 57.5F, 61, 64, 68, 71.5F, 74.5F, 77.5F, 81.5F, 84, 88, 91, 94.5F, 97.5F, 101.5F, 104.5F, 108, 111, 115, 117.5F, 121.5F, 125.5F, 128, 132, 135, 138.5F, 141.5F, 145.5F, 148.5F, 152, 155, 159, 161.5F, 165.5F, 168.5F, 172, 175, 179, 182, 185.5F, 188.5F, 192.5F, 195, 199, 202, 205.5F, 209.5F, 212.5F, 216, 219, 223, 226 };
        public Form1()
        {
            InitializeComponent();
        }

        private void btnClick_Click(object sender, EventArgs e)
        {
            
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < Destin.Length; i++)
            {
                ComboFrom.Items.Add(Destin[i]);
                ComboTo.Items.Add(Destin[i]);
            }
        }

        private void BtnCalculate_Click(object sender, EventArgs e)
        {
            int Temp;
            Temp = Math.Abs(ComboFrom.SelectedIndex - ComboTo.SelectedIndex); //Reduce Index and remove negative sign
            float ObjTwo;
            float ObjThree;
            string Obj2 = Journey[Temp];
            float Obj1;
            Obj1 = FareChild[Temp];
            float Obj;
            Obj = Fare[Temp];
            Ref++;

            if (ComboPass.SelectedIndex > -1 && ComboPass12.SelectedIndex > -1)
            {
                ObjTwo = float.Parse(ComboPass.Text) * Obj;
                ObjThree = float.Parse(ComboPass12.Text) * Obj1;
                lblTotFare.Text = String.Format("Rs. " + "{0:F2}", (ObjThree + ObjTwo));
            }
            else if (ComboPass12.SelectedIndex > -1)
            {
                ObjThree = float.Parse(ComboPass12.Text) * Obj1;
                lblTotFare.Text = String.Format("Rs. " + "{0:F2}", ObjThree);
            }
            else if (ComboPass.SelectedIndex > -1)
            {
                ObjTwo = float.Parse(ComboPass.Text) * Obj;
                lblTotFare.Text = String.Format("Rs. " + "{0:F2}", ObjTwo);
            }
            else
            {
                lblTotFare.Text = String.Format("Rs. " + "{0:F2}", Obj);
            }

           
            RtbBill.AppendText("                                                                      " + Environment.NewLine);
            RtbBill.AppendText("----------------------------------------------------------------------" + Environment.NewLine);

            RtbBill.SelectionFont = new Font("Arial", 9, FontStyle.Bold);
            RtbBill.AppendText("COLOMBO" + Environment.NewLine);

            RtbBill.SelectionFont = new Font("Arial", 8);
            RtbBill.AppendText("BN:GD-9878 Normal CN#:Colombo RT#:001" + Environment.NewLine);

            RtbBill.SelectionFont = new Font("Arial", 9, FontStyle.Bold);
            RtbBill.AppendText("Ref: "+ Ref + Environment.NewLine);

            RtbBill.SelectionFont = new Font("Arial", 8);
            RtbBill.AppendText("T:"+DateTime.Now.ToLongTimeString()+"\t"+"D:"+ DateTime.Now.ToShortDateString() + Environment.NewLine);

            RtbBill.SelectionFont = new Font("Arial", 8);
            RtbBill.AppendText("Route: 001 Colombo-Kandy" + Environment.NewLine);

            RtbBill.SelectionFont = new Font("Arial", 9);
            RtbBill.AppendText(ComboFrom.Text.ToUpper()+" - "+ComboTo.Text.ToUpper() + Environment.NewLine);

            RtbBill.SelectionFont = new Font("Arial", 7);
            RtbBill.AppendText("(Journey - "+ Obj2+")" + Environment.NewLine);

            if (ComboPass.SelectedIndex > -1 && ComboPass12.SelectedIndex > -1)
            {
                RtbBill.SelectionFont = new Font("Arial", 7);
                RtbBill.AppendText("Full: " + ComboPass.Text + "*" + Obj + "=" + (float.Parse(ComboPass.Text) * Obj) + Environment.NewLine);

                RtbBill.SelectionFont = new Font("Arial", 7);
                RtbBill.AppendText("Half: " + ComboPass12.Text + "*" + Obj1 + "=" + (float.Parse(ComboPass12.Text) * Obj1) + Environment.NewLine);
            }
            else if (ComboPass.SelectedIndex > -1)
            {
                RtbBill.SelectionFont = new Font("Arial", 7);
                RtbBill.AppendText("Full: " + ComboPass.Text + "*" + Obj + "=" + (float.Parse(ComboPass.Text) * Obj) + Environment.NewLine);
            }
            else if (ComboPass12.SelectedIndex > -1)
            {
                RtbBill.SelectionFont = new Font("Arial", 7);
                RtbBill.AppendText("Half: " + ComboPass12.Text + "*" + Obj1 + "=" + (float.Parse(ComboPass12.Text) * Obj1) + Environment.NewLine);
            }

            RtbBill.SelectionFont = new Font("Arial", 9, FontStyle.Bold);
            RtbBill.AppendText("TOTAL : "+ lblTotFare.Text+ Environment.NewLine);

            RtbBill.SelectionFont = new Font("Arial", 7);
            RtbBill.AppendText("Depot Hotline: 0117706580" + Environment.NewLine);
            RtbBill.AppendText("----------------------------------------------------------------------" + Environment.NewLine);

            //align all in rich text box
            RtbBill.SelectAll();
            RtbBill.SelectionAlignment = HorizontalAlignment.Center;

            // set the current caret position to the end
            RtbBill.SelectionStart = RtbBill.Text.Length;
            // scroll it automatically
            RtbBill.ScrollToCaret();

            ComboPass.SelectedIndex = -1;
            ComboPass12.SelectedIndex = -1;
        }

        private void GrB1_Click(object sender, EventArgs e)
        {

        }
    }
}
