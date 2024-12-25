using System;
using System.Collections.Generic;
using System.Text;

namespace IvanovS
{
    public class Smartphone
    {
        public string Mark { get; set; }
        public string Model { get; set; }
        public double Cost { get; set; }


        public Smartphone (string mark, string model, double cost)
        {
            Mark = mark;
            Model = model;
            Cost = cost;
        }


        public override string ToString ()
        {
            return $"{Mark}, {Model}, {Cost}";
        }
    }
}
