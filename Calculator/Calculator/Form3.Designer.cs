
namespace Calculator
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.lblFirstNumber = new System.Windows.Forms.Label();
            this.lblTwoNumber = new System.Windows.Forms.Label();
            this.txtNumber1 = new System.Windows.Forms.TextBox();
            this.txtNumber2 = new System.Windows.Forms.TextBox();
            this.btnplus = new System.Windows.Forms.Button();
            this.btndminus = new System.Windows.Forms.Button();
            this.btnum = new System.Windows.Forms.Button();
            this.btndel = new System.Windows.Forms.Button();
            this.lblres = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblFirstNumber
            // 
            this.lblFirstNumber.AutoSize = true;
            this.lblFirstNumber.BackColor = System.Drawing.Color.Transparent;
            this.lblFirstNumber.Font = new System.Drawing.Font("Verdana", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblFirstNumber.ForeColor = System.Drawing.Color.White;
            this.lblFirstNumber.Location = new System.Drawing.Point(7, 59);
            this.lblFirstNumber.Name = "lblFirstNumber";
            this.lblFirstNumber.Size = new System.Drawing.Size(230, 32);
            this.lblFirstNumber.TabIndex = 0;
            this.lblFirstNumber.Text = "Первое число";
            // 
            // lblTwoNumber
            // 
            this.lblTwoNumber.AutoSize = true;
            this.lblTwoNumber.BackColor = System.Drawing.Color.Transparent;
            this.lblTwoNumber.Font = new System.Drawing.Font("Verdana", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTwoNumber.ForeColor = System.Drawing.Color.White;
            this.lblTwoNumber.Location = new System.Drawing.Point(25, 148);
            this.lblTwoNumber.Name = "lblTwoNumber";
            this.lblTwoNumber.Size = new System.Drawing.Size(225, 32);
            this.lblTwoNumber.TabIndex = 1;
            this.lblTwoNumber.Text = "Второе число";
            // 
            // txtNumber1
            // 
            this.txtNumber1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtNumber1.Location = new System.Drawing.Point(272, 70);
            this.txtNumber1.Name = "txtNumber1";
            this.txtNumber1.Size = new System.Drawing.Size(100, 23);
            this.txtNumber1.TabIndex = 2;
            this.txtNumber1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_KeyDown);
            this.txtNumber1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_KeyPress);
            // 
            // txtNumber2
            // 
            this.txtNumber2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtNumber2.Location = new System.Drawing.Point(272, 159);
            this.txtNumber2.Name = "txtNumber2";
            this.txtNumber2.Size = new System.Drawing.Size(100, 23);
            this.txtNumber2.TabIndex = 3;
            this.txtNumber2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_KeyDown);
            this.txtNumber2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_KeyPress);
            // 
            // btnplus
            // 
            this.btnplus.BackColor = System.Drawing.Color.Yellow;
            this.btnplus.FlatAppearance.BorderSize = 0;
            this.btnplus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnplus.Font = new System.Drawing.Font("Verdana", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnplus.Location = new System.Drawing.Point(13, 266);
            this.btnplus.Name = "btnplus";
            this.btnplus.Size = new System.Drawing.Size(75, 75);
            this.btnplus.TabIndex = 4;
            this.btnplus.Text = "+";
            this.btnplus.UseVisualStyleBackColor = false;
            this.btnplus.Click += new System.EventHandler(this.btn_Click);
            // 
            // btndminus
            // 
            this.btndminus.BackColor = System.Drawing.Color.Yellow;
            this.btndminus.FlatAppearance.BorderSize = 0;
            this.btndminus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btndminus.Font = new System.Drawing.Font("Verdana", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btndminus.Location = new System.Drawing.Point(121, 266);
            this.btndminus.Name = "btndminus";
            this.btndminus.Size = new System.Drawing.Size(75, 75);
            this.btndminus.TabIndex = 5;
            this.btndminus.Text = "-";
            this.btndminus.UseVisualStyleBackColor = false;
            this.btndminus.Click += new System.EventHandler(this.btn_Click);
            // 
            // btnum
            // 
            this.btnum.BackColor = System.Drawing.Color.Yellow;
            this.btnum.FlatAppearance.BorderSize = 0;
            this.btnum.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnum.Font = new System.Drawing.Font("Verdana", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnum.Location = new System.Drawing.Point(202, 266);
            this.btnum.Name = "btnum";
            this.btnum.Size = new System.Drawing.Size(75, 75);
            this.btnum.TabIndex = 6;
            this.btnum.Text = "*";
            this.btnum.UseVisualStyleBackColor = false;
            this.btnum.Click += new System.EventHandler(this.btn_Click);
            // 
            // btndel
            // 
            this.btndel.BackColor = System.Drawing.Color.Yellow;
            this.btndel.FlatAppearance.BorderSize = 0;
            this.btndel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btndel.Font = new System.Drawing.Font("Verdana", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btndel.Location = new System.Drawing.Point(283, 266);
            this.btndel.Name = "btndel";
            this.btndel.Size = new System.Drawing.Size(75, 75);
            this.btndel.TabIndex = 7;
            this.btndel.Text = "/";
            this.btndel.UseVisualStyleBackColor = false;
            this.btndel.Click += new System.EventHandler(this.btn_Click);
            // 
            // lblres
            // 
            this.lblres.AutoSize = true;
            this.lblres.BackColor = System.Drawing.Color.Transparent;
            this.lblres.Font = new System.Drawing.Font("Verdana", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblres.ForeColor = System.Drawing.Color.White;
            this.lblres.Location = new System.Drawing.Point(8, 401);
            this.lblres.Name = "lblres";
            this.lblres.Size = new System.Drawing.Size(148, 26);
            this.lblres.TabIndex = 8;
            this.lblres.Text = "Результат:";
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.BackColor = System.Drawing.Color.Transparent;
            this.lblResult.Font = new System.Drawing.Font("Verdana", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblResult.ForeColor = System.Drawing.Color.White;
            this.lblResult.Location = new System.Drawing.Point(162, 401);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(28, 26);
            this.lblResult.TabIndex = 9;
            this.lblResult.Text = "*";
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Yellow;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Verdana", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnExit.Location = new System.Drawing.Point(138, 499);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(90, 50);
            this.btnExit.TabIndex = 10;
            this.btnExit.Text = "Выход";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btn_Exit);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Calculator.Properties.Resources.free_png_ru_199;
            this.ClientSize = new System.Drawing.Size(384, 561);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.lblres);
            this.Controls.Add(this.btndel);
            this.Controls.Add(this.btnum);
            this.Controls.Add(this.btndminus);
            this.Controls.Add(this.btnplus);
            this.Controls.Add(this.txtNumber2);
            this.Controls.Add(this.txtNumber1);
            this.Controls.Add(this.lblTwoNumber);
            this.Controls.Add(this.lblFirstNumber);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "калькулятор";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFirstNumber;
        private System.Windows.Forms.Label lblTwoNumber;
        private System.Windows.Forms.TextBox txtNumber1;
        private System.Windows.Forms.TextBox txtNumber2;
        private System.Windows.Forms.Button btnplus;
        private System.Windows.Forms.Button btndminus;
        private System.Windows.Forms.Button btnum;
        private System.Windows.Forms.Button btndel;
        private System.Windows.Forms.Label lblres;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Button btnExit;
    }
}