using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4
{
    public class Car
    {
        private int characters = 8;

        public Car()
        {
            //  Constructor
        }

        private string _make;
        public string Make
        {
            get { return _make; }
            set { _make = value; }
        }

        private string _model;
        public string Model
        {
            get { return _model; }
            set { _model = value; }
        }

        private int _year;
        public int Year
        {
            get { return _year; }
            set { _year = value; }
        }

        private string _engine;
        public string Engine
        {
            get { return _engine; }
            set { _engine = value; }
        }

        private string _asperation;
        public string Asperation
        {
            get { return _asperation; }
            set { _asperation = value; }
        }

        public string Space(int temp)
        {

            if (temp == 0)
            {
                if (Make.Length >= characters) return "\t";
                else return "\t\t";
            }
            else if (temp == 1)
            {
                if (Model.Length >= characters) return "\t";
                else return "\t\t";
            }
            else
            {
                return "\t";
            }
        }

        public string Display
        {
            get { return this.Make + Space(0) + this.Model + Space(1) + this.Year + Space(2) + this.Engine + Space(3) + this.Asperation; }
        }
        public string Header
        {
            get { return "Make:\t\tModel:\t\tYear:\tEngine:\tAsperation:"; }
        }

        private string Output(int temp)
        {
            if (temp == 0)
            {
                if (_make.Length >= characters) return _make + "\t";
                else return _make + "\t\t";
            }
            else if (temp == 1)
            {
                if (_model.Length >= characters) return _model + "\t";
                else return "\t\t";
            }
            else if (temp == 2)
            {
                if (_engine.Length >= characters) return _engine + "\t";
                else return "\t\t";
            }
            else if (temp == 3)
            {
                if (_asperation.Length >= characters) return _asperation + "\t";
                else return "\t\t";
            }
            else
            {
                return "\t";
            }
        }
    }
}
