namespace petstore
{
    partial class UserPageForm
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
            btnOpenStore = new Button();
            userInfoGroup = new GroupBox();
            txtNumPetsOwned = new TextBox();
            txtUsername = new TextBox();
            label2 = new Label();
            label1 = new Label();
            addBalanceGroup = new GroupBox();
            btnSubmitBalance = new Button();
            numAddBalanceAmount = new NumericUpDown();
            txtCurrentBalance = new TextBox();
            label4 = new Label();
            label3 = new Label();
            flowListOwnedPets = new FlowLayoutPanel();
            adoptedPetsGroup = new GroupBox();
            userInfoGroup.SuspendLayout();
            addBalanceGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numAddBalanceAmount).BeginInit();
            adoptedPetsGroup.SuspendLayout();
            SuspendLayout();
            // 
            // btnOpenStore
            // 
            btnOpenStore.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnOpenStore.Location = new Point(935, 12);
            btnOpenStore.Name = "btnOpenStore";
            btnOpenStore.Size = new Size(94, 29);
            btnOpenStore.TabIndex = 0;
            btnOpenStore.Text = "Go to store";
            btnOpenStore.UseVisualStyleBackColor = true;
            btnOpenStore.Click += btnOpenStore_Click;
            // 
            // userInfoGroup
            // 
            userInfoGroup.Controls.Add(txtNumPetsOwned);
            userInfoGroup.Controls.Add(txtUsername);
            userInfoGroup.Controls.Add(label2);
            userInfoGroup.Controls.Add(label1);
            userInfoGroup.Location = new Point(12, 12);
            userInfoGroup.Name = "userInfoGroup";
            userInfoGroup.Size = new Size(299, 125);
            userInfoGroup.TabIndex = 1;
            userInfoGroup.TabStop = false;
            userInfoGroup.Text = "User Info";
            // 
            // txtNumPetsOwned
            // 
            txtNumPetsOwned.Location = new Point(98, 59);
            txtNumPetsOwned.Name = "txtNumPetsOwned";
            txtNumPetsOwned.ReadOnly = true;
            txtNumPetsOwned.Size = new Size(181, 27);
            txtNumPetsOwned.TabIndex = 3;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(98, 26);
            txtUsername.Name = "txtUsername";
            txtUsername.ReadOnly = true;
            txtUsername.Size = new Size(181, 27);
            txtUsername.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 62);
            label2.Name = "label2";
            label2.Size = new Size(86, 20);
            label2.TabIndex = 1;
            label2.Text = "Pets Owned";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 29);
            label1.Name = "label1";
            label1.Size = new Size(75, 20);
            label1.TabIndex = 0;
            label1.Text = "Username";
            // 
            // addBalanceGroup
            // 
            addBalanceGroup.Controls.Add(btnSubmitBalance);
            addBalanceGroup.Controls.Add(numAddBalanceAmount);
            addBalanceGroup.Controls.Add(txtCurrentBalance);
            addBalanceGroup.Controls.Add(label4);
            addBalanceGroup.Controls.Add(label3);
            addBalanceGroup.Location = new Point(317, 12);
            addBalanceGroup.Name = "addBalanceGroup";
            addBalanceGroup.Size = new Size(371, 125);
            addBalanceGroup.TabIndex = 2;
            addBalanceGroup.TabStop = false;
            addBalanceGroup.Text = "Balance";
            // 
            // btnSubmitBalance
            // 
            btnSubmitBalance.Location = new Point(256, 43);
            btnSubmitBalance.Name = "btnSubmitBalance";
            btnSubmitBalance.Size = new Size(94, 29);
            btnSubmitBalance.TabIndex = 4;
            btnSubmitBalance.Text = "Submit";
            btnSubmitBalance.UseVisualStyleBackColor = true;
            btnSubmitBalance.Click += btnSubmitBalance_Click;
            // 
            // numAddBalanceAmount
            // 
            numAddBalanceAmount.DecimalPlaces = 1;
            numAddBalanceAmount.Increment = new decimal(new int[] { 1000, 0, 0, 0 });
            numAddBalanceAmount.Location = new Point(125, 59);
            numAddBalanceAmount.Maximum = new decimal(new int[] { 10000000, 0, 0, 0 });
            numAddBalanceAmount.Name = "numAddBalanceAmount";
            numAddBalanceAmount.Size = new Size(125, 27);
            numAddBalanceAmount.TabIndex = 3;
            numAddBalanceAmount.ThousandsSeparator = true;
            // 
            // txtCurrentBalance
            // 
            txtCurrentBalance.Location = new Point(125, 26);
            txtCurrentBalance.Name = "txtCurrentBalance";
            txtCurrentBalance.ReadOnly = true;
            txtCurrentBalance.Size = new Size(125, 27);
            txtCurrentBalance.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 61);
            label4.Name = "label4";
            label4.Size = new Size(93, 20);
            label4.TabIndex = 1;
            label4.Text = "Add Balance";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 29);
            label3.Name = "label3";
            label3.Size = new Size(113, 20);
            label3.TabIndex = 0;
            label3.Text = "Current Balance";
            // 
            // flowListOwnedPets
            // 
            flowListOwnedPets.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            flowListOwnedPets.Location = new Point(3, 23);
            flowListOwnedPets.Name = "flowListOwnedPets";
            flowListOwnedPets.Size = new Size(1026, 423);
            flowListOwnedPets.TabIndex = 0;
            // 
            // adoptedPetsGroup
            // 
            adoptedPetsGroup.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            adoptedPetsGroup.Controls.Add(flowListOwnedPets);
            adoptedPetsGroup.Location = new Point(0, 143);
            adoptedPetsGroup.Name = "adoptedPetsGroup";
            adoptedPetsGroup.Size = new Size(1032, 446);
            adoptedPetsGroup.TabIndex = 3;
            adoptedPetsGroup.TabStop = false;
            adoptedPetsGroup.Text = "Adopted Pets";
            // 
            // UserPageForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1032, 601);
            Controls.Add(adoptedPetsGroup);
            Controls.Add(addBalanceGroup);
            Controls.Add(userInfoGroup);
            Controls.Add(btnOpenStore);
            Name = "UserPageForm";
            Text = "User Page";
            userInfoGroup.ResumeLayout(false);
            userInfoGroup.PerformLayout();
            addBalanceGroup.ResumeLayout(false);
            addBalanceGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numAddBalanceAmount).EndInit();
            adoptedPetsGroup.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button btnOpenStore;
        private GroupBox userInfoGroup;
        private GroupBox addBalanceGroup;
        private TextBox txtNumPetsOwned;
        private TextBox txtUsername;
        private Label label2;
        private Label label1;
        private Label label4;
        private Label label3;
        private TextBox txtCurrentBalance;
        private NumericUpDown numAddBalanceAmount;
        private Button btnSubmitBalance;
        private FlowLayoutPanel flowListOwnedPets;
        private GroupBox adoptedPetsGroup;
    }
}