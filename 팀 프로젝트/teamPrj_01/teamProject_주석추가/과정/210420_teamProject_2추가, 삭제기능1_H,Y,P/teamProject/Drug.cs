﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teamProject
{
    class Drug
    {

        private string medName;
        private string medComp;
        private string medId;
        private string chart;
        private string formName;
        private string className;
        private string mainIngr;

        public string MedName { get => medName; set => medName = value; }
        public string MedComp { get => medComp; set => medComp = value; }
        public string MedId { get => medId; set => medId = value; }
        public string Chart { get => chart; set => chart = value; }
        public string FormName { get => formName; set => formName = value; }
        public string ClassName { get => className; set => className = value; }
        public string MainIngr { get => mainIngr; set => mainIngr = value; }

        public Drug(string medName, string medId, string medComp, string chart,string formName, string className,string mainIngr)
        {
            this.medName = medName;
            this.medId = medId;
            this.medComp = medComp;
            this.chart = chart;
            this.formName = formName;
            this.className = className;
            this.mainIngr = mainIngr;


        }
    }
}
