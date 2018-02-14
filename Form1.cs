using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SingletonDemo
{
    public partial class Form1 : Form
    {
        HoldableItem rock;
        HoldableItem stick;
        HoldableItem dirt;
        Hand hand;

        public Form1()
        {
            InitializeComponent();

            rock  = new HoldableItem("Rock",  2.0);
            stick = new HoldableItem("Stick", 1.0);
            dirt  = new HoldableItem("Dirt",  0.5);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            hand = Hand.PickUpObject(rock);
            lbl_hand.Text = hand.GetHeldObjectName();
        }

        private void btn_stick_Click(object sender, EventArgs e)
        {
            hand = Hand.PickUpObject(stick);
            lbl_hand.Text = hand.GetHeldObjectName();
        }

        private void btn_dirt_Click(object sender, EventArgs e)
        {
            hand = Hand.PickUpObject(dirt);
            lbl_hand.Text = hand.GetHeldObjectName();
        }

        private void btn_dropItem_Click(object sender, EventArgs e)
        {
            hand = Hand.DropObject();
            lbl_hand.Text = "";
        }
    }
}
