namespace Project
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SpecializationBox = new System.Windows.Forms.ComboBox();
            this.NameBox = new System.Windows.Forms.ComboBox();
            this.AddressBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SortBy = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.GoForm1 = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.SaveButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // checkBox1
            // 
            resources.ApplyResources(this.checkBox1, "checkBox1");
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // SpecializationBox
            // 
            this.SpecializationBox.FormattingEnabled = true;
            resources.ApplyResources(this.SpecializationBox, "SpecializationBox");
            this.SpecializationBox.Name = "SpecializationBox";
            this.SpecializationBox.TextChanged += new System.EventHandler(this.comboBox_TextChanged);
            // 
            // NameBox
            // 
            this.NameBox.FormattingEnabled = true;
            resources.ApplyResources(this.NameBox, "NameBox");
            this.NameBox.Name = "NameBox";
            this.NameBox.TextChanged += new System.EventHandler(this.comboBox_TextChanged);
            // 
            // AddressBox
            // 
            this.AddressBox.FormattingEnabled = true;
            resources.ApplyResources(this.AddressBox, "AddressBox");
            this.AddressBox.Name = "AddressBox";
            this.AddressBox.TextChanged += new System.EventHandler(this.comboBox_TextChanged);
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // SortBy
            // 
            this.SortBy.FormattingEnabled = true;
            resources.ApplyResources(this.SortBy, "SortBy");
            this.SortBy.Name = "SortBy";
            this.SortBy.TextChanged += new System.EventHandler(this.comboBox_TextChanged);
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // GoForm1
            // 
            resources.ApplyResources(this.GoForm1, "GoForm1");
            this.GoForm1.Name = "GoForm1";
            this.GoForm1.UseVisualStyleBackColor = true;
            this.GoForm1.Click += new System.EventHandler(this.GoForm1_Click);
            // 
            // flowLayoutPanel1
            // 
            resources.ApplyResources(this.flowLayoutPanel1, "flowLayoutPanel1");
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            // 
            // SaveButton
            // 
            resources.ApplyResources(this.SaveButton, "SaveButton");
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // Form2
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.GoForm1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.SortBy);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.AddressBox);
            this.Controls.Add(this.NameBox);
            this.Controls.Add(this.SpecializationBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkBox1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.KeyPreview = true;
            this.Name = "Form2";
            this.ShowIcon = false;
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox SpecializationBox;
        private System.Windows.Forms.ComboBox NameBox;
        private System.Windows.Forms.ComboBox AddressBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox SortBy;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button GoForm1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button SaveButton;
    }
}