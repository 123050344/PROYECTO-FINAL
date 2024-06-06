namespace PROYECT
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            btnback = new FontAwesome.Sharp.IconButton();
            dgvingredients = new DataGridView();
            Ingredient = new DataGridViewTextBoxColumn();
            Quantity = new DataGridViewTextBoxColumn();
            Calories = new DataGridViewTextBoxColumn();
            label5 = new Label();
            cbkindoffood = new ComboBox();
            txtnamerecipe = new TextBox();
            btnaddrecipe = new FontAwesome.Sharp.IconButton();
            label1 = new Label();
            lstrecipes = new ListView();
            txtnotes = new TextBox();
            label3 = new Label();
            txttotalcalories = new TextBox();
            btncalculatecalories = new Button();
            btncreaterecipe = new Button();
            label2 = new Label();
            txtnumberingredients = new TextBox();
            btnaddningredients = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvingredients).BeginInit();
            SuspendLayout();
            // 
            // btnback
            // 
            btnback.BackColor = Color.Transparent;
            btnback.IconChar = FontAwesome.Sharp.IconChar.ArrowCircleLeft;
            btnback.IconColor = Color.Black;
            btnback.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnback.IconSize = 32;
            btnback.Location = new Point(3, 4);
            btnback.Name = "btnback";
            btnback.Size = new Size(51, 36);
            btnback.TabIndex = 18;
            btnback.Text = "                            Back";
            btnback.UseVisualStyleBackColor = false;
            btnback.Click += btnback_Click;
            // 
            // dgvingredients
            // 
            dgvingredients.BackgroundColor = Color.Peru;
            dgvingredients.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvingredients.Columns.AddRange(new DataGridViewColumn[] { Ingredient, Quantity, Calories });
            dgvingredients.GridColor = Color.PeachPuff;
            dgvingredients.Location = new Point(446, 12);
            dgvingredients.Name = "dgvingredients";
            dgvingredients.RowTemplate.Height = 25;
            dgvingredients.Size = new Size(512, 257);
            dgvingredients.TabIndex = 0;
            dgvingredients.CellContentClick += dgvrecipe_CellContentClick;
            // 
            // Ingredient
            // 
            Ingredient.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Ingredient.HeaderText = "Ingredient";
            Ingredient.Name = "Ingredient";
            // 
            // Quantity
            // 
            Quantity.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Quantity.HeaderText = "Quantity";
            Quantity.Name = "Quantity";
            Quantity.Width = 78;
            // 
            // Calories
            // 
            Calories.HeaderText = "Calories";
            Calories.Name = "Calories";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Perpetua Titling MT", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.PeachPuff;
            label5.Location = new Point(107, 14);
            label5.Name = "label5";
            label5.Size = new Size(259, 26);
            label5.TabIndex = 20;
            label5.Text = "Create your recipe";
            // 
            // cbkindoffood
            // 
            cbkindoffood.BackColor = Color.PeachPuff;
            cbkindoffood.FormattingEnabled = true;
            cbkindoffood.Items.AddRange(new object[] { "Sweet", "Salty", "Drink" });
            cbkindoffood.Location = new Point(12, 126);
            cbkindoffood.Name = "cbkindoffood";
            cbkindoffood.Size = new Size(193, 23);
            cbkindoffood.TabIndex = 21;
            cbkindoffood.SelectedIndexChanged += cbkindoffood_SelectedIndexChanged;
            // 
            // txtnamerecipe
            // 
            txtnamerecipe.BackColor = Color.PeachPuff;
            txtnamerecipe.Location = new Point(12, 77);
            txtnamerecipe.Name = "txtnamerecipe";
            txtnamerecipe.Size = new Size(238, 23);
            txtnamerecipe.TabIndex = 22;
            // 
            // btnaddrecipe
            // 
            btnaddrecipe.BackColor = Color.Transparent;
            btnaddrecipe.FlatStyle = FlatStyle.Popup;
            btnaddrecipe.IconChar = FontAwesome.Sharp.IconChar.PlusSquare;
            btnaddrecipe.IconColor = Color.DarkOrange;
            btnaddrecipe.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnaddrecipe.IconSize = 40;
            btnaddrecipe.Location = new Point(292, 366);
            btnaddrecipe.Name = "btnaddrecipe";
            btnaddrecipe.Size = new Size(64, 42);
            btnaddrecipe.TabIndex = 23;
            btnaddrecipe.UseVisualStyleBackColor = false;
            btnaddrecipe.Click += btnaddrecipe_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Peru;
            label1.Location = new Point(12, 54);
            label1.Name = "label1";
            label1.Size = new Size(57, 20);
            label1.TabIndex = 24;
            label1.Text = "Name:";
            // 
            // lstrecipes
            // 
            lstrecipes.BackColor = Color.SaddleBrown;
            lstrecipes.BackgroundImage = (Image)resources.GetObject("lstrecipes.BackgroundImage");
            lstrecipes.Location = new Point(12, 213);
            lstrecipes.Name = "lstrecipes";
            lstrecipes.Size = new Size(274, 195);
            lstrecipes.TabIndex = 26;
            lstrecipes.UseCompatibleStateImageBehavior = false;
            lstrecipes.View = View.List;
            lstrecipes.SelectedIndexChanged += lstrecipes_SelectedIndexChanged_1;
            // 
            // txtnotes
            // 
            txtnotes.BackColor = Color.SandyBrown;
            txtnotes.BorderStyle = BorderStyle.FixedSingle;
            txtnotes.Location = new Point(446, 276);
            txtnotes.Multiline = true;
            txtnotes.Name = "txtnotes";
            txtnotes.Size = new Size(390, 193);
            txtnotes.TabIndex = 27;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.Peru;
            label3.Location = new Point(12, 103);
            label3.Name = "label3";
            label3.Size = new Size(102, 20);
            label3.TabIndex = 28;
            label3.Text = "Kind of food:";
            // 
            // txttotalcalories
            // 
            txttotalcalories.BackColor = Color.PeachPuff;
            txttotalcalories.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txttotalcalories.ForeColor = Color.Black;
            txttotalcalories.Location = new Point(183, 432);
            txttotalcalories.Name = "txttotalcalories";
            txttotalcalories.Size = new Size(212, 29);
            txttotalcalories.TabIndex = 30;
            // 
            // btncalculatecalories
            // 
            btncalculatecalories.BackColor = Color.SaddleBrown;
            btncalculatecalories.FlatStyle = FlatStyle.Popup;
            btncalculatecalories.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btncalculatecalories.ForeColor = Color.PeachPuff;
            btncalculatecalories.Location = new Point(3, 424);
            btncalculatecalories.Name = "btncalculatecalories";
            btncalculatecalories.Size = new Size(164, 37);
            btncalculatecalories.TabIndex = 32;
            btncalculatecalories.Text = "Calculate calories";
            btncalculatecalories.UseVisualStyleBackColor = false;
            btncalculatecalories.Click += btncalculatecalories_Click;
            // 
            // btncreaterecipe
            // 
            btncreaterecipe.BackColor = Color.FromArgb(255, 192, 128);
            btncreaterecipe.Font = new Font("Script MT Bold", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            btncreaterecipe.ForeColor = Color.Maroon;
            btncreaterecipe.ImageAlign = ContentAlignment.MiddleRight;
            btncreaterecipe.Location = new Point(842, 275);
            btncreaterecipe.Name = "btncreaterecipe";
            btncreaterecipe.Size = new Size(116, 194);
            btncreaterecipe.TabIndex = 33;
            btncreaterecipe.Text = "Create";
            btncreaterecipe.UseVisualStyleBackColor = false;
            btncreaterecipe.Click += btncreaterecipe_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.Peru;
            label2.Location = new Point(12, 152);
            label2.Name = "label2";
            label2.Size = new Size(174, 20);
            label2.TabIndex = 34;
            label2.Text = "Number of ingredients:";
            // 
            // txtnumberingredients
            // 
            txtnumberingredients.BackColor = Color.PeachPuff;
            txtnumberingredients.Location = new Point(12, 175);
            txtnumberingredients.Name = "txtnumberingredients";
            txtnumberingredients.Size = new Size(238, 23);
            txtnumberingredients.TabIndex = 35;
            // 
            // btnaddningredients
            // 
            btnaddningredients.BackColor = Color.SaddleBrown;
            btnaddningredients.FlatStyle = FlatStyle.Popup;
            btnaddningredients.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnaddningredients.ForeColor = Color.PeachPuff;
            btnaddningredients.Location = new Point(256, 164);
            btnaddningredients.Name = "btnaddningredients";
            btnaddningredients.Size = new Size(53, 34);
            btnaddningredients.TabIndex = 36;
            btnaddningredients.Text = "ADD";
            btnaddningredients.UseVisualStyleBackColor = false;
            btnaddningredients.Click += btnaddningredients_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(970, 473);
            Controls.Add(btnaddningredients);
            Controls.Add(txtnumberingredients);
            Controls.Add(label2);
            Controls.Add(btncreaterecipe);
            Controls.Add(btncalculatecalories);
            Controls.Add(txttotalcalories);
            Controls.Add(label3);
            Controls.Add(txtnotes);
            Controls.Add(lstrecipes);
            Controls.Add(label1);
            Controls.Add(btnaddrecipe);
            Controls.Add(txtnamerecipe);
            Controls.Add(cbkindoffood);
            Controls.Add(label5);
            Controls.Add(btnback);
            Controls.Add(dgvingredients);
            Name = "Form2";
            Text = "Create";
            ((System.ComponentModel.ISupportInitialize)dgvingredients).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtname;
        private TextBox txtingredients;
        private TextBox txtkindoffood;
        private Label lable;
        private Label label1;
        private TextBox txtcalories;
        private Label label3;
        private FontAwesome.Sharp.IconButton btnback;
        private DataGridView dgvingredients;
        private Label label5;
        private ComboBox cbkindoffood;
        private TextBox txtnamerecipe;
        private DataGridViewTextBoxColumn Ingredient;
        private DataGridViewTextBoxColumn Quantity;
        private DataGridViewTextBoxColumn Calories;
        private ListView lstrecipes;
        private TextBox txtnotes;
        private FontAwesome.Sharp.IconButton btnaddrecipe;
        private TextBox txttotalcalories;
        private Button btncalculatecalories;
        private Button btncreaterecipe;
        private Label label2;
        private TextBox txtnumberingredients;
        private Button btnaddningredients;
    }
}