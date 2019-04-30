using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Model;
using WindowsFormsApp1.Repository;

namespace WindowsFormsApp1
{
    public partial class patientDetail : Form
    {

        private PatientBasic patient, newData;
        private Boolean isChanged = false;

        public patientDetail()
        {
            InitializeComponent();
            patient = patientData.ChosenPatient;
            LoadData();
        }

        //初始化数据
        private void LoadData()
        {

            setOriginData();
            setButtom();

        }

        //返回
        private void back_Click(object sender, EventArgs e)
        {
            this.Owner.Show();
            this.Close();
        }

        //下一步
        private void next_Click(object sender, EventArgs e)
        {
            new MainView().Show();
            this.Close();
        }

        //恢复为原始数据，设定按钮
        private void revert_Click(object sender, EventArgs e)
        {

            setOriginData();
            isChanged = false;
            setButtom();

        }

        //revert和load：设为原始数据
        private void setOriginData()
        {
            chartNo.Text = patient.CharNo;
            //name.Text = patient.Name;
            patientId.Text = patient.PId;
            weight.Text = patient.Weight.ToString();
            height.Text = patient.Height.ToString();
            //blood.Text = patient.BloodType;
            history.Text = patient.Comment;
            //date.Value = patient.BirthDate;
            date2.Text = patient.BirthDate.ToString();
            blood2.Text = patient.BloodType.ToString();
            name2.Text = patient.Name.ToString();
        }

        //保存,设定按钮
        private void save_Click(object sender, EventArgs e)
        {

            PatientBasicRepository pbr = new PatientBasicRepository();
            //读取目前的信息
            newData = new PatientBasic
            {
                CharNo = patient.CharNo,
                PId = patient.PId,
                Weight = float.Parse(weight.Text),
                Height = float.Parse(height.Text),
                BirthDate = patient.BirthDate,
                BloodType = bloodl.Text,
                Name = namel.Text,
                Comment = history.ToString()
            };
            //保存
            pbr.saveOnePatient(newData);

            //替换目前的内容为更新后的 重新加载
            isChanged = false;
            patient.Weight = newData.Weight;
            patient.Height = newData.Height;
            patient.BirthDate = newData.BirthDate;
            patient.BloodType = newData.BloodType;
            patient.Name = newData.Name;
            LoadData();

        }

        //重新设定按钮（数据没有改变），load、恢复或保存后，下一步启用，恢复和保存禁用
        //重新设定按钮（数据有改变），在修改数据之后，恢复和保存可以按，下一步被禁用
        private void setButtom()
        {

            if (!isChanged)
            {
                revert.Enabled = false;
                save.Enabled = false;
                next.Enabled = true;
            }
            else
            {
                revert.Enabled = true;
                save.Enabled = true;
                next.Enabled = false;
            }

        }

        /*判断是否有修改病人的数据，如果有就重新设定按钮
        
        /*
        private void name_TextChanged(object sender, EventArgs e)
        {

            if (name.Text != patient.Name) isChanged = true;

            setButtom();

        }
        */

        /*
        private void blood_TextChanged(object sender, EventArgs e)
        {

            if (blood.Text != patient.BloodType) isChanged = true;

            setButtom();

        }
        */

        private void height_TextChanged(object sender, EventArgs e)
        {

            if (height.Text != patient.Height.ToString()) isChanged = true;

            setButtom();

        }

        private void weight_TextChanged(object sender, EventArgs e)
        {

            if (weight.Text != patient.Weight.ToString()) isChanged = true;

            setButtom();

        }

        private void history_TextChanged(object sender, EventArgs e)
        {

            if (history.Text != patient.Comment) isChanged = true;

            setButtom();

        }

        /*
        private void date_ValueChanged(object sender, EventArgs e)
        {

            if (date.Value != patient.BirthDate) isChanged = true;

            setButtom();

        }
        */

        //身高体重只能输入小数（数字和小数点）以及删除，其他按键无效
        private void height_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

        private void weight_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }
    }
}
