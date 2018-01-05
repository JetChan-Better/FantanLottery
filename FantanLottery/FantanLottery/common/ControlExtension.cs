using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FantanLottery.common
{
    public static class ControlExtension
    {
        public static void AppendTextColorful(this RichTextBox rtBox, string text, Color color, bool addNewLine = true)
        {
            if (addNewLine)
            {
                text += Environment.NewLine;
            }
            rtBox.SelectionStart = rtBox.TextLength;
            rtBox.SelectionLength = 0;
            rtBox.SelectionColor = color;
            rtBox.AppendText(text);
            rtBox.SelectionColor = rtBox.ForeColor;
        }

        public static string AppendSymbol(this string value, string tag = "=", int length = 5)
        {
            StringBuilder sbNewValue = new StringBuilder(value);
            sbNewValue.Insert(0, " ").Append(" ");
            for (int i = 0; i < length; i++)
            {
                sbNewValue.Insert(0, tag).Append(tag);
            }
            return sbNewValue.ToString();
        }
    }
}
