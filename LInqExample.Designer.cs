namespace WindowsFormsLINQ
{
    partial class LInqExample
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvStudents = new System.Windows.Forms.DataGridView();
            this.dgvConditon = new System.Windows.Forms.DataGridView();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtKor = new System.Windows.Forms.TextBox();
            this.txtMath = new System.Windows.Forms.TextBox();
            this.txtEng = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtCID = new System.Windows.Forms.TextBox();
            this.txtCName = new System.Windows.Forms.TextBox();
            this.txtCKor = new System.Windows.Forms.TextBox();
            this.txtCMath = new System.Windows.Forms.TextBox();
            this.txtCEng = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnLinq = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudents)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConditon)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvStudents
            // 
            this.dgvStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudents.Location = new System.Drawing.Point(157, 20);
            this.dgvStudents.Name = "dgvStudents";
            this.dgvStudents.RowTemplate.Height = 23;
            this.dgvStudents.Size = new System.Drawing.Size(240, 218);
            this.dgvStudents.TabIndex = 0;
            // 
            // dgvConditon
            // 
            this.dgvConditon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConditon.Location = new System.Drawing.Point(548, 20);
            this.dgvConditon.Name = "dgvConditon";
            this.dgvConditon.RowTemplate.Height = 23;
            this.dgvConditon.Size = new System.Drawing.Size(240, 218);
            this.dgvConditon.TabIndex = 1;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(51, 16);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(100, 21);
            this.txtID.TabIndex = 2;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(51, 65);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 21);
            this.txtName.TabIndex = 3;
            // 
            // txtKor
            // 
            this.txtKor.Location = new System.Drawing.Point(51, 110);
            this.txtKor.Name = "txtKor";
            this.txtKor.Size = new System.Drawing.Size(100, 21);
            this.txtKor.TabIndex = 4;
            // 
            // txtMath
            // 
            this.txtMath.Location = new System.Drawing.Point(51, 160);
            this.txtMath.Name = "txtMath";
            this.txtMath.Size = new System.Drawing.Size(100, 21);
            this.txtMath.TabIndex = 5;
            // 
            // txtEng
            // 
            this.txtEng.Location = new System.Drawing.Point(51, 213);
            this.txtEng.Name = "txtEng";
            this.txtEng.Size = new System.Drawing.Size(100, 21);
            this.txtEng.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 12);
            this.label1.TabIndex = 7;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 8;
            this.label2.Text = "이름";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 9;
            this.label3.Text = "국어";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 10;
            this.label4.Text = "수학";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 216);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 12);
            this.label5.TabIndex = 11;
            this.label5.Text = "영어";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(51, 261);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(100, 23);
            this.btnAdd.TabIndex = 12;
            this.btnAdd.Text = "학생추가";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtCID
            // 
            this.txtCID.Location = new System.Drawing.Point(442, 21);
            this.txtCID.Name = "txtCID";
            this.txtCID.Size = new System.Drawing.Size(100, 21);
            this.txtCID.TabIndex = 13;
            // 
            // txtCName
            // 
            this.txtCName.Location = new System.Drawing.Point(442, 69);
            this.txtCName.Name = "txtCName";
            this.txtCName.Size = new System.Drawing.Size(100, 21);
            this.txtCName.TabIndex = 14;
            // 
            // txtCKor
            // 
            this.txtCKor.Location = new System.Drawing.Point(442, 114);
            this.txtCKor.Name = "txtCKor";
            this.txtCKor.Size = new System.Drawing.Size(100, 21);
            this.txtCKor.TabIndex = 15;
            // 
            // txtCMath
            // 
            this.txtCMath.Location = new System.Drawing.Point(442, 164);
            this.txtCMath.Name = "txtCMath";
            this.txtCMath.Size = new System.Drawing.Size(100, 21);
            this.txtCMath.TabIndex = 16;
            // 
            // txtCEng
            // 
            this.txtCEng.Location = new System.Drawing.Point(442, 208);
            this.txtCEng.Name = "txtCEng";
            this.txtCEng.Size = new System.Drawing.Size(100, 21);
            this.txtCEng.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(403, 221);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 12);
            this.label6.TabIndex = 22;
            this.label6.Text = "영어";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(403, 168);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 12);
            this.label7.TabIndex = 21;
            this.label7.Text = "수학";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(403, 118);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 12);
            this.label8.TabIndex = 20;
            this.label8.Text = "국어";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(403, 73);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(29, 12);
            this.label9.TabIndex = 19;
            this.label9.Text = "이름";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(403, 24);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(16, 12);
            this.label10.TabIndex = 18;
            this.label10.Text = "ID";
            // 
            // btnLinq
            // 
            this.btnLinq.Location = new System.Drawing.Point(442, 262);
            this.btnLinq.Name = "btnLinq";
            this.btnLinq.Size = new System.Drawing.Size(100, 23);
            this.btnLinq.TabIndex = 23;
            this.btnLinq.Text = "LINQ 실행";
            this.btnLinq.UseVisualStyleBackColor = true;
            this.btnLinq.Click += new System.EventHandler(this.btnLinq_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(713, 262);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 24;
            this.btnClear.Text = "내용지우기";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // LInqExample
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 314);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnLinq);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtCEng);
            this.Controls.Add(this.txtCMath);
            this.Controls.Add(this.txtCKor);
            this.Controls.Add(this.txtCName);
            this.Controls.Add(this.txtCID);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtEng);
            this.Controls.Add(this.txtMath);
            this.Controls.Add(this.txtKor);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.dgvConditon);
            this.Controls.Add(this.dgvStudents);
            this.Name = "LInqExample";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudents)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConditon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvStudents;
        private System.Windows.Forms.DataGridView dgvConditon;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtKor;
        private System.Windows.Forms.TextBox txtMath;
        private System.Windows.Forms.TextBox txtEng;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtCID;
        private System.Windows.Forms.TextBox txtCName;
        private System.Windows.Forms.TextBox txtCKor;
        private System.Windows.Forms.TextBox txtCMath;
        private System.Windows.Forms.TextBox txtCEng;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnLinq;
        private System.Windows.Forms.Button btnClear;
    }
}

