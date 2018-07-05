﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;

namespace DesktopSheduler
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        /// 
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.editTaskBtn = new System.Windows.Forms.Button();
            this.deleteTaskBtn = new System.Windows.Forms.Button();
            this.createTaskBtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.toDoPanel = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.currentWeekDay = new System.Windows.Forms.Label();
            this.currentMnthYear = new System.Windows.Forms.Label();
            this.currentDay = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.datesTable = new System.Windows.Forms.TableLayoutPanel();
            this.eventTaskBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.eventItemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.checboxCol = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.DescColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TimeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.toDoPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eventTaskBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventItemBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.toDoPanel);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 638);
            this.panel1.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(85)))));
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.editTaskBtn);
            this.panel4.Controls.Add(this.deleteTaskBtn);
            this.panel4.Controls.Add(this.createTaskBtn);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Location = new System.Drawing.Point(3, 395);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(194, 215);
            this.panel4.TabIndex = 5;
            // 
            // editTaskBtn
            // 
            this.editTaskBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(78)))), ((int)(((byte)(115)))));
            this.editTaskBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.editTaskBtn.FlatAppearance.BorderSize = 0;
            this.editTaskBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editTaskBtn.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editTaskBtn.ForeColor = System.Drawing.Color.White;
            this.editTaskBtn.Location = new System.Drawing.Point(18, 138);
            this.editTaskBtn.Name = "editTaskBtn";
            this.editTaskBtn.Size = new System.Drawing.Size(156, 30);
            this.editTaskBtn.TabIndex = 6;
            this.editTaskBtn.Text = "Edit ";
            this.editTaskBtn.UseVisualStyleBackColor = false;
            this.editTaskBtn.Click += new System.EventHandler(this.EditTask);
            // 
            // deleteTaskBtn
            // 
            this.deleteTaskBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.deleteTaskBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.deleteTaskBtn.FlatAppearance.BorderSize = 0;
            this.deleteTaskBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteTaskBtn.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteTaskBtn.ForeColor = System.Drawing.Color.White;
            this.deleteTaskBtn.Location = new System.Drawing.Point(18, 92);
            this.deleteTaskBtn.Name = "deleteTaskBtn";
            this.deleteTaskBtn.Size = new System.Drawing.Size(160, 30);
            this.deleteTaskBtn.TabIndex = 5;
            this.deleteTaskBtn.Text = "Delete this task";
            this.deleteTaskBtn.UseVisualStyleBackColor = false;
            this.deleteTaskBtn.Click += new System.EventHandler(this.DeleteTask);
            // 
            // createTaskBtn
            // 
            this.createTaskBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(131)))), ((int)(((byte)(68)))));
            this.createTaskBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.createTaskBtn.FlatAppearance.BorderSize = 0;
            this.createTaskBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createTaskBtn.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createTaskBtn.ForeColor = System.Drawing.Color.White;
            this.createTaskBtn.Location = new System.Drawing.Point(18, 44);
            this.createTaskBtn.Name = "createTaskBtn";
            this.createTaskBtn.Size = new System.Drawing.Size(160, 30);
            this.createTaskBtn.TabIndex = 4;
            this.createTaskBtn.Text = "Create new";
            this.createTaskBtn.UseVisualStyleBackColor = false;
            this.createTaskBtn.Click += new System.EventHandler(this.CreateNewTask);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(20, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "Actions";
            // 
            // toDoPanel
            // 
            this.toDoPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(85)))));
            this.toDoPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.toDoPanel.Controls.Add(this.dataGridView1);
            this.toDoPanel.Controls.Add(this.label3);
            this.toDoPanel.Location = new System.Drawing.Point(3, 174);
            this.toDoPanel.Name = "toDoPanel";
            this.toDoPanel.Size = new System.Drawing.Size(194, 215);
            this.toDoPanel.TabIndex = 0;
            this.toDoPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.toDoPanel_Paint);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.ColumnHeadersHeight = 25;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.checboxCol,
            this.DescColumn,
            this.TimeColumn});
            this.dataGridView1.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 34);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(192, 179);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(20, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 18);
            this.label3.TabIndex = 3;
            this.label3.Text = "To Do";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.currentWeekDay);
            this.panel3.Controls.Add(this.currentMnthYear);
            this.panel3.Controls.Add(this.currentDay);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 168);
            this.panel3.TabIndex = 0;
            // 
            // currentWeekDay
            // 
            this.currentWeekDay.AutoSize = true;
            this.currentWeekDay.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.currentWeekDay.ForeColor = System.Drawing.Color.White;
            this.currentWeekDay.Location = new System.Drawing.Point(41, 126);
            this.currentWeekDay.Name = "currentWeekDay";
            this.currentWeekDay.Size = new System.Drawing.Size(126, 18);
            this.currentWeekDay.TabIndex = 2;
            this.currentWeekDay.Text = "понедельник";
            // 
            // currentMnthYear
            // 
            this.currentMnthYear.AutoSize = true;
            this.currentMnthYear.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.currentMnthYear.ForeColor = System.Drawing.Color.White;
            this.currentMnthYear.Location = new System.Drawing.Point(39, 108);
            this.currentMnthYear.Name = "currentMnthYear";
            this.currentMnthYear.Size = new System.Drawing.Size(19, 18);
            this.currentMnthYear.TabIndex = 1;
            this.currentMnthYear.Text = "6";
            // 
            // currentDay
            // 
            this.currentDay.AutoSize = true;
            this.currentDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.currentDay.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.currentDay.Location = new System.Drawing.Point(25, 0);
            this.currentDay.Name = "currentDay";
            this.currentDay.Size = new System.Drawing.Size(151, 108);
            this.currentDay.TabIndex = 0;
            this.currentDay.Text = "25";
            // 
            // panel2
            // 
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.datesTable);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(206, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(703, 638);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(580, 92);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(40, 16);
            this.label11.TabIndex = 3;
            this.label11.Text = "Sun.";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(497, 92);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(37, 16);
            this.label10.TabIndex = 3;
            this.label10.Text = "Sat.";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(414, 92);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(32, 16);
            this.label9.TabIndex = 3;
            this.label9.Text = "Fri.";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(328, 92);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 16);
            this.label8.TabIndex = 3;
            this.label8.Text = "Thu.";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(239, 92);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 16);
            this.label7.TabIndex = 3;
            this.label7.Text = "Wed.";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(158, 92);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 16);
            this.label6.TabIndex = 3;
            this.label6.Text = "Tue.";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(75, 92);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 16);
            this.label5.TabIndex = 3;
            this.label5.Text = "Mon.";
            // 
            // datesTable
            // 
            this.datesTable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(85)))));
            this.datesTable.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.datesTable.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Inset;
            this.datesTable.ColumnCount = 7;
            this.datesTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.datesTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.datesTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.datesTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.datesTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.datesTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.datesTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.datesTable.Location = new System.Drawing.Point(46, 113);
            this.datesTable.Name = "datesTable";
            this.datesTable.RowCount = 5;
            this.datesTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.datesTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.datesTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.datesTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.datesTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.datesTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.datesTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.datesTable.Size = new System.Drawing.Size(601, 502);
            this.datesTable.TabIndex = 5;
            this.datesTable.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel2_Paint);
            // 
            // eventTaskBindingSource
            // 
            this.eventTaskBindingSource.DataSource = typeof(DesktopSheduler.EventTask);
            // 
            // eventItemBindingSource
            // 
            this.eventItemBindingSource.DataSource = typeof(DesktopSheduler.EventItem);
            // 
            // checboxCol
            // 
            this.checboxCol.Frozen = true;
            this.checboxCol.HeaderText = "Done";
            this.checboxCol.Name = "checboxCol";
            this.checboxCol.ReadOnly = true;
            this.checboxCol.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.checboxCol.Width = 35;
            // 
            // DescColumn
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.DescColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.DescColumn.HeaderText = "DescColumn";
            this.DescColumn.Name = "DescColumn";
            this.DescColumn.ReadOnly = true;
            this.DescColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.DescColumn.Width = 120;
            // 
            // TimeColumn
            // 
            this.TimeColumn.HeaderText = "Time";
            this.TimeColumn.Name = "TimeColumn";
            this.TimeColumn.ReadOnly = true;
            this.TimeColumn.Width = 35;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(909, 638);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Opacity = 0.95D;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.toDoPanel.ResumeLayout(false);
            this.toDoPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eventTaskBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventItemBindingSource)).EndInit();
            this.ResumeLayout(false);

        }
        #endregion

        private void CustomizeButton(Button button, DateTime date, int taskCount, bool isActive)
        {
            if (isActive)
            {
                button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(176)))), ((int)(((byte)(210)))));
                button.Text = date.ToString("dd.MM.yyyy") + "\r\n\r\n" + taskCount + " Tasks\r\n";
                button.Enabled = true;
            }
            else
            {
                button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(92)))), ((int)(((byte)(117)))));
                button.Enabled = false;
                button.Text = date.ToString("dd.MM.yyyy");
            }

         }

        private Button createButton(DateTime date, int taskCount,bool isActive) {
            Button button = new Button();
            CustomizeButton(button, date, taskCount, isActive);

            if (isActive)
            {
                button.Click += (s, e) =>
                {
                    button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(96)))), ((int)(((byte)(55)))));
                    if (this.prevButton != null && this.prevButton != s as Button)
                        this.prevButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(176)))), ((int)(((byte)(210)))));

                    this.prevButton = button;
                    SetCurrentDate(datesButtonList[button].date);
                    ShowToDoList(datesButtonList[button]);
                };                 
            }

            button.Anchor = ((System.Windows.Forms.AnchorStyles)((((
                       System.Windows.Forms.AnchorStyles.Top
                     | System.Windows.Forms.AnchorStyles.Bottom)
                     | System.Windows.Forms.AnchorStyles.Left)
                     | System.Windows.Forms.AnchorStyles.Right)
                     )
             );

            button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            button.FlatAppearance.BorderSize = 0;
            button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            button.ForeColor = System.Drawing.Color.White;
            button.Location = new System.Drawing.Point(0, 0);
            button.Name = date.ToString() + "_btn";
            button.AutoSize = false;

            button.UseVisualStyleBackColor = false;
            return button;
        }

        private void ShowToDoList(EventItem eventItem) {
            foreach(EventTask task in eventItem.taskList)
                this.dataGridView1.Rows.Add(task.alarmTime,task.taskDescription,task.isAlarmOn,task.isDone);
        }

        private Dictionary<Button, EventItem> SetCalendarDates(DateTime currentMonth) {
           
            Calendar     calendar   = CultureInfo.InvariantCulture.Calendar;
            JSONLoader   jSONLoader = new JSONLoader();

            List<EventItem> eventList = jSONLoader.Read();
            Dictionary<Button, EventItem> eventButtonMap = new Dictionary<Button, EventItem>();
       
            DateTime date = new DateTime(currentMonth.Year,currentMonth.Month,1);        
            int dayOfWeek = ((int)date.DayOfWeek + 6) % 7;
  

            Button btn = null;
              for (int j = 0; j < 5;)
                {
                EventItem eventItem = eventList.Find(x => CheckTwoDates(x.date,date));

                if (eventItem != null)
                {
                    btn = createButton(date, eventItem.taskList.Count, true);
                }
                else
                {
                    btn = createButton(date, 0, false);
                    eventItem = new EventItem(date,new List<EventTask>());
                }
                eventButtonMap.Add(btn, eventItem);
                 datesTable.Controls.Add(btn, dayOfWeek++,j);
              
                    if (dayOfWeek >= 8)
                    {
                        dayOfWeek = 0;
                        j++;
                    }
                    date = date.AddDays(1);

                    if (date.Month != currentMonth.Month)
                        break;                 
                }
            return eventButtonMap;
         }

        private void RefreshTable () {
            datesTable.Controls.Clear();
            this.datesButtonList = SetCalendarDates(DateTime.Now);
        }

        private bool CheckTwoDates(DateTime dateTime1,DateTime dateTime2) {
            return (dateTime1.Month == dateTime2.Month && dateTime1.Day == dateTime2.Day && dateTime1.Year == dateTime2.Year);
        }

        private void UpdateDay(EventTask newTask) {
            EventItem evntItem = null; 
          
            foreach (Button btn in datesButtonList.Keys)
            {
                evntItem = datesButtonList[btn];
             
                if (CheckTwoDates(evntItem.date, newTask.alarmTime))
                {
                    evntItem.taskList.Add(newTask);
                    CustomizeButton(btn, evntItem.date, evntItem.taskList.Count, true);
                    break;
                }                              
            }
            JSONLoader jSONLoader = new JSONLoader();
            jSONLoader.Write(evntItem);
          
        }


        private void SetCurrentDate(DateTime dateTime) {
            this.currentDay.Text      = dateTime.Day.ToString();
            this.currentMnthYear.Text = dateTime.ToString("MMMM") + " " + dateTime.Year;
            this.currentWeekDay.Text  = dateTime.ToString("dddd");
        }


        private Dictionary<Button,EventItem> datesButtonList;
        private Button prevButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label currentDay;
        private System.Windows.Forms.Label currentMnthYear;
        private System.Windows.Forms.Panel toDoPanel;
        private System.Windows.Forms.Label currentWeekDay;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button createTaskBtn;
        private System.Windows.Forms.Button editTaskBtn;
        private System.Windows.Forms.Button deleteTaskBtn;
        private System.Windows.Forms.TableLayoutPanel datesTable;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private DataGridView dataGridView1;
        private BindingSource eventTaskBindingSource;
        private BindingSource eventItemBindingSource;
        private DataGridViewCheckBoxColumn checboxCol;
        private DataGridViewTextBoxColumn DescColumn;
        private DataGridViewTextBoxColumn TimeColumn;
    }
}

