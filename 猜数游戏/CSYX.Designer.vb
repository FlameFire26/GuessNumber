<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CSYX
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
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

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意: 以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。  
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CSYX))
        Me.LT1 = New System.Windows.Forms.Label()
        Me.TNum = New System.Windows.Forms.TextBox()
        Me.BtnCheck = New System.Windows.Forms.Button()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.LMax = New System.Windows.Forms.Label()
        Me.LTo = New System.Windows.Forms.Label()
        Me.LMin = New System.Windows.Forms.Label()
        Me.Timer = New System.Windows.Forms.Timer(Me.components)
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel4 = New System.Windows.Forms.TableLayoutPanel()
        Me.LT2 = New System.Windows.Forms.Label()
        Me.LScore = New System.Windows.Forms.Label()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.TableLayoutPanel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'LT1
        '
        Me.LT1.AutoSize = True
        Me.LT1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LT1.Font = New System.Drawing.Font("微软雅黑", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.LT1.Location = New System.Drawing.Point(3, 0)
        Me.LT1.Name = "LT1"
        Me.LT1.Size = New System.Drawing.Size(290, 64)
        Me.LT1.TabIndex = 0
        Me.LT1.Text = "猜猜我想的数字"
        Me.LT1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TNum
        '
        Me.TNum.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TNum.Font = New System.Drawing.Font("微软雅黑", 18.0!, System.Drawing.FontStyle.Bold)
        Me.TNum.Location = New System.Drawing.Point(4, 132)
        Me.TNum.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TNum.Name = "TNum"
        Me.TNum.Size = New System.Drawing.Size(288, 55)
        Me.TNum.TabIndex = 2
        Me.TNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'BtnCheck
        '
        Me.BtnCheck.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BtnCheck.Enabled = False
        Me.BtnCheck.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.BtnCheck.Font = New System.Drawing.Font("微软雅黑", 12.0!)
        Me.BtnCheck.Location = New System.Drawing.Point(12, 204)
        Me.BtnCheck.Margin = New System.Windows.Forms.Padding(12, 12, 12, 12)
        Me.BtnCheck.Name = "BtnCheck"
        Me.BtnCheck.Size = New System.Drawing.Size(272, 42)
        Me.BtnCheck.TabIndex = 3
        Me.BtnCheck.Text = "检查"
        Me.BtnCheck.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel1.Controls.Add(Me.BtnCheck, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.LT1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.TNum, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel2, 0, 1)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(10, 10)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(10, 10, 10, 10)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 4
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(296, 258)
        Me.TableLayoutPanel1.TabIndex = 4
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 3
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40.81633!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.36735!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40.81633!))
        Me.TableLayoutPanel2.Controls.Add(Me.LMax, 2, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.LTo, 1, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.LMin, 0, 0)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(3, 67)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 1
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(290, 58)
        Me.TableLayoutPanel2.TabIndex = 4
        '
        'LMax
        '
        Me.LMax.AutoSize = True
        Me.LMax.Dock = System.Windows.Forms.DockStyle.Left
        Me.LMax.Font = New System.Drawing.Font("微软雅黑", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.LMax.ForeColor = System.Drawing.Color.DarkGreen
        Me.LMax.Location = New System.Drawing.Point(174, 0)
        Me.LMax.Name = "LMax"
        Me.LMax.Size = New System.Drawing.Size(59, 58)
        Me.LMax.TabIndex = 3
        Me.LMax.Text = "××"
        Me.LMax.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LTo
        '
        Me.LTo.AutoSize = True
        Me.LTo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LTo.Font = New System.Drawing.Font("微软雅黑", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.LTo.Location = New System.Drawing.Point(121, 0)
        Me.LTo.Name = "LTo"
        Me.LTo.Size = New System.Drawing.Size(47, 58)
        Me.LTo.TabIndex = 2
        Me.LTo.Text = "~"
        Me.LTo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LMin
        '
        Me.LMin.AutoSize = True
        Me.LMin.Dock = System.Windows.Forms.DockStyle.Right
        Me.LMin.Font = New System.Drawing.Font("微软雅黑", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.LMin.ForeColor = System.Drawing.Color.DarkRed
        Me.LMin.Location = New System.Drawing.Point(56, 0)
        Me.LMin.Name = "LMin"
        Me.LMin.Size = New System.Drawing.Size(59, 58)
        Me.LMin.TabIndex = 1
        Me.LMin.Text = "××"
        Me.LMin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Timer
        '
        Me.Timer.Interval = 2000
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.ColumnCount = 2
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel3.Controls.Add(Me.TableLayoutPanel1, 0, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.TableLayoutPanel4, 1, 0)
        Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 1
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(436, 279)
        Me.TableLayoutPanel3.TabIndex = 5
        '
        'TableLayoutPanel4
        '
        Me.TableLayoutPanel4.ColumnCount = 1
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel4.Controls.Add(Me.LT2, 0, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.LScore, 0, 1)
        Me.TableLayoutPanel4.Controls.Add(Me.ListBox1, 0, 2)
        Me.TableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel4.Location = New System.Drawing.Point(320, 4)
        Me.TableLayoutPanel4.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TableLayoutPanel4.Name = "TableLayoutPanel4"
        Me.TableLayoutPanel4.RowCount = 3
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 19.73684!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 19.73684!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60.52632!))
        Me.TableLayoutPanel4.Size = New System.Drawing.Size(112, 271)
        Me.TableLayoutPanel4.TabIndex = 5
        '
        'LT2
        '
        Me.LT2.AutoSize = True
        Me.LT2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LT2.Font = New System.Drawing.Font("微软雅黑", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.LT2.Location = New System.Drawing.Point(3, 0)
        Me.LT2.Name = "LT2"
        Me.LT2.Size = New System.Drawing.Size(106, 53)
        Me.LT2.TabIndex = 1
        Me.LT2.Text = "总分"
        Me.LT2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LScore
        '
        Me.LScore.AutoSize = True
        Me.LScore.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LScore.Font = New System.Drawing.Font("微软雅黑", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.LScore.Location = New System.Drawing.Point(3, 53)
        Me.LScore.Name = "LScore"
        Me.LScore.Size = New System.Drawing.Size(106, 53)
        Me.LScore.TabIndex = 2
        Me.LScore.Text = "0"
        Me.LScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ListBox1
        '
        Me.ListBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ListBox1.Font = New System.Drawing.Font("微软雅黑", 12.0!)
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 31
        Me.ListBox1.Location = New System.Drawing.Point(4, 110)
        Me.ListBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(104, 157)
        Me.ListBox1.TabIndex = 3
        '
        'CSYX
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(436, 279)
        Me.Controls.Add(Me.TableLayoutPanel3)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "CSYX"
        Me.Text = "猜数游戏"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.TableLayoutPanel4.ResumeLayout(False)
        Me.TableLayoutPanel4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents LT1 As Label
    Friend WithEvents TNum As TextBox
    Friend WithEvents BtnCheck As Button
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents LMax As Label
    Friend WithEvents LTo As Label
    Friend WithEvents LMin As Label
    Friend WithEvents Timer As Timer
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel4 As TableLayoutPanel
    Friend WithEvents LT2 As Label
    Friend WithEvents LScore As Label
    Friend WithEvents ListBox1 As ListBox
End Class
