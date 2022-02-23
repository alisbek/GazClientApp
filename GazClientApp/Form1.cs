using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.ServiceModel;
using GazClientApp.GazDataService;

namespace GazClientApp
{
    public partial class MainFrm : Form
    {
        public MainFrm()
        {
            InitializeComponent();
        }

        private void GetDetails_Click(object sender, EventArgs e)
        {
            string strAccNo;
            int nValue;
            strAccNo=AccNoText.Text;
            nValue = Convert.ToInt32(ConsumText.Text);
            DataAccessServiceClient client = new DataAccessServiceClient("WSHttpBinding_IDataAccessService");
            BillItemClass strResponse = client.GetBill(strAccNo, nValue);
            FIOtext.Text = strResponse.FullName;
            SummText.Text = strResponse.GazAmount.ToString();
            GAZText.Text = strResponse.GazVolume.ToString();
            PenaltyText.Text = strResponse.Penalty.ToString();
            ErrorList.Items.AddRange(strResponse.Error);
            client.Close();
        }
    }
}
