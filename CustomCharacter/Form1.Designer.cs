namespace CustomCharacter
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
            this._numHeadSize = new System.Windows.Forms.NumericUpDown();
            this._numBodySize = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this._numHeadSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._numBodySize)).BeginInit();
            this.SuspendLayout();
            // 
            // _numHeadSize
            // 
            this._numHeadSize.Location = new System.Drawing.Point(74, 7);
            this._numHeadSize.Maximum = new decimal(new int[] { 500, 0, 0, 0 });
            this._numHeadSize.Minimum = new decimal(new int[] { 3, 0, 0, 0 });
            this._numHeadSize.Name = "_numHeadSize";
            this._numHeadSize.Size = new System.Drawing.Size(120, 22);
            this._numHeadSize.TabIndex = 0;
            this._numHeadSize.Value = new decimal(new int[] { 3, 0, 0, 0 });
            this._numHeadSize.ValueChanged += new System.EventHandler(this._numHeadSize_ValueChanged);
            // 
            // _numBodySize
            // 
            this._numBodySize.Location = new System.Drawing.Point(281, 6);
            this._numBodySize.Name = "_numBodySize";
            this._numBodySize.Size = new System.Drawing.Size(120, 22);
            this._numBodySize.TabIndex = 1;
            this._numBodySize.Value = new decimal(new int[] { 3, 0, 0, 0 });
            this._numBodySize.ValueChanged += new System.EventHandler(this._numBodySize_ValueChanged);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "Head";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(224, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "Body";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(952, 703);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this._numBodySize);
            this.Controls.Add(this._numHeadSize);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this._numHeadSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._numBodySize)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.NumericUpDown _numHeadSize;
        private System.Windows.Forms.NumericUpDown _numBodySize;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;

        #endregion
    }
}