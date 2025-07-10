
namespace WindowsFormsApp1
{
    partial class WelcomeScreen
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.bLogIn = new System.Windows.Forms.Button();
            this.bNewUser = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pPanel = new System.Windows.Forms.Panel();
            this.bSecretary = new System.Windows.Forms.Button();
            this.bPatient = new System.Windows.Forms.Button();
            this.bDoctor = new System.Windows.Forms.Button();
            this.pPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // bLogIn
            // 
            this.bLogIn.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.bLogIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bLogIn.Location = new System.Drawing.Point(192, 12);
            this.bLogIn.Name = "bLogIn";
            this.bLogIn.Size = new System.Drawing.Size(117, 46);
            this.bLogIn.TabIndex = 0;
            this.bLogIn.Text = "Log In";
            this.bLogIn.UseVisualStyleBackColor = false;
            this.bLogIn.Click += new System.EventHandler(this.bLogin_Click);
            // 
            // bNewUser
            // 
            this.bNewUser.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.bNewUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bNewUser.Location = new System.Drawing.Point(383, 12);
            this.bNewUser.Name = "bNewUser";
            this.bNewUser.Size = new System.Drawing.Size(180, 46);
            this.bNewUser.TabIndex = 1;
            this.bNewUser.Text = "Create a new User";
            this.bNewUser.UseVisualStyleBackColor = false;
            this.bNewUser.Click += new System.EventHandler(this.bNewUser_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.IndianRed;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.Location = new System.Drawing.Point(658, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 33);
            this.button1.TabIndex = 3;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // pPanel
            // 
            this.pPanel.Controls.Add(this.button1);
            this.pPanel.Location = new System.Drawing.Point(23, 12);
            this.pPanel.Name = "pPanel";
            this.pPanel.Size = new System.Drawing.Size(740, 489);
            this.pPanel.TabIndex = 2;
            // 
            // bSecretary
            // 
            this.bSecretary.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.bSecretary.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bSecretary.Location = new System.Drawing.Point(635, 507);
            this.bSecretary.Name = "bSecretary";
            this.bSecretary.Size = new System.Drawing.Size(121, 41);
            this.bSecretary.TabIndex = 8;
            this.bSecretary.Text = "Secretary";
            this.bSecretary.UseVisualStyleBackColor = false;
            this.bSecretary.Click += new System.EventHandler(this.bSecretary_Click);
            // 
            // bPatient
            // 
            this.bPatient.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.bPatient.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bPatient.Location = new System.Drawing.Point(338, 507);
            this.bPatient.Name = "bPatient";
            this.bPatient.Size = new System.Drawing.Size(121, 41);
            this.bPatient.TabIndex = 7;
            this.bPatient.Text = "Admin";
            this.bPatient.UseVisualStyleBackColor = false;
            this.bPatient.Click += new System.EventHandler(this.bPatient_Click);
            // 
            // bDoctor
            // 
            this.bDoctor.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.bDoctor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bDoctor.Location = new System.Drawing.Point(85, 507);
            this.bDoctor.Name = "bDoctor";
            this.bDoctor.Size = new System.Drawing.Size(121, 41);
            this.bDoctor.TabIndex = 6;
            this.bDoctor.Text = "Doctor";
            this.bDoctor.UseVisualStyleBackColor = false;
            this.bDoctor.Click += new System.EventHandler(this.bDoctor_Click);
            // 
            // WelcomeScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(832, 560);
            this.Controls.Add(this.bDoctor);
            this.Controls.Add(this.bPatient);
            this.Controls.Add(this.bSecretary);
            this.Controls.Add(this.bNewUser);
            this.Controls.Add(this.bLogIn);
            this.Controls.Add(this.pPanel);
            this.Name = "WelcomeScreen";
            this.Text = "Tab";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bLogIn;
        private System.Windows.Forms.Button bNewUser;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel pPanel;
        private System.Windows.Forms.Button bSecretary;
        private System.Windows.Forms.Button bPatient;
        private System.Windows.Forms.Button bDoctor;
    }
}

