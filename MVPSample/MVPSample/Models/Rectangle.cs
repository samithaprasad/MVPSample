using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MVPSample.Models
{
    class Rectangle
    {
        /// <summary>Gets or sets the length.</summary>
        /// <value>The length.</value>
        /// 
        public double Length { get; set; }

        /// <summary>Gets or sets the breadth.</summary>
        /// <value>The breadth.</value>
        /// 
        public double Breadth { get; set; }

        /// <summary>Calculates the area.</summary>
        /// <returns>
        ///   <br />
        /// </returns>
        public double CalculateArea()
        {
            return Length * Breadth;
        }

    }
}
