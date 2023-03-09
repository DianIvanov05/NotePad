namespace TextRedactor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void mnuSaveAs_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "Text|*.txt|All files|*.*";
            saveFileDialog1.ShowDialog();
            rtb.SaveFile(saveFileDialog1.FileName);
        }

        private void mnuNew_Click(object sender, EventArgs e)
        {
            if (rtb.Modified)
            {
                DialogResult a = MessageBox.Show(this, "Do you want to save?", "Prompt", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

                if (a == DialogResult.Yes)
                {
                  mnuSave_Click(sender, e);
                }
                if (a==DialogResult.Cancel)
                {
                    return;
                }
                rtb.Clear();
            }

        }

        private void mnuOpen_Click(object sender, EventArgs e)
        {
            if (rtb.Modified)
            {
                DialogResult a = MessageBox.Show(this, "Do you want to save?", "Prompt", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (a == DialogResult.Yes)
                {
                    mnuSave_Click(sender, e);
                }
                if (a == DialogResult.Cancel)
                {
                    return;
                }
            }
            openFileDialog1.Filter = "Text|*.txt|All files|*.*";
            openFileDialog1.ShowDialog();
            rtb.LoadFile(openFileDialog1.FileName);
        }

        private void mnuExit_Click(object sender, EventArgs e)
        {
            if(rtb.Modified)
            {
                DialogResult a = MessageBox.Show(this, "Do you want to save?", "Prompt", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (a == DialogResult.Yes)
                {
                    mnuSave_Click(sender, e);
                }
                if (a == DialogResult.Cancel)
                {
                    return;
                }
            }
            this.Close();
        }

        private void mnuSave_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "Text|*.txt|All files|*.*";
            saveFileDialog1.ShowDialog();
            rtb.SaveFile(saveFileDialog1.FileName);
        }

        private void mnuFont_Click(object sender, EventArgs e)
        {
            fontDialog1.ShowEffects = true;
            fontDialog1.ShowColor = true;
            fontDialog1.ShowDialog();
            rtb.SelectionFont= fontDialog1.Font;
            rtb.SelectionColor = fontDialog1.Color;
        }
    }
}