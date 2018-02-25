using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADEPTFormsApp
{
    public partial class ADEPTDemoForm : Form
    {
        private ADEPTManager myManager { get; set; }

        public ADEPTDemoForm()
        {
            InitializeComponent();
            myManager = new ADEPTManager();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            List<ADEPTNodeDTO> myNodes = new List<ADEPTNodeDTO>();

            if(myManager != null && string.Compare(myManager.db_connectionstatus, "active") == 0)
            {
                ADEPTFormInputs myInputs = GetFormInputs();
                myNodes = myManager.Search(myInputs);
            }
        }

        private void btnUpsert_Click(object sender, EventArgs e)
        {
            ADEPTNodeDTO resultNode = new ADEPTNodeDTO();

            if (myManager != null && string.Compare(myManager.db_connectionstatus, "active") == 0)
            {
                ADEPTFormInputs myInputs = GetFormInputs();
                ADEPTNodeDTO targetNode = myInputs != null ? myInputs.ToNodeDTO() : null;

                if (targetNode != null)
                {
                    resultNode = myManager.Upsert(targetNode);
                }
            }
        }

        public ADEPTFormInputs GetFormInputs()
        {
            ADEPTFormInputs myInputs = new ADEPTFormInputs();
            myInputs.Symbol = txtSymbol.Text;
            myInputs.Thing = txtThing.Text;
            return myInputs;
        }

        public void UpdateDisplay() { }
    }
}
