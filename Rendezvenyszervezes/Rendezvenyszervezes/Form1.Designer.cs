namespace Rendezvenyszervezes
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
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lb_carNumber = new System.Windows.Forms.Label();
            this.btn_addCars = new System.Windows.Forms.Button();
            this.nud_addCars = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.grid_cars = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.grid_props = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_addCars)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_cars)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_props)).BeginInit();
            this.SuspendLayout();
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(768, 400);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Rendezvényszervezés";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.panel2);
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(768, 400);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Erőforrás";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(776, 426);
            this.tabControl1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.grid_cars);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.nud_addCars);
            this.panel1.Controls.Add(this.btn_addCars);
            this.panel1.Controls.Add(this.lb_carNumber);
            this.panel1.Location = new System.Drawing.Point(6, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(756, 190);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(205, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Elérhető autók:";
            // 
            // lb_carNumber
            // 
            this.lb_carNumber.AutoSize = true;
            this.lb_carNumber.Location = new System.Drawing.Point(288, 7);
            this.lb_carNumber.Name = "lb_carNumber";
            this.lb_carNumber.Size = new System.Drawing.Size(13, 13);
            this.lb_carNumber.TabIndex = 0;
            this.lb_carNumber.Text = "0";
            // 
            // btn_addCars
            // 
            this.btn_addCars.Location = new System.Drawing.Point(306, 23);
            this.btn_addCars.Name = "btn_addCars";
            this.btn_addCars.Size = new System.Drawing.Size(151, 23);
            this.btn_addCars.TabIndex = 1;
            this.btn_addCars.Text = "Autó hozzáadása";
            this.btn_addCars.UseVisualStyleBackColor = true;
            this.btn_addCars.Click += new System.EventHandler(this.button1_Click);
            // 
            // nud_addCars
            // 
            this.nud_addCars.Location = new System.Drawing.Point(208, 26);
            this.nud_addCars.Name = "nud_addCars";
            this.nud_addCars.Size = new System.Drawing.Size(67, 20);
            this.nud_addCars.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(281, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(19, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "db";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // grid_cars
            // 
            this.grid_cars.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grid_cars.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_cars.Location = new System.Drawing.Point(3, 64);
            this.grid_cars.Name = "grid_cars";
            this.grid_cars.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.grid_cars.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.grid_cars.Size = new System.Drawing.Size(750, 126);
            this.grid_cars.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.grid_props);
            this.panel2.Location = new System.Drawing.Point(6, 202);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(756, 195);
            this.panel2.TabIndex = 1;
            // 
            // grid_props
            // 
            this.grid_props.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grid_props.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_props.Location = new System.Drawing.Point(-3, 0);
            this.grid_props.Name = "grid_props";
            this.grid_props.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.grid_props.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.grid_props.Size = new System.Drawing.Size(753, 189);
            this.grid_props.TabIndex = 5;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(768, 400);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Készlet";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Rendezvényszervezés";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabPage1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_addCars)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_cars)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grid_props)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_addCars;
        private System.Windows.Forms.Label lb_carNumber;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nud_addCars;
        private System.Windows.Forms.DataGridView grid_cars;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView grid_props;
        private System.Windows.Forms.TabPage tabPage3;
    }
}

