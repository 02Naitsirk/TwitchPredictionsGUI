namespace TwitchPredictionsGUI
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
            this.numberOfPointsLabel = new System.Windows.Forms.Label();
            this.choiceALabel = new System.Windows.Forms.Label();
            this.choiceBLabel = new System.Windows.Forms.Label();
            this.aSuccessProbLabel = new System.Windows.Forms.Label();
            this.goButton = new System.Windows.Forms.Button();
            this.betLabel = new System.Windows.Forms.Label();
            this.numberOfPointsInput = new System.Windows.Forms.NumericUpDown();
            this.aPointsInput = new System.Windows.Forms.NumericUpDown();
            this.bPointsInput = new System.Windows.Forms.NumericUpDown();
            this.aProbInput = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numberOfPointsInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aPointsInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bPointsInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aProbInput)).BeginInit();
            this.SuspendLayout();
            // 
            // numberOfPointsLabel
            // 
            this.numberOfPointsLabel.Location = new System.Drawing.Point(12, 9);
            this.numberOfPointsLabel.Name = "numberOfPointsLabel";
            this.numberOfPointsLabel.Size = new System.Drawing.Size(100, 23);
            this.numberOfPointsLabel.TabIndex = 0;
            this.numberOfPointsLabel.Text = "Points You Have";
            // 
            // choiceALabel
            // 
            this.choiceALabel.Location = new System.Drawing.Point(12, 32);
            this.choiceALabel.Name = "choiceALabel";
            this.choiceALabel.Size = new System.Drawing.Size(100, 23);
            this.choiceALabel.TabIndex = 1;
            this.choiceALabel.Text = "Points on A";
            // 
            // choiceBLabel
            // 
            this.choiceBLabel.Location = new System.Drawing.Point(12, 55);
            this.choiceBLabel.Name = "choiceBLabel";
            this.choiceBLabel.Size = new System.Drawing.Size(100, 23);
            this.choiceBLabel.TabIndex = 2;
            this.choiceBLabel.Text = "Points on B";
            // 
            // aSuccessProbLabel
            // 
            this.aSuccessProbLabel.Location = new System.Drawing.Point(12, 78);
            this.aSuccessProbLabel.Name = "aSuccessProbLabel";
            this.aSuccessProbLabel.Size = new System.Drawing.Size(164, 23);
            this.aSuccessProbLabel.TabIndex = 3;
            this.aSuccessProbLabel.Text = "Choice A Success Probability (%)";
            // 
            // goButton
            // 
            this.goButton.Location = new System.Drawing.Point(12, 102);
            this.goButton.Name = "goButton";
            this.goButton.Size = new System.Drawing.Size(270, 23);
            this.goButton.TabIndex = 10;
            this.goButton.Text = "Go";
            this.goButton.UseVisualStyleBackColor = true;
            this.goButton.Click += new System.EventHandler(this.goButton_Click);
            // 
            // betLabel
            // 
            this.betLabel.Location = new System.Drawing.Point(12, 128);
            this.betLabel.Name = "betLabel";
            this.betLabel.Size = new System.Drawing.Size(270, 23);
            this.betLabel.TabIndex = 11;
            this.betLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // numberOfPointsInput
            // 
            this.numberOfPointsInput.Location = new System.Drawing.Point(134, 7);
            this.numberOfPointsInput.Maximum = new decimal(new int[] { 2147483647, 0, 0, 0 });
            this.numberOfPointsInput.Name = "numberOfPointsInput";
            this.numberOfPointsInput.Size = new System.Drawing.Size(148, 20);
            this.numberOfPointsInput.TabIndex = 12;
            // 
            // aPointsInput
            // 
            this.aPointsInput.Location = new System.Drawing.Point(134, 30);
            this.aPointsInput.Maximum = new decimal(new int[] { 2147483647, 0, 0, 0 });
            this.aPointsInput.Name = "aPointsInput";
            this.aPointsInput.Size = new System.Drawing.Size(148, 20);
            this.aPointsInput.TabIndex = 13;
            // 
            // bPointsInput
            // 
            this.bPointsInput.Location = new System.Drawing.Point(134, 53);
            this.bPointsInput.Maximum = new decimal(new int[] { 2147483647, 0, 0, 0 });
            this.bPointsInput.Name = "bPointsInput";
            this.bPointsInput.Size = new System.Drawing.Size(148, 20);
            this.bPointsInput.TabIndex = 14;
            // 
            // aProbInput
            // 
            this.aProbInput.DecimalPlaces = 2;
            this.aProbInput.Location = new System.Drawing.Point(182, 76);
            this.aProbInput.Name = "aProbInput";
            this.aProbInput.Size = new System.Drawing.Size(100, 20);
            this.aProbInput.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(294, 159);
            this.Controls.Add(this.aProbInput);
            this.Controls.Add(this.bPointsInput);
            this.Controls.Add(this.aPointsInput);
            this.Controls.Add(this.numberOfPointsInput);
            this.Controls.Add(this.betLabel);
            this.Controls.Add(this.goButton);
            this.Controls.Add(this.aSuccessProbLabel);
            this.Controls.Add(this.choiceBLabel);
            this.Controls.Add(this.choiceALabel);
            this.Controls.Add(this.numberOfPointsLabel);
            this.Name = "Form1";
            this.Text = "Twitch Predictions Helper";
            ((System.ComponentModel.ISupportInitialize)(this.numberOfPointsInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aPointsInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bPointsInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aProbInput)).EndInit();
            this.ResumeLayout(false);
            this.MaximizeBox = false;
        }

        private System.Windows.Forms.NumericUpDown aProbInput;

        private System.Windows.Forms.NumericUpDown bPointsInput;

        private System.Windows.Forms.NumericUpDown aPointsInput;

        private System.Windows.Forms.NumericUpDown numberOfPointsInput;

        private System.Windows.Forms.Label betLabel;

        private System.Windows.Forms.Button goButton;

        private System.Windows.Forms.Label aSuccessProbLabel;

        private System.Windows.Forms.Label choiceALabel;
        private System.Windows.Forms.Label choiceBLabel;

        private System.Windows.Forms.Label numberOfPointsLabel;

        #endregion
    }
}