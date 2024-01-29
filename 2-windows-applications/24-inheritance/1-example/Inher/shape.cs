using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InherName
{
    class shape
    {
        public double height;
        public double width;

        public void showDim() {

            string valueBox = "The Width and Height are " + width + " " + height;

            System.Windows.Forms.MessageBox.Show(valueBox);

        }

        
    }


    //Now Tringle can use all properties and methods inside the shape class.

    class Tringle : shape {

        public string style;


        public double Area() {

            return width * height / 2;
        }

        public void showStyle() {

            System.Windows.Forms.MessageBox.Show("The tringle is "+style);
        }

    }
}
