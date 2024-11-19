namespace OfficeEquipment_
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
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.btnAddEquipment = new System.Windows.Forms.Button();
            this.btnAddFax = new System.Windows.Forms.Button();
            this.btnAddPrinter = new System.Windows.Forms.Button();
            this.btnShowDevices = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtOutput
            // 
            this.txtOutput.Location = new System.Drawing.Point(88, 133);
            this.txtOutput.Multiline = true;
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.Size = new System.Drawing.Size(620, 159);
            this.txtOutput.TabIndex = 0;
            this.txtOutput.TextChanged += new System.EventHandler(this.txtOutput_TextChanged);
            // 
            // btnAddEquipment
            // 
            this.btnAddEquipment.Location = new System.Drawing.Point(88, 12);
            this.btnAddEquipment.Name = "btnAddEquipment";
            this.btnAddEquipment.Size = new System.Drawing.Size(148, 92);
            this.btnAddEquipment.TabIndex = 1;
            this.btnAddEquipment.Text = "Добавить новое офисное оборудование";
            this.btnAddEquipment.UseVisualStyleBackColor = true;
            this.btnAddEquipment.Click += new System.EventHandler(this.btnAddEquipment_Click_1);
            // 
            // btnAddFax
            // 
            this.btnAddFax.Location = new System.Drawing.Point(242, 12);
            this.btnAddFax.Name = "btnAddFax";
            this.btnAddFax.Size = new System.Drawing.Size(168, 92);
            this.btnAddFax.TabIndex = 2;
            this.btnAddFax.Text = "Добавить факс";
            this.btnAddFax.UseVisualStyleBackColor = true;
            this.btnAddFax.Click += new System.EventHandler(this.btnAddFax_Click_1);
            // 
            // btnAddPrinter
            // 
            this.btnAddPrinter.Location = new System.Drawing.Point(416, 12);
            this.btnAddPrinter.Name = "btnAddPrinter";
            this.btnAddPrinter.Size = new System.Drawing.Size(148, 92);
            this.btnAddPrinter.TabIndex = 3;
            this.btnAddPrinter.Text = "Добавить принтер";
            this.btnAddPrinter.UseVisualStyleBackColor = true;
            this.btnAddPrinter.Click += new System.EventHandler(this.btnAddPrinter_Click_1);
            // 
            // btnShowDevices
            // 
            this.btnShowDevices.Location = new System.Drawing.Point(570, 12);
            this.btnShowDevices.Name = "btnShowDevices";
            this.btnShowDevices.Size = new System.Drawing.Size(138, 92);
            this.btnShowDevices.TabIndex = 4;
            this.btnShowDevices.Text = "Показать все устройства";
            this.btnShowDevices.UseVisualStyleBackColor = true;
            this.btnShowDevices.Click += new System.EventHandler(this.btnShowDevices_Click_1);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(320, 327);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(153, 56);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Завершить программу";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnShowDevices);
            this.Controls.Add(this.btnAddPrinter);
            this.Controls.Add(this.btnAddFax);
            this.Controls.Add(this.btnAddEquipment);
            this.Controls.Add(this.txtOutput);
            this.Name = "Form1";
            this.Text = "Офисное оборудование";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtOutput;
        private System.Windows.Forms.Button btnAddEquipment;
        private System.Windows.Forms.Button btnAddFax;
        private System.Windows.Forms.Button btnAddPrinter;
        private System.Windows.Forms.Button btnShowDevices;
        private System.Windows.Forms.Button btnExit;
    }
}
