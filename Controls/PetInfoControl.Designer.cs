namespace petstore
{
    partial class PetInfoControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            picture = new PictureBox();
            name = new Label();
            type = new Label();
            adopt = new Button();
            price = new Label();
            ((System.ComponentModel.ISupportInitialize)picture).BeginInit();
            SuspendLayout();
            // 
            // picture
            // 
            picture.Location = new Point(27, 22);
            picture.Name = "picture";
            picture.Size = new Size(194, 198);
            picture.TabIndex = 0;
            picture.TabStop = false;
            // 
            // name
            // 
            name.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            name.AutoSize = true;
            name.Location = new Point(27, 240);
            name.Name = "name";
            name.Size = new Size(49, 20);
            name.TabIndex = 1;
            name.Text = "Name";
            name.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // type
            // 
            type.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            type.AutoSize = true;
            type.Location = new Point(31, 271);
            type.Name = "type";
            type.Size = new Size(40, 20);
            type.TabIndex = 2;
            type.Text = "Type";
            type.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // adopt
            // 
            adopt.Location = new Point(77, 333);
            adopt.Name = "adopt";
            adopt.Size = new Size(94, 29);
            adopt.TabIndex = 3;
            adopt.Text = "Adopt";
            adopt.UseVisualStyleBackColor = true;
            // 
            // price
            // 
            price.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            price.AutoSize = true;
            price.Location = new Point(30, 301);
            price.Name = "price";
            price.Size = new Size(41, 20);
            price.TabIndex = 4;
            price.Text = "Price";
            price.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // PetInfoControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(price);
            Controls.Add(adopt);
            Controls.Add(type);
            Controls.Add(name);
            Controls.Add(picture);
            Name = "PetInfoControl";
            Size = new Size(248, 385);
            ((System.ComponentModel.ISupportInitialize)picture).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button adopt;
        public PictureBox picture;
        public Label name;
        public Label price;
        public Label type;
    }
}
