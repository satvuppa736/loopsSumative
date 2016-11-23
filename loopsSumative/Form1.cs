﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace loopsSumative
{
    public partial class Form1 : Form
    { 
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            startLabel.Visible = false;
            Graphics fg = this.CreateGraphics();
            Font drawFont = new Font("OCR A Std", 12, FontStyle.Bold);
            SolidBrush drawBrush = new SolidBrush(Color.LimeGreen);

            string line1 = "Your mission is as follows:";

            for (int i = 0; i <= line1.Length; i++)
            {
                fg.DrawString(line1.Substring(0,i), drawFont, drawBrush, 10, 20);
                Thread.Sleep(100);
            }

            string line2 = "The Death Star needs to be destroyed";
            for (int n = 0; n <= line2.Length; n++)
            {
                fg.DrawString(line2.Substring(0, n), drawFont, drawBrush, 10, 40);
                Thread.Sleep(100);
            }
            string line3 = "You need to fly by and drop the bomb in the opening.";
            for (int x = 0; x <= line3.Length; x++)
            {
                fg.DrawString(line3.Substring(0, x), drawFont, drawBrush, 10, 60);
                Thread.Sleep(100);
            }
            string line4 = "The main reactor is exposed there. Good Luck.";
            for (int a = 0; a <= line4.Length; a++)
            {
                fg.DrawString(line4.Substring(0, a), drawFont, drawBrush, 10, 80);
                Thread.Sleep(100);
            }



            #region EXTRA CODE IF NEEDED
            //#region DRAWING INTRO

            //fg.DrawString("Y", drawFont, drawBrush, 10, 20);
            //Thread.Sleep(100);
            //fg.Clear(Color.Black);
            //fg.DrawString("Yo", drawFont, drawBrush, 10, 20);
            //Thread.Sleep(100);
            //fg.Clear(Color.Black);
            //fg.DrawString("You", drawFont, drawBrush, 10, 20);
            //Thread.Sleep(100);
            //fg.Clear(Color.Black);
            //fg.DrawString("Your", drawFont, drawBrush, 10, 20);
            //Thread.Sleep(100);
            //fg.Clear(Color.Black);
            //fg.DrawString("Your m", drawFont, drawBrush, 10, 20);
            //Thread.Sleep(100);
            //fg.Clear(Color.Black);
            //fg.DrawString("Your mi", drawFont, drawBrush, 10, 20);
            //Thread.Sleep(100);
            //fg.Clear(Color.Black);
            //fg.DrawString("Your mis", drawFont, drawBrush, 10, 20);
            //Thread.Sleep(100);
            //fg.Clear(Color.Black);
            //fg.DrawString("Your miss", drawFont, drawBrush, 10, 20);
            //Thread.Sleep(100);
            //fg.Clear(Color.Black);
            //fg.DrawString("Your missi", drawFont, drawBrush, 10, 20);
            //Thread.Sleep(100);
            //fg.Clear(Color.Black);
            //fg.DrawString("Your missio", drawFont, drawBrush, 10, 20);
            //Thread.Sleep(100);
            //fg.Clear(Color.Black);
            //fg.DrawString("Your mission", drawFont, drawBrush, 10, 20);
            //Thread.Sleep(100);
            //fg.Clear(Color.Black);
            //fg.DrawString("Your mission i", drawFont, drawBrush, 10, 20);
            //Thread.Sleep(100);
            //fg.Clear(Color.Black);
            //fg.DrawString("Your mission is", drawFont, drawBrush, 10, 20);
            //Thread.Sleep(100);
            //fg.Clear(Color.Black);
            //fg.DrawString("Your mission is a", drawFont, drawBrush, 10, 20);
            //Thread.Sleep(100);
            //fg.Clear(Color.Black);
            //fg.DrawString("Your mission is as", drawFont, drawBrush, 10, 20);
            //Thread.Sleep(100);
            //fg.Clear(Color.Black);
            //fg.DrawString("Your mission is as f", drawFont, drawBrush, 10, 20);
            //Thread.Sleep(100);
            //fg.Clear(Color.Black);
            //fg.DrawString("Your mission is as fo", drawFont, drawBrush, 10, 20);
            //Thread.Sleep(100);
            //fg.Clear(Color.Black);
            //fg.DrawString("Your mission is as fol", drawFont, drawBrush, 10, 20);
            //Thread.Sleep(100);
            //fg.Clear(Color.Black);
            //fg.DrawString("Your mission is as foll", drawFont, drawBrush, 10, 20);
            //Thread.Sleep(100);
            //fg.Clear(Color.Black);
            //fg.DrawString("Your mission is as follo", drawFont, drawBrush, 10, 20);
            //Thread.Sleep(100);
            //fg.Clear(Color.Black);
            //fg.DrawString("Your mission is as follow", drawFont, drawBrush, 10, 20);
            //Thread.Sleep(100);
            //fg.Clear(Color.Black);
            //fg.DrawString("Your mission is as follows", drawFont, drawBrush, 10, 20);
            //Thread.Sleep(100);
            //fg.Clear(Color.Black);
            //fg.DrawString("Your mission is as follows:", drawFont, drawBrush, 10, 20);
            //#endregion

            //#region DRAWING FIRST LINE

            //fg.DrawString("Your mission is as follows:", drawFont, drawBrush, 10, 20);
            //fg.DrawString("T", drawFont, drawBrush, 10, 40);
            //Thread.Sleep(100);
            //fg.Clear(Color.Black);
            //fg.DrawString("Your mission is as follows:", drawFont, drawBrush, 10, 20);
            //fg.DrawString("Th", drawFont, drawBrush, 10, 40);
            //Thread.Sleep(100);
            //fg.Clear(Color.Black);
            //fg.DrawString("Your mission is as follows:", drawFont, drawBrush, 10, 20);
            //fg.DrawString("The", drawFont, drawBrush, 10, 40);
            //Thread.Sleep(100);
            //fg.Clear(Color.Black);
            //fg.DrawString("Your mission is as follows:", drawFont, drawBrush, 10, 20);
            //fg.DrawString("The D", drawFont, drawBrush, 10, 40);
            //Thread.Sleep(100);
            //fg.Clear(Color.Black);
            //fg.DrawString("Your mission is as follows:", drawFont, drawBrush, 10, 20);
            //fg.DrawString("The Dea", drawFont, drawBrush, 10, 40);
            //Thread.Sleep(100);
            //fg.Clear(Color.Black);
            //fg.DrawString("Your mission is as follows:", drawFont, drawBrush, 10, 20);
            //fg.DrawString("The Deat", drawFont, drawBrush, 10, 40);
            //Thread.Sleep(100);
            //fg.Clear(Color.Black);
            //fg.DrawString("Your mission is as follows:", drawFont, drawBrush, 10, 20);
            //fg.DrawString("The Death", drawFont, drawBrush, 10, 40);
            //Thread.Sleep(100);
            //fg.Clear(Color.Black);
            //fg.DrawString("Your mission is as follows:", drawFont, drawBrush, 10, 20);
            //fg.DrawString("The Death S", drawFont, drawBrush, 10, 40);
            //Thread.Sleep(100);
            //fg.Clear(Color.Black);
            //fg.DrawString("Your mission is as follows:", drawFont, drawBrush, 10, 20);
            //fg.DrawString("The Death St", drawFont, drawBrush, 10, 40);
            //Thread.Sleep(100);
            //fg.Clear(Color.Black);
            //fg.DrawString("Your mission is as follows:", drawFont, drawBrush, 10, 20);
            //fg.DrawString("The Death Sta", drawFont, drawBrush, 10, 40);
            //Thread.Sleep(100);
            //fg.DrawString("Your mission is as follows:", drawFont, drawBrush, 10, 20);
            //fg.DrawString("The Death Star", drawFont, drawBrush, 10, 40);
            //Thread.Sleep(100);
            //fg.DrawString("Your mission is as follows:", drawFont, drawBrush, 10, 20);
            //fg.DrawString("The Death Star n", drawFont, drawBrush, 10, 40);
            //Thread.Sleep(100);
            //fg.Clear(Color.Black);
            //fg.DrawString("Your mission is as follows:", drawFont, drawBrush, 10, 20);
            //fg.DrawString("The Death Star ne", drawFont, drawBrush, 10, 40);
            //Thread.Sleep(100);
            //fg.Clear(Color.Black);
            //fg.DrawString("Your mission is as follows:", drawFont, drawBrush, 10, 20);
            //fg.DrawString("The Death Star nee", drawFont, drawBrush, 10, 40);
            //Thread.Sleep(100);
            //fg.Clear(Color.Black);
            //fg.DrawString("Your mission is as follows:", drawFont, drawBrush, 10, 20);
            //fg.DrawString("The Death Star need", drawFont, drawBrush, 10, 40);
            //Thread.Sleep(100);
            //fg.Clear(Color.Black);
            //fg.DrawString("Your mission is as follows:", drawFont, drawBrush, 10, 20);
            //fg.DrawString("The Death Star needs", drawFont, drawBrush, 10, 40);
            //Thread.Sleep(100);
            //fg.Clear(Color.Black);
            //fg.DrawString("Your mission is as follows:", drawFont, drawBrush, 10, 20);
            //fg.DrawString("The Death Star needs t", drawFont, drawBrush, 10, 40);
            //Thread.Sleep(100);
            //fg.Clear(Color.Black);
            //fg.DrawString("Your mission is as follows:", drawFont, drawBrush, 10, 20);
            //fg.DrawString("The Death Star needs to", drawFont, drawBrush, 10, 40);
            //Thread.Sleep(100);
            //fg.Clear(Color.Black);
            //fg.DrawString("Your mission is as follows:", drawFont, drawBrush, 10, 20);
            //fg.DrawString("The Death Star needs to b", drawFont, drawBrush, 10, 40);
            //Thread.Sleep(100);
            //fg.Clear(Color.Black);
            //fg.DrawString("Your mission is as follows:", drawFont, drawBrush, 10, 20);
            //fg.DrawString("The Death Star needs to be", drawFont, drawBrush, 10, 40);
            //Thread.Sleep(100);
            //fg.Clear(Color.Black);
            //fg.DrawString("Your mission is as follows:", drawFont, drawBrush, 10, 20);
            //fg.DrawString("The Death Star needs to be de", drawFont, drawBrush, 10, 40);
            //Thread.Sleep(100);
            //fg.Clear(Color.Black);
            //fg.DrawString("Your mission is as follows:", drawFont, drawBrush, 10, 20);
            //fg.DrawString("The Death Star needs to be des", drawFont, drawBrush, 10, 40);
            //Thread.Sleep(100);
            //fg.Clear(Color.Black);
            //fg.DrawString("Your mission is as follows:", drawFont, drawBrush, 10, 20);
            //fg.DrawString("The Death Star needs to be dest", drawFont, drawBrush, 10, 40);
            //Thread.Sleep(100);
            //fg.Clear(Color.Black);
            //fg.DrawString("Your mission is as follows:", drawFont, drawBrush, 10, 20);
            //fg.DrawString("The Death Star needs to be destr", drawFont, drawBrush, 10, 40);
            //Thread.Sleep(100);
            //fg.Clear(Color.Black);
            //fg.DrawString("Your mission is as follows:", drawFont, drawBrush, 10, 20);
            //fg.DrawString("The Death Star needs to be destro", drawFont, drawBrush, 10, 40);
            //Thread.Sleep(100);
            //fg.Clear(Color.Black);
            //fg.DrawString("Your mission is as follows:", drawFont, drawBrush, 10, 20);
            //fg.DrawString("The Death Star needs to be destroye", drawFont, drawBrush, 10, 40);
            //Thread.Sleep(100);
            //fg.Clear(Color.Black);
            //fg.DrawString("Your mission is as follows:", drawFont, drawBrush, 10, 20);
            //fg.DrawString("The Death Star needs to be destroyed.", drawFont, drawBrush, 10, 40);
            //#endregion

            //#region DRAWING SECOND LINE
            //fg.DrawString("Your mission is as follows:", drawFont, drawBrush, 10, 20);
            //fg.DrawString("The Death Star needs to be destroyed.", drawFont, drawBrush, 10, 40);
            //fg.DrawString("Yo", drawFont, drawBrush, 10, 60);
            //Thread.Sleep(100);
            //fg.Clear(Color.Black);
            //fg.DrawString("Your mission is as follows:", drawFont, drawBrush, 10, 20);
            //fg.DrawString("The Death Star needs to be destroyed.", drawFont, drawBrush, 10, 40);
            //fg.DrawString("You", drawFont, drawBrush, 10, 60);
            //Thread.Sleep(100);
            //fg.Clear(Color.Black);
            //fg.DrawString("Your mission is as follows:", drawFont, drawBrush, 10, 20);
            //fg.DrawString("The Death Star needs to be destroyed.", drawFont, drawBrush, 10, 40);
            //fg.DrawString("You n", drawFont, drawBrush, 10, 60);
            //Thread.Sleep(100);
            //fg.Clear(Color.Black);
            //fg.DrawString("Your mission is as follows:", drawFont, drawBrush, 10, 20);
            //fg.DrawString("The Death Star needs to be destroyed.", drawFont, drawBrush, 10, 40);
            //fg.DrawString("You nee", drawFont, drawBrush, 10, 60);
            //Thread.Sleep(100);
            //fg.Clear(Color.Black);
            //fg.DrawString("Your mission is as follows:", drawFont, drawBrush, 10, 20);
            //fg.DrawString("The Death Star needs to be destroyed.", drawFont, drawBrush, 10, 40);
            //fg.DrawString("You need", drawFont, drawBrush, 10, 60);
            //Thread.Sleep(100);
            //fg.Clear(Color.Black);
            //fg.DrawString("Your mission is as follows:", drawFont, drawBrush, 10, 20);
            //fg.DrawString("The Death Star needs to be destroyed.", drawFont, drawBrush, 10, 40);
            //fg.DrawString("You need t", drawFont, drawBrush, 10, 60);
            //Thread.Sleep(100);
            //fg.DrawString("Your mission is as follows:", drawFont, drawBrush, 10, 20);
            //fg.DrawString("The Death Star needs to be destroyed.", drawFont, drawBrush, 10, 40);
            //fg.DrawString("You need to", drawFont, drawBrush, 10, 60);
            //Thread.Sleep(100);
            //fg.Clear(Color.Black);
            //fg.DrawString("Your mission is as follows:", drawFont, drawBrush, 10, 20);
            //fg.DrawString("The Death Star needs to be destroyed.", drawFont, drawBrush, 10, 40);
            //fg.DrawString("You need to d", drawFont, drawBrush, 10, 60);
            //Thread.Sleep(100);
            //fg.Clear(Color.Black);
            //fg.DrawString("Your mission is as follows:", drawFont, drawBrush, 10, 20);
            //fg.DrawString("The Death Star needs to be destroyed.", drawFont, drawBrush, 10, 40);
            //fg.DrawString("You need to dr", drawFont, drawBrush, 10, 60);
            //Thread.Sleep(100);
            //fg.Clear(Color.Black);
            //fg.DrawString("Your mission is as follows:", drawFont, drawBrush, 10, 20);
            //fg.DrawString("The Death Star needs to be destroyed.", drawFont, drawBrush, 10, 40);
            //fg.DrawString("You need to dro", drawFont, drawBrush, 10, 60);
            //Thread.Sleep(100);
            //fg.Clear(Color.Black);
            //fg.DrawString("Your mission is as follows:", drawFont, drawBrush, 10, 20);
            //fg.DrawString("The Death Star needs to be destroyed.", drawFont, drawBrush, 10, 40);
            //fg.DrawString("You need to drop", drawFont, drawBrush, 10, 60);
            //Thread.Sleep(100);
            //fg.Clear(Color.Black);
            //fg.DrawString("Your mission is as follows:", drawFont, drawBrush, 10, 20);
            //fg.DrawString("The Death Star needs to be destroyed.", drawFont, drawBrush, 10, 40);
            //fg.DrawString("You need to drop t", drawFont, drawBrush, 10, 60);
            //Thread.Sleep(100);
            //fg.DrawString("Your mission is as follows:", drawFont, drawBrush, 10, 20);
            //fg.DrawString("The Death Star needs to be destroyed.", drawFont, drawBrush, 10, 40);
            //fg.DrawString("You need to drop th", drawFont, drawBrush, 10, 60);
            //Thread.Sleep(100);
            //fg.Clear(Color.Black);
            //fg.DrawString("Your mission is as follows:", drawFont, drawBrush, 10, 20);
            //fg.DrawString("The Death Star needs to be destroyed.", drawFont, drawBrush, 10, 40);
            //fg.DrawString("You need to drop the", drawFont, drawBrush, 10, 60);
            //Thread.Sleep(100);
            //fg.Clear(Color.Black);
            //fg.DrawString("Your mission is as follows:", drawFont, drawBrush, 10, 20);
            //fg.DrawString("The Death Star needs to be destroyed.", drawFont, drawBrush, 10, 40);
            //fg.DrawString("You need to drop the b", drawFont, drawBrush, 10, 60);
            //Thread.Sleep(100);
            //fg.Clear(Color.Black);
            //fg.DrawString("Your mission is as follows:", drawFont, drawBrush, 10, 20);
            //fg.DrawString("The Death Star needs to be destroyed.", drawFont, drawBrush, 10, 40);
            //fg.DrawString("You need to drop the bo", drawFont, drawBrush, 10, 60);
            //Thread.Sleep(100);
            //fg.Clear(Color.Black);
            //fg.DrawString("Your mission is as follows:", drawFont, drawBrush, 10, 20);
            //fg.DrawString("The Death Star needs to be destroyed.", drawFont, drawBrush, 10, 40);
            //fg.DrawString("You need to drop the bom", drawFont, drawBrush, 10, 60);
            //Thread.Sleep(100);
            //fg.Clear(Color.Black);
            //fg.DrawString("Your mission is as follows:", drawFont, drawBrush, 10, 20);
            //fg.DrawString("The Death Star needs to be destroyed.", drawFont, drawBrush, 10, 40);
            //fg.DrawString("You need to drop the bomb", drawFont, drawBrush, 10, 60);
            //Thread.Sleep(100);
            //fg.Clear(Color.Black);
            //fg.DrawString("Your mission is as follows:", drawFont, drawBrush, 10, 20);
            //fg.DrawString("The Death Star needs to be destroyed.", drawFont, drawBrush, 10, 40);
            //fg.DrawString("You need to drop the bomb i", drawFont, drawBrush, 10, 60);
            //Thread.Sleep(100);
            //fg.Clear(Color.Black);
            //fg.DrawString("Your mission is as follows:", drawFont, drawBrush, 10, 20);
            //fg.DrawString("The Death Star needs to be destroyed.", drawFont, drawBrush, 10, 40);
            //fg.DrawString("You need to drop the bomb in", drawFont, drawBrush, 10, 60); Thread.Sleep(100);
            //Thread.Sleep(100);
            //fg.Clear(Color.Black);
            //fg.DrawString("Your mission is as follows:", drawFont, drawBrush, 10, 20);
            //fg.DrawString("The Death Star needs to be destroyed.", drawFont, drawBrush, 10, 40);
            //fg.DrawString("You need to drop the bomb in t", drawFont, drawBrush, 10, 60); Thread.Sleep(100);
            //Thread.Sleep(100);
            //fg.Clear(Color.Black);
            //fg.DrawString("Your mission is as follows:", drawFont, drawBrush, 10, 20);
            //fg.DrawString("The Death Star needs to be destroyed.", drawFont, drawBrush, 10, 40);
            //fg.DrawString("You need to drop the bomb in th", drawFont, drawBrush, 10, 60); Thread.Sleep(100);
            //Thread.Sleep(100);
            //fg.Clear(Color.Black);
            //fg.DrawString("Your mission is as follows:", drawFont, drawBrush, 10, 20);
            //fg.DrawString("The Death Star needs to be destroyed.", drawFont, drawBrush, 10, 40);
            //fg.DrawString("You need to drop the bomb in the", drawFont, drawBrush, 10, 60);
            //Thread.Sleep(100);
            //fg.Clear(Color.Black);
            //fg.DrawString("Your mission is as follows:", drawFont, drawBrush, 10, 20);
            //fg.DrawString("The Death Star needs to be destroyed.", drawFont, drawBrush, 10, 40);
            //fg.DrawString("You need to drop the bomb in the o", drawFont, drawBrush, 10, 60);
            //Thread.Sleep(100);
            //fg.Clear(Color.Black);
            //fg.DrawString("Your mission is as follows:", drawFont, drawBrush, 10, 20);
            //fg.DrawString("The Death Star needs to be destroyed.", drawFont, drawBrush, 10, 40);
            //fg.DrawString("You need to drop the bomb in the ope", drawFont, drawBrush, 10, 60);
            //Thread.Sleep(100);
            //fg.Clear(Color.Black);
            //fg.DrawString("Your mission is as follows:", drawFont, drawBrush, 10, 20);
            //fg.DrawString("The Death Star needs to be destroyed.", drawFont, drawBrush, 10, 40);
            //fg.DrawString("You need to drop the bomb in the open", drawFont, drawBrush, 10, 60);
            //Thread.Sleep(100);
            //fg.Clear(Color.Black);
            //fg.DrawString("Your mission is as follows:", drawFont, drawBrush, 10, 20);
            //fg.DrawString("The Death Star needs to be destroyed.", drawFont, drawBrush, 10, 40);
            //fg.DrawString("You need to drop the bomb in the openi", drawFont, drawBrush, 10, 60);
            //Thread.Sleep(100);
            //fg.Clear(Color.Black);
            //fg.DrawString("Your mission is as follows:", drawFont, drawBrush, 10, 20);
            //fg.DrawString("The Death Star needs to be destroyed.", drawFont, drawBrush, 10, 40);
            //fg.DrawString("You need to drop the bomb in the openin", drawFont, drawBrush, 10, 60);
            //Thread.Sleep(100);
            //fg.Clear(Color.Black);
            //fg.DrawString("Your mission is as follows:", drawFont, drawBrush, 10, 20);
            //fg.DrawString("The Death Star needs to be destroyed.", drawFont, drawBrush, 10, 40);
            //fg.DrawString("You need to drop the bomb in the opening.", drawFont, drawBrush, 10, 60);
            //#endregion
            #endregion

        }
    }
}
