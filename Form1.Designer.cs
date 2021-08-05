
namespace Covid_patient_tracking_system
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
            this.openbutton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.previousbutton = new System.Windows.Forms.Button();
            this.nextbutton = new System.Windows.Forms.Button();
            this.updatebutton = new System.Windows.Forms.Button();
            this.savebutton = new System.Windows.Forms.Button();
            this.namesearchtextBox = new System.Windows.Forms.TextBox();
            this.namesearchbutton = new System.Windows.Forms.Button();
            this.cleargridbutton = new System.Windows.Forms.Button();
            this.patientmedicalhistoryaddbutton = new System.Windows.Forms.Button();
            this.patienttreatmentbutton = new System.Windows.Forms.Button();
            this.medicalstaffbutton = new System.Windows.Forms.Button();
            this.Headinglabel = new System.Windows.Forms.Label();
            this.deletebutton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // openbutton
            // 
            this.openbutton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.openbutton.Location = new System.Drawing.Point(132, 74);
            this.openbutton.Name = "openbutton";
            this.openbutton.Size = new System.Drawing.Size(221, 32);
            this.openbutton.TabIndex = 0;
            this.openbutton.Text = "Patient Detail";
            this.openbutton.UseVisualStyleBackColor = true;
            this.openbutton.Click += new System.EventHandler(this.openbutton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 229);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(834, 235);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // previousbutton
            // 
            this.previousbutton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.previousbutton.Location = new System.Drawing.Point(10, 186);
            this.previousbutton.Name = "previousbutton";
            this.previousbutton.Size = new System.Drawing.Size(93, 32);
            this.previousbutton.TabIndex = 3;
            this.previousbutton.Text = "Previous ";
            this.previousbutton.UseVisualStyleBackColor = true;
            this.previousbutton.Click += new System.EventHandler(this.previousbutton_Click);
            // 
            // nextbutton
            // 
            this.nextbutton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.nextbutton.Location = new System.Drawing.Point(104, 186);
            this.nextbutton.Name = "nextbutton";
            this.nextbutton.Size = new System.Drawing.Size(101, 32);
            this.nextbutton.TabIndex = 4;
            this.nextbutton.Text = "Next";
            this.nextbutton.UseVisualStyleBackColor = true;
            this.nextbutton.Click += new System.EventHandler(this.nextbutton_Click);
            // 
            // updatebutton
            // 
            this.updatebutton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.updatebutton.Location = new System.Drawing.Point(309, 186);
            this.updatebutton.Name = "updatebutton";
            this.updatebutton.Size = new System.Drawing.Size(125, 32);
            this.updatebutton.TabIndex = 7;
            this.updatebutton.Text = "Edit/Add";
            this.updatebutton.UseVisualStyleBackColor = true;
            this.updatebutton.Click += new System.EventHandler(this.updatebutton_Click);
            // 
            // savebutton
            // 
            this.savebutton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.savebutton.Location = new System.Drawing.Point(542, 186);
            this.savebutton.Name = "savebutton";
            this.savebutton.Size = new System.Drawing.Size(96, 32);
            this.savebutton.TabIndex = 8;
            this.savebutton.Text = "Save";
            this.savebutton.UseVisualStyleBackColor = true;
            this.savebutton.Click += new System.EventHandler(this.savebutton_Click);
            // 
            // namesearchtextBox
            // 
            this.namesearchtextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.namesearchtextBox.Location = new System.Drawing.Point(644, 193);
            this.namesearchtextBox.Name = "namesearchtextBox";
            this.namesearchtextBox.Size = new System.Drawing.Size(119, 23);
            this.namesearchtextBox.TabIndex = 11;
            // 
            // namesearchbutton
            // 
            this.namesearchbutton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.namesearchbutton.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.namesearchbutton.Location = new System.Drawing.Point(764, 194);
            this.namesearchbutton.Name = "namesearchbutton";
            this.namesearchbutton.Size = new System.Drawing.Size(80, 24);
            this.namesearchbutton.TabIndex = 13;
            this.namesearchbutton.Text = "Search";
            this.namesearchbutton.UseVisualStyleBackColor = true;
            this.namesearchbutton.Click += new System.EventHandler(this.namesearchbutton_Click);
            // 
            // cleargridbutton
            // 
            this.cleargridbutton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cleargridbutton.Location = new System.Drawing.Point(206, 186);
            this.cleargridbutton.Name = "cleargridbutton";
            this.cleargridbutton.Size = new System.Drawing.Size(102, 32);
            this.cleargridbutton.TabIndex = 16;
            this.cleargridbutton.Text = "Clear Grid";
            this.cleargridbutton.UseVisualStyleBackColor = true;
            this.cleargridbutton.Click += new System.EventHandler(this.cleargridbutton_Click);
            // 
            // patientmedicalhistoryaddbutton
            // 
            this.patientmedicalhistoryaddbutton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.patientmedicalhistoryaddbutton.Location = new System.Drawing.Point(132, 127);
            this.patientmedicalhistoryaddbutton.Name = "patientmedicalhistoryaddbutton";
            this.patientmedicalhistoryaddbutton.Size = new System.Drawing.Size(221, 32);
            this.patientmedicalhistoryaddbutton.TabIndex = 18;
            this.patientmedicalhistoryaddbutton.Text = "Patient Medical History";
            this.patientmedicalhistoryaddbutton.UseVisualStyleBackColor = true;
            this.patientmedicalhistoryaddbutton.Click += new System.EventHandler(this.patientmedicalhistoryaddbutton_Click);
            // 
            // patienttreatmentbutton
            // 
            this.patienttreatmentbutton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.patienttreatmentbutton.Location = new System.Drawing.Point(473, 127);
            this.patienttreatmentbutton.Name = "patienttreatmentbutton";
            this.patienttreatmentbutton.Size = new System.Drawing.Size(215, 32);
            this.patienttreatmentbutton.TabIndex = 20;
            this.patienttreatmentbutton.Text = "Patient Treatment";
            this.patienttreatmentbutton.UseVisualStyleBackColor = true;
            this.patienttreatmentbutton.Click += new System.EventHandler(this.patienttreatmentbutton_Click);
            // 
            // medicalstaffbutton
            // 
            this.medicalstaffbutton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.medicalstaffbutton.Location = new System.Drawing.Point(473, 74);
            this.medicalstaffbutton.Name = "medicalstaffbutton";
            this.medicalstaffbutton.Size = new System.Drawing.Size(215, 32);
            this.medicalstaffbutton.TabIndex = 22;
            this.medicalstaffbutton.Text = "Medical Staff";
            this.medicalstaffbutton.UseVisualStyleBackColor = true;
            this.medicalstaffbutton.Click += new System.EventHandler(this.medicalstaffbutton_Click);
            // 
            // Headinglabel
            // 
            this.Headinglabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Headinglabel.AutoSize = true;
            this.Headinglabel.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Headinglabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Headinglabel.Location = new System.Drawing.Point(220, 9);
            this.Headinglabel.Name = "Headinglabel";
            this.Headinglabel.Size = new System.Drawing.Size(403, 37);
            this.Headinglabel.TabIndex = 23;
            this.Headinglabel.Text = "Covid Patient Tracking system\r\n";
            // 
            // deletebutton
            // 
            this.deletebutton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.deletebutton.Location = new System.Drawing.Point(440, 186);
            this.deletebutton.Name = "deletebutton";
            this.deletebutton.Size = new System.Drawing.Size(96, 32);
            this.deletebutton.TabIndex = 24;
            this.deletebutton.Text = "Delete";
            this.deletebutton.UseVisualStyleBackColor = true;
            this.deletebutton.Click += new System.EventHandler(this.deletebutton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(859, 470);
            this.Controls.Add(this.deletebutton);
            this.Controls.Add(this.Headinglabel);
            this.Controls.Add(this.medicalstaffbutton);
            this.Controls.Add(this.patienttreatmentbutton);
            this.Controls.Add(this.patientmedicalhistoryaddbutton);
            this.Controls.Add(this.cleargridbutton);
            this.Controls.Add(this.namesearchbutton);
            this.Controls.Add(this.namesearchtextBox);
            this.Controls.Add(this.savebutton);
            this.Controls.Add(this.updatebutton);
            this.Controls.Add(this.nextbutton);
            this.Controls.Add(this.previousbutton);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.openbutton);
            this.Name = "Form1";
            this.Text = "Open";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button openbutton;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button previousbutton;
        private System.Windows.Forms.Button nextbutton;
        private System.Windows.Forms.Button updatebutton;
        private System.Windows.Forms.Button savebutton;
        private System.Windows.Forms.TextBox namesearchtextBox;
        private System.Windows.Forms.Button namesearchbutton;
        private System.Windows.Forms.Button cleargridbutton;
        private System.Windows.Forms.Button patientmedicalhistoryaddbutton;
        private System.Windows.Forms.Button patienttreatmentbutton;
        private System.Windows.Forms.Button medicalstaffbutton;
        private System.Windows.Forms.Label Headinglabel;
        private System.Windows.Forms.Button deletebutton;
    }
}

