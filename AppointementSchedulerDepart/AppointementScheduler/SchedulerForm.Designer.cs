
namespace AppointementScheduler
{
    partial class SchedulerForm
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            AppointementScheduler.Calendar.CalendarEvents calendarEvents5 = new AppointementScheduler.Calendar.CalendarEvents();
            this.scheduleCalendar = new AppointementScheduler.Controls.ScheduleCalendar();
            this.btnAddAppointement = new System.Windows.Forms.Button();
            this.btnCancelAppointement = new System.Windows.Forms.Button();
            this.btnCustomerFile = new System.Windows.Forms.Button();
            this.btnAddCustomer = new System.Windows.Forms.Button();
            this.btnDisplayAllCustomers = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // scheduleCalendar
            // 
            this.scheduleCalendar.AutoSize = true;
            this.scheduleCalendar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.scheduleCalendar.CalendarEvents = calendarEvents5;
            this.scheduleCalendar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scheduleCalendar.Location = new System.Drawing.Point(15, 111);
            this.scheduleCalendar.Margin = new System.Windows.Forms.Padding(6);
            this.scheduleCalendar.Name = "scheduleCalendar";
            this.scheduleCalendar.Size = new System.Drawing.Size(1050, 598);
            this.scheduleCalendar.TabIndex = 0;
            // 
            // btnAddAppointement
            // 
            this.btnAddAppointement.BackColor = System.Drawing.Color.ForestGreen;
            this.btnAddAppointement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddAppointement.ForeColor = System.Drawing.Color.White;
            this.btnAddAppointement.Location = new System.Drawing.Point(58, 21);
            this.btnAddAppointement.Name = "btnAddAppointement";
            this.btnAddAppointement.Size = new System.Drawing.Size(185, 70);
            this.btnAddAppointement.TabIndex = 1;
            this.btnAddAppointement.Text = "Ajouter un rendez-vous";
            this.btnAddAppointement.UseVisualStyleBackColor = false;
            this.btnAddAppointement.Click += new System.EventHandler(this.btnAddAppointement_Click);
            // 
            // btnCancelAppointement
            // 
            this.btnCancelAppointement.BackColor = System.Drawing.Color.Firebrick;
            this.btnCancelAppointement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelAppointement.ForeColor = System.Drawing.Color.White;
            this.btnCancelAppointement.Location = new System.Drawing.Point(249, 21);
            this.btnCancelAppointement.Name = "btnCancelAppointement";
            this.btnCancelAppointement.Size = new System.Drawing.Size(185, 70);
            this.btnCancelAppointement.TabIndex = 2;
            this.btnCancelAppointement.Text = "Annuler un rendez-vous";
            this.btnCancelAppointement.UseVisualStyleBackColor = false;
            this.btnCancelAppointement.Click += new System.EventHandler(this.btnCancelAppointement_Click);
            // 
            // btnCustomerFile
            // 
            this.btnCustomerFile.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnCustomerFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCustomerFile.ForeColor = System.Drawing.Color.White;
            this.btnCustomerFile.Location = new System.Drawing.Point(631, 21);
            this.btnCustomerFile.Name = "btnCustomerFile";
            this.btnCustomerFile.Size = new System.Drawing.Size(185, 70);
            this.btnCustomerFile.TabIndex = 3;
            this.btnCustomerFile.Text = "Voir un dossier client";
            this.btnCustomerFile.UseVisualStyleBackColor = false;
            this.btnCustomerFile.Click += new System.EventHandler(this.btnCustomerFile_Click);
            // 
            // btnAddCustomer
            // 
            this.btnAddCustomer.BackColor = System.Drawing.Color.DarkCyan;
            this.btnAddCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddCustomer.ForeColor = System.Drawing.Color.White;
            this.btnAddCustomer.Location = new System.Drawing.Point(440, 21);
            this.btnAddCustomer.Name = "btnAddCustomer";
            this.btnAddCustomer.Size = new System.Drawing.Size(185, 70);
            this.btnAddCustomer.TabIndex = 4;
            this.btnAddCustomer.Text = "Ajouter un client";
            this.btnAddCustomer.UseVisualStyleBackColor = false;
            this.btnAddCustomer.Click += new System.EventHandler(this.btnAddCustomer_Click);
            // 
            // btnDisplayAllCustomers
            // 
            this.btnDisplayAllCustomers.BackColor = System.Drawing.Color.DarkGray;
            this.btnDisplayAllCustomers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDisplayAllCustomers.ForeColor = System.Drawing.Color.White;
            this.btnDisplayAllCustomers.Location = new System.Drawing.Point(822, 21);
            this.btnDisplayAllCustomers.Name = "btnDisplayAllCustomers";
            this.btnDisplayAllCustomers.Size = new System.Drawing.Size(185, 70);
            this.btnDisplayAllCustomers.TabIndex = 5;
            this.btnDisplayAllCustomers.Text = "Voir tous les clients";
            this.btnDisplayAllCustomers.UseVisualStyleBackColor = false;
            this.btnDisplayAllCustomers.Click += new System.EventHandler(this.btnDisplayAllCustomers_Click);
            // 
            // SchedulerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1066, 821);
            this.Controls.Add(this.btnDisplayAllCustomers);
            this.Controls.Add(this.btnAddCustomer);
            this.Controls.Add(this.btnCustomerFile);
            this.Controls.Add(this.btnCancelAppointement);
            this.Controls.Add(this.btnAddAppointement);
            this.Controls.Add(this.scheduleCalendar);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.Name = "SchedulerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calendrier des rendez-vous";
            this.Load += new System.EventHandler(this.SchedulerForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Controls.ScheduleCalendar scheduleCalendar;
        private System.Windows.Forms.Button btnAddAppointement;
        private System.Windows.Forms.Button btnCancelAppointement;
        private System.Windows.Forms.Button btnCustomerFile;
        private System.Windows.Forms.Button btnAddCustomer;
        private System.Windows.Forms.Button btnDisplayAllCustomers;
    }
}

