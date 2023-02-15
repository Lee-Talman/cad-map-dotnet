
namespace cad_map_dotnet
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnLoadBlocksWithoutAttributes = new System.Windows.Forms.Button();
            this.btnLoadBlocksWithAttributes = new System.Windows.Forms.Button();
            this.btnLoadPlines = new System.Windows.Forms.Button();
            this.btnLoadMText = new System.Windows.Forms.Button();
            this.btnLoadLines = new System.Windows.Forms.Button();
            this.lblInfo = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnLoadBlocksWithoutAttributes);
            this.groupBox1.Controls.Add(this.btnLoadBlocksWithAttributes);
            this.groupBox1.Controls.Add(this.btnLoadPlines);
            this.groupBox1.Controls.Add(this.btnLoadMText);
            this.groupBox1.Controls.Add(this.btnLoadLines);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 426);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Create";
            // 
            // btnLoadBlocksWithoutAttributes
            // 
            this.btnLoadBlocksWithoutAttributes.BackColor = System.Drawing.Color.PaleGreen;
            this.btnLoadBlocksWithoutAttributes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoadBlocksWithoutAttributes.Location = new System.Drawing.Point(19, 294);
            this.btnLoadBlocksWithoutAttributes.Name = "btnLoadBlocksWithoutAttributes";
            this.btnLoadBlocksWithoutAttributes.Size = new System.Drawing.Size(150, 50);
            this.btnLoadBlocksWithoutAttributes.TabIndex = 5;
            this.btnLoadBlocksWithoutAttributes.Text = "Load Blocks (No Attributes)";
            this.btnLoadBlocksWithoutAttributes.UseVisualStyleBackColor = false;
            this.btnLoadBlocksWithoutAttributes.Click += new System.EventHandler(this.btnLoadBlocksWithoutAttributes_Click);
            // 
            // btnLoadBlocksWithAttributes
            // 
            this.btnLoadBlocksWithAttributes.BackColor = System.Drawing.Color.PaleGreen;
            this.btnLoadBlocksWithAttributes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoadBlocksWithAttributes.Location = new System.Drawing.Point(19, 350);
            this.btnLoadBlocksWithAttributes.Name = "btnLoadBlocksWithAttributes";
            this.btnLoadBlocksWithAttributes.Size = new System.Drawing.Size(150, 50);
            this.btnLoadBlocksWithAttributes.TabIndex = 4;
            this.btnLoadBlocksWithAttributes.Text = "Load Blocks (with Attributes)";
            this.btnLoadBlocksWithAttributes.UseVisualStyleBackColor = false;
            this.btnLoadBlocksWithAttributes.Click += new System.EventHandler(this.btnLoadBlocksWithAttributes_Click);
            // 
            // btnLoadPlines
            // 
            this.btnLoadPlines.BackColor = System.Drawing.Color.PaleGreen;
            this.btnLoadPlines.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoadPlines.Location = new System.Drawing.Point(19, 156);
            this.btnLoadPlines.Name = "btnLoadPlines";
            this.btnLoadPlines.Size = new System.Drawing.Size(150, 50);
            this.btnLoadPlines.TabIndex = 3;
            this.btnLoadPlines.Text = "Load Polylines to DB";
            this.btnLoadPlines.UseVisualStyleBackColor = false;
            this.btnLoadPlines.Click += new System.EventHandler(this.btnLoadPlines_Click);
            // 
            // btnLoadMText
            // 
            this.btnLoadMText.BackColor = System.Drawing.Color.PaleGreen;
            this.btnLoadMText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoadMText.Location = new System.Drawing.Point(19, 100);
            this.btnLoadMText.Name = "btnLoadMText";
            this.btnLoadMText.Size = new System.Drawing.Size(150, 50);
            this.btnLoadMText.TabIndex = 2;
            this.btnLoadMText.Text = "Load MTexts to DB";
            this.btnLoadMText.UseVisualStyleBackColor = false;
            this.btnLoadMText.Click += new System.EventHandler(this.btnLoadMText_Click);
            // 
            // btnLoadLines
            // 
            this.btnLoadLines.BackColor = System.Drawing.Color.PaleGreen;
            this.btnLoadLines.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoadLines.Location = new System.Drawing.Point(19, 44);
            this.btnLoadLines.Name = "btnLoadLines";
            this.btnLoadLines.Size = new System.Drawing.Size(150, 50);
            this.btnLoadLines.TabIndex = 0;
            this.btnLoadLines.Text = "Load Lines to DB";
            this.btnLoadLines.UseVisualStyleBackColor = false;
            this.btnLoadLines.Click += new System.EventHandler(this.btnLoadLines_Click);
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Location = new System.Drawing.Point(218, 334);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(180, 13);
            this.lblInfo.TabIndex = 1;
            this.lblInfo.Text = "Error Message(s) will populate here...";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(221, 65);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(567, 164);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Blue;
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.SystemColors.Menu;
            this.textBox1.Location = new System.Drawing.Point(221, 30);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(567, 29);
            this.textBox1.TabIndex = 3;
            this.textBox1.Text = "Engineering USA Presents: CAD-MAP v2";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblInfo);
            this.Name = "Main";
            this.Text = "Main";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnLoadLines;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Button btnLoadMText;
        private System.Windows.Forms.Button btnLoadPlines;
        private System.Windows.Forms.Button btnLoadBlocksWithAttributes;
        private System.Windows.Forms.Button btnLoadBlocksWithoutAttributes;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBox1;
    }
}