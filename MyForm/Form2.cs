using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;
using System.Windows.Forms;
using System.Drawing;

namespace MyForm
{
    public partial class MyForm : Form
    {
        
        ComboBox comboBox;
        Label label;
        Label label1;
        Panel panel;
        TextBox textBox;
        GroupBox groupBox;
        RichTextBox richTextBox;
        ListBox listBox;
        ListBox listBox1;
        CheckBox checkBox1;
        CheckBox checkBox2;
        RadioButton radioButton;
        Button button;
        RadioButton radioButton2;
        RadioButton radioButton3;
        Button button2;
        Button button3;
     
        Button button5;
        Button button6;
        Button button7;
        Button button8;
        Button button9;
        Button button10;
        Button button11;
        Button button12;
        Button button13;
        Button button14;
        Button button15;
        ComboBox comboBox2;

        public MyForm()
        {
            this.Height = 700;
            this.Width = 900;
            this.Text = "Vorm põhielementidega";
           

            if (radioButton != null)
            {
                radioButton.Checked = true;
            }
            if (radioButton2 != null)
            {
                radioButton2.Checked = false;
            }
            if (radioButton3 != null)
            {
                radioButton3.Checked = false;
            }

            // Set CheckBox attributes
            if (checkBox1 != null)
            {
                checkBox1.Checked = true;
            }
            if (checkBox2 != null)
            {
                checkBox2.Checked = false;
            }

            // Set ComboBox attributes and add items
            if (comboBox != null)
            {
                comboBox.Items.AddRange(new string[] { "Tähestik (kasvav)", "Tähestikuline (kahanev)", "Sõna pikkus (kasvavalt)", "Sõna pikkus (kahanev)" });
                comboBox.SelectedIndex = 0;
            }

            if (comboBox2 != null)
            {
                comboBox2.Items.AddRange(new string[] { "Tähestik (kasvav)", "Tähestikuline (kahanev)", "Sõna pikkus (kasvavalt)", "Sõna pikkus (kahanev)" });
                comboBox2.SelectedIndex = 0;
            }

            // Set ListBox attribute
            if (listBox != null)
            {
                listBox.SelectionMode = SelectionMode.MultiExtended;
            }




            button = new Button();
            button.Location = new Point(770, 500);
            button.Height = 80;
            button.Width = 80;
            button.Text = "Выполнить";
            button.Click += Button_Click;
            button.TabIndex = 1;
            button.Visible= true;
            button.BackColor = Color.Yellow; // Устанавливаем желтый цвет фона для кнопки

            radioButton2 = new RadioButton();
            radioButton2.Location = new Point(640, 530);
            radioButton2.Text = "RadioButton 2";
            radioButton2.TabIndex = 12;
            radioButton2.BackColor = Color.Yellow;

            radioButton3 = new RadioButton();
            radioButton3.Location = new Point(640, 560);
            radioButton3.Text = "RadioButton 3";
            radioButton3.TabIndex = 13;
            radioButton3.BackColor = Color.Blue;

            button2 = new Button();
            button2.Location = new Point(245, 570);
            button2.Height = 50;
            button2.Width = 90;
            button2.Text = "Button 2";
            button2.Click += Button2_Click;
            button2.TabIndex = 14;
            button2.Visible = true;
            button2.BackColor = Color.Green;

            button3 = new Button();
            button3.Location = new Point(370, 550);
            button3.Height = 70;
            button3.Width = 150;
            button3.Text = "Button 3";
            button3.Click += Button3_Click;
            button3.TabIndex = 15;
            button3.Visible = true;
            button3.BackColor = Color.Purple;

         

            button5 = new Button();
            button5.Location = new Point(370, 480);
            button5.Height = 70;
            button5.Width = 150;
            button5.Text = "Button 5";
            button5.Click += Button5_Click;
            button5.TabIndex = 15;
            button5.Visible = true;
            button5.BackColor = Color.Purple;

            button6 = new Button();
            button6.Location = new Point(200, 100);
            button6.Height = 30;
            button6.Width = 150;
            button6.Text = ">";
            button6.Click += Button6_Click;
            button6.TabIndex = 15;
            button6.Visible = true;
            button6.BackColor = Color.Aqua;

            button7 = new Button();
            button7.Location = new Point(200, 140);
            button7.Height = 30;
            button7.Width = 150;
            button7.Text = "<";
            button7.Click += Button7_Click;
            button7.TabIndex = 15;
            button7.Visible = true;
            button7.BackColor = Color.Aqua;

            button8 = new Button();
            button8.Location = new Point(200, 180);
            button8.Height = 30;
            button8.Width = 150;
            button8.Text = ">>";
            button8.Click += Button8_Click;
            button8.TabIndex = 15;
            button8.Visible = true;
            button8.BackColor = Color.Aqua;
        
            button9 = new Button();
            button9.Location = new Point(200, 220);
            button9.Height = 30;
            button9.Width = 150;
            button9.Text = "<<";
            button9.Click += Button9_Click;
            button9.TabIndex = 15;
            button9.Visible = true;
            button9.BackColor = Color.Aqua;

            button10 = new Button();
            button10.Location = new Point(25, 350);
            button10.Height = 30;
            button10.Width = 140;
            button10.Text = "Button 10";
            button10.Click += Button10_Click;
            button10.TabIndex = 15;
            button10.Visible = true;
            button10.BackColor = Color.Purple;

           

            button11 = new Button();
            button11.Location = new Point(25, 380);
            button11.Height = 30;
            button11.Width = 140;
            button11.Text = "Button 11";
            button11.Click += Button11_Click;
            button11.TabIndex = 15;
            button11.Visible = true;
            button11.BackColor = Color.Purple;

            button12 = new Button();
            button12.Location = new Point(200, 350);
            button12.Height = 30;
            button12.Width = 140;
            button12.Text = "Button 12";
            button12.Click += Button12_Click;
            button12.TabIndex = 15;
            button12.Visible = true;
            button12.BackColor = Color.Purple;

            button13 = new Button();
            button13.Location = new Point(200, 380);
            button13.Height = 30;
            button13.Width = 140;
            button13.Text = "Button 13";
            button13.Click += Button13_Click;
            button13.TabIndex = 15;
            button13.Visible = true;
            button13.BackColor = Color.Purple;

            button14 = new Button();
            button14.Location = new Point(375, 350);
            button14.Height = 30;
            button14.Width = 140;
            button14.Text = "Button 14";
            button14.Click += Button14_Click;
            button14.TabIndex = 15;
            button14.Visible = true;
            button14.BackColor = Color.Purple;

            button15 = new Button();
            button15.Location = new Point(375, 380);
            button15.Height = 30;
            button15.Width = 140;
            button15.Text = "Button 4";
            button15.Click += Button15_Click;
            button15.TabIndex = 15;
            button15.Visible = true;
            button15.BackColor = Color.Purple;


            comboBox2 = new ComboBox();
            comboBox2.Location = new Point(370, 60);
            comboBox2.Width = 150;
            comboBox2.TabIndex = 16;
            comboBox2.BackColor = Color.LightGray;




            comboBox = new ComboBox();
            comboBox.Location = new Point(25, 60);
            comboBox.Width = 150;
            comboBox.TabIndex = 2;
            comboBox.BackColor = Color.LightCyan;

            label = new Label();
            label.Location = new Point(25, 25);
            label.Text = "Метка";
            label.TabIndex = 3;
            label.BackColor = Color.DarkOrange;

            label1 = new Label();
            label1.Location = new Point(370, 25);
            label1.Text = "Метка";
            label1.TabIndex = 3;
            label1.BackColor = Color.DarkOrange;



            textBox = new TextBox();
            textBox.Location = new Point(25, 490);
            textBox.Width = 150;
            textBox.TabIndex = 5;
            textBox.BackColor = Color.Yellow;

            groupBox = new GroupBox();
            groupBox.Location = new Point(25, 520);
            groupBox.Text = "Группа";
            groupBox.TabIndex = 6;
            groupBox.BackColor = Color.Yellow;
            


            richTextBox = new RichTextBox();
            richTextBox.Location = new Point(640, 25);
            richTextBox.Size = new Size(240, 450);
            richTextBox.TabIndex = 7;
            richTextBox.BackColor = Color.Pink;

            listBox = new ListBox();
            listBox.Location = new Point(25, 100);
            listBox.Width = 150;
            listBox.Height = 250;
            listBox.TabIndex = 8;
            listBox.BackColor = Color.LightPink;

            listBox1 = new ListBox();
            listBox1.Location = new Point(370, 100);
            listBox1.Width = 150;
            listBox1.Height = 250;
            listBox1.TabIndex = 8;
            listBox1.BackColor = Color.LightPink;


            checkBox1 = new CheckBox();
            checkBox1.Location = new Point(240, 510);
            checkBox1.Text = "CheckBox 1";
            checkBox1.TabIndex = 9;
            checkBox1.BackColor = Color.Aqua;

            checkBox2 = new CheckBox();
            checkBox2.Location = new Point(240, 540);
            checkBox2.Text = "CheckBox 2";
            checkBox2.TabIndex = 10;
            checkBox2.BackColor = Color.Aqua;

            radioButton = new RadioButton();
            radioButton.Location = new Point(640, 500);
            radioButton.Text = "RadioButton";
            radioButton.TabIndex = 11;
            radioButton.BackColor = Color.Red;

            panel = new Panel();
            panel.Location = new Point(10, 10);
            panel.Size = new Size(550, 640);
            panel.BorderStyle = BorderStyle.Fixed3D; // Set BorderStyle for the Panel
            panel.TabIndex = 4;

            panel.SendToBack();

            


            this.Controls.Add(panel);
            this.Controls.Add(comboBox);
            this.Controls.Add(label);
            this.Controls.Add(label1);

            this.Controls.Add(textBox);
            this.Controls.Add(groupBox);
            this.Controls.Add(richTextBox);
            this.Controls.Add(listBox);
            this.Controls.Add(listBox1);
            this.Controls.Add(checkBox1);
            this.Controls.Add(checkBox2);
            this.Controls.Add(radioButton);
            this.Controls.Add(button);

            // Additional controls from the second part

            this.Controls.Add(radioButton2);
            this.Controls.Add(radioButton3);

            this.Controls.Add(button2);
            this.Controls.Add(button3);
           
            this.Controls.Add(button5);
            this.Controls.Add(button6);
            this.Controls.Add(button7);
            this.Controls.Add(button8);

            this.Controls.Add(button9);
            this.Controls.Add(button10);
            this.Controls.Add(button11);
            this.Controls.Add(button12);
            this.Controls.Add(button13);
            this.Controls.Add(button14);
            this.Controls.Add(button15);
            this.Controls.Add(comboBox2);
            this.Controls.Add(panel);
        }

        private void Button15_Click(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void Button14_Click(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void Button13_Click(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void Button12_Click(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void Button11_Click(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void Button10_Click(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void Button9_Click(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void Button8_Click(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void Button7_Click(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void Button6_Click(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void Button5_Click(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

      
        private void Button3_Click(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void Button2_Click(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void Button_Click(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
