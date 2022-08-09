namespace ShowBigProject
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
            this.btnTupple = new System.Windows.Forms.Button();
            this.btnDelegate = new System.Windows.Forms.Button();
            this.btnEvent = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnTupple
            // 
            this.btnTupple.Location = new System.Drawing.Point(65, 43);
            this.btnTupple.Name = "btnTupple";
            this.btnTupple.Size = new System.Drawing.Size(75, 23);
            this.btnTupple.TabIndex = 0;
            this.btnTupple.Text = "Tupple";
            this.btnTupple.UseVisualStyleBackColor = true;
            this.btnTupple.Click += new System.EventHandler(this.btnTupple_Click);
            // 
            // btnDelegate
            // 
            this.btnDelegate.Location = new System.Drawing.Point(65, 88);
            this.btnDelegate.Name = "btnDelegate";
            this.btnDelegate.Size = new System.Drawing.Size(75, 23);
            this.btnDelegate.TabIndex = 1;
            this.btnDelegate.Text = "Delegate";
            this.btnDelegate.UseVisualStyleBackColor = true;
            this.btnDelegate.Click += new System.EventHandler(this.btnDelegate_Click);
            // 
            // btnEvent
            // 
            this.btnEvent.Location = new System.Drawing.Point(65, 133);
            this.btnEvent.Name = "btnEvent";
            this.btnEvent.Size = new System.Drawing.Size(75, 23);
            this.btnEvent.TabIndex = 2;
            this.btnEvent.Text = "Event";
            this.btnEvent.UseVisualStyleBackColor = true;
            this.btnEvent.Click += new System.EventHandler(this.btnEvent_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnEvent);
            this.Controls.Add(this.btnDelegate);
            this.Controls.Add(this.btnTupple);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnTupple;
        private System.Windows.Forms.Button btnDelegate;
        private System.Windows.Forms.Button btnEvent;
    }
}

