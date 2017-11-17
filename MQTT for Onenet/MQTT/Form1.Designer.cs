namespace MQTT
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Go = new System.Windows.Forms.Button();
            this.Messages = new System.Windows.Forms.TextBox();
            this.p_topic_0 = new System.Windows.Forms.TextBox();
            this.p_click_0 = new System.Windows.Forms.Button();
            this.disconnect = new System.Windows.Forms.Button();
            this.s_topic_0 = new System.Windows.Forms.TextBox();
            this.s_received_0 = new System.Windows.Forms.TextBox();
            this.s_click_0 = new System.Windows.Forms.CheckBox();
            this.s_click_1 = new System.Windows.Forms.CheckBox();
            this.s_received_1 = new System.Windows.Forms.TextBox();
            this.s_topic_1 = new System.Windows.Forms.TextBox();
            this.s_click_2 = new System.Windows.Forms.CheckBox();
            this.s_received_2 = new System.Windows.Forms.TextBox();
            this.s_topic_2 = new System.Windows.Forms.TextBox();
            this.s_click_3 = new System.Windows.Forms.CheckBox();
            this.s_received_3 = new System.Windows.Forms.TextBox();
            this.s_topic_3 = new System.Windows.Forms.TextBox();
            this.s_click_4 = new System.Windows.Forms.CheckBox();
            this.s_received_4 = new System.Windows.Forms.TextBox();
            this.s_topic_4 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.s_qos_0 = new System.Windows.Forms.ComboBox();
            this.s_qos_1 = new System.Windows.Forms.ComboBox();
            this.s_qos_2 = new System.Windows.Forms.ComboBox();
            this.s_qos_3 = new System.Windows.Forms.ComboBox();
            this.s_qos_4 = new System.Windows.Forms.ComboBox();
            this.p_qos_0 = new System.Windows.Forms.ComboBox();
            this.p_qos_1 = new System.Windows.Forms.ComboBox();
            this.p_topic_1 = new System.Windows.Forms.TextBox();
            this.p_click_1 = new System.Windows.Forms.Button();
            this.p_qos_2 = new System.Windows.Forms.ComboBox();
            this.p_topic_2 = new System.Windows.Forms.TextBox();
            this.p_click_2 = new System.Windows.Forms.Button();
            this.p_qos_3 = new System.Windows.Forms.ComboBox();
            this.p_topic_3 = new System.Windows.Forms.TextBox();
            this.p_click_3 = new System.Windows.Forms.Button();
            this.s_update_time_0 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.s_update_time_1 = new System.Windows.Forms.Label();
            this.s_update_time_2 = new System.Windows.Forms.Label();
            this.s_update_time_3 = new System.Windows.Forms.Label();
            this.s_update_time_4 = new System.Windows.Forms.Label();
            this.p_qos_4 = new System.Windows.Forms.ComboBox();
            this.p_topic_4 = new System.Windows.Forms.TextBox();
            this.p_click_4 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.p_message_0 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.p_message_1 = new System.Windows.Forms.TextBox();
            this.p_message_2 = new System.Windows.Forms.TextBox();
            this.p_message_3 = new System.Windows.Forms.TextBox();
            this.p_message_4 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Go
            // 
            this.Go.Location = new System.Drawing.Point(24, 364);
            this.Go.Name = "Go";
            this.Go.Size = new System.Drawing.Size(75, 21);
            this.Go.TabIndex = 3;
            this.Go.Text = "Connect";
            this.Go.UseVisualStyleBackColor = true;
            this.Go.Click += new System.EventHandler(this.Go_Click);
            // 
            // Messages
            // 
            this.Messages.AcceptsReturn = true;
            this.Messages.BackColor = System.Drawing.Color.Black;
            this.Messages.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Messages.ForeColor = System.Drawing.Color.Green;
            this.Messages.Location = new System.Drawing.Point(557, 12);
            this.Messages.Multiline = true;
            this.Messages.Name = "Messages";
            this.Messages.ReadOnly = true;
            this.Messages.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Messages.Size = new System.Drawing.Size(268, 373);
            this.Messages.TabIndex = 7;
            // 
            // p_topic_0
            // 
            this.p_topic_0.Location = new System.Drawing.Point(24, 196);
            this.p_topic_0.Name = "p_topic_0";
            this.p_topic_0.Size = new System.Drawing.Size(188, 21);
            this.p_topic_0.TabIndex = 10;
            // 
            // p_click_0
            // 
            this.p_click_0.Location = new System.Drawing.Point(449, 197);
            this.p_click_0.Name = "p_click_0";
            this.p_click_0.Size = new System.Drawing.Size(75, 21);
            this.p_click_0.TabIndex = 9;
            this.p_click_0.Text = "Publish";
            this.p_click_0.UseVisualStyleBackColor = true;
            this.p_click_0.Click += new System.EventHandler(this.Publish_Click);
            // 
            // disconnect
            // 
            this.disconnect.Enabled = false;
            this.disconnect.Location = new System.Drawing.Point(117, 364);
            this.disconnect.Name = "disconnect";
            this.disconnect.Size = new System.Drawing.Size(75, 21);
            this.disconnect.TabIndex = 11;
            this.disconnect.Text = "disconnect";
            this.disconnect.UseVisualStyleBackColor = true;
            this.disconnect.Click += new System.EventHandler(this.disconnect_Click);
            // 
            // s_topic_0
            // 
            this.s_topic_0.Location = new System.Drawing.Point(45, 31);
            this.s_topic_0.Name = "s_topic_0";
            this.s_topic_0.Size = new System.Drawing.Size(147, 21);
            this.s_topic_0.TabIndex = 14;
            // 
            // s_received_0
            // 
            this.s_received_0.Location = new System.Drawing.Point(246, 31);
            this.s_received_0.Name = "s_received_0";
            this.s_received_0.Size = new System.Drawing.Size(185, 21);
            this.s_received_0.TabIndex = 15;
            // 
            // s_click_0
            // 
            this.s_click_0.AutoSize = true;
            this.s_click_0.Location = new System.Drawing.Point(24, 38);
            this.s_click_0.Name = "s_click_0";
            this.s_click_0.Size = new System.Drawing.Size(15, 14);
            this.s_click_0.TabIndex = 16;
            this.s_click_0.UseVisualStyleBackColor = true;
            this.s_click_0.CheckedChanged += new System.EventHandler(this.s_click_0_CheckedChanged);
            // 
            // s_click_1
            // 
            this.s_click_1.AutoSize = true;
            this.s_click_1.Location = new System.Drawing.Point(24, 65);
            this.s_click_1.Name = "s_click_1";
            this.s_click_1.Size = new System.Drawing.Size(15, 14);
            this.s_click_1.TabIndex = 20;
            this.s_click_1.UseVisualStyleBackColor = true;
            this.s_click_1.CheckedChanged += new System.EventHandler(this.s_click_1_CheckedChanged);
            // 
            // s_received_1
            // 
            this.s_received_1.Location = new System.Drawing.Point(246, 58);
            this.s_received_1.Name = "s_received_1";
            this.s_received_1.Size = new System.Drawing.Size(185, 21);
            this.s_received_1.TabIndex = 19;
            // 
            // s_topic_1
            // 
            this.s_topic_1.Location = new System.Drawing.Point(45, 58);
            this.s_topic_1.Name = "s_topic_1";
            this.s_topic_1.Size = new System.Drawing.Size(147, 21);
            this.s_topic_1.TabIndex = 18;
            // 
            // s_click_2
            // 
            this.s_click_2.AutoSize = true;
            this.s_click_2.Location = new System.Drawing.Point(24, 92);
            this.s_click_2.Name = "s_click_2";
            this.s_click_2.Size = new System.Drawing.Size(15, 14);
            this.s_click_2.TabIndex = 23;
            this.s_click_2.UseVisualStyleBackColor = true;
            this.s_click_2.CheckedChanged += new System.EventHandler(this.s_click_2_CheckedChanged);
            // 
            // s_received_2
            // 
            this.s_received_2.Location = new System.Drawing.Point(246, 85);
            this.s_received_2.Name = "s_received_2";
            this.s_received_2.Size = new System.Drawing.Size(185, 21);
            this.s_received_2.TabIndex = 22;
            // 
            // s_topic_2
            // 
            this.s_topic_2.Location = new System.Drawing.Point(45, 85);
            this.s_topic_2.Name = "s_topic_2";
            this.s_topic_2.Size = new System.Drawing.Size(147, 21);
            this.s_topic_2.TabIndex = 21;
            // 
            // s_click_3
            // 
            this.s_click_3.AutoSize = true;
            this.s_click_3.Location = new System.Drawing.Point(24, 119);
            this.s_click_3.Name = "s_click_3";
            this.s_click_3.Size = new System.Drawing.Size(15, 14);
            this.s_click_3.TabIndex = 26;
            this.s_click_3.UseVisualStyleBackColor = true;
            this.s_click_3.CheckedChanged += new System.EventHandler(this.s_click_3_CheckedChanged);
            // 
            // s_received_3
            // 
            this.s_received_3.Location = new System.Drawing.Point(246, 112);
            this.s_received_3.Name = "s_received_3";
            this.s_received_3.Size = new System.Drawing.Size(185, 21);
            this.s_received_3.TabIndex = 25;
            // 
            // s_topic_3
            // 
            this.s_topic_3.Location = new System.Drawing.Point(45, 112);
            this.s_topic_3.Name = "s_topic_3";
            this.s_topic_3.Size = new System.Drawing.Size(147, 21);
            this.s_topic_3.TabIndex = 24;
            // 
            // s_click_4
            // 
            this.s_click_4.AutoSize = true;
            this.s_click_4.Location = new System.Drawing.Point(24, 146);
            this.s_click_4.Name = "s_click_4";
            this.s_click_4.Size = new System.Drawing.Size(15, 14);
            this.s_click_4.TabIndex = 29;
            this.s_click_4.UseVisualStyleBackColor = true;
            this.s_click_4.CheckedChanged += new System.EventHandler(this.s_click_4_CheckedChanged);
            // 
            // s_received_4
            // 
            this.s_received_4.Location = new System.Drawing.Point(246, 137);
            this.s_received_4.Name = "s_received_4";
            this.s_received_4.Size = new System.Drawing.Size(185, 21);
            this.s_received_4.TabIndex = 28;
            // 
            // s_topic_4
            // 
            this.s_topic_4.Location = new System.Drawing.Point(45, 139);
            this.s_topic_4.Name = "s_topic_4";
            this.s_topic_4.Size = new System.Drawing.Size(147, 21);
            this.s_topic_4.TabIndex = 27;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 30;
            this.label1.Text = "订阅主题";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(237, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 12);
            this.label2.TabIndex = 31;
            this.label2.Text = "接收到的主题";
            // 
            // s_qos_0
            // 
            this.s_qos_0.FormattingEnabled = true;
            this.s_qos_0.Items.AddRange(new object[] {
            "0",
            "1",
            "2"});
            this.s_qos_0.Location = new System.Drawing.Point(199, 31);
            this.s_qos_0.Name = "s_qos_0";
            this.s_qos_0.Size = new System.Drawing.Size(41, 20);
            this.s_qos_0.TabIndex = 32;
            this.s_qos_0.Text = "0";
            // 
            // s_qos_1
            // 
            this.s_qos_1.FormattingEnabled = true;
            this.s_qos_1.Items.AddRange(new object[] {
            "0",
            "1",
            "2"});
            this.s_qos_1.Location = new System.Drawing.Point(199, 59);
            this.s_qos_1.Name = "s_qos_1";
            this.s_qos_1.Size = new System.Drawing.Size(41, 20);
            this.s_qos_1.TabIndex = 33;
            this.s_qos_1.Text = "0";
            // 
            // s_qos_2
            // 
            this.s_qos_2.FormattingEnabled = true;
            this.s_qos_2.Items.AddRange(new object[] {
            "0",
            "1",
            "2"});
            this.s_qos_2.Location = new System.Drawing.Point(198, 86);
            this.s_qos_2.Name = "s_qos_2";
            this.s_qos_2.Size = new System.Drawing.Size(42, 20);
            this.s_qos_2.TabIndex = 34;
            this.s_qos_2.Text = "0";
            // 
            // s_qos_3
            // 
            this.s_qos_3.FormattingEnabled = true;
            this.s_qos_3.Items.AddRange(new object[] {
            "0",
            "1",
            "2"});
            this.s_qos_3.Location = new System.Drawing.Point(199, 112);
            this.s_qos_3.Name = "s_qos_3";
            this.s_qos_3.Size = new System.Drawing.Size(41, 20);
            this.s_qos_3.TabIndex = 35;
            this.s_qos_3.Text = "0";
            // 
            // s_qos_4
            // 
            this.s_qos_4.FormattingEnabled = true;
            this.s_qos_4.Items.AddRange(new object[] {
            "0",
            "1",
            "2"});
            this.s_qos_4.Location = new System.Drawing.Point(199, 138);
            this.s_qos_4.Name = "s_qos_4";
            this.s_qos_4.Size = new System.Drawing.Size(41, 20);
            this.s_qos_4.TabIndex = 36;
            this.s_qos_4.Text = "0";
            // 
            // p_qos_0
            // 
            this.p_qos_0.FormattingEnabled = true;
            this.p_qos_0.Items.AddRange(new object[] {
            "0",
            "1",
            "2"});
            this.p_qos_0.Location = new System.Drawing.Point(393, 198);
            this.p_qos_0.Name = "p_qos_0";
            this.p_qos_0.Size = new System.Drawing.Size(50, 20);
            this.p_qos_0.TabIndex = 37;
            this.p_qos_0.Text = "0";
            // 
            // p_qos_1
            // 
            this.p_qos_1.FormattingEnabled = true;
            this.p_qos_1.Items.AddRange(new object[] {
            "0",
            "1",
            "2"});
            this.p_qos_1.Location = new System.Drawing.Point(393, 224);
            this.p_qos_1.Name = "p_qos_1";
            this.p_qos_1.Size = new System.Drawing.Size(50, 20);
            this.p_qos_1.TabIndex = 40;
            this.p_qos_1.Text = "0";
            // 
            // p_topic_1
            // 
            this.p_topic_1.Location = new System.Drawing.Point(24, 223);
            this.p_topic_1.Name = "p_topic_1";
            this.p_topic_1.Size = new System.Drawing.Size(188, 21);
            this.p_topic_1.TabIndex = 39;
            // 
            // p_click_1
            // 
            this.p_click_1.Location = new System.Drawing.Point(449, 222);
            this.p_click_1.Name = "p_click_1";
            this.p_click_1.Size = new System.Drawing.Size(75, 21);
            this.p_click_1.TabIndex = 38;
            this.p_click_1.Text = "Publish";
            this.p_click_1.UseVisualStyleBackColor = true;
            this.p_click_1.Click += new System.EventHandler(this.p_click_1_Click);
            // 
            // p_qos_2
            // 
            this.p_qos_2.FormattingEnabled = true;
            this.p_qos_2.Items.AddRange(new object[] {
            "0",
            "1",
            "2"});
            this.p_qos_2.Location = new System.Drawing.Point(393, 249);
            this.p_qos_2.Name = "p_qos_2";
            this.p_qos_2.Size = new System.Drawing.Size(50, 20);
            this.p_qos_2.TabIndex = 43;
            this.p_qos_2.Text = "0";
            // 
            // p_topic_2
            // 
            this.p_topic_2.Location = new System.Drawing.Point(24, 250);
            this.p_topic_2.Name = "p_topic_2";
            this.p_topic_2.Size = new System.Drawing.Size(188, 21);
            this.p_topic_2.TabIndex = 42;
            // 
            // p_click_2
            // 
            this.p_click_2.Location = new System.Drawing.Point(449, 249);
            this.p_click_2.Name = "p_click_2";
            this.p_click_2.Size = new System.Drawing.Size(75, 21);
            this.p_click_2.TabIndex = 41;
            this.p_click_2.Text = "Publish";
            this.p_click_2.UseVisualStyleBackColor = true;
            this.p_click_2.Click += new System.EventHandler(this.p_click_2_Click);
            // 
            // p_qos_3
            // 
            this.p_qos_3.FormattingEnabled = true;
            this.p_qos_3.Items.AddRange(new object[] {
            "0",
            "1",
            "2"});
            this.p_qos_3.Location = new System.Drawing.Point(393, 275);
            this.p_qos_3.Name = "p_qos_3";
            this.p_qos_3.Size = new System.Drawing.Size(50, 20);
            this.p_qos_3.TabIndex = 46;
            this.p_qos_3.Text = "0";
            // 
            // p_topic_3
            // 
            this.p_topic_3.Location = new System.Drawing.Point(24, 277);
            this.p_topic_3.Name = "p_topic_3";
            this.p_topic_3.Size = new System.Drawing.Size(188, 21);
            this.p_topic_3.TabIndex = 45;
            // 
            // p_click_3
            // 
            this.p_click_3.Location = new System.Drawing.Point(449, 276);
            this.p_click_3.Name = "p_click_3";
            this.p_click_3.Size = new System.Drawing.Size(75, 21);
            this.p_click_3.TabIndex = 44;
            this.p_click_3.Text = "Publish";
            this.p_click_3.UseVisualStyleBackColor = true;
            this.p_click_3.Click += new System.EventHandler(this.p_click_3_Click);
            // 
            // s_update_time_0
            // 
            this.s_update_time_0.AutoSize = true;
            this.s_update_time_0.Location = new System.Drawing.Point(437, 34);
            this.s_update_time_0.Name = "s_update_time_0";
            this.s_update_time_0.Size = new System.Drawing.Size(11, 12);
            this.s_update_time_0.TabIndex = 47;
            this.s_update_time_0.Text = " ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(431, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 48;
            this.label4.Text = "跟新时间";
            // 
            // s_update_time_1
            // 
            this.s_update_time_1.AutoSize = true;
            this.s_update_time_1.Location = new System.Drawing.Point(437, 62);
            this.s_update_time_1.Name = "s_update_time_1";
            this.s_update_time_1.Size = new System.Drawing.Size(11, 12);
            this.s_update_time_1.TabIndex = 49;
            this.s_update_time_1.Text = " ";
            // 
            // s_update_time_2
            // 
            this.s_update_time_2.AutoSize = true;
            this.s_update_time_2.Location = new System.Drawing.Point(437, 88);
            this.s_update_time_2.Name = "s_update_time_2";
            this.s_update_time_2.Size = new System.Drawing.Size(11, 12);
            this.s_update_time_2.TabIndex = 50;
            this.s_update_time_2.Text = " ";
            // 
            // s_update_time_3
            // 
            this.s_update_time_3.AutoSize = true;
            this.s_update_time_3.Location = new System.Drawing.Point(437, 119);
            this.s_update_time_3.Name = "s_update_time_3";
            this.s_update_time_3.Size = new System.Drawing.Size(11, 12);
            this.s_update_time_3.TabIndex = 51;
            this.s_update_time_3.Text = " ";
            // 
            // s_update_time_4
            // 
            this.s_update_time_4.AutoSize = true;
            this.s_update_time_4.Location = new System.Drawing.Point(437, 142);
            this.s_update_time_4.Name = "s_update_time_4";
            this.s_update_time_4.Size = new System.Drawing.Size(11, 12);
            this.s_update_time_4.TabIndex = 52;
            this.s_update_time_4.Text = " ";
            // 
            // p_qos_4
            // 
            this.p_qos_4.FormattingEnabled = true;
            this.p_qos_4.Items.AddRange(new object[] {
            "0",
            "1",
            "2"});
            this.p_qos_4.Location = new System.Drawing.Point(393, 302);
            this.p_qos_4.Name = "p_qos_4";
            this.p_qos_4.Size = new System.Drawing.Size(50, 20);
            this.p_qos_4.TabIndex = 55;
            this.p_qos_4.Text = "0";
            // 
            // p_topic_4
            // 
            this.p_topic_4.Location = new System.Drawing.Point(24, 304);
            this.p_topic_4.Name = "p_topic_4";
            this.p_topic_4.Size = new System.Drawing.Size(188, 21);
            this.p_topic_4.TabIndex = 54;
            // 
            // p_click_4
            // 
            this.p_click_4.Location = new System.Drawing.Point(449, 303);
            this.p_click_4.Name = "p_click_4";
            this.p_click_4.Size = new System.Drawing.Size(75, 21);
            this.p_click_4.TabIndex = 53;
            this.p_click_4.Text = "Publish";
            this.p_click_4.UseVisualStyleBackColor = true;
            this.p_click_4.Click += new System.EventHandler(this.p_click_4_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(180, 12);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 12);
            this.label9.TabIndex = 56;
            this.label9.Text = "qosLevel";
            // 
            // p_message_0
            // 
            this.p_message_0.Location = new System.Drawing.Point(218, 197);
            this.p_message_0.Name = "p_message_0";
            this.p_message_0.Size = new System.Drawing.Size(169, 21);
            this.p_message_0.TabIndex = 58;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 59;
            this.label3.Text = "发布的主题";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(218, 179);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 60;
            this.label5.Text = "主题数据";
            // 
            // p_message_1
            // 
            this.p_message_1.Location = new System.Drawing.Point(218, 223);
            this.p_message_1.Name = "p_message_1";
            this.p_message_1.Size = new System.Drawing.Size(169, 21);
            this.p_message_1.TabIndex = 61;
            // 
            // p_message_2
            // 
            this.p_message_2.Location = new System.Drawing.Point(218, 248);
            this.p_message_2.Name = "p_message_2";
            this.p_message_2.Size = new System.Drawing.Size(169, 21);
            this.p_message_2.TabIndex = 62;
            // 
            // p_message_3
            // 
            this.p_message_3.Location = new System.Drawing.Point(218, 276);
            this.p_message_3.Name = "p_message_3";
            this.p_message_3.Size = new System.Drawing.Size(169, 21);
            this.p_message_3.TabIndex = 63;
            // 
            // p_message_4
            // 
            this.p_message_4.Location = new System.Drawing.Point(220, 301);
            this.p_message_4.Name = "p_message_4";
            this.p_message_4.Size = new System.Drawing.Size(169, 21);
            this.p_message_4.TabIndex = 64;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(837, 401);
            this.Controls.Add(this.p_message_4);
            this.Controls.Add(this.p_message_3);
            this.Controls.Add(this.p_message_2);
            this.Controls.Add(this.p_message_1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.p_message_0);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.p_qos_4);
            this.Controls.Add(this.p_topic_4);
            this.Controls.Add(this.p_click_4);
            this.Controls.Add(this.s_update_time_4);
            this.Controls.Add(this.s_update_time_3);
            this.Controls.Add(this.s_update_time_2);
            this.Controls.Add(this.s_update_time_1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.s_update_time_0);
            this.Controls.Add(this.p_qos_3);
            this.Controls.Add(this.p_topic_3);
            this.Controls.Add(this.p_click_3);
            this.Controls.Add(this.p_qos_2);
            this.Controls.Add(this.p_topic_2);
            this.Controls.Add(this.p_click_2);
            this.Controls.Add(this.p_qos_1);
            this.Controls.Add(this.p_topic_1);
            this.Controls.Add(this.p_click_1);
            this.Controls.Add(this.p_qos_0);
            this.Controls.Add(this.s_qos_4);
            this.Controls.Add(this.s_qos_3);
            this.Controls.Add(this.s_qos_2);
            this.Controls.Add(this.s_qos_1);
            this.Controls.Add(this.s_qos_0);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.s_click_4);
            this.Controls.Add(this.s_received_4);
            this.Controls.Add(this.s_topic_4);
            this.Controls.Add(this.s_click_3);
            this.Controls.Add(this.s_received_3);
            this.Controls.Add(this.s_topic_3);
            this.Controls.Add(this.s_click_2);
            this.Controls.Add(this.s_received_2);
            this.Controls.Add(this.s_topic_2);
            this.Controls.Add(this.s_click_1);
            this.Controls.Add(this.s_received_1);
            this.Controls.Add(this.s_topic_1);
            this.Controls.Add(this.s_click_0);
            this.Controls.Add(this.s_received_0);
            this.Controls.Add(this.s_topic_0);
            this.Controls.Add(this.disconnect);
            this.Controls.Add(this.p_topic_0);
            this.Controls.Add(this.p_click_0);
            this.Controls.Add(this.Messages);
            this.Controls.Add(this.Go);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MQTT4Onenet";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.From1_Closing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.From1_Closed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Go;
        private System.Windows.Forms.TextBox Messages;
        private System.Windows.Forms.TextBox p_topic_0;
        private System.Windows.Forms.Button p_click_0;
        private System.Windows.Forms.Button disconnect;
        private System.Windows.Forms.TextBox s_topic_0;
        private System.Windows.Forms.TextBox s_received_0;
        private System.Windows.Forms.CheckBox s_click_0;
        private System.Windows.Forms.CheckBox s_click_1;
        private System.Windows.Forms.TextBox s_received_1;
        private System.Windows.Forms.TextBox s_topic_1;
        private System.Windows.Forms.CheckBox s_click_2;
        private System.Windows.Forms.TextBox s_received_2;
        private System.Windows.Forms.TextBox s_topic_2;
        private System.Windows.Forms.CheckBox s_click_3;
        private System.Windows.Forms.TextBox s_received_3;
        private System.Windows.Forms.TextBox s_topic_3;
        private System.Windows.Forms.CheckBox s_click_4;
        private System.Windows.Forms.TextBox s_received_4;
        private System.Windows.Forms.TextBox s_topic_4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox s_qos_0;
        private System.Windows.Forms.ComboBox s_qos_1;
        private System.Windows.Forms.ComboBox s_qos_2;
        private System.Windows.Forms.ComboBox s_qos_3;
        private System.Windows.Forms.ComboBox s_qos_4;
        private System.Windows.Forms.ComboBox p_qos_0;
        private System.Windows.Forms.ComboBox p_qos_1;
        private System.Windows.Forms.TextBox p_topic_1;
        private System.Windows.Forms.Button p_click_1;
        private System.Windows.Forms.ComboBox p_qos_2;
        private System.Windows.Forms.TextBox p_topic_2;
        private System.Windows.Forms.Button p_click_2;
        private System.Windows.Forms.ComboBox p_qos_3;
        private System.Windows.Forms.TextBox p_topic_3;
        private System.Windows.Forms.Button p_click_3;
        private System.Windows.Forms.Label s_update_time_0;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label s_update_time_1;
        private System.Windows.Forms.Label s_update_time_2;
        private System.Windows.Forms.Label s_update_time_3;
        private System.Windows.Forms.Label s_update_time_4;
        private System.Windows.Forms.ComboBox p_qos_4;
        private System.Windows.Forms.TextBox p_topic_4;
        private System.Windows.Forms.Button p_click_4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox p_message_0;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox p_message_1;
        private System.Windows.Forms.TextBox p_message_2;
        private System.Windows.Forms.TextBox p_message_3;
        private System.Windows.Forms.TextBox p_message_4;
    }
}

