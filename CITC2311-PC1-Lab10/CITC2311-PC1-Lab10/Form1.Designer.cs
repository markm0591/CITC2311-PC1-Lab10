namespace CITC2311_PC1_Lab10
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            IncidentsListBx = new ListBox();
            SuspendLayout();
            //
            // IncidentsListBx
            //
            IncidentsListBx.Font = new Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            IncidentsListBx.FormattingEnabled = true;
            IncidentsListBx.Location = new Point(12, 12);
            IncidentsListBx.Name = "IncidentsListBx";
            IncidentsListBx.Size = new Size(720, 244);
            IncidentsListBx.TabIndex = 0;
            //
            // Form1
            //
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(744, 268);
            Controls.Add(IncidentsListBx);
            Name = "Form1";
            Text = "Incidents by Technician";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private ListBox IncidentsListBx;
    }
}
