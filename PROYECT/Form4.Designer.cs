namespace PROYECT
{
    partial class Form4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            txtfinalnote = new TextBox();
            lstrecipefinal = new ListView();
            ingredient = new ColumnHeader();
            quantity = new ColumnHeader();
            btnexportword = new FontAwesome.Sharp.IconButton();
            btnexportexcel = new FontAwesome.Sharp.IconButton();
            btnexporttxt = new FontAwesome.Sharp.IconButton();
            lblnamefinal = new Label();
            btnexportxml = new FontAwesome.Sharp.IconButton();
            btnexportjson = new FontAwesome.Sharp.IconButton();
            SuspendLayout();
            // 
            // txtfinalnote
            // 
            txtfinalnote.BackColor = Color.BurlyWood;
            txtfinalnote.Location = new Point(28, 351);
            txtfinalnote.Multiline = true;
            txtfinalnote.Name = "txtfinalnote";
            txtfinalnote.Size = new Size(335, 118);
            txtfinalnote.TabIndex = 1;
            // 
            // lstrecipefinal
            // 
            lstrecipefinal.BackColor = Color.BurlyWood;
            lstrecipefinal.BackgroundImage = (Image)resources.GetObject("lstrecipefinal.BackgroundImage");
            lstrecipefinal.Columns.AddRange(new ColumnHeader[] { ingredient, quantity });
            lstrecipefinal.Font = new Font("Segoe UI", 9.75F, FontStyle.Italic, GraphicsUnit.Point);
            lstrecipefinal.Location = new Point(28, 92);
            lstrecipefinal.Name = "lstrecipefinal";
            lstrecipefinal.Size = new Size(241, 253);
            lstrecipefinal.TabIndex = 2;
            lstrecipefinal.UseCompatibleStateImageBehavior = false;
            lstrecipefinal.View = View.Details;
            // 
            // ingredient
            // 
            ingredient.Text = "Ingredient";
            // 
            // quantity
            // 
            quantity.Text = "Quantity";
            // 
            // btnexportword
            // 
            btnexportword.BackColor = Color.Transparent;
            btnexportword.BackgroundImageLayout = ImageLayout.Center;
            btnexportword.FlatStyle = FlatStyle.Flat;
            btnexportword.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnexportword.ForeColor = Color.Transparent;
            btnexportword.IconChar = FontAwesome.Sharp.IconChar.FileWord;
            btnexportword.IconColor = Color.White;
            btnexportword.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnexportword.IconSize = 38;
            btnexportword.Location = new Point(404, 38);
            btnexportword.Name = "btnexportword";
            btnexportword.Size = new Size(69, 67);
            btnexportword.TabIndex = 14;
            btnexportword.Text = "Word";
            btnexportword.TextAlign = ContentAlignment.BottomCenter;
            btnexportword.UseVisualStyleBackColor = false;
            btnexportword.Click += btnexportword_Click;
            // 
            // btnexportexcel
            // 
            btnexportexcel.BackColor = Color.Transparent;
            btnexportexcel.FlatStyle = FlatStyle.Flat;
            btnexportexcel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnexportexcel.ForeColor = SystemColors.ControlLightLight;
            btnexportexcel.IconChar = FontAwesome.Sharp.IconChar.FileExcel;
            btnexportexcel.IconColor = Color.White;
            btnexportexcel.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnexportexcel.IconSize = 38;
            btnexportexcel.Location = new Point(404, 111);
            btnexportexcel.Name = "btnexportexcel";
            btnexportexcel.Size = new Size(69, 67);
            btnexportexcel.TabIndex = 15;
            btnexportexcel.Text = "Excel";
            btnexportexcel.TextAlign = ContentAlignment.BottomCenter;
            btnexportexcel.UseVisualStyleBackColor = false;
            btnexportexcel.Click += btnexportexcel_Click;
            // 
            // btnexporttxt
            // 
            btnexporttxt.BackColor = Color.Transparent;
            btnexporttxt.FlatStyle = FlatStyle.Flat;
            btnexporttxt.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnexporttxt.ForeColor = SystemColors.ButtonHighlight;
            btnexporttxt.IconChar = FontAwesome.Sharp.IconChar.FileText;
            btnexporttxt.IconColor = Color.White;
            btnexporttxt.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnexporttxt.IconSize = 38;
            btnexporttxt.Location = new Point(404, 184);
            btnexporttxt.Name = "btnexporttxt";
            btnexporttxt.Size = new Size(69, 67);
            btnexporttxt.TabIndex = 16;
            btnexporttxt.Text = "TXT";
            btnexporttxt.TextAlign = ContentAlignment.BottomCenter;
            btnexporttxt.UseVisualStyleBackColor = false;
            btnexporttxt.Click += btnexporttxt_Click;
            // 
            // lblnamefinal
            // 
            lblnamefinal.AutoSize = true;
            lblnamefinal.BackColor = Color.Transparent;
            lblnamefinal.Font = new Font("Script MT Bold", 26.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblnamefinal.ForeColor = Color.LemonChiffon;
            lblnamefinal.Location = new Point(27, 47);
            lblnamefinal.Name = "lblnamefinal";
            lblnamefinal.Size = new Size(0, 42);
            lblnamefinal.TabIndex = 17;
            // 
            // btnexportxml
            // 
            btnexportxml.BackColor = Color.Transparent;
            btnexportxml.BackgroundImageLayout = ImageLayout.Center;
            btnexportxml.FlatStyle = FlatStyle.Flat;
            btnexportxml.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnexportxml.ForeColor = Color.Transparent;
            btnexportxml.IconChar = FontAwesome.Sharp.IconChar.File;
            btnexportxml.IconColor = Color.White;
            btnexportxml.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnexportxml.IconSize = 38;
            btnexportxml.Location = new Point(404, 257);
            btnexportxml.Name = "btnexportxml";
            btnexportxml.Size = new Size(69, 67);
            btnexportxml.TabIndex = 18;
            btnexportxml.Text = "XML";
            btnexportxml.TextAlign = ContentAlignment.BottomCenter;
            btnexportxml.UseVisualStyleBackColor = false;
            btnexportxml.Click += btnexportxml_Click;
            // 
            // btnexportjson
            // 
            btnexportjson.BackColor = Color.Transparent;
            btnexportjson.BackgroundImageLayout = ImageLayout.Center;
            btnexportjson.FlatStyle = FlatStyle.Flat;
            btnexportjson.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnexportjson.ForeColor = Color.Transparent;
            btnexportjson.IconChar = FontAwesome.Sharp.IconChar.FileText;
            btnexportjson.IconColor = Color.White;
            btnexportjson.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnexportjson.IconSize = 38;
            btnexportjson.Location = new Point(404, 330);
            btnexportjson.Name = "btnexportjson";
            btnexportjson.Size = new Size(69, 67);
            btnexportjson.TabIndex = 19;
            btnexportjson.Text = "JSON";
            btnexportjson.TextAlign = ContentAlignment.BottomCenter;
            btnexportjson.UseVisualStyleBackColor = false;
            btnexportjson.Click += btnexportjson_Click;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(494, 481);
            Controls.Add(btnexportjson);
            Controls.Add(btnexportxml);
            Controls.Add(lblnamefinal);
            Controls.Add(btnexporttxt);
            Controls.Add(btnexportexcel);
            Controls.Add(btnexportword);
            Controls.Add(lstrecipefinal);
            Controls.Add(txtfinalnote);
            Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            Name = "Form4";
            Text = "Recipe";
            Load += Form4_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtfinalnote;
        private ColumnHeader ingredient;
        private ColumnHeader quantity;
        public ListView lstrecipefinal;
        private FontAwesome.Sharp.IconButton btnexportword;
        private FontAwesome.Sharp.IconButton btnexportexcel;
        private FontAwesome.Sharp.IconButton btnexporttxt;
        private Label lblnamefinal;
        private FontAwesome.Sharp.IconButton btnexportxml;
        private FontAwesome.Sharp.IconButton btnexportjson;
    }
}