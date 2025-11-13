using System.Drawing;
using System.Windows.Forms;

namespace AutoRent.UI.Forms
{
 public static class FormStyles
 {
 public static void ApplyDefault(Form f)
 {
 f.Font = new Font("Segoe UI",9f);
 f.BackColor = Color.WhiteSmoke;
 foreach (Control c in f.Controls)
 {
 if (c is Button b)
 {
 b.FlatStyle = FlatStyle.System;
 }
 }
 }
 }
}
