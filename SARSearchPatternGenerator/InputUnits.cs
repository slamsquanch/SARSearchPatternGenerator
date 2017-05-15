using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.ComponentModel.Design;
using System.ComponentModel;

namespace SARSearchPatternGenerator
{
    [Designer("System.Windows.Forms.Design.ParentControlDesigner, System.Design", typeof(IDesigner))]
    public class InputUnits : UserControl
    {
        private TextBox textBox1;
        private ComboBox comboBox1;
        private Label label4;
        private TableLayoutPanel tableLayoutPanel1;

        public InputUnits() : base()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.textBox1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label4, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.comboBox1, 2, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.68132F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 81.31868F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(280, 100);
            this.tableLayoutPanel1.TabIndex = 2;

            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "nm";
            // 
            // comboBox1
            // 
            initializeComboBox();
            // 
            // tableLayoutPanel2
            // 
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(3, 3);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 4;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);

            // 
            // InputUnits
            // 
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "InputUnits";
            this.Size = new System.Drawing.Size(642, 578);
            this.Load += new System.EventHandler(this.PatternDisplay_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        private void PatternDisplay_Load(object sender, EventArgs e)
        {

        }


        //Orientation textBox.
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }


        /*
         *  Takes in a string passed from the unit dropdown function and changes the units label based on that.
         */
        private void changeUnitText(String s)
        {
            switch (s)
            {
                case "nautical miles":
                    this.label4.Text = "nm";
                    break;
                case "miles":
                    this.label4.Text = "mi";
                    break;
                case "feet":
                    this.label4.Text = "ft";
                    break;
                case "kilometres":
                    this.label4.Text = "km";
                    break;
                case "metres":
                    this.label4.Text = "metres";
                    break;

            }

        }

        //Units label.
        private void label4_Click(object sender, EventArgs e)
        {

        }


        /*
         * Unit selection drop down list.  
         */
        private void initializeComboBox()
        {
            string[] units = new string[]{"nautical miles", "miles",
            "feet", "kilometres", "metres"};

            comboBox1.Items.AddRange(units);
            this.comboBox1.MaxDropDownItems = 5;
            this.comboBox1.Text = "nautical miles";
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(148, 138);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox comboBox = (ComboBox)sender;

            // Save the selected employee's name, because we will remove
            // the employee's name from the list.
            //string selectedUnitSystem = (string)comboBox1.SelectedItem;

            string selected = this.comboBox1.GetItemText(this.comboBox1.SelectedItem);
            //MessageBox.Show(selected);
            changeUnitText(selected);

            //int count = 0;
            //int resultIndex = -1;

            // Call the FindStringExact method to find the first 
            // occurrence in the list.
            //resultIndex = comboBox1.FindStringExact(selectedUnitSystem);
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
