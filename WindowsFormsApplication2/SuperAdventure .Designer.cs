namespace WindowsFormsApplication2
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
            this.components = new System.ComponentModel.Container();
            this.button_click = new System.Windows.Forms.Button();
            this.label_points = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button_addon_10 = new System.Windows.Forms.Button();
            this.button_addon_9 = new System.Windows.Forms.Button();
            this.button_addon_8 = new System.Windows.Forms.Button();
            this.button_addon_7 = new System.Windows.Forms.Button();
            this.button_addon_6 = new System.Windows.Forms.Button();
            this.button_addon_5 = new System.Windows.Forms.Button();
            this.label_addon1 = new System.Windows.Forms.Label();
            this.button_addon_4 = new System.Windows.Forms.Button();
            this.button_addon_3 = new System.Windows.Forms.Button();
            this.button_addon_2 = new System.Windows.Forms.Button();
            this.button_addon_1 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_click
            // 
            this.button_click.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_click.Location = new System.Drawing.Point(27, 245);
            this.button_click.Name = "button_click";
            this.button_click.Size = new System.Drawing.Size(240, 69);
            this.button_click.TabIndex = 0;
            this.button_click.Text = "Click me";
            this.button_click.UseVisualStyleBackColor = true;
            this.button_click.Click += new System.EventHandler(this.button_click_Click);
            // 
            // label_points
            // 
            this.label_points.AutoSize = true;
            this.label_points.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_points.Location = new System.Drawing.Point(100, 38);
            this.label_points.Name = "label_points";
            this.label_points.Size = new System.Drawing.Size(88, 25);
            this.label_points.TabIndex = 1;
            this.label_points.Text = "0 points";
            this.label_points.Click += new System.EventHandler(this.label1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button_addon_10);
            this.groupBox1.Controls.Add(this.button_addon_9);
            this.groupBox1.Controls.Add(this.button_addon_8);
            this.groupBox1.Controls.Add(this.button_addon_7);
            this.groupBox1.Controls.Add(this.button_addon_6);
            this.groupBox1.Controls.Add(this.button_addon_5);
            this.groupBox1.Controls.Add(this.label_addon1);
            this.groupBox1.Controls.Add(this.button_addon_4);
            this.groupBox1.Controls.Add(this.button_addon_3);
            this.groupBox1.Controls.Add(this.button_addon_2);
            this.groupBox1.Controls.Add(this.button_addon_1);
            this.groupBox1.Location = new System.Drawing.Point(363, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(309, 540);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Buy Addons";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // button_addon_10
            // 
            this.button_addon_10.Location = new System.Drawing.Point(164, 366);
            this.button_addon_10.Name = "button_addon_10";
            this.button_addon_10.Size = new System.Drawing.Size(138, 54);
            this.button_addon_10.TabIndex = 18;
            this.button_addon_10.Text = "10,000p";
            this.button_addon_10.UseVisualStyleBackColor = true;
            // 
            // button_addon_9
            // 
            this.button_addon_9.Location = new System.Drawing.Point(9, 366);
            this.button_addon_9.Name = "button_addon_9";
            this.button_addon_9.Size = new System.Drawing.Size(138, 54);
            this.button_addon_9.TabIndex = 16;
            this.button_addon_9.Text = "5,000p";
            this.button_addon_9.UseVisualStyleBackColor = true;
            // 
            // button_addon_8
            // 
            this.button_addon_8.Location = new System.Drawing.Point(164, 285);
            this.button_addon_8.Name = "button_addon_8";
            this.button_addon_8.Size = new System.Drawing.Size(138, 54);
            this.button_addon_8.TabIndex = 14;
            this.button_addon_8.Text = "4,000p";
            this.button_addon_8.UseVisualStyleBackColor = true;
            // 
            // button_addon_7
            // 
            this.button_addon_7.Location = new System.Drawing.Point(9, 285);
            this.button_addon_7.Name = "button_addon_7";
            this.button_addon_7.Size = new System.Drawing.Size(138, 54);
            this.button_addon_7.TabIndex = 12;
            this.button_addon_7.Text = "3,000p";
            this.button_addon_7.UseVisualStyleBackColor = true;
            // 
            // button_addon_6
            // 
            this.button_addon_6.Location = new System.Drawing.Point(164, 204);
            this.button_addon_6.Name = "button_addon_6";
            this.button_addon_6.Size = new System.Drawing.Size(138, 54);
            this.button_addon_6.TabIndex = 10;
            this.button_addon_6.Text = "2,000p";
            this.button_addon_6.UseVisualStyleBackColor = true;
            // 
            // button_addon_5
            // 
            this.button_addon_5.Location = new System.Drawing.Point(6, 204);
            this.button_addon_5.Name = "button_addon_5";
            this.button_addon_5.Size = new System.Drawing.Size(138, 54);
            this.button_addon_5.TabIndex = 8;
            this.button_addon_5.Text = "1,000p";
            this.button_addon_5.UseVisualStyleBackColor = true;
            // 
            // label_addon1
            // 
            this.label_addon1.AutoSize = true;
            this.label_addon1.Location = new System.Drawing.Point(6, 26);
            this.label_addon1.Name = "label_addon1";
            this.label_addon1.Size = new System.Drawing.Size(52, 13);
            this.label_addon1.TabIndex = 4;
            this.label_addon1.Text = "Amount =";
            // 
            // button_addon_4
            // 
            this.button_addon_4.Location = new System.Drawing.Point(164, 123);
            this.button_addon_4.Name = "button_addon_4";
            this.button_addon_4.Size = new System.Drawing.Size(138, 54);
            this.button_addon_4.TabIndex = 3;
            this.button_addon_4.Text = "500p";
            this.button_addon_4.UseVisualStyleBackColor = true;
            this.button_addon_4.Click += new System.EventHandler(this.button_addon_4_Click);
            // 
            // button_addon_3
            // 
            this.button_addon_3.Location = new System.Drawing.Point(6, 123);
            this.button_addon_3.Name = "button_addon_3";
            this.button_addon_3.Size = new System.Drawing.Size(138, 54);
            this.button_addon_3.TabIndex = 2;
            this.button_addon_3.Text = "250p";
            this.button_addon_3.UseVisualStyleBackColor = true;
            this.button_addon_3.Click += new System.EventHandler(this.button_addon_3_Click);
            // 
            // button_addon_2
            // 
            this.button_addon_2.Location = new System.Drawing.Point(164, 42);
            this.button_addon_2.Name = "button_addon_2";
            this.button_addon_2.Size = new System.Drawing.Size(138, 54);
            this.button_addon_2.TabIndex = 1;
            this.button_addon_2.Text = "100p";
            this.button_addon_2.UseVisualStyleBackColor = true;
            this.button_addon_2.Click += new System.EventHandler(this.button_addon_2_Click);
            // 
            // button_addon_1
            // 
            this.button_addon_1.Location = new System.Drawing.Point(6, 42);
            this.button_addon_1.Name = "button_addon_1";
            this.button_addon_1.Size = new System.Drawing.Size(138, 54);
            this.button_addon_1.TabIndex = 0;
            this.button_addon_1.Text = "Auto clicker - 50P";
            this.button_addon_1.UseVisualStyleBackColor = true;
            this.button_addon_1.Click += new System.EventHandler(this.button_addon_1_Click_1);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 50;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Interval = 1;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 564);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label_points);
            this.Controls.Add(this.button_click);
            this.Name = "Form1";
            this.Text = "Cookie clicker";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_click;
        private System.Windows.Forms.Label label_points;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button_addon_1;
        private System.Windows.Forms.Button button_addon_4;
        private System.Windows.Forms.Button button_addon_3;
        private System.Windows.Forms.Button button_addon_2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Button button_addon_5;
        private System.Windows.Forms.Label label_addon1;
        private System.Windows.Forms.Button button_addon_10;
        private System.Windows.Forms.Button button_addon_9;
        private System.Windows.Forms.Button button_addon_8;
        private System.Windows.Forms.Button button_addon_7;
        private System.Windows.Forms.Button button_addon_6;
    }
}

