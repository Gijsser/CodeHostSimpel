namespace HostCSH
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button_Connect = new System.Windows.Forms.Button();
            this.comboBox_Comport = new System.Windows.Forms.ComboBox();
            this.comboBox_Baudrate = new System.Windows.Forms.ComboBox();
            this.textBoxOutput = new System.Windows.Forms.RichTextBox();
            this.button_Disconnect = new System.Windows.Forms.Button();
            this.textBoxJsonMessage = new System.Windows.Forms.TextBox();
            this.buttonSendJson = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.listBoxJsonFiles = new System.Windows.Forms.ListBox();
            this.buttonWriteJsonFIle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(67, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "ComPort";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(67, 161);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "BaudRate";
            // 
            // button_Connect
            // 
            this.button_Connect.Location = new System.Drawing.Point(164, 229);
            this.button_Connect.Name = "button_Connect";
            this.button_Connect.Size = new System.Drawing.Size(111, 44);
            this.button_Connect.TabIndex = 2;
            this.button_Connect.Text = "Connect";
            this.button_Connect.UseVisualStyleBackColor = true;
            this.button_Connect.Click += new System.EventHandler(this.button_Connect_Click);
            // 
            // comboBox_Comport
            // 
            this.comboBox_Comport.FormattingEnabled = true;
            this.comboBox_Comport.Location = new System.Drawing.Point(236, 106);
            this.comboBox_Comport.Name = "comboBox_Comport";
            this.comboBox_Comport.Size = new System.Drawing.Size(121, 37);
            this.comboBox_Comport.TabIndex = 3;
            // 
            // comboBox_Baudrate
            // 
            this.comboBox_Baudrate.FormattingEnabled = true;
            this.comboBox_Baudrate.Location = new System.Drawing.Point(236, 161);
            this.comboBox_Baudrate.Name = "comboBox_Baudrate";
            this.comboBox_Baudrate.Size = new System.Drawing.Size(121, 37);
            this.comboBox_Baudrate.TabIndex = 4;
            // 
            // textBoxOutput
            // 
            this.textBoxOutput.Location = new System.Drawing.Point(539, 118);
            this.textBoxOutput.Name = "textBoxOutput";
            this.textBoxOutput.Size = new System.Drawing.Size(1021, 610);
            this.textBoxOutput.TabIndex = 5;
            this.textBoxOutput.Text = "";
            // 
            // button_Disconnect
            // 
            this.button_Disconnect.Location = new System.Drawing.Point(140, 279);
            this.button_Disconnect.Name = "button_Disconnect";
            this.button_Disconnect.Size = new System.Drawing.Size(150, 44);
            this.button_Disconnect.TabIndex = 6;
            this.button_Disconnect.Text = "Disconnect";
            this.button_Disconnect.UseVisualStyleBackColor = true;
            this.button_Disconnect.Click += new System.EventHandler(this.button_Disconnect_Click);
            // 
            // textBoxJsonMessage
            // 
            this.textBoxJsonMessage.Location = new System.Drawing.Point(40, 796);
            this.textBoxJsonMessage.Name = "textBoxJsonMessage";
            this.textBoxJsonMessage.Size = new System.Drawing.Size(908, 35);
            this.textBoxJsonMessage.TabIndex = 7;
            // 
            // buttonSendJson
            // 
            this.buttonSendJson.Location = new System.Drawing.Point(40, 861);
            this.buttonSendJson.Name = "buttonSendJson";
            this.buttonSendJson.Size = new System.Drawing.Size(202, 38);
            this.buttonSendJson.TabIndex = 8;
            this.buttonSendJson.Text = "Send Json";
            this.buttonSendJson.UseVisualStyleBackColor = true;
            this.buttonSendJson.Click += new System.EventHandler(this.buttonSendJson_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(0, 0);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 37);
            this.comboBox1.TabIndex = 9;
            // 
            // listBoxJsonFiles
            // 
            this.listBoxJsonFiles.FormattingEnabled = true;
            this.listBoxJsonFiles.ItemHeight = 29;
            this.listBoxJsonFiles.Location = new System.Drawing.Point(1616, 115);
            this.listBoxJsonFiles.Name = "listBoxJsonFiles";
            this.listBoxJsonFiles.Size = new System.Drawing.Size(766, 613);
            this.listBoxJsonFiles.TabIndex = 10;
            this.listBoxJsonFiles.SelectedIndexChanged += new System.EventHandler(this.listBoxJsonFiles_SelectedIndexChanged);
            // 
            // buttonWriteJsonFIle
            // 
            this.buttonWriteJsonFIle.Location = new System.Drawing.Point(2388, 686);
            this.buttonWriteJsonFIle.Name = "buttonWriteJsonFIle";
            this.buttonWriteJsonFIle.Size = new System.Drawing.Size(134, 42);
            this.buttonWriteJsonFIle.TabIndex = 11;
            this.buttonWriteJsonFIle.Text = "Write";
            this.buttonWriteJsonFIle.UseVisualStyleBackColor = true;
            this.buttonWriteJsonFIle.Click += new System.EventHandler(this.buttonWriteJsonFIle_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2604, 1065);
            this.Controls.Add(this.buttonWriteJsonFIle);
            this.Controls.Add(this.listBoxJsonFiles);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.buttonSendJson);
            this.Controls.Add(this.textBoxJsonMessage);
            this.Controls.Add(this.button_Disconnect);
            this.Controls.Add(this.textBoxOutput);
            this.Controls.Add(this.comboBox_Baudrate);
            this.Controls.Add(this.comboBox_Comport);
            this.Controls.Add(this.button_Connect);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_Connect;
        private System.Windows.Forms.ComboBox comboBox_Comport;
        private System.Windows.Forms.ComboBox comboBox_Baudrate;
        private System.Windows.Forms.RichTextBox textBoxOutput;
        private System.Windows.Forms.Button button_Disconnect;
        private System.Windows.Forms.TextBox textBoxJsonMessage;
        private System.Windows.Forms.Button buttonSendJson;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ListBox listBoxJsonFiles;
        private System.Windows.Forms.Button buttonWriteJsonFIle;
    }
}

