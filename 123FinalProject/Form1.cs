using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

/*****************************************************************
 * CIS123: Introduction to Object-Oriented Programming
 * Interfaces/Generics Practice (Team Assignment)
 * Team 2, June 17, 2022
 * Patrick McKee & Dominique Tepper
 * **************************************************************/

namespace _123FinalProject
{
    public partial class PuppyDuplicator : Form
    {
        
        public PuppyDuplicator()
        {
            InitializeComponent();
        }

        private void btnClone_Click(object sender, EventArgs e)
        {
            ThisDog thisDog = new ThisDog();
            thisDog.Name = "Kya";
            ThisDog cloneDog = (ThisDog)thisDog.Clone();
            MessageBox.Show($"Presenting the clone puppy: {cloneDog.Name}", "Double Trouble!");
        }
    }

    class ThisDog : ICloneable
    {
        public string Name
        {
            get;
            set;
        }


        public object Clone()
        {
            return this;
        }
    }
}