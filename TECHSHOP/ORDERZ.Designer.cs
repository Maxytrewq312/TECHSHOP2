namespace TECHSHOP
{
    partial class ORDERZ
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ORDERZ));
            this.LVORDERZ = new System.Windows.Forms.ListView();
            this.NAMEP = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PRICEP = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.COUNTP = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PRICEALL = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Status = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.STATUSCB = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // LVORDERZ
            // 
            this.LVORDERZ.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.LVORDERZ.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.NAMEP,
            this.PRICEP,
            this.COUNTP,
            this.PRICEALL,
            this.Status});
            this.LVORDERZ.ForeColor = System.Drawing.Color.White;
            this.LVORDERZ.GridLines = true;
            this.LVORDERZ.HideSelection = false;
            this.LVORDERZ.Location = new System.Drawing.Point(29, 104);
            this.LVORDERZ.MultiSelect = false;
            this.LVORDERZ.Name = "LVORDERZ";
            this.LVORDERZ.Size = new System.Drawing.Size(1015, 341);
            this.LVORDERZ.TabIndex = 12;
            this.LVORDERZ.UseCompatibleStateImageBehavior = false;
            this.LVORDERZ.View = System.Windows.Forms.View.Details;
            this.LVORDERZ.SelectedIndexChanged += new System.EventHandler(this.LVORDERZ_SelectedIndexChanged);
            // 
            // NAMEP
            // 
            this.NAMEP.Tag = "0";
            this.NAMEP.Text = "НАИМЕНОВАНИЕ";
            this.NAMEP.Width = 242;
            // 
            // PRICEP
            // 
            this.PRICEP.Tag = "1";
            this.PRICEP.Text = "ЦЕНА";
            this.PRICEP.Width = 159;
            // 
            // COUNTP
            // 
            this.COUNTP.Tag = "2";
            this.COUNTP.Text = "КОЛ-ВО";
            this.COUNTP.Width = 99;
            // 
            // PRICEALL
            // 
            this.PRICEALL.Tag = "3";
            this.PRICEALL.Text = "ОБЩАЯ ЦЕНА";
            this.PRICEALL.Width = 223;
            // 
            // Status
            // 
            this.Status.Tag = "4";
            this.Status.Text = "СТАТУС ЗАКАЗА";
            this.Status.Width = 289;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button1.BackgroundImage = global::TECHSHOP.Properties.Resources.ОТМЕНИТЬ_ЗАКАЗ;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(29, 470);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(202, 48);
            this.button1.TabIndex = 13;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button2.BackgroundImage = global::TECHSHOP.Properties.Resources.ИЗМЕНИТЬ_СТАТУС_ЗАКАЗА;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(770, 470);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(274, 48);
            this.button2.TabIndex = 14;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // STATUSCB
            // 
            this.STATUSCB.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.STATUSCB.FormattingEnabled = true;
            this.STATUSCB.Items.AddRange(new object[] {
            "Создан",
            "Обработан",
            "Выполняется",
            "Готов"});
            this.STATUSCB.Location = new System.Drawing.Point(786, 536);
            this.STATUSCB.Name = "STATUSCB";
            this.STATUSCB.Size = new System.Drawing.Size(247, 26);
            this.STATUSCB.TabIndex = 26;
            // 
            // ORDERZ
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TECHSHOP.Properties.Resources.ORDERS;
            this.ClientSize = new System.Drawing.Size(1064, 583);
            this.Controls.Add(this.STATUSCB);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.LVORDERZ);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ORDERZ";
            this.Text = "ЗАКАЗЫ";
            this.Load += new System.EventHandler(this.ORDERZ_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        public System.Windows.Forms.ListView LVORDERZ;
        public System.Windows.Forms.ColumnHeader NAMEP;
        public System.Windows.Forms.ColumnHeader PRICEP;
        public System.Windows.Forms.ColumnHeader COUNTP;
        public System.Windows.Forms.ColumnHeader Status;
        private System.Windows.Forms.ColumnHeader PRICEALL;
        public System.Windows.Forms.ComboBox STATUSCB;
    }
}