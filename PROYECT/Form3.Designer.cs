namespace PROYECT
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            dgvinformation = new DataGridView();
            label5 = new Label();
            btnsave = new Button();
            btnback2 = new FontAwesome.Sharp.IconButton();
            btnopenfile = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvinformation).BeginInit();
            SuspendLayout();
            // 
            // dgvinformation
            // 
            dgvinformation.BackgroundColor = Color.Sienna;
            dgvinformation.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvinformation.Location = new Point(303, 60);
            dgvinformation.Name = "dgvinformation";
            dgvinformation.RowTemplate.Height = 25;
            dgvinformation.Size = new Size(462, 354);
            dgvinformation.TabIndex = 0;
            dgvinformation.CellContentClick += dataGridView1_CellContentClick;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Perpetua Titling MT", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.PeachPuff;
            label5.Location = new Point(74, 26);
            label5.Name = "label5";
            label5.Size = new Size(206, 29);
            label5.TabIndex = 21;
            label5.Text = "Open a recipe";
            // 
            // btnsave
            // 
            btnsave.BackColor = Color.BurlyWood;
            btnsave.FlatStyle = FlatStyle.Popup;
            btnsave.Font = new Font("Copperplate Gothic Bold", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btnsave.ForeColor = Color.FromArgb(64, 0, 0);
            btnsave.Location = new Point(51, 223);
            btnsave.Name = "btnsave";
            btnsave.Size = new Size(157, 57);
            btnsave.TabIndex = 23;
            btnsave.Text = "Save ";
            btnsave.UseVisualStyleBackColor = false;
            btnsave.Click += btnsave_Click;
            // 
            // btnback2
            // 
            btnback2.BackColor = Color.Transparent;
            btnback2.IconChar = FontAwesome.Sharp.IconChar.ArrowCircleLeft;
            btnback2.IconColor = Color.Black;
            btnback2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnback2.IconSize = 32;
            btnback2.Location = new Point(3, 0);
            btnback2.Name = "btnback2";
            btnback2.Size = new Size(51, 36);
            btnback2.TabIndex = 24;
            btnback2.Text = "                            Back";
            btnback2.UseVisualStyleBackColor = false;
            btnback2.Click += btnback2_Click;
            // 
            // btnopenfile
            // 
            btnopenfile.BackColor = Color.BurlyWood;
            btnopenfile.FlatStyle = FlatStyle.Popup;
            btnopenfile.Font = new Font("Copperplate Gothic Bold", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btnopenfile.ForeColor = Color.FromArgb(64, 0, 0);
            btnopenfile.Location = new Point(51, 108);
            btnopenfile.Name = "btnopenfile";
            btnopenfile.Size = new Size(157, 57);
            btnopenfile.TabIndex = 25;
            btnopenfile.Text = "Open file";
            btnopenfile.UseVisualStyleBackColor = false;
            btnopenfile.Click += btnopenfile_Click_1;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(800, 450);
            Controls.Add(btnopenfile);
            Controls.Add(btnback2);
            Controls.Add(btnsave);
            Controls.Add(label5);
            Controls.Add(dgvinformation);
            Name = "Form3";
            Text = "Open ";
            ((System.ComponentModel.ISupportInitialize)dgvinformation).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvinformation;
        private FontAwesome.Sharp.IconButton btnsave2;
        private Label label5;
        private Button btnsave;
        private FontAwesome.Sharp.IconButton btnback2;
        private Button btnopenfile;
    }
}