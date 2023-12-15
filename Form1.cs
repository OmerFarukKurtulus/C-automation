using System.Diagnostics.Metrics;
using System.Windows.Forms;

namespace BenzinlikOtomasyonu
{
    public partial class Form1 : Form
    {
        int abenzinf = 30, adizelf = 35, alpgf = 10, sbenzinf = 40, sdizelf = 45, slpgf = 20, textint;
        double depo, ddepo, ldepo, fiyata, kasa = 400000;
        string a, skasa;
        public Form1()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                if (button1.Enabled == true && button2.Enabled == true)
                {
                    MessageBox.Show("Litre veya Fiyat butonunu seçiniz....");
                }
                else if (button1.Enabled == true)
                {
                    if (comboBox1.SelectedIndex == -1)
                    {
                        MessageBox.Show("Alıs veya Satıs butonunu seçiniz....");

                    }
                    else if (comboBox1.SelectedIndex == 0)
                    {
                        if (textBox1.Text == string.Empty)
                        {
                            MessageBox.Show("Deger gir....");
                        }
                        else
                        {
                            textint = Convert.ToInt32(textBox1.Text);

                            if (textint > (10000 - depo))
                            {
                                MessageBox.Show("Depo dolu....");
                                button1.Enabled = true;
                                button2.Enabled = true;
                                textBox1.Text = string.Empty;
                                comboBox1.SelectedIndex = -1;
                            }
                            else
                            {
                                if (kasa < (textint * abenzinf))
                                {
                                    MessageBox.Show("Kasanda para yok....");
                                }
                                else
                                {
                                    progressBar1.Maximum = 10000;
                                    depo += textint;
                                    fiyata = abenzinf * textint;
                                    progressBar1.Value = (int)depo;
                                    a = Convert.ToString((progressBar1.Value / 100));
                                    label4.Text = (a + " %");
                                    MessageBox.Show("Fiyat " + fiyata);
                                    kasa -= fiyata;
                                    string newItem = string.Format("{0} ₺ {1}", fiyata, "Kasadan Eksildi");
                                    listBox1.Items.Add(newItem);

                                }
                                button1.Enabled = true;
                                button2.Enabled = true;
                                textBox1.Text = string.Empty;
                                comboBox1.SelectedIndex = -1;
                            }


                        }

                    }
                    else
                    {
                        if (textBox1.Text == string.Empty)
                        {
                            MessageBox.Show("Deger gir....");
                        }
                        else
                        {
                            textint = Convert.ToInt32(textBox1.Text);

                            if (textint > depo)
                            {
                                MessageBox.Show("Depo boş....");
                                button1.Enabled = true;
                                button2.Enabled = true;
                                textBox1.Text = string.Empty;
                                comboBox1.SelectedIndex = -1;
                            }
                            else
                            {
                                progressBar1.Maximum = 10000;
                                depo -= textint;
                                fiyata = sbenzinf * textint;
                                progressBar1.Value = (int)depo;
                                a = Convert.ToString((progressBar1.Value / 100));
                                label4.Text = (a + " %");
                                MessageBox.Show("Fiyat" + fiyata);
                                kasa += fiyata;
                                string newItem = string.Format("{0} ₺ {1}", fiyata, "Kasaya Eklendi");
                                listBox1.Items.Add(newItem);
                            }
                            button1.Enabled = true;
                            button2.Enabled = true;
                            textBox1.Text = string.Empty;
                            comboBox1.SelectedIndex = -1;
                        }
                    }
                }
                else
                {
                    if (comboBox1.SelectedIndex == -1)
                    {
                        MessageBox.Show("Alıs veya Satıs butonunu seçiniz....");

                    }
                    else if (comboBox1.SelectedIndex == 0)
                    {
                        if (textBox1.Text == string.Empty)
                        {
                            MessageBox.Show("Deger gir....");
                        }
                        else
                        {
                            textint = Convert.ToInt32(textBox1.Text);

                            if (textint > ((abenzinf * 10000) - (abenzinf * depo)))
                            {
                                MessageBox.Show("Depo dolu....");
                                button1.Enabled = true;
                                button2.Enabled = true;
                                textBox1.Text = string.Empty;
                                comboBox1.SelectedIndex = -1;
                            }
                            else
                            {
                                if (kasa < textint)
                                {
                                    MessageBox.Show("Kasanda para yok....");
                                }
                                else
                                {
                                    progressBar1.Maximum = 10000;
                                    fiyata = (double)textint / (double)abenzinf;
                                    depo += fiyata;
                                    progressBar1.Value = (int)depo;
                                    a = Convert.ToString((progressBar1.Value / 100));
                                    label4.Text = (a + " %");
                                    MessageBox.Show("Litre " + fiyata);
                                    kasa -= textint;
                                    string newItem = string.Format("{0} ₺ {1}", textint, "Kasadan Eksildi");
                                    listBox1.Items.Add(newItem);
                                }
                                button1.Enabled = true;
                                button2.Enabled = true;
                                textBox1.Text = string.Empty;
                                comboBox1.SelectedIndex = -1;
                            }
                        }

                    }
                    else
                    {
                        if (textBox1.Text == string.Empty)
                        {
                            MessageBox.Show("Deger gir....");
                        }
                        else
                        {
                            textint = Convert.ToInt32(textBox1.Text);

                            if (textint > (sbenzinf * depo))
                            {
                                MessageBox.Show("Depo boş....");
                                button1.Enabled = true;
                                button2.Enabled = true;
                                textBox1.Text = string.Empty;
                                comboBox1.SelectedIndex = -1;
                            }
                            else
                            {
                                progressBar1.Maximum = 10000;
                                fiyata = (double)textint / (double)sbenzinf;
                                depo -= fiyata;
                                progressBar1.Value = (int)depo;
                                a = Convert.ToString((progressBar1.Value / 100));
                                label4.Text = (a + " %");
                                MessageBox.Show("Litre " + fiyata);
                                kasa += textint;
                                string newItem = string.Format("{0} ₺ {1}", textint, "Kasaya Eklendi");
                                listBox1.Items.Add(newItem);
                            }
                            button1.Enabled = true;
                            button2.Enabled = true;
                            textBox1.Text = string.Empty;
                            comboBox1.SelectedIndex = -1;
                        }
                    }
                }

            }
            else if (radioButton2.Checked == true)
            {
                if (button1.Enabled == true && button2.Enabled == true)
                {
                    MessageBox.Show("Litre veya Fiyat butonunu seçiniz....");
                }
                else if (button1.Enabled == true)
                {
                    if (comboBox1.SelectedIndex == -1)
                    {
                        MessageBox.Show("Alıs veya Satıs butonunu seçiniz....");

                    }
                    else if (comboBox1.SelectedIndex == 0)
                    {
                        if (textBox1.Text == string.Empty)
                        {
                            MessageBox.Show("Deger gir....");
                        }
                        else
                        {
                            textint = Convert.ToInt32(textBox1.Text);

                            if (textint > (10000 - ddepo))
                            {
                                MessageBox.Show("Depo dolu....");
                                button1.Enabled = true;
                                button2.Enabled = true;
                                textBox1.Text = string.Empty;
                                comboBox1.SelectedIndex = -1;
                            }
                            else
                            {
                                if (kasa < (textint * adizelf))
                                {
                                    MessageBox.Show("Kasanda para yok....");
                                }
                                else
                                {
                                    progressBar2.Maximum = 10000;
                                    ddepo += textint;
                                    fiyata = adizelf * textint;
                                    progressBar2.Value = (int)ddepo;
                                    a = Convert.ToString((progressBar2.Value / 100));
                                    label5.Text = (a + " %");
                                    MessageBox.Show("Fiyat " + fiyata);
                                    kasa -= fiyata;
                                    string newItem = string.Format("{0} ₺ {1}", fiyata, "Kasadan Eksildi");
                                    listBox1.Items.Add(newItem);
                                }
                                button1.Enabled = true;
                                button2.Enabled = true;
                                textBox1.Text = string.Empty;
                                comboBox1.SelectedIndex = -1;
                            }
                        }

                    }
                    else
                    {
                        if (textBox1.Text == string.Empty)
                        {
                            MessageBox.Show("Deger gir....");
                        }
                        else
                        {
                            textint = Convert.ToInt32(textBox1.Text);

                            if (textint > ddepo)
                            {
                                MessageBox.Show("Depo boş....");
                                button1.Enabled = true;
                                button2.Enabled = true;
                                textBox1.Text = string.Empty;
                                comboBox1.SelectedIndex = -1;
                            }
                            else
                            {
                                progressBar2.Maximum = 10000;
                                ddepo -= textint;
                                fiyata = sdizelf * textint;
                                progressBar2.Value = (int)ddepo;
                                a = Convert.ToString((progressBar2.Value / 100));
                                label5.Text = (a + " %");
                                MessageBox.Show("Fiyat" + fiyata);
                                kasa += fiyata;
                                string newItem = string.Format("{0} ₺ {1}", fiyata, "Kasaya Eklendi");
                                listBox1.Items.Add(newItem);
                            }
                            button1.Enabled = true;
                            button2.Enabled = true;
                            textBox1.Text = string.Empty;
                            comboBox1.SelectedIndex = -1;
                        }
                    }
                }
                else
                {
                    if (comboBox1.SelectedIndex == -1)
                    {
                        MessageBox.Show("Alıs veya Satıs butonunu seçiniz....");

                    }
                    else if (comboBox1.SelectedIndex == 0)
                    {
                        if (textBox1.Text == string.Empty)
                        {
                            MessageBox.Show("Deger gir....");
                        }
                        else
                        {
                            textint = Convert.ToInt32(textBox1.Text);

                            if (textint > ((adizelf * 10000) - (adizelf * ddepo)))
                            {
                                MessageBox.Show("Depo dolu....");
                                button1.Enabled = true;
                                button2.Enabled = true;
                                textBox1.Text = string.Empty;
                                comboBox1.SelectedIndex = -1;
                            }
                            else
                            {
                                if (kasa < textint)
                                {
                                    MessageBox.Show("Kasanda para yok....");
                                }
                                else
                                {
                                    progressBar2.Maximum = 10000;
                                    fiyata = (double)textint / (double)adizelf;
                                    ddepo += fiyata;
                                    progressBar2.Value = (int)ddepo;
                                    a = Convert.ToString((progressBar2.Value / 100));
                                    label5.Text = (a + " %");
                                    MessageBox.Show("Litre " + fiyata);
                                    kasa -= textint;
                                    string newItem = string.Format("{0} ₺ {1}", textint, "Kasadan Eksildi");
                                    listBox1.Items.Add(newItem);
                                }
                                button1.Enabled = true;
                                button2.Enabled = true;
                                textBox1.Text = string.Empty;
                                comboBox1.SelectedIndex = -1;
                            }
                        }

                    }
                    else
                    {
                        if (textBox1.Text == string.Empty)
                        {
                            MessageBox.Show("Deger gir....");
                        }
                        else
                        {
                            textint = Convert.ToInt32(textBox1.Text);

                            if (textint > (sdizelf * ddepo))
                            {
                                MessageBox.Show("Depo boş....");
                                button1.Enabled = true;
                                button2.Enabled = true;
                                textBox1.Text = string.Empty;
                                comboBox1.SelectedIndex = -1;
                            }
                            else
                            {
                                progressBar2.Maximum = 10000;
                                fiyata = (double)textint / (double)sdizelf;
                                ddepo -= fiyata;
                                progressBar2.Value = (int)ddepo;
                                a = Convert.ToString((progressBar2.Value / 100));
                                label5.Text = (a + " %");
                                MessageBox.Show("Litre " + fiyata);
                                kasa += textint;
                                string newItem = string.Format("{0} ₺ {1}", textint, "Kasaya Eklendi");
                                listBox1.Items.Add(newItem);
                            }
                            button1.Enabled = true;
                            button2.Enabled = true;
                            textBox1.Text = string.Empty;
                            comboBox1.SelectedIndex = -1;
                        }
                    }
                }
            }
            else if (radioButton3.Checked == true)
            {
                if (button1.Enabled == true && button2.Enabled == true)
                {
                    MessageBox.Show("Litre veya Fiyat butonunu seçiniz....");
                }
                else if (button1.Enabled == true)
                {
                    if (comboBox1.SelectedIndex == -1)
                    {
                        MessageBox.Show("Alıs veya Satıs butonunu seçiniz....");

                    }
                    else if (comboBox1.SelectedIndex == 0)
                    {
                        if (textBox1.Text == string.Empty)
                        {
                            MessageBox.Show("Deger gir....");
                        }
                        else
                        {
                            textint = Convert.ToInt32(textBox1.Text);

                            if (textint > (10000 - ldepo))
                            {
                                MessageBox.Show("Depo dolu....");
                                button1.Enabled = true;
                                button2.Enabled = true;
                                textBox1.Text = string.Empty;
                                comboBox1.SelectedIndex = -1;
                            }
                            else
                            {
                                if (kasa < (textint * alpgf))
                                {
                                    MessageBox.Show("Kasanda para yok....");
                                }
                                else
                                {
                                    progressBar3.Maximum = 10000;
                                    ldepo += textint;
                                    fiyata = alpgf * textint;
                                    progressBar3.Value = (int)ldepo;
                                    a = Convert.ToString((progressBar3.Value / 100));
                                    label6.Text = (a + " %");
                                    MessageBox.Show("Fiyat " + fiyata);
                                    kasa -= fiyata;
                                    string newItem = string.Format("{0} ₺ {1}", fiyata, "Kasadan Eksildi");
                                    listBox1.Items.Add(newItem);
                                }
                                button1.Enabled = true;
                                button2.Enabled = true;
                                textBox1.Text = string.Empty;
                                comboBox1.SelectedIndex = -1;
                            }
                        }

                    }
                    else
                    {
                        if (textBox1.Text == string.Empty)
                        {
                            MessageBox.Show("Deger gir....");
                        }
                        else
                        {
                            textint = Convert.ToInt32(textBox1.Text);

                            if (textint > ldepo)
                            {
                                MessageBox.Show("Depo boş....");
                                button1.Enabled = true;
                                button2.Enabled = true;
                                textBox1.Text = string.Empty;
                                comboBox1.SelectedIndex = -1;
                            }
                            else
                            {
                                progressBar3.Maximum = 10000;
                                ldepo -= textint;
                                fiyata = slpgf * textint;
                                progressBar3.Value = (int)ldepo;
                                a = Convert.ToString((progressBar3.Value / 100));
                                label6.Text = (a + " %");
                                MessageBox.Show("Fiyat" + fiyata);
                                kasa += fiyata;
                                string newItem = string.Format("{0} ₺ {1}", fiyata, "Kasaya Eklendi");
                                listBox1.Items.Add(newItem);
                            }
                            button1.Enabled = true;
                            button2.Enabled = true;
                            textBox1.Text = string.Empty;
                            comboBox1.SelectedIndex = -1;
                        }
                    }
                }
                else
                {
                    if (comboBox1.SelectedIndex == -1)
                    {
                        MessageBox.Show("Alıs veya Satıs butonunu seçiniz....");

                    }
                    else if (comboBox1.SelectedIndex == 0)
                    {
                        if (textBox1.Text == string.Empty)
                        {
                            MessageBox.Show("Deger gir....");
                        }
                        else
                        {
                            textint = Convert.ToInt32(textBox1.Text);

                            if (textint > ((alpgf * 10000) - (alpgf * ldepo)))
                            {
                                MessageBox.Show("Depo Dolu....");
                                button1.Enabled = true;
                                button2.Enabled = true;
                                textBox1.Text = string.Empty;
                                comboBox1.SelectedIndex = -1;
                            }
                            else
                            {
                                if (kasa < textint)
                                {
                                    MessageBox.Show("Kasanda para yok....");
                                }
                                else
                                {
                                    progressBar3.Maximum = 10000;
                                    fiyata = (double)textint / (double)alpgf;
                                    ldepo += fiyata;
                                    progressBar3.Value = (int)ldepo;
                                    a = Convert.ToString((progressBar3.Value / 100));
                                    label6.Text = (a + " %");
                                    MessageBox.Show("Litre " + fiyata);
                                    kasa -= textint;
                                    string newItem = string.Format("{0} ₺ {1}", textint, "Kasadan Eksildi");
                                    listBox1.Items.Add(newItem);
                                }
                                button1.Enabled = true;
                                button2.Enabled = true;
                                textBox1.Text = string.Empty;
                                comboBox1.SelectedIndex = -1;
                            }
                        }

                    }
                    else
                    {
                        if (textBox1.Text == string.Empty)
                        {
                            MessageBox.Show("Deger gir....");
                        }
                        else
                        {
                            textint = Convert.ToInt32(textBox1.Text);

                            if (textint > (slpgf * ldepo))
                            {
                                MessageBox.Show("Depo boş....");
                                button1.Enabled = true;
                                button2.Enabled = true;
                                textBox1.Text = string.Empty;
                                comboBox1.SelectedIndex = -1;
                            }
                            else
                            {
                                progressBar3.Maximum = 10000;
                                fiyata = (double)textint / (double)slpgf;
                                ldepo -= fiyata;
                                progressBar3.Value = (int)ldepo;
                                a = Convert.ToString((progressBar3.Value / 100));
                                label6.Text = (a + " %");
                                MessageBox.Show("Litre " + fiyata);
                                kasa += textint;
                                string newItem = string.Format("{0} ₺ {1}", textint, "Kasaya Eklendi");
                                listBox1.Items.Add(newItem);
                            }
                            button1.Enabled = true;
                            button2.Enabled = true;
                            textBox1.Text = string.Empty;
                            comboBox1.SelectedIndex = -1;
                        }
                    }
                }
            }
            skasa = Convert.ToString(kasa);
            label7.Text = ("Kasa : " + skasa);
        }

        private void progressBar2_Click(object sender, EventArgs e)
        {
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {
        }

        private void label5_Click(object sender, EventArgs e)
        {
        }

        private void label4_Click(object sender, EventArgs e)
        {
        }

        private void label3_Click(object sender, EventArgs e)
        {
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void progressBar3_Click(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button2.Enabled = false;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}