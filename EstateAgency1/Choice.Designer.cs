namespace EstateAgency1
{
    partial class Choice
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
            this.buttonLoadXml = new System.Windows.Forms.Button();
            this.buttonLoadJson = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonLoadXml
            // 
            this.buttonLoadXml.BackColor = System.Drawing.Color.LightCoral;
            this.buttonLoadXml.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonLoadXml.Location = new System.Drawing.Point(0, 341);
            this.buttonLoadXml.Name = "buttonLoadXml";
            this.buttonLoadXml.Size = new System.Drawing.Size(800, 109);
            this.buttonLoadXml.TabIndex = 0;
            this.buttonLoadXml.Text = "Открыть с помощью XML";
            this.buttonLoadXml.UseVisualStyleBackColor = false;
            this.buttonLoadXml.Click += new System.EventHandler(this.buttonLoadXml_Click);
            // 
            // buttonLoadJson
            // 
            this.buttonLoadJson.BackColor = System.Drawing.Color.LightCoral;
            this.buttonLoadJson.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonLoadJson.Location = new System.Drawing.Point(0, 0);
            this.buttonLoadJson.Name = "buttonLoadJson";
            this.buttonLoadJson.Size = new System.Drawing.Size(800, 100);
            this.buttonLoadJson.TabIndex = 1;
            this.buttonLoadJson.Text = "Открыть с помощью JSON";
            this.buttonLoadJson.UseVisualStyleBackColor = false;
            this.buttonLoadJson.Click += new System.EventHandler(this.buttonLoadJson_Click);
            // 
            // Choice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonLoadJson);
            this.Controls.Add(this.buttonLoadXml);
            this.Name = "Choice";
            this.Text = "Choice";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonLoadXml;
        private System.Windows.Forms.Button buttonLoadJson;
    }
}