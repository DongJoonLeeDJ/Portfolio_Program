﻿
namespace API_Practice
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.durBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.durNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.durIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.durCompDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.durBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.durNameDataGridViewTextBoxColumn,
            this.durIdDataGridViewTextBoxColumn,
            this.durCompDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.durBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(792, 391);
            this.dataGridView1.TabIndex = 0;
            // 
            // durBindingSource1
            // 
            this.durBindingSource1.DataSource = typeof(API_Practice.Dur);
            // 
            // durNameDataGridViewTextBoxColumn
            // 
            this.durNameDataGridViewTextBoxColumn.DataPropertyName = "DurName";
            this.durNameDataGridViewTextBoxColumn.HeaderText = "약품 이름";
            this.durNameDataGridViewTextBoxColumn.Name = "durNameDataGridViewTextBoxColumn";
            this.durNameDataGridViewTextBoxColumn.Width = 300;
            // 
            // durIdDataGridViewTextBoxColumn
            // 
            this.durIdDataGridViewTextBoxColumn.DataPropertyName = "DurId";
            this.durIdDataGridViewTextBoxColumn.HeaderText = "약품 번호";
            this.durIdDataGridViewTextBoxColumn.Name = "durIdDataGridViewTextBoxColumn";
            // 
            // durCompDataGridViewTextBoxColumn
            // 
            this.durCompDataGridViewTextBoxColumn.DataPropertyName = "DurComp";
            this.durCompDataGridViewTextBoxColumn.HeaderText = "제조사";
            this.durCompDataGridViewTextBoxColumn.Name = "durCompDataGridViewTextBoxColumn";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 415);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.durBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource durBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn durNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn durIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn durCompDataGridViewTextBoxColumn;
    }
}

