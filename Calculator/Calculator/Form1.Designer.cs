
namespace Calculator
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
            this.lbllCalculator = new System.Windows.Forms.LinkLabel();
            this.lblNameMenu = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbllCalculator
            // 
            this.lbllCalculator.ActiveLinkColor = System.Drawing.Color.Magenta;
            this.lbllCalculator.AutoSize = true;
            this.lbllCalculator.Font = new System.Drawing.Font("Verdana", 28F, System.Drawing.FontStyle.Bold);
            this.lbllCalculator.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lbllCalculator.Location = new System.Drawing.Point(360, 186);
            this.lbllCalculator.Name = "lbllCalculator";
            this.lbllCalculator.Size = new System.Drawing.Size(303, 46);
            this.lbllCalculator.TabIndex = 0;
            this.lbllCalculator.TabStop = true;
            this.lbllCalculator.Text = "Калькулятор";
            this.lbllCalculator.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lbllCalculator.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lbllCalculator_LinkClicked);
            // 
            // lblNameMenu
            // 
            this.lblNameMenu.AutoSize = true;
            this.lblNameMenu.Font = new System.Drawing.Font("Verdana", 40F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblNameMenu.Location = new System.Drawing.Point(12, 55);
            this.lblNameMenu.Name = "lblNameMenu";
            this.lblNameMenu.Size = new System.Drawing.Size(641, 65);
            this.lblNameMenu.TabIndex = 1;
            this.lblNameMenu.Text = "Добро пожаловать!";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LimeGreen;
            this.ClientSize = new System.Drawing.Size(728, 378);
            this.Controls.Add(this.lblNameMenu);
            this.Controls.Add(this.lbllCalculator);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "меню проекта";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel lbllCalculator;
        private System.Windows.Forms.Label lblNameMenu;
    }
}

