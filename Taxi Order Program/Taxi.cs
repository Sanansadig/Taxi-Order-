using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taxi_Order_Program
{
    class Taxi
    {
        private string adi; 
        private byte city_code;
        private string seria;
        private int number;
        private int in_lat;
        private int in_lon;
        private int oneInLat;
        private int oneInLong;


        public Taxi (string addi, byte ci_cod, string seri, int num, int innLat, int innLon, int onInLat, int onInLong)
        {
            adi = addi;
            city_code = ci_cod;
            seria = seri;
            number = num;
            in_lat = innLat;
            in_lon = innLon;
            oneInLat = onInLat;
            oneInLong = onInLong;


    }
        public string Adi
        {
            get { return adi; }
            set { adi = value; }
        } 

        public string Seria
        {
            get { return seria; }
            set { seria = value; }
        }
        public byte City_code
        {
            get { return city_code; }
            set { city_code = value; }
        }
        public int Number
        {
            get { return number; }
            set { number = value; }
        }

        public int In_lat
        {
            get { return in_lat; }
            set { in_lat = value; }
        }

        public int In_lon
        {
            get { return in_lon; }
            set { in_lon = value; }
        }


        public int OneInLat
        {
            get { return oneInLat; }
            set { oneInLat = value; }
        }
        public int OneInLong
        {
            get { return oneInLong; }
            set { oneInLong = value; }
        }


        public int hesabla()
        {
            int l = Convert.ToInt32(Math.Sqrt((In_lat - OneInLat) * (In_lat - OneInLat) + (In_lon - OneInLong) * (In_lon - OneInLong)));
            return l; 
        }

        public int muqayise(Customer obj)
        {
            int tax_cor = Convert.ToInt32(Math.Sqrt(obj.In_latit * obj.In_latit + obj.In_longtit * obj.In_latit));
            return tax_cor;
        }

    }
}
