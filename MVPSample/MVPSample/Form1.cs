using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MVPSample.Presenters;
using MVPSample.Views;

namespace MVPSample
{
    /// <summary>
    ///   <br />
    /// </summary>
    public partial class Form1 : Form,IRectangle
    {
        /// <summary>Initializes a new instance of the <see cref="Form1" /> class.</summary>
        public Form1()
        {
            InitializeComponent();
        }

        public string LengthText
        {
            get
            {
                return tbLength.Text;
            }
            set
            {
                tbLength.Text = value;
            }
        }
        /// <summary>Gets or sets the breadth text.</summary>
        /// <value>The breadth text.</value>
        public string BreadthText
        {
            get
            {
                return tbBreadth.Text;
            }
            set
            {
                tbBreadth.Text = value;
            }
        }

        /// <summary>Gets or sets the area text.</summary>
        /// <value>The area text.</value>
        public string AreaText
        {
            get
            {
                return lblAnswer.Text;
            }
            set
            {
                lblAnswer.Text = value;
            }
        }

        /// <summary>Handles the Click event of the BtnCal control.</summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        private void BtnCal_Click(object sender, EventArgs e)
        {
            RectanglePresenter rectanglePresenter = new RectanglePresenter(this);
            rectanglePresenter.CalculateArea();

        }
    }

}
