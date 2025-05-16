namespace petstore
{
    partial class PetStoreForm
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
            listPetPanel = new FlowLayoutPanel();
            reload = new Button();
            lblPetStoreTitle = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // listPetPanel
            // 
            listPetPanel.AutoScroll = true;
            listPetPanel.BorderStyle = BorderStyle.FixedSingle;
            listPetPanel.Dock = DockStyle.Bottom;
            listPetPanel.Location = new Point(0, 115);
            listPetPanel.Name = "listPetPanel";
            listPetPanel.Size = new Size(1093, 529);
            listPetPanel.TabIndex = 0;
            // 
            // reload
            // 
            reload.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            reload.Location = new Point(987, 64);
            reload.Name = "reload";
            reload.Size = new Size(94, 29);
            reload.TabIndex = 1;
            reload.Text = "Reload";
            reload.UseVisualStyleBackColor = true;
            reload.Click += reload_Click;
            // 
            // lblPetStoreTitle
            // 
            lblPetStoreTitle.AutoSize = true;
            lblPetStoreTitle.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPetStoreTitle.Location = new Point(12, 28);
            lblPetStoreTitle.Name = "lblPetStoreTitle";
            lblPetStoreTitle.Size = new Size(126, 38);
            lblPetStoreTitle.TabIndex = 2;
            lblPetStoreTitle.Text = "Pet store";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label1.Location = new Point(603, 28);
            label1.Name = "label1";
            label1.Size = new Size(478, 20);
            label1.TabIndex = 3;
            label1.Text = "Current Balance:";
            label1.TextAlign = ContentAlignment.MiddleRight;
            // 
            // PetStoreForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1093, 644);
            Controls.Add(label1);
            Controls.Add(lblPetStoreTitle);
            Controls.Add(reload);
            Controls.Add(listPetPanel);
            Name = "PetStoreForm";
            Text = "Pet store";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel listPetPanel;
        private Button reload;
        private Label lblPetStoreTitle;
        private Label label1;
    }
}