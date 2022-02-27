using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace БЛОКНОТ
{
    public partial class FontSettings : Form
    {
        public int fontSize = 0;
        public System.Drawing.FontStyle fs = FontStyle.Regular;
        public FontSettings()
        {
            InitializeComponent();
            FontBox.SelectedItem = FontBox.Items[3];
            styleBox.SelectedItem = styleBox.Items[0];
        }

        private void FontBox_SelectedIndexChangedFontBox_SelectedValueChanged(object sender, EventArgs e)
        {
            ExampleText.Font = new Font(ExampleText.Font.FontFamily,int.Parse(FontBox.SelectedItem.ToString()), ExampleText.Font.Style);
            fontSize = int.Parse(FontBox.SelectedItem.ToString());
        }
        private void OnStyleChanged(object sender, EventArgs e)
        {
            switch(styleBox.SelectedItem.ToString())
            {
                case "Обычный": ExampleText.Font = new Font(ExampleText.Font.FontFamily, int.Parse(FontBox.SelectedItem.ToString()), FontStyle.Regular); break;
                case "Курсив": ExampleText.Font = new Font(ExampleText.Font.FontFamily, int.Parse(FontBox.SelectedItem.ToString()), FontStyle.Italic); break;
                case "Полужирный": ExampleText.Font = new Font(ExampleText.Font.FontFamily, int.Parse(FontBox.SelectedItem.ToString()), FontStyle.Bold); break;
                case "Подчеркнуто линией": ExampleText.Font = new Font(ExampleText.Font.FontFamily, int.Parse(FontBox.SelectedItem.ToString()), FontStyle.Underline); break;
            }

            fs = ExampleText.Font.Style;
        }

        private void button_OK_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
