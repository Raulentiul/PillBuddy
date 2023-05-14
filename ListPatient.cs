using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MedstuffPrincipal
{
    public partial class ListPatient : UserControl
    {
        public ListPatient()
        {
            InitializeComponent();
        }

        #region
        private string _name;
        private string _code;
        private string _phone;
        private string _email;
        private string _afectionsDet;
        private string _treatmentDet;
        
        [Category("Custom props")]
        public string NamePacient
        {
            get { return _name; }
            set { _name = value; lblName.Text = value; }
        }

        [Category("Custom props")]
        public string Code
        {
            get { return _code; }
            set { _code = value; codePacient.Text = value; }
        }

        [Category("Custom props")]
        public string Phone
        {
            get { return _phone; }
            set { _phone = value; phonePacient.Text = value; }
        }

        [Category("Custom props")]
        public string Email
        {
            get { return _email; }
            set { _email = value; emailPacient.Text = value; }
        }

        [Category("Custom props")]
        public string Affections
        {
            get { return _afectionsDet; }
            set { _afectionsDet = value; txtAfec.Text = value; }
        }

        [Category("Custom props")]
        public string Treatment
        {
            get { return _treatmentDet; }
            set { _treatmentDet = value; txtTrat.Text = value; }
        }
        #endregion

    }
}
