using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;


namespace BirkaPrint2
{
    public partial class Main : Form
    {
        string[] data_xy = Properties.Settings.Default.Data_xy.Split('/');
        string[] cobor_xy = Properties.Settings.Default.CodeOborudovoniya_xy.Split('/');
        string[] system_xy = Properties.Settings.Default.SystemUpravleniya_xy.Split('/');
        string[] codbolock_xy = Properties.Settings.Default.CodeBlocka_xy.Split('/');
        string[] sern_xy = Properties.Settings.Default.SerialNumber_xy.Split('/');
        string[] fio_xy = Properties.Settings.Default.Fio_xy.Split('/');
        string[] neispr_xy = Properties.Settings.Default.Neispravnost_xy.Split('/');
        string[] proisv_xy = Properties.Settings.Default.Proisvodstvo_xy.Split('/');
        string[] zayavka_xy = Properties.Settings.Default.Zayavka_xy.Split('/');

        bool has_zayavka = true;

        Dictionary<Int32, LabelTextsClass> LabelTexts = new Dictionary<Int32, LabelTextsClass>();

        public bool IsStp
        {
            get { return Properties.Settings.Default.StpMode; }
            set
            {
                Properties.Settings.Default["StpMode"] = value;
                Properties.Settings.Default.Save();
            }
        }

#if DEBUG
        string VER = "Beta";
#else
        string VER = "Release";
#endif
        public Main()
        {
            InitializeComponent();
            Properties.Settings.Default.Properties["StpMode"].IsReadOnly = false;

            LabelTexts[1] = new LabelTextsClass("Код оборудования");
            LabelTexts[2] = new LabelTextsClass("Система управления", "Узел");
            LabelTexts[3] = new LabelTextsClass("Наименование блока", "Код ВАЗа");
            LabelTexts[4] = new LabelTextsClass("Серийный номер", "Тип");
            LabelTexts[5] = new LabelTextsClass("Фамилия");
            LabelTexts[6] = new LabelTextsClass("Неисправность");
            LabelTexts[7] = new LabelTextsClass("№ заявки на ремонт");
            
            versionLabel.Text = VER == "Beta" ? VER : "";
            this.Text = this.Text + " " + versionLabel.Text;
        }

        /// <summary>
        /// Функция перевода из милиметров в пиксели.
        /// </summary>
        /// <param name="value">Значение в милиметрах</param>
        /// <returns>Возвращаемое значение в inch</returns>
        int in_mm(double value)
        {
            return Convert.ToInt32(value / 25.4 * 96);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (IsStp)
            {
                MessageBox.Show("Функция печати бирок по форме \"4209 по СТП\" пока ещё не реализована.\nДанная возможность появится в скором времени.\nСпасибо за понимание.", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!IsValid()) return;

            if (printDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    printDocument1.Print();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка печати", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
        }

        private static System.Drawing.Printing.PrintPageEventArgs evv;
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs ev)
        {
            evv = ev;
            if (has_zayavka)
            {
                CreateText(Convert.ToDouble(zayavka_xy[0]), Convert.ToDouble(zayavka_xy[1]), String.Format("З.№:{0}",ZayavkaText.Text));
            }
            CreateText(Convert.ToDouble(proisv_xy[0]), Convert.ToDouble(proisv_xy[1]), "МСП к. 15/2");
            CreateText(Convert.ToDouble(cobor_xy[0]), Convert.ToDouble(cobor_xy[1]), CodeText.Text);
            CreateText(Convert.ToDouble(system_xy[0]), Convert.ToDouble(system_xy[1]), SystemText.Text);
            CreateText(Convert.ToDouble(codbolock_xy[0]), Convert.ToDouble(codbolock_xy[1]), NameText.Text, 8f);
            CreateText(Convert.ToDouble(sern_xy[0]), Convert.ToDouble(sern_xy[1]), NumberText.Text);
            CreateText(Convert.ToDouble(data_xy[0]), Convert.ToDouble(data_xy[1]), DateTime.Now.ToString("dd.M.yyyy"));
            CreateText(Convert.ToDouble(fio_xy[0]), Convert.ToDouble(fio_xy[1]), String.Format("{0} {1}", FIOText.Text, "т.12-32-77"), 8.1f);
            if (DescText.Text.Length > 0)
                CreateText(Convert.ToDouble(neispr_xy[0]), Convert.ToDouble(neispr_xy[1]), Slice(DescText.Text,0, 24));
            if (DescText.Text.Length > 24)
                CreateText(Convert.ToDouble(neispr_xy[0]), Convert.ToDouble(neispr_xy[1]) + 7, Slice(DescText.Text,24, 44));
            if (DescText.Text.Length > 44)
                CreateText(Convert.ToDouble(neispr_xy[0]), Convert.ToDouble(neispr_xy[1]) + 7 + 7, Slice(DescText.Text,44, 64));
            ev = evv;
            ev.HasMorePages = false;
        }

        private void CreateText(double x, double y, string text, float size = 11f)
        {
            printDocument1.OriginAtMargins = true;
            evv.PageSettings.Margins = new System.Drawing.Printing.Margins(0, 0, 0, 0);
            //evv.PageSettings.PaperSize = new System.Drawing.Printing.PaperSize("Бирка", 104, 74);
            var font = new Font("Courier New", size);
            //int h = (int)evv.Graphics.MeasureString(text, font).Height + 5;
            //int w = (int)evv.Graphics.MeasureString(text, font).Width + 1;

            //var stringFormat = new StringFormat();
            //stringFormat.Alignment = StringAlignment.Near;
            //stringFormat.LineAlignment = StringAlignment.Near;

            //RectangleF rect1 = new RectangleF(evv.MarginBounds.Width / 2 + in_mm(x + 15) - w, in_mm(y - 7), w, h);

            evv.Graphics.DrawString(text, font, Brushes.Black, in_mm(evv.MarginBounds.Left/2 + x + 15), in_mm(y));
        }

        public static string Slice(string source, int start, int end)
        {
            if (end < 0)
            {
                end = source.Length + end;
            }
            int len = end - start;
            if (source.Length - start < len)
                return source.Substring(start, source.Length - start);
            else
                return source.Substring(start, len);
        }

        bool IsValid()
        {
            if (String.IsNullOrEmpty(CodeText.Text))
            {
                MessageBox.Show("Не указан код оборудования!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                CodeText.Focus();
                return false;
            }
            if (String.IsNullOrEmpty(SystemText.Text))
            {
                MessageBox.Show("Не указана система управления!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                SystemText.Focus();
                return false;
            }
            if (String.IsNullOrEmpty(NameText.Text))
            {
                MessageBox.Show("Не указан код блока!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                NameText.Focus();
                return false;
            }
            if (String.IsNullOrEmpty(NumberText.Text))
            {
                MessageBox.Show("Не указан серийный номер!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                NumberText.Focus();
                return false;
            }
            if (String.IsNullOrEmpty(FIOText.Text))
            {
                MessageBox.Show("Не указана фамилия!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                FIOText.Focus();
                return false;
            }
            if (String.IsNullOrEmpty(DescText.Text))
            {
                MessageBox.Show("Не указана неисправность!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                DescText.Focus();
                return false;
            }
            if (String.IsNullOrEmpty(ZayavkaText.Text))
            {
                has_zayavka = false;
                if (MessageBox.Show("Заявка на ремонт не указана.\nХотите указать?", "Вопрос, относящийся к Вам!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                {
                    ZayavkaText.Focus();
                    return false;
                }
            }
            else
            {
                has_zayavka = true;
            }
            return true;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (DialogResult.No == MessageBox.Show("Вы действительно хотите выйти?", "Вопрос, относящийся к Вам!", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                e.Cancel = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Печать складских бирок.\nДанная программа разработана бригадой ОЭТС №621.\n\nВерсия программы: "+ProductVersion+" "+VER+"\n\nВопросы и пожелания по улучшению программы, просьба направлять на почту dr.morz@gmail.com", "О программе", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            IsStp = checkBox1.Checked;
            Form1_Load(null, null);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            checkBox1.Checked = IsStp;
            for (int i = 1; i < LabelTexts.Count; ++i)
            {
                var name = "label" + (i);
                var t = this.Controls.Find(name, false);
                ((Label)t[0]).Text = LabelTexts[i].Text(IsStp);
            }
        }

    }
}
