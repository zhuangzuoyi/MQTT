
/*https://gist.github.com/adrenalinehit/a4e2684a0b3b0a49b48e#file-mqtt-publisher-cs*/
/*https://code.msdn.microsoft.com/windowsapps/M2Mqtt-MQTT-client-library-ac6d3858*/
/*https://www.symantec.com/content/en/us/enterprise/verisign/roots/VeriSign-Class%203-Public-Primary-Certification-Authority-G5.pem*/
/*http://docs.aws.amazon.com/iot/latest/developerguide/verify-pub-sub.html*/
/*https://m2mqtt.wordpress.com/m2mqtt-and-amazon-aws-iot/*/
using MQTT.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using uPLibrary.Networking.M2Mqtt;
using uPLibrary.Networking.M2Mqtt.Messages;

/* 引用命名空间 */
using System.Runtime.InteropServices; //调用系统DLL
using System.IO; //读写文件

namespace MQTT
{
    public partial class Form1 : Form
    {
        MqttClient mqttclient = null;
        byte[] qosLevels = { MqttMsgBase.QOS_LEVEL_AT_MOST_ONCE, MqttMsgBase.QOS_LEVEL_AT_MOST_ONCE };
        //byte qosLevel = MqttMsgBase.QOS_LEVEL_AT_MOST_ONCE;

        private string strFilePath = Application.StartupPath + "\\client.ini"; //INI文件路径名
        private string strSec = "client";  //节点名称

        string host_ip = null;

        string username=null;
        string password=null;
        string clientid = null;
        /// <summary>
        /// 写入INI文件
        /// </summary>
        /// <param name="section">节点名称[如[TypeName]]</param>
        /// <param name="key">键</param>
        /// <param name="val">值</param>
        /// <param name="filepath">文件路径</param>
        /// <returns></returns>
        [DllImport("kernel32")]
        private static extern long WritePrivateProfileString(string section, string key, string val, string filepath);

        /// <summary>
        /// 读取INI文件
        /// </summary>
        /// <param name="section">节点名称</param>
        /// <param name="key">键</param>
        /// <param name="def">值</param>
        /// <param name="retval">stringbulider对象</param>
        /// <param name="size">字节大小</param>
        /// <param name="filePath">文件路径</param>
        /// <returns></returns>
        [DllImport("kernel32")]
        private static extern int GetPrivateProfileString(string section, string key, string def, StringBuilder retval, int size, string filePath);



        delegate void SetTextCallback(string text);
        public Form1()
        {
            InitializeComponent();
        }

        private string ContentValue(string Section, string key)
        {
            StringBuilder temp = new StringBuilder(1024);
            GetPrivateProfileString(Section, key, "", temp, 1024, strFilePath);
            return temp.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            set_checkbok_disable();
            if (File.Exists(strFilePath))//读取时先要判读INI文件是否存在
            {
                strSec = Path.GetFileNameWithoutExtension(strFilePath);
                username = ContentValue(strSec, "username");
                password = ContentValue(strSec, "password");
                clientid = ContentValue(strSec, "clientid");
                host_ip = ContentValue(strSec, "host");

            }
            else
            {
                MessageBox.Show("INI文件配置不存在");
            }
        }

        private void From1_Close(object sender, EventArgs e)
        {

        }
        private void SetText(string text)
        {
            try
            {
                if (this.Messages.InvokeRequired)
                {
                    SetTextCallback d = new SetTextCallback(SetText);
                    this.Invoke(d, new object[] { text });
                }
                else
                    Messages.AppendText(text + "\r\n");
            }
            catch (InvalidCastException ex)
            {
                MessageBox.Show(ex.Message, "Urgh!", MessageBoxButtons.OK);
            }
        }


        void client_MqttMsgPublishReceived(object sender,
            MqttMsgPublishEventArgs e)
        {
            // The MQTT lib engine runs in another tread, so it´s necessary 
            // to do some trick to update Messages.Text property.
            // See SetText above.
            ///SetText(e.Topic + "/" + System.Text.Encoding.Default.GetString(e.Message)+":"+DateTime.Now.ToString());
            ///
            SetText("[" + DateTime.Now.ToLongTimeString().ToString() + "] " +"Recived:"+ e.Topic + "/" + System.Text.Encoding.Default.GetString(e.Message));
            //DateTime.Now.ToLongTimeString().ToString();
            if(string.Compare(s_topic_0.Text,e.Topic)==0 )
            {
                s_received_0.Text = System.Text.Encoding.Default.GetString(e.Message);
                s_update_time_0.Text = DateTime.Now.ToLongTimeString().ToString(); 
            }
            else if (string.Compare(s_topic_1.Text, e.Topic) == 0)
            {
                s_received_1.Text = System.Text.Encoding.Default.GetString(e.Message);
                s_update_time_1.Text = DateTime.Now.ToLongTimeString().ToString(); 
            }
            else if (string.Compare(s_topic_2.Text, e.Topic) == 0)
            {
                s_received_2.Text = System.Text.Encoding.Default.GetString(e.Message);
                s_update_time_2.Text = DateTime.Now.ToLongTimeString().ToString(); 
            }
            else if (string.Compare(s_topic_3.Text, e.Topic) == 0)
            {
                s_received_3.Text = System.Text.Encoding.Default.GetString(e.Message);
                s_update_time_3.Text = DateTime.Now.ToLongTimeString().ToString(); 
            }
            else if (string.Compare(s_topic_4.Text, e.Topic) == 0)
            {
                s_received_4.Text = System.Text.Encoding.Default.GetString(e.Message);
                s_update_time_4.Text = DateTime.Now.ToLongTimeString().ToString(); 
            }
        }


        void Client_disconnect(object sender, EventArgs e)
        {
            SetText("connect event");
            if(mqttclient.IsConnected)
            {

            }
            else
            {
                Go.Enabled = true;
                disconnect.Enabled = false;
            }
        }
        void client_subscribe(object sender, MqttMsgSubscribedEventArgs e)
        {
            SetText("topic sub");
        }

        void set_checkbok_disable()
        {
            s_click_0.Enabled = false;
            s_click_1.Enabled = false;
            s_click_2.Enabled = false;
            s_click_3.Enabled = false;
            s_click_4.Enabled = false;
        }

        void set_checkbok_enable()
        {
            s_click_0.Enabled = true;
            s_click_1.Enabled = true;
            s_click_2.Enabled = true;
            s_click_3.Enabled = true;
            s_click_4.Enabled = true;
        }
        private void Port_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) /*&&
             (e.KeyChar != '.')*/)
            {
                e.Handled = true;
            }
        }

        private void Go_Click(object sender, EventArgs e)
        {
            if(clientid.Length ==0 || username.Length ==0 || password.Length ==0)
            {
                MessageBox.Show(" ClientID or UserName or Password  Invalid");
                return;
            }

            try
            {
                    IPAddress HOST = IPAddress.Parse(host_ip);

                    mqttclient = new MqttClient(HOST);
                    // Set the message receive event
                    mqttclient.MqttMsgPublishReceived +=
                        client_MqttMsgPublishReceived;

                    mqttclient.ConnectionClosed += Client_disconnect;
                    mqttclient.MqttMsgSubscribed += client_subscribe;
                    // Connect to the broker

                    mqttclient.Connect(clientid, username, password);
                if(mqttclient.IsConnected)
                {
                    Go.Enabled = false;
                    disconnect.Enabled = true;
                    SetText("[" + DateTime.Now.ToLongTimeString().ToString() + "] " + "Connected to Broker:" + host_ip);
                    set_checkbok_enable();
                }
                else
                {
                    set_checkbok_disable();
                }
            }
            catch (Exception ex)
            {
                set_checkbok_disable();
                MessageBox.Show(ex.Message, "Urgh!", MessageBoxButtons.OK);
            }
        }

        private void s_click_0_CheckedChanged(object sender, EventArgs e)
        {
            if (mqttclient == null)
            {
                MessageBox.Show("Client is NULL");
                return;
            }

            if (mqttclient.IsConnected == false)
            {
                MessageBox.Show("Not connect to broker");
                //s_click_0.CheckState = CheckState.Unchecked;
                return;
            }
            if (s_topic_0.Text.Length == 0)
            {
                MessageBox.Show("Topic or message is empty");
                //s_click_0.CheckState = CheckState.Unchecked;
                return;
            }
            if(s_click_0.CheckState  == CheckState.Checked)
            {
                if(string.Compare(s_qos_0.Text,"0")==0 )
                {
                    mqttclient.Subscribe(new string[] { s_topic_0.Text }, new byte[] { 0 });
                }else if(string.Compare(s_qos_0.Text,"1")==0 )
                {
                    mqttclient.Subscribe(new string[] { s_topic_0.Text }, new byte[] { 1 });
                }else if(string.Compare(s_qos_0.Text,"2")==0 )
                {
                    mqttclient.Subscribe(new string[] { s_topic_0.Text }, new byte[] { 2 });
                }
                
            }else if (s_click_0.CheckState == CheckState.Indeterminate)
            {

            }else if (s_click_0.CheckState == CheckState.Unchecked)
            {
                mqttclient.Unsubscribe(new string[] { s_topic_0.Text });
            }
        }
        private void s_click_1_CheckedChanged(object sender, EventArgs e)
        {
            if (mqttclient == null)
            {
                MessageBox.Show("Not connect to broker");
                return;
            }

            if (mqttclient.IsConnected == false)
            {
                MessageBox.Show("Not connect to broker");
                return;
            }
            if (s_topic_1.Text.Length  == 0 )
            {
                MessageBox.Show("Topic or message is empty");
                return;
            }

            if (s_click_1.CheckState == CheckState.Checked)
            {
                if (string.Compare(s_qos_1.Text, "0") == 0)
                {
                    mqttclient.Subscribe(new string[] { s_topic_1.Text }, new byte[] { 0 });
                }
                else if (string.Compare(s_qos_1.Text, "1") == 0)
                {
                    mqttclient.Subscribe(new string[] { s_topic_1.Text }, new byte[] { 1 });
                }
                else if (string.Compare(s_qos_1.Text, "2") == 0)
                {
                    mqttclient.Subscribe(new string[] { s_topic_1.Text }, new byte[] { 2 });
                }

            }
            else if (s_click_1.CheckState == CheckState.Indeterminate)
            {

            }
            else if (s_click_1.CheckState == CheckState.Unchecked)
            {
                mqttclient.Unsubscribe(new string[] { s_topic_1.Text });
            }
        }
        private void s_click_2_CheckedChanged(object sender, EventArgs e)
        {
            if (mqttclient == null)
            {
                MessageBox.Show("Not connect to broker");
                return;
            }

            if (mqttclient.IsConnected == false)
            {
                MessageBox.Show("Not connect to broker");
                return;
            }
            if (s_topic_2.Text.Length == 0)
            {
                MessageBox.Show("Topic or message is empty");
                return;
            }

            if (s_click_2.CheckState == CheckState.Checked)
            {
                if (string.Compare(s_qos_2.Text, "0") == 0)
                {
                    mqttclient.Subscribe(new string[] { s_topic_2.Text }, new byte[] { 0 });
                }
                else if (string.Compare(s_qos_2.Text, "1") == 0)
                {
                    mqttclient.Subscribe(new string[] { s_topic_2.Text }, new byte[] { 1 });
                }
                else if (string.Compare(s_qos_2.Text, "2") == 0)
                {
                    mqttclient.Subscribe(new string[] { s_topic_2.Text }, new byte[] { 2 });
                }

            }
            else if (s_click_2.CheckState == CheckState.Indeterminate)
            {

            }
            else if (s_click_2.CheckState == CheckState.Unchecked)
            {
                mqttclient.Unsubscribe(new string[] { s_topic_2.Text });
            }
        }

        private void s_click_3_CheckedChanged(object sender, EventArgs e)
        {
            if (mqttclient == null)
            {
                MessageBox.Show("Not connect to broker");
                return;
            }

            if (mqttclient.IsConnected == false)
            {
                MessageBox.Show("Not connect to broker");
                return;
            }
            if (s_topic_3.Text.Length == 0)
            {
                MessageBox.Show("Topic or message is empty");
                return;
            }

            if (s_click_3.CheckState == CheckState.Checked)
            {
                if (string.Compare(s_qos_3.Text, "0") == 0)
                {
                    mqttclient.Subscribe(new string[] { s_topic_3.Text }, new byte[] { 0 });
                }
                else if (string.Compare(s_qos_3.Text, "1") == 0)
                {
                    mqttclient.Subscribe(new string[] { s_topic_3.Text }, new byte[] { 1 });
                }
                else if (string.Compare(s_qos_3.Text, "2") == 0)
                {
                    mqttclient.Subscribe(new string[] { s_topic_3.Text }, new byte[] { 2 });
                }

            }
            else if (s_click_3.CheckState == CheckState.Indeterminate)
            {

            }
            else if (s_click_3.CheckState == CheckState.Unchecked)
            {
                mqttclient.Unsubscribe(new string[] { s_topic_3.Text });
            }
        }

        private void s_click_4_CheckedChanged(object sender, EventArgs e)
        {
            if (mqttclient == null)
            {
                MessageBox.Show("Not connect to broker");
                return;
            }

            if (mqttclient.IsConnected == false)
            {
                MessageBox.Show("Not connect to broker");
                return;
            }
            if (s_topic_4.Text.Length == 0)
            {
                MessageBox.Show("Topic or message is empty");
                return;
            }

            if (s_click_4.CheckState == CheckState.Checked)
            {
                if (string.Compare(s_qos_4.Text, "0") == 0)
                {
                    mqttclient.Subscribe(new string[] { s_topic_4.Text }, new byte[] { 0 });
                }
                else if (string.Compare(s_qos_4.Text, "1") == 0)
                {
                    mqttclient.Subscribe(new string[] { s_topic_4.Text }, new byte[] { 1 });
                }
                else if (string.Compare(s_qos_4.Text, "2") == 0)
                {
                    mqttclient.Subscribe(new string[] { s_topic_4.Text }, new byte[] { 2 });
                }

            }
            else if (s_click_4.CheckState == CheckState.Indeterminate)
            {

            }
            else if (s_click_4.CheckState == CheckState.Unchecked)
            {
                mqttclient.Unsubscribe(new string[] { s_topic_4.Text });
            }
        }
        /// <summary>
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// 
        private void Publish_Click(object sender, EventArgs e)
        {
            if (mqttclient == null)
            {
                MessageBox.Show("Not connect to broker");
                return;
            }

            if (mqttclient.IsConnected == false)
            {
                MessageBox.Show("Not connect to broker");
                return;
            }
            if (p_topic_0.Text.Length == 0 || p_message_0.Text.Length == 0)
            {
                MessageBox.Show("Topic or message is empty");
                return;
            }
                
            if (string.Compare(p_qos_0.Text, "0") == 0)
            {
                // mqttclient.Subscribe(new string[] { s_topic_0.Text }, new byte[] { 0 });
                mqttclient.Publish(p_topic_0.Text, Encoding.UTF8.GetBytes(p_message_0.Text), 0, true);
            }
            else if (string.Compare(p_qos_0.Text, "1") == 0)
            {
                mqttclient.Publish(p_topic_0.Text, Encoding.UTF8.GetBytes(p_message_0.Text), 1, true);
            }
            else if (string.Compare(p_qos_0.Text, "2") == 0)
            {
                mqttclient.Publish(p_topic_0.Text, Encoding.UTF8.GetBytes(p_message_0.Text), 2, true);
            }
        }
        private void p_click_1_Click(object sender, EventArgs e)
        {
            if (mqttclient == null)
            {
                MessageBox.Show("Not connect to broker");
                return;
            }

            if (mqttclient.IsConnected == false)
            {
                MessageBox.Show("Not connect to broker");
                return;
            }
            if (p_topic_1.Text.Length == 0 || p_message_1.Text.Length == 0)
            {
                MessageBox.Show("Topic or message is empty");
                return;
            }

            if (string.Compare(p_qos_1.Text, "0") == 0)
            {
                // mqttclient.Subscribe(new string[] { s_topic_0.Text }, new byte[] { 0 });
                mqttclient.Publish(p_topic_1.Text, Encoding.UTF8.GetBytes(p_message_1.Text), 0, true);
            }
            else if (string.Compare(p_qos_1.Text, "1") == 0)
            {
                mqttclient.Publish(p_topic_1.Text, Encoding.UTF8.GetBytes(p_message_1.Text), 1, true);
            }
            else if (string.Compare(p_qos_1.Text, "2") == 0)
            {
                mqttclient.Publish(p_topic_1.Text, Encoding.UTF8.GetBytes(p_message_1.Text), 2, true);
            }
        }

        private void p_click_2_Click(object sender, EventArgs e)
        {
            if (mqttclient == null)
            {
                MessageBox.Show("Not connect to broker");
                return;
            }

            if (mqttclient.IsConnected == false)
            {
                MessageBox.Show("Not connect to broker");
                return;
            }
            if (p_topic_2.Text.Length == 0 || p_message_2.Text.Length == 0)
            {
                MessageBox.Show("Topic or message is empty");
                return;
            }
            if (string.Compare(p_qos_2.Text, "0") == 0)
            {
                // mqttclient.Subscribe(new string[] { s_topic_0.Text }, new byte[] { 0 });
                mqttclient.Publish(p_topic_2.Text, Encoding.UTF8.GetBytes(p_message_2.Text), 0, true);
            }
            else if (string.Compare(p_qos_2.Text, "1") == 0)
            {
                mqttclient.Publish(p_topic_2.Text, Encoding.UTF8.GetBytes(p_message_2.Text), 1, true);
            }
            else if (string.Compare(p_qos_2.Text, "2") == 0)
            {
                mqttclient.Publish(p_topic_2.Text, Encoding.UTF8.GetBytes(p_message_2.Text), 2, true);
            }
        }

        private void p_click_3_Click(object sender, EventArgs e)
        {
            if (mqttclient == null)
            {
                MessageBox.Show("Not connect to broker");
                return;
            }

            if (mqttclient.IsConnected == false)
            {
                MessageBox.Show("Not connect to broker");
                return;
            }
            if (p_topic_3.Text.Length == 0 || p_message_3.Text.Length == 0)
            {
                MessageBox.Show("Topic or message is empty");
                return;
            }
            if (string.Compare(p_qos_3.Text, "0") == 0)
            {
                // mqttclient.Subscribe(new string[] { s_topic_0.Text }, new byte[] { 0 });
                mqttclient.Publish(p_topic_3.Text, Encoding.UTF8.GetBytes(p_message_3.Text), 0, true);
            }
            else if (string.Compare(p_qos_3.Text, "1") == 0)
            {
                mqttclient.Publish(p_topic_3.Text, Encoding.UTF8.GetBytes(p_message_3.Text), 1, true);
            }
            else if (string.Compare(p_qos_3.Text, "2") == 0)
            {
                mqttclient.Publish(p_topic_3.Text, Encoding.UTF8.GetBytes(p_message_3.Text), 2, true);
            }
        }

        private void p_click_4_Click(object sender, EventArgs e)
        {
            if (mqttclient == null)
            {
                MessageBox.Show("Not connect to broker");
                return; 
            }
            
            if (mqttclient.IsConnected == false)
            {
                MessageBox.Show("Not connect to broker");
                return;
            }
            if (p_topic_4.Text.Length == 0 || p_message_4.Text.Length == 0)
            {
                MessageBox.Show("Topic or message is empty");
                return;
            }
            if (string.Compare(p_qos_4.Text, "0") == 0)
            {
                // mqttclient.Subscribe(new string[] { s_topic_0.Text }, new byte[] { 0 });
                mqttclient.Publish(p_topic_4.Text, Encoding.UTF8.GetBytes(p_message_4.Text), 0, true);
            }
            else if (string.Compare(p_qos_4.Text, "1") == 0)
            {
                mqttclient.Publish(p_topic_4.Text, Encoding.UTF8.GetBytes(p_message_4.Text), 1, true);
            }
            else if (string.Compare(p_qos_4.Text, "2") == 0)
            {
                mqttclient.Publish(p_topic_4.Text, Encoding.UTF8.GetBytes(p_message_4.Text), 2, true);
            }
        }

        private void disconnect_Click(object sender, EventArgs e)
        {
            mqttclient.Disconnect();
            disconnect.Enabled = false;
            Go.Enabled = true;
            set_checkbok_disable();
        }

        private void From1_Closing(object sender, FormClosingEventArgs e)
        {
            if(mqttclient != null)
                mqttclient.Disconnect();
            
        }
        //解决关闭程序时，还有进程没关的问题，
        private void From1_Closed(object sender, FormClosedEventArgs e)
        {
           // System.Windows.Forms.Application.Exit();
            System.Environment.Exit(0);
        }

    }
}
