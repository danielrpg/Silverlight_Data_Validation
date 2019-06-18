using System;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;

namespace SilverlightApplication1
{
    public class Student
    {
        private string _name;
        private int _age;

        public string Name {
            get { return _name; }
            set { _name = value; }
        }

        public int Age
        {
            get { return _age; }
            set
            {
                if(value > 100 || value < 0)
                {
                    throw new Exception("Please enter age between 0 - 100.");
                }
                _age = value;
            }
        }
    }
}
