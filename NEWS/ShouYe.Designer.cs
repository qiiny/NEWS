
namespace NEWS
{
    partial class ShouYe
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
            this.richTextBoxTM1 = new NEWS.RichTextBoxTM();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // richTextBoxTM1
            // 
            this.richTextBoxTM1.BackColor = System.Drawing.Color.White;
            this.richTextBoxTM1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.richTextBoxTM1.CausesValidation = false;
            this.richTextBoxTM1.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.richTextBoxTM1.Location = new System.Drawing.Point(81, 184);
            this.richTextBoxTM1.Name = "richTextBoxTM1";
            this.richTextBoxTM1.ReadOnly = true;
            this.richTextBoxTM1.Size = new System.Drawing.Size(706, 357);
            this.richTextBoxTM1.TabIndex = 2;
            this.richTextBoxTM1.Text = "";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("隶书", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(274, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(264, 41);
            this.label1.TabIndex = 3;
            this.label1.Text = "新闻管理系统";
            // 
            // ShouYe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(872, 591);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.richTextBoxTM1);
            this.Name = "ShouYe";
            this.Text = "ShouldYe";
            this.Load += new System.EventHandler(this.ShouYe_Load);
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Label label1;

        #endregion

        private RichTextBoxTM richTextBoxTM1;
    }
}