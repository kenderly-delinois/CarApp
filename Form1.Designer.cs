namespace CarApp
{
    partial class Form1
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
            cargrid = new DataGridView();
            combomake = new ComboBox();
            lblvin = new Label();
            lblmake = new Label();
            lblmodel = new Label();
            lblyear = new Label();
            txtvin = new TextBox();
            txtyear = new TextBox();
            btnaddcar = new Button();
            combomodel = new ComboBox();
            lblprice = new Label();
            txtprice = new TextBox();
            btnsubmit = new Button();
            btnupdate = new Button();
            btndelete = new Button();
            btnselecttoupdate = new Button();
            lblid = new Label();
            txtid = new TextBox();
            ((System.ComponentModel.ISupportInitialize)cargrid).BeginInit();
            SuspendLayout();
            // 
            // cargrid
            // 
            cargrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            cargrid.Location = new Point(77, 12);
            cargrid.Name = "cargrid";
            cargrid.Size = new Size(636, 203);
            cargrid.TabIndex = 0;
            // 
            // combomake
            // 
            combomake.FormattingEnabled = true;
            combomake.Location = new Point(119, 324);
            combomake.Name = "combomake";
            combomake.Size = new Size(121, 23);
            combomake.TabIndex = 1;
            // 
            // lblvin
            // 
            lblvin.AutoSize = true;
            lblvin.Location = new Point(47, 285);
            lblvin.Name = "lblvin";
            lblvin.Size = new Size(45, 15);
            lblvin.TabIndex = 2;
            lblvin.Text = "Car Vin";
            // 
            // lblmake
            // 
            lblmake.AutoSize = true;
            lblmake.Location = new Point(44, 324);
            lblmake.Name = "lblmake";
            lblmake.Size = new Size(57, 15);
            lblmake.TabIndex = 3;
            lblmake.Text = "Car Make";
            // 
            // lblmodel
            // 
            lblmodel.AutoSize = true;
            lblmodel.Location = new Point(47, 358);
            lblmodel.Name = "lblmodel";
            lblmodel.Size = new Size(62, 15);
            lblmodel.TabIndex = 4;
            lblmodel.Text = "Car Model";
            // 
            // lblyear
            // 
            lblyear.AutoSize = true;
            lblyear.Location = new Point(47, 387);
            lblyear.Name = "lblyear";
            lblyear.Size = new Size(50, 15);
            lblyear.TabIndex = 5;
            lblyear.Text = "Car Year";
            // 
            // txtvin
            // 
            txtvin.Location = new Point(119, 285);
            txtvin.Name = "txtvin";
            txtvin.Size = new Size(121, 23);
            txtvin.TabIndex = 6;
            // 
            // txtyear
            // 
            txtyear.Location = new Point(119, 387);
            txtyear.Name = "txtyear";
            txtyear.Size = new Size(121, 23);
            txtyear.TabIndex = 8;
            // 
            // btnaddcar
            // 
            btnaddcar.Location = new Point(302, 328);
            btnaddcar.Name = "btnaddcar";
            btnaddcar.Size = new Size(105, 23);
            btnaddcar.TabIndex = 10;
            btnaddcar.Text = "Add Car";
            btnaddcar.UseVisualStyleBackColor = true;
            btnaddcar.Click += btnaddcar_Click;
            // 
            // combomodel
            // 
            combomodel.FormattingEnabled = true;
            combomodel.Location = new Point(119, 358);
            combomodel.Name = "combomodel";
            combomodel.Size = new Size(121, 23);
            combomodel.TabIndex = 11;
            // 
            // lblprice
            // 
            lblprice.AutoSize = true;
            lblprice.Location = new Point(47, 424);
            lblprice.Name = "lblprice";
            lblprice.Size = new Size(54, 15);
            lblprice.TabIndex = 12;
            lblprice.Text = "Car Price";
            // 
            // txtprice
            // 
            txtprice.Location = new Point(119, 416);
            txtprice.Name = "txtprice";
            txtprice.Size = new Size(121, 23);
            txtprice.TabIndex = 13;
            // 
            // btnsubmit
            // 
            btnsubmit.Location = new Point(435, 266);
            btnsubmit.Name = "btnsubmit";
            btnsubmit.Size = new Size(105, 23);
            btnsubmit.TabIndex = 14;
            btnsubmit.Text = "Submit";
            btnsubmit.UseVisualStyleBackColor = true;
            btnsubmit.Click += btnsubmit_Click;
            // 
            // btnupdate
            // 
            btnupdate.Location = new Point(435, 324);
            btnupdate.Name = "btnupdate";
            btnupdate.Size = new Size(105, 23);
            btnupdate.TabIndex = 15;
            btnupdate.Text = "Update";
            btnupdate.UseVisualStyleBackColor = true;
            btnupdate.Click += btnupdate_Click;
            // 
            // btndelete
            // 
            btndelete.Location = new Point(435, 389);
            btndelete.Name = "btndelete";
            btndelete.Size = new Size(105, 23);
            btndelete.TabIndex = 16;
            btndelete.Text = "Delete";
            btndelete.UseVisualStyleBackColor = true;
            btndelete.Click += btndelete_Click;
            // 
            // btnselecttoupdate
            // 
            btnselecttoupdate.Location = new Point(574, 328);
            btnselecttoupdate.Name = "btnselecttoupdate";
            btnselecttoupdate.Size = new Size(105, 23);
            btnselecttoupdate.TabIndex = 17;
            btnselecttoupdate.Text = "Select To Update";
            btnselecttoupdate.UseVisualStyleBackColor = true;
            btnselecttoupdate.Click += btnselecttoupdate_Click;
            // 
            // lblid
            // 
            lblid.AutoSize = true;
            lblid.Location = new Point(47, 255);
            lblid.Name = "lblid";
            lblid.Size = new Size(39, 15);
            lblid.TabIndex = 18;
            lblid.Text = "Car ID";
            // 
            // txtid
            // 
            txtid.Location = new Point(119, 252);
            txtid.Name = "txtid";
            txtid.Size = new Size(121, 23);
            txtid.TabIndex = 19;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtid);
            Controls.Add(lblid);
            Controls.Add(btnselecttoupdate);
            Controls.Add(btndelete);
            Controls.Add(btnupdate);
            Controls.Add(btnsubmit);
            Controls.Add(txtprice);
            Controls.Add(lblprice);
            Controls.Add(combomodel);
            Controls.Add(btnaddcar);
            Controls.Add(txtyear);
            Controls.Add(txtvin);
            Controls.Add(lblyear);
            Controls.Add(lblmodel);
            Controls.Add(lblmake);
            Controls.Add(lblvin);
            Controls.Add(combomake);
            Controls.Add(cargrid);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)cargrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView cargrid;
        private ComboBox combomake;
        private Label lblvin;
        private Label lblmake;
        private Label lblmodel;
        private Label lblyear;
        private TextBox txtvin;
        private TextBox txtyear;
        private Button btnaddcar;
        private ComboBox combomodel;
        private Label lblprice;
        private TextBox txtprice;
        private Button btnsubmit;
        private Button btnupdate;
        private Button btndelete;
        private Button btnselecttoupdate;
        private Label lblid;
        private TextBox txtid;
    }
}
