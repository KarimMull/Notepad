
namespace БЛОКНОТ
{
    partial class FontSettings
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
            this.ExampleLabel = new System.Windows.Forms.Label();
            this.ExampleText = new System.Windows.Forms.Label();
            this.FontBox = new System.Windows.Forms.ComboBox();
            this.styleBox = new System.Windows.Forms.ComboBox();
            this.button_OK = new System.Windows.Forms.Button();
            this.Маштаб = new System.Windows.Forms.Label();
            this.Начертание = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ExampleLabel
            // 
            this.ExampleLabel.AutoSize = true;
            this.ExampleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ExampleLabel.Location = new System.Drawing.Point(52, 119);
            this.ExampleLabel.Name = "ExampleLabel";
            this.ExampleLabel.Size = new System.Drawing.Size(93, 25);
            this.ExampleLabel.TabIndex = 0;
            this.ExampleLabel.Text = "Образец";
            // 
            // ExampleText
            // 
            this.ExampleText.AutoSize = true;
            this.ExampleText.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ExampleText.Location = new System.Drawing.Point(48, 197);
            this.ExampleText.Name = "ExampleText";
            this.ExampleText.Size = new System.Drawing.Size(227, 51);
            this.ExampleText.TabIndex = 1;
            this.ExampleText.Text = "AaBbYyZz";
            // 
            // FontBox
            // 
            this.FontBox.FormattingEnabled = true;
            this.FontBox.Items.AddRange(new object[] {
            "8",
            "9",
            "10",
            "12",
            "14",
            "16",
            "18",
            "20",
            "22",
            "24",
            "26",
            "28",
            "36",
            "48",
            "72"});
            this.FontBox.Location = new System.Drawing.Point(57, 48);
            this.FontBox.Name = "FontBox";
            this.FontBox.Size = new System.Drawing.Size(121, 24);
            this.FontBox.TabIndex = 3;
            this.FontBox.SelectedValueChanged += new System.EventHandler(this.FontBox_SelectedIndexChangedFontBox_SelectedValueChanged);
            // 
            // styleBox
            // 
            this.styleBox.FormattingEnabled = true;
            this.styleBox.Items.AddRange(new object[] {
            "Обычный",
            "Курсив",
            "Полужирный",
            "Подчеркнуто линией"});
            this.styleBox.Location = new System.Drawing.Point(243, 48);
            this.styleBox.Name = "styleBox";
            this.styleBox.Size = new System.Drawing.Size(121, 24);
            this.styleBox.TabIndex = 4;
            this.styleBox.SelectedValueChanged += new System.EventHandler(this.OnStyleChanged);
            // 
            // button_OK
            // 
            this.button_OK.Location = new System.Drawing.Point(164, 304);
            this.button_OK.Name = "button_OK";
            this.button_OK.Size = new System.Drawing.Size(111, 51);
            this.button_OK.TabIndex = 5;
            this.button_OK.Text = "OK";
            this.button_OK.UseVisualStyleBackColor = true;
            this.button_OK.Click += new System.EventHandler(this.button_OK_Click);
            // 
            // Маштаб
            // 
            this.Маштаб.AutoSize = true;
            this.Маштаб.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Маштаб.Location = new System.Drawing.Point(258, 9);
            this.Маштаб.Name = "Маштаб";
            this.Маштаб.Size = new System.Drawing.Size(87, 25);
            this.Маштаб.TabIndex = 6;
            this.Маштаб.Text = "Маштаб";
            // 
            // Начертание
            // 
            this.Начертание.AutoSize = true;
            this.Начертание.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Начертание.Location = new System.Drawing.Point(55, 9);
            this.Начертание.Name = "Начертание";
            this.Начертание.Size = new System.Drawing.Size(123, 25);
            this.Начертание.TabIndex = 7;
            this.Начертание.Text = "Начертание";
            // 
            // FontSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 450);
            this.Controls.Add(this.Начертание);
            this.Controls.Add(this.Маштаб);
            this.Controls.Add(this.button_OK);
            this.Controls.Add(this.styleBox);
            this.Controls.Add(this.FontBox);
            this.Controls.Add(this.ExampleText);
            this.Controls.Add(this.ExampleLabel);
            this.Name = "FontSettings";
            this.Text = "Шрифт";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ExampleLabel;
        private System.Windows.Forms.Label ExampleText;
        private System.Windows.Forms.ComboBox FontBox;
        private System.Windows.Forms.ComboBox styleBox;
        private System.Windows.Forms.Button button_OK;
        private System.Windows.Forms.Label Маштаб;
        private System.Windows.Forms.Label Начертание;
    }
}