
namespace AppointementScheduler.Controls
{
    partial class ScheduleCalendarBox
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

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblDay = new System.Windows.Forms.Label();
            this.eventsPanel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // lblDay
            // 
            this.lblDay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDay.AutoSize = true;
            this.lblDay.Location = new System.Drawing.Point(115, 0);
            this.lblDay.Name = "lblDay";
            this.lblDay.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblDay.Size = new System.Drawing.Size(30, 24);
            this.lblDay.TabIndex = 0;
            this.lblDay.Text = "31";
            this.lblDay.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // eventsPanel
            // 
            this.eventsPanel.Location = new System.Drawing.Point(3, 27);
            this.eventsPanel.Name = "eventsPanel";
            this.eventsPanel.Size = new System.Drawing.Size(144, 70);
            this.eventsPanel.TabIndex = 1;
            // 
            // ScheduleCalendarBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.eventsPanel);
            this.Controls.Add(this.lblDay);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "ScheduleCalendarBox";
            this.Size = new System.Drawing.Size(148, 98);
            this.Load += new System.EventHandler(this.ScheduleCalendarBox_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDay;
        private System.Windows.Forms.Panel eventsPanel;
    }
}
