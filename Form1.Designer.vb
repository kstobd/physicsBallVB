<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BallPhysicsKst
    Inherits System.Windows.Forms.Form

    'Форма переопределяет dispose для очистки списка компонентов.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Является обязательной для конструктора форм Windows Forms
    Private components As System.ComponentModel.IContainer

    'Примечание: следующая процедура является обязательной для конструктора форм Windows Forms
    'Для ее изменения используйте конструктор форм Windows Form.  
    'Не изменяйте ее в редакторе исходного кода.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.InputGB = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.protR = New System.Windows.Forms.RadioButton()
        Me.poR = New System.Windows.Forms.RadioButton()
        Me.windNum = New System.Windows.Forms.NumericUpDown()
        Me.windLab = New System.Windows.Forms.Label()
        Me.hNum = New System.Windows.Forms.NumericUpDown()
        Me.hLab = New System.Windows.Forms.Label()
        Me.sLab = New System.Windows.Forms.Label()
        Me.sNum = New System.Windows.Forms.NumericUpDown()
        Me.aLab = New System.Windows.Forms.Label()
        Me.aNum = New System.Windows.Forms.NumericUpDown()
        Me.v0Lab = New System.Windows.Forms.Label()
        Me.v0Num = New System.Windows.Forms.NumericUpDown()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.LLB = New System.Windows.Forms.Label()
        Me.LTB = New System.Windows.Forms.TextBox()
        Me.resTB = New System.Windows.Forms.TextBox()
        Me.resLab = New System.Windows.Forms.Label()
        Me.InputGB.SuspendLayout()
        CType(Me.windNum, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.hNum, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sNum, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.aNum, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.v0Num, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'InputGB
        '
        Me.InputGB.Controls.Add(Me.Label1)
        Me.InputGB.Controls.Add(Me.protR)
        Me.InputGB.Controls.Add(Me.poR)
        Me.InputGB.Controls.Add(Me.windNum)
        Me.InputGB.Controls.Add(Me.windLab)
        Me.InputGB.Controls.Add(Me.hNum)
        Me.InputGB.Controls.Add(Me.hLab)
        Me.InputGB.Controls.Add(Me.sLab)
        Me.InputGB.Controls.Add(Me.sNum)
        Me.InputGB.Controls.Add(Me.aLab)
        Me.InputGB.Controls.Add(Me.aNum)
        Me.InputGB.Controls.Add(Me.v0Lab)
        Me.InputGB.Controls.Add(Me.v0Num)
        Me.InputGB.Location = New System.Drawing.Point(17, 2)
        Me.InputGB.Name = "InputGB"
        Me.InputGB.Size = New System.Drawing.Size(285, 181)
        Me.InputGB.TabIndex = 0
        Me.InputGB.TabStop = False
        Me.InputGB.Text = "Вводные данные"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(74, 146)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(107, 13)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Направление ветра"
        '
        'protR
        '
        Me.protR.AutoSize = True
        Me.protR.Location = New System.Drawing.Point(143, 158)
        Me.protR.Name = "protR"
        Me.protR.Size = New System.Drawing.Size(136, 17)
        Me.protR.TabIndex = 13
        Me.protR.Text = "по направлению мяча"
        Me.protR.UseVisualStyleBackColor = True
        '
        'poR
        '
        Me.poR.AutoSize = True
        Me.poR.Checked = True
        Me.poR.Location = New System.Drawing.Point(9, 158)
        Me.poR.Name = "poR"
        Me.poR.Size = New System.Drawing.Size(59, 17)
        Me.poR.TabIndex = 12
        Me.poR.TabStop = True
        Me.poR.Text = "на мяч"
        Me.poR.UseVisualStyleBackColor = True
        '
        'windNum
        '
        Me.windNum.Location = New System.Drawing.Point(152, 123)
        Me.windNum.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.windNum.Name = "windNum"
        Me.windNum.Size = New System.Drawing.Size(120, 20)
        Me.windNum.TabIndex = 11
        Me.windNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'windLab
        '
        Me.windLab.AutoSize = True
        Me.windLab.Location = New System.Drawing.Point(6, 125)
        Me.windLab.Name = "windLab"
        Me.windLab.Size = New System.Drawing.Size(92, 13)
        Me.windLab.TabIndex = 10
        Me.windLab.Text = "Сила ветра (м/с)"
        '
        'hNum
        '
        Me.hNum.Location = New System.Drawing.Point(152, 97)
        Me.hNum.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.hNum.Name = "hNum"
        Me.hNum.Size = New System.Drawing.Size(120, 20)
        Me.hNum.TabIndex = 9
        Me.hNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'hLab
        '
        Me.hLab.AutoSize = True
        Me.hLab.Location = New System.Drawing.Point(6, 99)
        Me.hLab.Name = "hLab"
        Me.hLab.Size = New System.Drawing.Size(100, 13)
        Me.hLab.TabIndex = 7
        Me.hLab.Text = "Высота стенки (м)"
        '
        'sLab
        '
        Me.sLab.AutoSize = True
        Me.sLab.Location = New System.Drawing.Point(6, 73)
        Me.sLab.Name = "sLab"
        Me.sLab.Size = New System.Drawing.Size(137, 13)
        Me.sLab.TabIndex = 5
        Me.sLab.Text = "Расстояние до стенки (м)"
        '
        'sNum
        '
        Me.sNum.Location = New System.Drawing.Point(152, 71)
        Me.sNum.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.sNum.Name = "sNum"
        Me.sNum.Size = New System.Drawing.Size(120, 20)
        Me.sNum.TabIndex = 8
        Me.sNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'aLab
        '
        Me.aLab.AutoSize = True
        Me.aLab.Location = New System.Drawing.Point(6, 47)
        Me.aLab.Name = "aLab"
        Me.aLab.Size = New System.Drawing.Size(143, 13)
        Me.aLab.TabIndex = 3
        Me.aLab.Text = "Угол бросания мяча (град)"
        '
        'aNum
        '
        Me.aNum.Location = New System.Drawing.Point(152, 45)
        Me.aNum.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.aNum.Name = "aNum"
        Me.aNum.Size = New System.Drawing.Size(120, 20)
        Me.aNum.TabIndex = 7
        Me.aNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'v0Lab
        '
        Me.v0Lab.AutoSize = True
        Me.v0Lab.Location = New System.Drawing.Point(6, 21)
        Me.v0Lab.Name = "v0Lab"
        Me.v0Lab.Size = New System.Drawing.Size(140, 13)
        Me.v0Lab.TabIndex = 1
        Me.v0Lab.Text = "Начальная скорость (м/с)"
        '
        'v0Num
        '
        Me.v0Num.Location = New System.Drawing.Point(152, 19)
        Me.v0Num.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.v0Num.Name = "v0Num"
        Me.v0Num.Size = New System.Drawing.Size(120, 20)
        Me.v0Num.TabIndex = 6
        Me.v0Num.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(337, 24)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(400, 220)
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'LLB
        '
        Me.LLB.AutoSize = True
        Me.LLB.Location = New System.Drawing.Point(14, 186)
        Me.LLB.Name = "LLB"
        Me.LLB.Size = New System.Drawing.Size(178, 13)
        Me.LLB.TabIndex = 2
        Me.LLB.Text = "Пройденное расстояение (м)  L = "
        '
        'LTB
        '
        Me.LTB.Location = New System.Drawing.Point(189, 183)
        Me.LTB.Name = "LTB"
        Me.LTB.ReadOnly = True
        Me.LTB.Size = New System.Drawing.Size(100, 20)
        Me.LTB.TabIndex = 3
        '
        'resTB
        '
        Me.resTB.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.resTB.Location = New System.Drawing.Point(151, 212)
        Me.resTB.Name = "resTB"
        Me.resTB.ReadOnly = True
        Me.resTB.Size = New System.Drawing.Size(138, 35)
        Me.resTB.TabIndex = 5
        '
        'resLab
        '
        Me.resLab.AutoSize = True
        Me.resLab.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.resLab.Location = New System.Drawing.Point(14, 215)
        Me.resLab.Name = "resLab"
        Me.resLab.Size = New System.Drawing.Size(138, 29)
        Me.resLab.TabIndex = 4
        Me.resLab.Text = "Результат:"
        '
        'BallPhysicsKst
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(783, 270)
        Me.Controls.Add(Me.resTB)
        Me.Controls.Add(Me.resLab)
        Me.Controls.Add(Me.LTB)
        Me.Controls.Add(Me.LLB)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.InputGB)
        Me.Name = "BallPhysicsKst"
        Me.Text = "Моделирование полета меча"
        Me.InputGB.ResumeLayout(False)
        Me.InputGB.PerformLayout()
        CType(Me.windNum, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.hNum, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sNum, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.aNum, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.v0Num, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents InputGB As GroupBox
    Friend WithEvents hLab As Label
    Friend WithEvents sLab As Label
    Friend WithEvents aLab As Label
    Friend WithEvents v0Lab As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents LLB As Label
    Friend WithEvents LTB As TextBox
    Friend WithEvents resTB As TextBox
    Friend WithEvents resLab As Label
    Friend WithEvents v0Num As NumericUpDown
    Friend WithEvents hNum As NumericUpDown
    Friend WithEvents sNum As NumericUpDown
    Friend WithEvents aNum As NumericUpDown
    Friend WithEvents protR As RadioButton
    Friend WithEvents poR As RadioButton
    Friend WithEvents windNum As NumericUpDown
    Friend WithEvents windLab As Label
    Friend WithEvents Label1 As Label
End Class
