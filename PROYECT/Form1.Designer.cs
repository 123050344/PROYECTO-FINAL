namespace PROYECT
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            btncreate = new Button();
            btnopen = new Button();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            lstnrecipes = new ListView();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Script MT Bold", 36F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.LightSalmon;
            label1.Location = new Point(24, 9);
            label1.Name = "label1";
            label1.Size = new Size(348, 58);
            label1.TabIndex = 0;
            label1.Text = "Recipe Manager";
            label1.Click += label1_Click;
            // 
            // btncreate
            // 
            btncreate.BackColor = Color.BurlyWood;
            btncreate.FlatStyle = FlatStyle.Popup;
            btncreate.Font = new Font("Copperplate Gothic Bold", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btncreate.ForeColor = Color.FromArgb(64, 0, 0);
            btncreate.Location = new Point(24, 123);
            btncreate.Name = "btncreate";
            btncreate.Size = new Size(157, 57);
            btncreate.TabIndex = 1;
            btncreate.Text = "Create";
            btncreate.UseVisualStyleBackColor = false;
            btncreate.Click += btncreate_Click;
            // 
            // btnopen
            // 
            btnopen.BackColor = Color.Tan;
            btnopen.FlatStyle = FlatStyle.Popup;
            btnopen.Font = new Font("Copperplate Gothic Bold", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btnopen.ForeColor = Color.FromArgb(64, 0, 0);
            btnopen.Location = new Point(24, 242);
            btnopen.Name = "btnopen";
            btnopen.Size = new Size(157, 57);
            btnopen.TabIndex = 2;
            btnopen.Text = "Open ";
            btnopen.UseVisualStyleBackColor = false;
            btnopen.Click += btnopen_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(463, -9);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(201, 457);
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI Emoji", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.SaddleBrown;
            label2.Location = new Point(24, 396);
            label2.Name = "label2";
            label2.Size = new Size(433, 34);
            label2.TabIndex = 4;
            label2.Text = "Note: if you already have a recipe, click on \"open\" to open and modify it.\r\n If you want to create one, click on \"create\".";
            label2.TextAlign = ContentAlignment.BottomCenter;
            label2.UseMnemonic = false;
            label2.Click += label2_Click;
            // 
            // lstnrecipes
            // 
            lstnrecipes.BackColor = Color.SaddleBrown;
            lstnrecipes.BackgroundImage = (Image)resources.GetObject("lstnrecipes.BackgroundImage");
            lstnrecipes.ForeColor = Color.SandyBrown;
            lstnrecipes.Location = new Point(236, 123);
            lstnrecipes.Name = "lstnrecipes";
            lstnrecipes.Size = new Size(193, 231);
            lstnrecipes.TabIndex = 5;
            lstnrecipes.UseCompatibleStateImageBehavior = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(660, 439);
            Controls.Add(lstnrecipes);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Controls.Add(btnopen);
            Controls.Add(btncreate);
            Controls.Add(label1);
            Cursor = Cursors.Hand;
            DoubleBuffered = true;
            Name = "Form1";
            Text = "Menu";
            TransparencyKey = Color.FromArgb(64, 0, 0);
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btncreate;
        private Button btnopen;
        private PictureBox pictureBox1;
        private Label label2;
        private ListView lstnrecipes;
    }
}