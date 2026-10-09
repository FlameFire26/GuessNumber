Public Class CSYX
    Public Min, Max, Num, Turn As Integer
    Public Score As Integer = 0
    Public TurnText As String
    Public Rand As New Random
    Public Scores As New List(Of String)

    Private Sub BtnCheck_Click(sender As Object, e As EventArgs) Handles BtnCheck.Click
        Dim N = TNum.Text
        Dim Add1, Add2
        Turn -= 1
        TurnText = "（剩" & Turn & "次机会）"
        TNum.Text = ""
        If N = Num Then
            BtnCheck.Text = "恭喜！猜对了"
            TNum.Enabled = False
            Timer.Enabled = True
            Add1 = Max - Min
            Add2 = (Turn + 1) ^ 2
            Score += Add1 + Add2
            ListBox1.Items.Insert(0, "+" & Add1 + Add2)
            Scores.Insert(0, $"差值分 {Add1} + 次数分 {Add2} = 总分 {Add1 + Add2}")
            Min = Nothing
            Max = Nothing
        ElseIf Turn = 0 Then
            BtnCheck.Text = "你输了！这个数是" & Num
            Turn = -1
            ListBox1.Items.Insert(0, "+0")
            Scores.Insert(0, $"差值分不计 + 次数分不计 = 总分 0")
            Timer.Enabled = True
        ElseIf N > Num Then
            BtnCheck.Text = "太大了" & TurnText
            BtnCheck.Enabled = False
            Max = N - 1
        Else
            BtnCheck.Text = "太小了" & TurnText
            BtnCheck.Enabled = False
            Min = N + 1
        End If
        Redraw()
    End Sub

    Private Sub CSYX_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Init()
    End Sub

    Private Sub TNum_TextChanged(sender As Object, e As EventArgs) Handles TNum.TextChanged
        BtnCheck.Text = "检查" & TurnText
        If IsNumeric(TNum.Text) Then
            If Fix(TNum.Text) = TNum.Text Then BtnCheck.Enabled = (TNum.Text >= Min) And (TNum.Text <= Max)
        Else
            BtnCheck.Enabled = False
        End If
    End Sub

    Private Sub Init()
        Randomize()
        Min = Rand.Next(0, 500)
        Max = Rand.Next(501, 1001)
        Num = Rand.Next(Min + 1, Max)
        Dim Diff = Max - Min
        If Diff < 100 Then
            Turn = 5
        ElseIf Diff < 200 Then
            Turn = 6
        ElseIf Diff < 300 Then
            Turn = 7
        ElseIf Diff < 400 Then
            Turn = 8
        ElseIf Diff < 500 Then
            Turn = 9
        ElseIf Diff < 700 Then
            Turn = 10
        ElseIf Diff < 900 Then
            Turn = 11
        Else
            Turn = 12
        End If
        Turn += 3
        TurnText = "（" & Turn & "次机会）"
        BtnCheck.Text = "检查" & TurnText
        TNum.Text = Nothing
        TNum.Enabled = True
        Redraw()
        TNum.Focus()
    End Sub

    Private Sub Redraw()
        If Min = Nothing Then
            LMin.Text = "××"
        Else
            LMin.Text = Min
        End If
        If Max = Nothing Then
            LMax.Text = "××"
        Else
            LMax.Text = Max
        End If
        LScore.Text = Score
    End Sub

    Private Sub Timer_Tick(sender As Object, e As EventArgs) Handles Timer.Tick
        Timer.Enabled = False
        Timer.Dispose()
        Init()
    End Sub

    Private Sub TNum_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TNum.KeyPress
        If e.KeyChar = ChrW(Keys.Return) And BtnCheck.Enabled Then
            BtnCheck_Click(sender, e)
        End If
    End Sub

    Private Sub ListBox1_Click(sender As Object, e As EventArgs) Handles ListBox1.Click
        If ListBox1.SelectedIndex <> -1 Then
            MessageBox.Show(Scores(ListBox1.SelectedIndex), $"分数详情 {ListBox1.Text}")
        End If
    End Sub
End Class
