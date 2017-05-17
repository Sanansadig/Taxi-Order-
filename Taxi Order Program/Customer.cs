using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taxi_Order_Program
{
    class Customer
    {
        private string ad;
        private double Tel;
        private int in_latit;
        private int in_longtit;
        private int o_latit;
        private int o_longtit;
        private int v;
        private int h;

        public Customer(string a, double tel, int in_lat, int in_longt, int o_lat, int o_longt)
        {
            ad = a;
            Tel = tel;
            in_latit = in_lat;
            in_longtit = in_longt;
            o_latit = o_lat;
            o_longtit = o_longt;
            v = (o_lat - in_lat)*(o_lat - in_lat) + (o_longt - in_longt)*(o_longt - in_longt);
        }

        public string Ad
        {
            get { return ad; }
            set { value = ad; }
        }

        public double TEL
        {
            get { return Tel; }
            set { value = Tel; }
        }

        public int In_latit
        {
            get { return in_latit; }
            set { in_latit = value; }
        }
        public int In_longtit
        {
            get { return in_longtit; }
            set { in_longtit = value; }
        }
        public int O_longtit
        {
            get { return o_longtit; }
            set { o_longtit = value; }
        }
        public int O_latit
        {
            get { return o_latit; }
            set { o_latit = value; }
        }
        public int input
        {
            get { return v; }
        }

        public int square()
        {
            int r = Convert.ToInt32(Math.Sqrt(input));
            return r;
        }

        public int mebleg()
        {
            int sa = (square() / 10) * 2;
            return sa;
        }

        public int vaxt()
        {
            int deq = square() / 3;
            return deq;
        }
    }

}
