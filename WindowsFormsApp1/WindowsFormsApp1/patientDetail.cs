using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Model;
using WindowsFormsApp1.Repository;

namespace WindowsFormsApp1
{
    public partial class PatientDetail : Form
    {

        private PatientBasic newData;
        private Boolean isChanged = false;

        public PatientDetail()
        {
            InitializeComponent();
            LoadData();
        }

        //初始化数据
        private void LoadData()
        {
            GetPatientData();
            setOriginData();
            setButtom();
        }

        private void GetPatientData()
        {
            PatientBasicRepository pbr = new PatientBasicRepository();
            StaticPatient.patient = pbr.selectOnePatient(StaticPatient.patient.CharNo);
        }

        //返回
        private void back_Click(object sender, EventArgs e)
        {
            new PatientData(true).Show();
            this.Close();
        }

        //下一步
        private void next_Click(object sender, EventArgs e)
        {
            AnesthesiaDataRepository apr = new AnesthesiaDataRepository();
            StaticPatient.operateList = apr.SelectByChartNo(StaticPatient.patient.CharNo);
            if (StaticPatient.operateList.Count == 0)
            {
                DialogResult dr = MessageBox.Show("這個病人沒有即將進行的手術！",
                    "注意", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                new ChooseOperator().Show();
                this.Close();
            }
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
            chartNo.Text = StaticPatient.patient.CharNo;
            patientId.Text = StaticPatient.patient.PId;
            weight.Text = StaticPatient.patient.Weight.ToString();
            height.Text = StaticPatient.patient.Height.ToString();
            newComment.Text = StaticPatient.newComment;
            date2.Text = StaticPatient.patient.BirthDate.ToString("yyyy-MM-dd");
            blood2.Text = StaticPatient.patient.BloodType.ToString();
            name2.Text = StaticPatient.patient.Name.ToString();
        }

        //保存,设定按钮
        private void save_Click(object sender, EventArgs e)
        {
            PatientBasicRepository pbr = new PatientBasicRepository();
            //读取目前的信息
            newData = new PatientBasic
            {
                CharNo = StaticPatient.patient.CharNo,
                PId = StaticPatient.patient.PId,
                Weight = float.Parse(weight.Text),
                Height = float.Parse(height.Text),
                BirthDate = StaticPatient.patient.BirthDate,
                BloodType = StaticPatient.patient.BloodType,
                Name = StaticPatient.patient.Name,
                Comment = StaticPatient.patient.Comment
            };
            //保存
            pbr.saveOnePatient(newData);
            StaticPatient.newComment = newComment.Text.ToString();

            //替换目前的内容为更新后的 重新加载
            isChanged = false;
            StaticPatient.patient.Weight = newData.Weight;
            StaticPatient.patient.Height = newData.Height;
            //StaticPatient.patient.BirthDate = newData.BirthDate;
            //StaticPatient.patient.BloodType = newData.BloodType;
            //StaticPatient.patient.Name = newData.Name;
            //StaticPatient.patient.Comment = newData.Comment;
            LoadData();

        }

        /***
         * 重新设定按钮（数据没有改变），load、恢复或保存后，下一步启用，恢复和保存禁用
         *重新设定按钮（数据有改变），在修改数据之后，恢复和保存可以按，下一步被禁用
        ***/
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

            if (name.Text != StaticPatient.patient.Name) isChanged = true;

            setButtom();

        }
        */

        /*
        private void blood_TextChanged(object sender, EventArgs e)
        {

            if (blood.Text != StaticPatient.patient.BloodType) isChanged = true;

            setButtom();

        }
        */

        private void height_TextChanged(object sender, EventArgs e)
        {
            if (height.Text != StaticPatient.patient.Height.ToString()) isChanged = true;

            setButtom();
        }

        private void weight_TextChanged(object sender, EventArgs e)
        {
            if (weight.Text != StaticPatient.patient.Weight.ToString()) isChanged = true;

            setButtom();
        }

        private void history_TextChanged(object sender, EventArgs e)
        {
            if (newComment.Text != StaticPatient.newComment) isChanged = true;

            setButtom();
        }

        /*
        private void date_ValueChanged(object sender, EventArgs e)
        {

            if (date.Value != StaticPatient.patient.BirthDate) isChanged = true;

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

        //改变按钮
        public void ChangeButton()
        {
            next.Hide();
            back.Hide();
        }

        private void HistoryComment_Click(object sender, EventArgs e)
        {
            PatientHistory ph = new PatientHistory();
            ph.Show();
            ph.LoadData(StaticPatient.patient.Name, StaticPatient.patient.Comment);
        }
    }
}
