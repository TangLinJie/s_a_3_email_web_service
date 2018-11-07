using s_a_3_client.EmailServer;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace s_a_3_client
{
    public partial class Form1 : Form
    {
        private EmailServer.EmailServicesClient client = null;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, System.EventArgs e)
        {
            client = new EmailServer.EmailServicesClient();
        }
        private void send_click(object sender, System.EventArgs e)
        {
            string content = this.content.Text;
            string address = this.address.Text;
            string[] addressArray=address.Split(';');
            bool result;

            if (addressArray.Length == 1)
                result=client.sendEmail(address, content);
            else
                result=client.sendEmailBatch(addressArray, content);
            if (result)
                this.resultLabel.Text = "发送成功！";
            else
                this.resultLabel.Text = "发送失败！";
        }
        private void check_click(object sender, System.EventArgs e)
        {
            string address = this.address.Text;
            bool result = client.validateEmailAddress(address);
            if (result)
                this.resultLabel.Text = "地址正确！";
            else
                this.resultLabel.Text = "地址错误！";
        }
    }
}
