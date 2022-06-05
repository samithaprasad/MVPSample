using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MVPSample.Models;
using MVPSample.Views;

namespace MVPSample.Presenters
{
    /// <summary>
    ///   <br />
    /// </summary>
    class RectanglePresenter
    {
        private IRectangle rectangleView;

        /// <summary>Initializes a new instance of the <see cref="RectanglePresenter" /> class.</summary>
        /// <param name="view">The view.</param>
        public RectanglePresenter(IRectangle view)
        {
            rectangleView = view;
        }

        /// <summary>Calculates the area.</summary>
        public void CalculateArea()
        {
            Rectangle rectangle = new Rectangle();
            rectangle.Length = double.Parse(rectangleView.LengthText);
            rectangle.Breadth = double.Parse(rectangleView.BreadthText);
            rectangleView.AreaText = rectangle.CalculateArea().ToString();
        }
    }
}
