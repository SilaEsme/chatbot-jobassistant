using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobAssistant
{
    public class Job
    {
        private int jobID;
        private string ingilizce;
        private string pozisyon;
        private string okul;
        private string yer;
        private string marka;
        

        public int JobID 
        {
            get => jobID;
            set => jobID = value;
        }
        public string Ingilizce
        {
            get => ingilizce;
            set => ingilizce = value;
        }
        public string Pozisyon
        {
            get => pozisyon;
            set => pozisyon = value;
        }
        public string Okul
        {
            get => okul;
            set => okul = value;
        }
        public string Yer
        {
            get => yer;
            set => yer = value;
        }
        public string Marka
        {
            get => marka;
            set => marka = value;
        }
    }
}
