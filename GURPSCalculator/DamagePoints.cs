using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

/*
 * ???  Damage (points) = sqrt (KE/(Caliber (mm) ^0.4))*0.6
 * 
        Damage (points) = sqrt(KE^1.04/Xsect^0.314)/13.3926


        KE = mv^2/2 (m - mass, v - speed)
        Xsect = pi(bore^2 / 100(for meeters))/4 (bore - caliber)
        */

/*
•  APHEX or APCR
1
•  Steel cap, reinforced core, or semi-armor piercing:    
1.25

• APDS
1.3

•  Steel rod core (for APFSD):
1.5

•  Tungsten or tungsten carbide core:
1.9

•  Depleted uranium (DU) core or penetrator:    
2.4
 */


namespace GURPSCalculator
{

    internal class DamagePoints
    {

        private double Caliber { get; set; }
        private double Speed { get; set; }
        private double Weight { get; set; }
        private double MaterMod { get; set; }

        public DamagePoints(double _Caliber, double _Speed, double _Weight, double materMod)
        {
            this.Caliber = _Caliber;
            this.Speed = _Speed;
            this.Weight = _Weight;
            this.MaterMod = materMod;
        }
        public int DamageCalc() 
        {
            double KE = 0.5 * (Weight * Math.Pow(Speed, 2));
            double Xsect = Math.PI * Math.Pow(Caliber / 100, 2) / 4;
            double DMGnoDice = Math.Sqrt(Math.Pow(KE, 1.04) / Math.Pow(Xsect, 0.314)) / 13.3926 / 3.5; // U can try to divide damage by either 3.5 or 7
            int answer = Convert.ToInt32(Math.Round(DMGnoDice / 6) * MaterMod /*тута надо домножить на тип снаряда *1.9 */);
            return answer;
        }

    }
}
