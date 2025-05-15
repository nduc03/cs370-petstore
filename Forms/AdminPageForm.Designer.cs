namespace petstore
{
    partial class AdminPageForm
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
            lblPetName = new Label();
            lblPetType = new Label();
            lblPetPictureUri = new Label();
            txtPetName = new TextBox();
            txtPetType = new TextBox();
            txtPetPictureUri = new TextBox();
            addPetGroupBox = new GroupBox();
            numPetPrice = new NumericUpDown();
            btnAddPet = new Button();
            lblPetPrice = new Label();
            btnOpenStore = new Button();
            addPetGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numPetPrice).BeginInit();
            SuspendLayout();
            // 
            // lblPetName
            // 
            lblPetName.AutoSize = true;
            lblPetName.Location = new Point(15, 26);
            lblPetName.Name = "lblPetName";
            lblPetName.Size = new Size(49, 20);
            lblPetName.TabIndex = 0;
            lblPetName.Text = "Name";
            // 
            // lblPetType
            // 
            lblPetType.AutoSize = true;
            lblPetType.Location = new Point(15, 68);
            lblPetType.Name = "lblPetType";
            lblPetType.Size = new Size(40, 20);
            lblPetType.TabIndex = 1;
            lblPetType.Text = "Type";
            // 
            // lblPetPictureUri
            // 
            lblPetPictureUri.AutoSize = true;
            lblPetPictureUri.Location = new Point(15, 108);
            lblPetPictureUri.Name = "lblPetPictureUri";
            lblPetPictureUri.Size = new Size(77, 20);
            lblPetPictureUri.TabIndex = 2;
            lblPetPictureUri.Text = "Picture Uri";
            // 
            // txtPetName
            // 
            txtPetName.Location = new Point(96, 26);
            txtPetName.Name = "txtPetName";
            txtPetName.Size = new Size(247, 27);
            txtPetName.TabIndex = 3;
            // 
            // txtPetType
            // 
            txtPetType.Location = new Point(96, 68);
            txtPetType.Name = "txtPetType";
            txtPetType.Size = new Size(246, 27);
            txtPetType.TabIndex = 4;
            // 
            // txtPetPictureUri
            // 
            txtPetPictureUri.Location = new Point(95, 108);
            txtPetPictureUri.Name = "txtPetPictureUri";
            txtPetPictureUri.Size = new Size(247, 27);
            txtPetPictureUri.TabIndex = 5;
            // 
            // addPetGroupBox
            // 
            addPetGroupBox.Controls.Add(numPetPrice);
            addPetGroupBox.Controls.Add(btnAddPet);
            addPetGroupBox.Controls.Add(lblPetPrice);
            addPetGroupBox.Controls.Add(lblPetName);
            addPetGroupBox.Controls.Add(txtPetPictureUri);
            addPetGroupBox.Controls.Add(lblPetType);
            addPetGroupBox.Controls.Add(txtPetType);
            addPetGroupBox.Controls.Add(lblPetPictureUri);
            addPetGroupBox.Controls.Add(txtPetName);
            addPetGroupBox.Location = new Point(12, 12);
            addPetGroupBox.Name = "addPetGroupBox";
            addPetGroupBox.Size = new Size(472, 197);
            addPetGroupBox.TabIndex = 6;
            addPetGroupBox.TabStop = false;
            addPetGroupBox.Text = "Add new pet";
            // 
            // numPetPrice
            // 
            numPetPrice.DecimalPlaces = 1;
            numPetPrice.Increment = new decimal(new int[] { 1000, 0, 0, 0 });
            numPetPrice.Location = new Point(96, 149);
            numPetPrice.Maximum = new decimal(new int[] { 10000000, 0, 0, 0 });
            numPetPrice.Name = "numPetPrice";
            numPetPrice.Size = new Size(246, 27);
            numPetPrice.TabIndex = 7;
            numPetPrice.ThousandsSeparator = true;
            // 
            // btnAddPet
            // 
            btnAddPet.Location = new Point(372, 87);
            btnAddPet.Name = "btnAddPet";
            btnAddPet.Size = new Size(94, 29);
            btnAddPet.TabIndex = 8;
            btnAddPet.Text = "Add";
            btnAddPet.UseVisualStyleBackColor = true;
            btnAddPet.Click += btnAddPet_Click;
            // 
            // lblPetPrice
            // 
            lblPetPrice.AutoSize = true;
            lblPetPrice.Location = new Point(16, 151);
            lblPetPrice.Name = "lblPetPrice";
            lblPetPrice.Size = new Size(41, 20);
            lblPetPrice.TabIndex = 6;
            lblPetPrice.Text = "Price";
            // 
            // btnOpenStore
            // 
            btnOpenStore.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnOpenStore.Location = new Point(694, 12);
            btnOpenStore.Name = "btnOpenStore";
            btnOpenStore.Size = new Size(94, 29);
            btnOpenStore.TabIndex = 7;
            btnOpenStore.Text = "Go to store";
            btnOpenStore.UseVisualStyleBackColor = true;
            btnOpenStore.Click += btnOpenStore_Click;
            // 
            // AdminPageForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnOpenStore);
            Controls.Add(addPetGroupBox);
            Name = "AdminPageForm";
            Text = "Admin Page";
            addPetGroupBox.ResumeLayout(false);
            addPetGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numPetPrice).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label lblPetName;
        private Label lblPetType;
        private Label lblPetPictureUri;
        private TextBox txtPetName;
        private TextBox txtPetType;
        private TextBox txtPetPictureUri;
        private GroupBox addPetGroupBox;
        private Button btnAddPet;
        private Label lblPetPrice;
        private NumericUpDown numPetPrice;
        private Button btnOpenStore;
    }
}