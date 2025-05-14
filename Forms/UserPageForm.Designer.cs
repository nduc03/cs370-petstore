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
            SuspendLayout();
            // 
            // btnOpenStore
            // 
            btnOpenStore.Location = new Point(694, 12);
            btnOpenStore.Name = "btnOpenStore";
            btnOpenStore.Size = new Size(94, 29);
            btnOpenStore.TabIndex = 0;
            btnOpenStore.Text = "Go to store";
            btnOpenStore.UseVisualStyleBackColor = true;
            btnOpenStore.Click += btnOpenStore_Click;
            // 
            // UserPageForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnOpenStore);
            Name = "UserPageForm";
            Text = "UserPageForm";
            ResumeLayout(false);
        }

        #endregion

        private Button btnOpenStore;
    }
}