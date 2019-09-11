namespace DynamicPets
{
    partial class Form1
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
            this.bntDog = new System.Windows.Forms.Button();
            this.btnAddCat = new System.Windows.Forms.Button();
            this.btnAddParrot = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.panelControls = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // bntDog
            // 
            this.bntDog.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(184)))), ((int)(((byte)(92)))));
            this.bntDog.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntDog.ForeColor = System.Drawing.Color.White;
            this.bntDog.Location = new System.Drawing.Point(24, 27);
            this.bntDog.Name = "bntDog";
            this.bntDog.Size = new System.Drawing.Size(161, 48);
            this.bntDog.TabIndex = 0;
            this.bntDog.Text = "Add Dog";
            this.bntDog.UseVisualStyleBackColor = false;
            this.bntDog.Click += new System.EventHandler(this.bntDog_Click);
            // 
            // btnAddCat
            // 
            this.btnAddCat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(192)))), ((int)(((byte)(222)))));
            this.btnAddCat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCat.ForeColor = System.Drawing.Color.White;
            this.btnAddCat.Location = new System.Drawing.Point(191, 27);
            this.btnAddCat.Name = "btnAddCat";
            this.btnAddCat.Size = new System.Drawing.Size(142, 48);
            this.btnAddCat.TabIndex = 1;
            this.btnAddCat.Text = "Add Cat";
            this.btnAddCat.UseVisualStyleBackColor = false;
            this.btnAddCat.Click += new System.EventHandler(this.btnAddCat_Click);
            // 
            // btnAddParrot
            // 
            this.btnAddParrot.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(173)))), ((int)(((byte)(78)))));
            this.btnAddParrot.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddParrot.ForeColor = System.Drawing.Color.White;
            this.btnAddParrot.Location = new System.Drawing.Point(349, 27);
            this.btnAddParrot.Name = "btnAddParrot";
            this.btnAddParrot.Size = new System.Drawing.Size(171, 48);
            this.btnAddParrot.TabIndex = 2;
            this.btnAddParrot.Text = "Add Parrot";
            this.btnAddParrot.UseVisualStyleBackColor = false;
            this.btnAddParrot.Click += new System.EventHandler(this.btnAddParrot_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(656, 29);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(132, 46);
            this.btnClear.TabIndex = 3;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // panelControls
            // 
            this.panelControls.Location = new System.Drawing.Point(22, 110);
            this.panelControls.Name = "panelControls";
            this.panelControls.Size = new System.Drawing.Size(766, 314);
            this.panelControls.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelControls);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnAddParrot);
            this.Controls.Add(this.btnAddCat);
            this.Controls.Add(this.bntDog);
            this.Name = "Form1";
            this.Text = "Dynamic Pets";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bntDog;
        private System.Windows.Forms.Button btnAddCat;
        private System.Windows.Forms.Button btnAddParrot;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Panel panelControls;
    }
}

