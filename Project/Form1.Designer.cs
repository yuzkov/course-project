namespace Project
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.DataGridShops = new System.Windows.Forms.DataGridView();
            this.GoForm2 = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.AddShop = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.Number = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridShops)).BeginInit();
            this.SuspendLayout();
            // 
            // DataGridShops
            // 
            resources.ApplyResources(this.DataGridShops, "DataGridShops");
            this.DataGridShops.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGridShops.BackgroundColor = System.Drawing.Color.DimGray;
            this.DataGridShops.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DataGridShops.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridShops.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.DataGridShops.Name = "DataGridShops";
            // 
            // GoForm2
            // 
            resources.ApplyResources(this.GoForm2, "GoForm2");
            this.GoForm2.Name = "GoForm2";
            this.GoForm2.UseVisualStyleBackColor = true;
            this.GoForm2.Click += new System.EventHandler(this.GoForm2_Click);
            // 
            // checkBox1
            // 
            resources.ApplyResources(this.checkBox1, "checkBox1");
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // AddShop
            // 
            resources.ApplyResources(this.AddShop, "AddShop");
            this.AddShop.Name = "AddShop";
            this.AddShop.UseVisualStyleBackColor = true;
            this.AddShop.Click += new System.EventHandler(this.AddShop_Click);
            // 
            // Delete
            // 
            resources.ApplyResources(this.Delete, "Delete");
            this.Delete.Name = "Delete";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // Number
            // 
            resources.ApplyResources(this.Number, "Number");
            this.Number.Name = "Number";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Number);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.AddShop);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.GoForm2);
            this.Controls.Add(this.DataGridShops);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridShops)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button GoForm2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button AddShop;
        private System.Windows.Forms.DataGridView DataGridShops;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.TextBox Number;
        private System.Windows.Forms.Label label1;
    }
}

