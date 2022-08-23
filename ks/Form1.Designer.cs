namespace ks
{
    partial class soft_start
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            this.label1 = new System.Windows.Forms.Label();
            this.button_start = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_address = new System.Windows.Forms.TextBox();
            this.button_stop = new System.Windows.Forms.Button();
            this.label_status = new System.Windows.Forms.Label();
            this.textBox_setup_current_value = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.vScrollBar_voltage = new System.Windows.Forms.VScrollBar();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_setup_voltage_value = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label_meas_current = new System.Windows.Forms.Label();
            this.label_meas_voltage = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.Location = new System.Drawing.Point(81, 113);
            this.vScrollBar1.Maximum = 1000;
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(48, 282);
            this.vScrollBar1.TabIndex = 1;
            this.vScrollBar1.ValueChanged += new System.EventHandler(this.vScrollBar1_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(197, 270);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Output current";
            // 
            // button_start
            // 
            this.button_start.Location = new System.Drawing.Point(221, 130);
            this.button_start.Name = "button_start";
            this.button_start.Size = new System.Drawing.Size(94, 29);
            this.button_start.TabIndex = 4;
            this.button_start.Text = "Start";
            this.button_start.UseVisualStyleBackColor = true;
            this.button_start.Click += new System.EventHandler(this.button_start_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "address";
            // 
            // textBox_address
            // 
            this.textBox_address.Location = new System.Drawing.Point(12, 32);
            this.textBox_address.Name = "textBox_address";
            this.textBox_address.Size = new System.Drawing.Size(409, 27);
            this.textBox_address.TabIndex = 6;
            // 
            // button_stop
            // 
            this.button_stop.Location = new System.Drawing.Point(341, 130);
            this.button_stop.Name = "button_stop";
            this.button_stop.Size = new System.Drawing.Size(94, 29);
            this.button_stop.TabIndex = 7;
            this.button_stop.Text = "Stop";
            this.button_stop.UseVisualStyleBackColor = true;
            this.button_stop.Click += new System.EventHandler(this.button_stop_Click);
            // 
            // label_status
            // 
            this.label_status.AutoSize = true;
            this.label_status.Location = new System.Drawing.Point(228, 91);
            this.label_status.Name = "label_status";
            this.label_status.Size = new System.Drawing.Size(42, 20);
            this.label_status.TabIndex = 8;
            this.label_status.Text = "stop";
            // 
            // textBox_setup_current_value
            // 
            this.textBox_setup_current_value.Location = new System.Drawing.Point(197, 328);
            this.textBox_setup_current_value.Name = "textBox_setup_current_value";
            this.textBox_setup_current_value.Size = new System.Drawing.Size(125, 27);
            this.textBox_setup_current_value.TabIndex = 9;
            this.textBox_setup_current_value.Validated += new System.EventHandler(this.textBox_setup_current_value_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(64, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "current limited";
            // 
            // vScrollBar_voltage
            // 
            this.vScrollBar_voltage.Location = new System.Drawing.Point(536, 130);
            this.vScrollBar_voltage.Maximum = 1000;
            this.vScrollBar_voltage.Name = "vScrollBar_voltage";
            this.vScrollBar_voltage.Size = new System.Drawing.Size(48, 282);
            this.vScrollBar_voltage.TabIndex = 11;
            this.vScrollBar_voltage.ValueChanged += new System.EventHandler(this.vScrollBar_voltage_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(516, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "voltage limited";
            // 
            // textBox_setup_voltage_value
            // 
            this.textBox_setup_voltage_value.Location = new System.Drawing.Point(609, 328);
            this.textBox_setup_voltage_value.Name = "textBox_setup_voltage_value";
            this.textBox_setup_voltage_value.Size = new System.Drawing.Size(125, 27);
            this.textBox_setup_voltage_value.TabIndex = 13;
            this.textBox_setup_voltage_value.Validated += new System.EventHandler(this.textBox_setup_voltage_value_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(609, 275);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 20);
            this.label5.TabIndex = 14;
            this.label5.Text = "Output voltage";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(197, 375);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(218, 20);
            this.label6.TabIndex = 15;
            this.label6.Text = "measure current and voltage";
            // 
            // label_meas_current
            // 
            this.label_meas_current.AutoSize = true;
            this.label_meas_current.Location = new System.Drawing.Point(163, 405);
            this.label_meas_current.Name = "label_meas_current";
            this.label_meas_current.Size = new System.Drawing.Size(18, 20);
            this.label_meas_current.TabIndex = 16;
            this.label_meas_current.Text = "0";
            // 
            // label_meas_voltage
            // 
            this.label_meas_voltage.AutoSize = true;
            this.label_meas_voltage.Location = new System.Drawing.Point(341, 405);
            this.label_meas_voltage.Name = "label_meas_voltage";
            this.label_meas_voltage.Size = new System.Drawing.Size(18, 20);
            this.label_meas_voltage.TabIndex = 17;
            this.label_meas_voltage.Text = "0";
            // 
            // soft_start
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label_meas_voltage);
            this.Controls.Add(this.label_meas_current);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox_setup_voltage_value);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.vScrollBar_voltage);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_setup_current_value);
            this.Controls.Add(this.label_status);
            this.Controls.Add(this.button_stop);
            this.Controls.Add(this.textBox_address);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button_start);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.vScrollBar1);
            this.Name = "soft_start";
            this.Text = "Soft_start";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private VScrollBar vScrollBar1;
        private Label label1;
        private Button button_start;
        private Label label2;
        private TextBox textBox_address;
        private Button button_stop;
        private Label label_status;
        private TextBox textBox_setup_current_value;
        private Label label3;
        private VScrollBar vScrollBar_voltage;
        private Label label4;
        private TextBox textBox_setup_voltage_value;
        private Label label5;
        private Label label6;
        private Label label_meas_current;
        private Label label_meas_voltage;
    }
}