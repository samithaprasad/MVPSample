using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MVPSample.Views
{
    interface IRectangle
    {
        /// <summary>
        ///   <para>
        /// Gets or sets the length text.
        /// </para>
        /// </summary>
        /// <value>The length text.</value>
        string LengthText { get; set; }

        /// <summary>Gets or sets the breadth text.</summary>
        /// <value>The breadth text.</value>
        string BreadthText { get; set; }

        /// <summary>Gets or sets the area text.</summary>
        /// <value>The area text.</value>
        string AreaText { get; set; }



    }
}
