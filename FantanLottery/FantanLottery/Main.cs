using FantanLottery.common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FantanLottery.common;
using HtmlAgilityPack;

namespace FantanLottery
{
    public partial class Main : Form
    {
        string gatherUrl = "http://www.321k.co/pk10";
        System.Timers.Timer timer = null;

        public Main()
        {
            InitializeComponent();
            //timer = TimerFunction.SetInterval(2000, e =>
            //{
            //    try
            //    {
            //        Action action = () =>
            //               {
            //                   rtbx_betRecord.AppendTextColorful("番摊自动下注软件开始运行.........".AppendSymbol(), Color.Red);
            //               };
            //        this.Invoke(action);
            //    }
            //    catch (Exception)
            //    {
            //    }
            //});
            StartGatherWebData();
        }

        private void btnStopGather_Click(object sender, EventArgs e)
        {
            if (timer != null)
            {
                timer.Stop();
                timer.Close();
            }
        }

        void StartGatherWebData()
        {

        }


    }


}
