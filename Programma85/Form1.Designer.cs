namespace Programma85
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
            this.label1 = new System.Windows.Forms.Label();
            this.labPilseta = new System.Windows.Forms.Label();
            this.butTurpinat = new System.Windows.Forms.Button();
            this.butParbaudit = new System.Windows.Forms.Button();
            this.txtAtbilde = new System.Windows.Forms.TextBox();
            this.labRez = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(10, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(666, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Atmini, kas tā par Latvijas pilsētu, kuras nosaukumu veido dotie burti ...";
            // 
            // labPilseta
            // 
            this.labPilseta.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.labPilseta.ForeColor = System.Drawing.Color.Maroon;
            this.labPilseta.Location = new System.Drawing.Point(57, 80);
            this.labPilseta.Name = "labPilseta";
            this.labPilseta.Size = new System.Drawing.Size(671, 73);
            this.labPilseta.TabIndex = 1;
            this.labPilseta.Text = "NOSAUKUMS";
            this.labPilseta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // butTurpinat
            // 
            this.butTurpinat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butTurpinat.Location = new System.Drawing.Point(672, 319);
            this.butTurpinat.Name = "butTurpinat";
            this.butTurpinat.Size = new System.Drawing.Size(100, 30);
            this.butTurpinat.TabIndex = 2;
            this.butTurpinat.Text = "Turpināt";
            this.butTurpinat.UseVisualStyleBackColor = true;
            this.butTurpinat.Click += new System.EventHandler(this.butTurpinat_Click);
            // 
            // butParbaudit
            // 
            this.butParbaudit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butParbaudit.Location = new System.Drawing.Point(672, 283);
            this.butParbaudit.Name = "butParbaudit";
            this.butParbaudit.Size = new System.Drawing.Size(100, 30);
            this.butParbaudit.TabIndex = 3;
            this.butParbaudit.Text = "Pārbaudīt";
            this.butParbaudit.UseVisualStyleBackColor = true;
            this.butParbaudit.Click += new System.EventHandler(this.butParbaudit_Click);
            // 
            // txtAtbilde
            // 
            this.txtAtbilde.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAtbilde.ForeColor = System.Drawing.Color.ForestGreen;
            this.txtAtbilde.Location = new System.Drawing.Point(199, 216);
            this.txtAtbilde.Name = "txtAtbilde";
            this.txtAtbilde.Size = new System.Drawing.Size(382, 29);
            this.txtAtbilde.TabIndex = 4;
            this.txtAtbilde.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labRez
            // 
            this.labRez.AutoSize = true;
            this.labRez.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labRez.Location = new System.Drawing.Point(358, 319);
            this.labRez.Name = "labRez";
            this.labRez.Size = new System.Drawing.Size(59, 20);
            this.labRez.TabIndex = 5;
            this.labRez.Text = "0 no 0";
            this.labRez.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 361);
            this.Controls.Add(this.labRez);
            this.Controls.Add(this.txtAtbilde);
            this.Controls.Add(this.butParbaudit);
            this.Controls.Add(this.butTurpinat);
            this.Controls.Add(this.labPilseta);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Latvijas pilsētas";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labPilseta;
        private System.Windows.Forms.Button butTurpinat;
        private System.Windows.Forms.Button butParbaudit;
        private System.Windows.Forms.TextBox txtAtbilde;
        private System.Windows.Forms.Label labRez;
    }
}

